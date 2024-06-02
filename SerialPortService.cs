using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Diagnostics;
using System.Threading;
using System.Timers;
using System.Windows.Forms;

namespace SerialADC
{
    internal class SerialPortService
    {
        public SerialPortService(SerialPortParams p)
        {           
            serialport = new SerialPort();

            serialport.BaudRate = p.BaudRate;
            serialport.PortName = p.Port;
            serialport.Parity = p.ParityBit;
            serialport.StopBits = p.StopBits;
            serialport.DataBits = p.DataBits;
            serialport.DataReceived += OnDataReceived;

            timeouttimer = new System.Timers.Timer(p.Timeout);
            timeouttimer.Elapsed += OnTimerElapsed;

            isconnected = false;
            iswaitngforanswer = false;
        }

        public bool IsConnected { get { return isconnected; } }
        public bool IsWaintingForAnswer { get { return iswaitngforanswer; } }

        SerialPort serialport;
        ADCParams adcparams;

        
        bool isconnected;
        bool iswaitngforanswer;
        System.Timers.Timer timeouttimer;
        string databuffer;

        public delegate void ConnectionStatusHandler(object sender);
        public event ConnectionStatusHandler Connected;
        public event ConnectionStatusHandler Disconnected;
        public event ConnectionStatusHandler Timeout;

        void OnDataReceived(object sender, SerialDataReceivedEventArgs args)
        {
            var size = serialport.BytesToRead;
            char[] buffer = new char[size];
            serialport.Read(buffer, 0, size);
            databuffer += buffer;

            if (databuffer.EndsWith("\n"))
            {
                if (databuffer == $"#OK%{adcparams.Resolution}%{adcparams.SampleRate}%VA\n")
                {
                    isconnected = true;

                    Connected(this);
                }
                else isconnected = false;
                iswaitngforanswer = false;
            }
        }

        void OnTimerElapsed(object sender, ElapsedEventArgs args)
        {
            timeouttimer.Stop();
            Timeout(this);
            serialport.Close();
        }

        public void TryConnection(ADCParams adc_p)
        {
            if (serialport.IsOpen) return;
            serialport.Open();

            adcparams = adc_p;
            SendBeginString();
            timeouttimer.Start();
            iswaitngforanswer = true;
        }

        public void CloseConnection()
        {
            if (serialport.IsOpen)
            {
                SendEndString();
                serialport.Close();
                isconnected = false;
                Disconnected(this);
            }
        }

        public void SendBytes(byte[] bytes, int n)
        {
            if(serialport.IsOpen)
            { 
                serialport.Write(bytes, 0, n);
            }
        }

        void SendBeginString()
        {
            // Send preamble
            // #ADC%[resolution]%[samplerate]%[data_transmission_order]\n
            // VA - volts first, than amps
            string preamble = $"#ADC%{adcparams.Resolution}%{adcparams.SampleRate}%VA";
            serialport.WriteLine(preamble);
        }

        void SendEndString()
        {
            string end = "#ADC%END";
            serialport.WriteLine(end);
        }
    }
}
