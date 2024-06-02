using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialADC
{
    internal class SignalGenerator
    {
        public SignalGenerator(ref PowerParams power_params, ref ADCParams adc_params)
        {
            power = power_params;
            adcparams = adc_params;
            generatingthread = null;
        }

        public bool IsRunning { get { return isrunning; } }

        bool isrunning;
        PowerParams power;
        ADCParams adcparams;

        Thread generatingthread;

        const double sqrt2 = 1.4142135623730d;

        double sampleperiod; // [s]
        double signallperiod; // [s]
        double time;
        double samplespersignalperiod; // Liczba próbek na okres sygnału

        public struct DataReadyArgs
        {
            public DataReadyArgs(double volts, double amps)
            {
                Volts = volts;
                Amps = amps;
            }
            public double Volts, Amps;
        }
        public delegate void DataReadyHandler(object sender, DataReadyArgs args);
        public event DataReadyHandler DataReady;

        public delegate void GeneratorStatusHandler(object sender);
        public event GeneratorStatusHandler Started;
        public event GeneratorStatusHandler Stopped;

        public void Start()
        {
            if (isrunning || generatingthread != null) return;
            
            PrepareParams();
            generatingthread = new Thread(new ThreadStart(Loop));

            isrunning = true;
            Started(this);
        }

        public void Stop()
        {
            if(!isrunning) return;

            isrunning = false;
            if (generatingthread.ThreadState == System.Threading.ThreadState.Running)
                generatingthread.Abort();
            generatingthread = null;
            Stopped(this);
        }

        void PrepareParams()
        {
            sampleperiod = 1 / adcparams.SampleRate;
            signallperiod = 1 / power.Freaquency;
            samplespersignalperiod = signallperiod / sampleperiod;
        }

        double ComputeVoltageValue()
        {
            // y = A*sin(2*pi*f*t)
            double ampitude = power.Volts * sqrt2;
            var res = ampitude * Math.Sin(2 * Math.PI * power.Freaquency * sampleperiod * time);

            return res;
        }

        double ComputeAmperageValue()
        {
            // y = A*sin(2*pi*f*t+fi)
            double ampitude = power.Amps * sqrt2;
            var res = ampitude * Math.Sin(2 * Math.PI * power.Freaquency * sampleperiod * time + power.Phase);

            return res;
        }

        void Loop()
        {
            int milis = 0;
            Stopwatch sw = new Stopwatch();
            while (isrunning)
            {
                sw.Start();
                var volts = ComputeVoltageValue();
                var amps = ComputeAmperageValue();

                DataReady(this, new DataReadyArgs(volts, amps));

                if (time < samplespersignalperiod)
                    time++;
                else time = 0;
                sw.Stop();

                milis = (int)Math.Round(sampleperiod * 1000) - (int)sw.ElapsedMilliseconds;
                Thread.Sleep(milis);
            };
        }
    }
}
