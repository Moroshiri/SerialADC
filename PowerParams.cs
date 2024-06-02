using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;
using System.IO;

namespace SerialADC
{
    internal class PowerParams
    {
        public double ActivePower { get { return activepow; } }
        public double ReactivePower { get { return reactivepow; } }
        public double ApparentPower { get { return apparentpow; } }
        public double CosPhi { get { return cosphi; } }
        public double TanPhi { get { return tanphi; } }

        public double Volts
        { 
            get { return volts; }
            set { volts = value; CalculateDeps(); }
        }

        public double Amps
        {
            get { return amps; }
            set { amps = value; CalculateDeps(); }
        }

        public double Freaquency
        {
            get { return freaq; }
            set { freaq = value; CalculateDeps(); }
        }

        /// <summary>
        /// In radians!
        /// </summary>
        public double Phase
        { 
            get { return phase; }
            set { phase = value; CalculateDeps(); }
        }

        public FlowDirection Flow
        {
            get { return flow; }
            set { flow = value; CalculateDeps(); }
        }

        // Strings to display

        public string VoltsString
        {
            get { return Math.Round(Volts).ToString() + " V"; }
        }

        public string AmpsString
        {
            get { return Math.Round(Amps).ToString() + " A"; }
        }

        public string FreaquencyString
        {
            get { return Freaquency.ToString("00.0", CultureInfo.InvariantCulture) + " Hz"; }
        }

        public string PhaseString
        {
            get { return Math.Round(Phase * 360 / (2*Math.PI)).ToString() + " °"; }
        }

        public string ActivePowerString
        {
            get { return Math.Round(ActivePower).ToString() + " W"; }
        }

        public string ReactivePowerString
        {
            get { return Math.Round(ReactivePower).ToString() + " var"; }
        }

        public string ApparentPowerString
        {
            get { return Math.Round(ApparentPower).ToString() + " VA"; }
        }

        public string CosPhiString
        {
            get { return CosPhi.ToString("0.000", CultureInfo.InvariantCulture) + " " + GetPFType(); }
        }

        public string TanPhiString
        {
            get 
            {
                if (TanPhi == double.PositiveInfinity || TanPhi > 1)
                    return ">1.000";
                else if (TanPhi == double.NegativeInfinity || TanPhi < -1)
                    return "<-1.000";
                else return TanPhi.ToString("0.000", CultureInfo.InvariantCulture);
            }
        }

        double activepow, reactivepow, apparentpow, cosphi, tanphi, volts, amps, freaq, phase;

        public enum FlowDirection
        {
            FromGridToDevice = 0,
            FromDevideToGrid = 1
        }

        FlowDirection flow;

        public PowerParams()
        { }

        public PowerParams(double volts, double amps, double freaq, double phase, FlowDirection flow)
        {
            SetAllValues(volts, amps, freaq, phase, flow);
        }

        void CalculateDeps()
        {
            // Add extra 180 deg if flow is from device to grid
            if (flow == FlowDirection.FromDevideToGrid && phase <= Math.PI / 2 && phase >= -Math.PI / 2)
                phase += Math.PI;
            activepow = volts * amps * Math.Cos(phase);
            reactivepow = volts * amps * Math.Sin(phase);
            apparentpow = Math.Sqrt(activepow * activepow + reactivepow * reactivepow);
            cosphi = Math.Cos(phase);
            tanphi = Math.Tan(phase);
        }

        string GetPFType()
        {
            var sinphi = Math.Sin(phase);
            if(sinphi < 0) return "c";
            else if(sinphi > 0) return "i";
            else return string.Empty;
        }

        public void SetAllValues(double volts, double amps, double freaq, double phase, FlowDirection flow)
        {
            this.volts = volts;
            this.amps = amps;
            this.freaq = freaq;
            this.phase = phase;
            this.flow = flow;
            CalculateDeps();
        }

        public void SetAllValues(double volts, double amps, double freaq, double phase)
        {
            SetAllValues(volts, amps, freaq, phase, flow);
        }
    }
}
