using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialADC
{
    internal static class ADCParamsParser
    {
        public static string BitRateString(ADCParams adc)
        {
            return ((double)adc.BitRate / 1000).ToString(CultureInfo.InvariantCulture) + " kbit/s";
        }
        public static string NyquistString(ADCParams adc)
        {
            return ((double)adc.Nyquist / 1000).ToString(CultureInfo.InvariantCulture) + " kHz";
        }
    }

    internal class ADCParams
    {
        public ADCParams() { }

        public uint Resolution { get { return resolution; }}
        public uint SampleRate { get { return samplerate; }}
        public uint BitRate { get { return bitrate; }}
        public uint Nyquist {  get { return nyquist; }}
        /// <summary>
        /// Absolute maximum level of input volts value. <br></br>
        /// Exceeding will couse clipping!
        /// </summary>
        public double MaxVolts { get { return maxvolts; } set { maxvolts = value; } }
        /// <summary>
        /// Absolute maximum level of input amps value. <br></br>
        /// Exceeding will couse clipping!
        /// </summary>
        public double MaxAmps { get { return maxamps; } set { maxamps = value; } } 

        uint resolution;
        uint samplerate;
        uint bitrate;
        uint nyquist;
        double maxvolts;
        double maxamps;

        public void SetAllValues(uint resolution, uint samplerate)
        {
            this.resolution = resolution;
            this.samplerate = samplerate;
            CalculateDeps();
        }

        void CalculateDeps()
        {
            bitrate = resolution * samplerate;
            nyquist = samplerate / 2;
        }
    }
}
