using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace SerialADC
{
    internal class SerialPortParams
    {
        public SerialPortParams() 
        {
            framedelay = 3;
            databits = 8;
            parity = Parity.None;
            stopbits = StopBits.One;
            baud = 9600;
            port = string.Empty;
            timeout = 5000;
            CalculateDataFlow();
        }

        public string Port { get { return port; } set { port = value; } }
        public int BaudRate { get { return baud; } set { baud = value; CalculateDataFlow(); } }
        public int DataBits { get { return databits; } set { databits = value; CalculateDataFlow(); } }
        public StopBits StopBits { get { return stopbits; } set { stopbits = value; CalculateDataFlow(); } }
        public Parity ParityBit { get { return parity; } set { parity = value; CalculateDataFlow(); } }
        public int DataFlow { get { return dataflow; } }
        public double Timeout { get { return timeout; } set { timeout = value; } }

        string port;
        int baud, databits, dataflow;
        Parity parity;
        StopBits stopbits;
        readonly int framedelay;
        double timeout;
        
        void CalculateDataFlow()
        {
            int stops = stopbits != StopBits.OnePointFive ? (int)stopbits : 2;
            int paritybits = parity != Parity.None ? 1 : 0;
            dataflow = databits * baud / (databits + paritybits + stops + framedelay);
        }

        public void SetValues(string port, int baud, double timeout)
        {
            this.port = port;
            this.baud = baud;
            this.timeout = timeout;
            CalculateDataFlow();
        }

        public string[] GetPortNames()
        {
            return SerialPort.GetPortNames();
        }
    }
}
