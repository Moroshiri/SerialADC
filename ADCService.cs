using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialADC
{
    internal class ADCService
    {
        public ADCService(ADCParams adc_params) 
        {
            adcparams = adc_params;
            nbytes = (int)adcparams.Resolution / 8;
        }

        ADCParams adcparams;
        int nbytes;

        public byte[] CreateFrame(double volts, double amps, out int n)
        {
            var tmpvolts = BitConverter.GetBytes(PrepareValue(volts, adcparams.MaxVolts));
            var tmpamps = BitConverter.GetBytes(PrepareValue(amps, adcparams.MaxAmps));
            n = nbytes * 2;
            byte[] bytes = new byte[n];
            for(int i = 0; i < bytes.Length; i++)
            {
                if(i < nbytes) // Insert volts value
                    bytes[i] = tmpvolts[i];
                else
                    bytes[i] = tmpamps[i-nbytes];
            }

            return bytes;
        }

        byte[] SmashToBytes(int value)
        {
            var tmp = BitConverter.GetBytes(value);
            byte[] bytes = new byte[nbytes];
            for (int i = 0; i < nbytes; i++)
                bytes[i] = tmp[i];

            return bytes;
        }

        int PrepareValue(double value, double max)
        {
            var scale = value / max;
            int adcmax = 1 << (int)adcparams.Resolution - 1;
            return (int)Math.Round(adcmax * scale);
        }
    }
}
