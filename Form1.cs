using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static SerialADC.SignalGenerator;

namespace SerialADC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            signalparams = new PowerParams();
            adcparams = new ADCParams();
            adcparams.MaxVolts = SignalVoltsFader.Maximum * 1.4142135623730d;
            adcparams.MaxAmps = SignalAmpsFader.Maximum * 1.4142135623730d;
            serialportparams = new SerialPortParams();
            signalgenerator = new SignalGenerator(ref signalparams, ref adcparams);
            signalgenerator.DataReady += Signal_OnDataReady;

            // Default ADC setting
            ADCResolutionSelect.SelectedIndex = 2;
            ADCSampleRateSelect.SelectedIndex = 1;

            // Default Serial Port setting
            SerialBaudSelect.SelectedIndex = 5;
            SerialTimeoutNum.Value = 5000;

            UpdateDisplays();

            //var item1 = new ListViewItem("2", 1);
            //item1.Checked = true;
            //item1.SubItems.Add("13");

            //HarmonicsList.Items.Add(item1);

        }

        private enum FormView
        {
            SerialStopped,
            SerialStarted
        }
        private void SetFormView(FormView form_view)
        {
            
            switch(form_view)
            {
                case FormView.SerialStopped:
                    SerialPortSelect.Enabled = true;
                    SerialBaudSelect.Enabled = true;
                    SerialTimeoutNum.Enabled = true;
                    ADCResolutionSelect.Enabled = true;
                    ADCSampleRateSelect.Enabled = true;
                    SerialStartStopButton.Text = "Start";
                    break;
                case FormView.SerialStarted:
                    SerialPortSelect.Enabled = false;
                    SerialBaudSelect.Enabled = false;
                    SerialTimeoutNum.Enabled = false;
                    ADCResolutionSelect.Enabled = false;
                    ADCSampleRateSelect.Enabled = false;
                    SerialStartStopButton.Text = "Stop";
                    break;
            }
        }

        private void UpdateDisplays()
        {
            UpdateSignalDisplays();
            UpdateADCDisplays();
        }

        // --- Signal settings ---

        PowerParams signalparams;
        SignalGenerator signalgenerator;

        private void SwitchFlowDirection()
        {
            if(signalparams.Flow == PowerParams.FlowDirection.FromGridToDevice)
            {
                signalparams.Flow = PowerParams.FlowDirection.FromDevideToGrid;
                SignalFlowDirectionBtn.Image = Properties.Resources.ArrowUp1;
            }
            else
            {
                signalparams.Flow = PowerParams.FlowDirection.FromGridToDevice;
                SignalFlowDirectionBtn.Image = Properties.Resources.ArrowDown1;
            }
        }

        private void GetFadersValues()
        {
            signalparams.SetAllValues(
                    (double)SignalVoltsFader.Value,
                    (double)SignalAmpsFader.Value,
                    (double)SignalFreaquencyFader.Value / 10,
                    (double)SignalPhaseFader.Value * 2 * Math.PI / 360);
        }
        
        private void DisplaySignalValues()
        {
            SignalVoltsDisplay.Text = signalparams.VoltsString;
            SignalAmpsDisplay.Text = signalparams.AmpsString;
            SignalPhaseDisplay.Text = signalparams.PhaseString;
            SignalFreaquencyDisplay.Text = signalparams.FreaquencyString;
            SignalActivePowerDisplay.Text = signalparams.ActivePowerString;
            SignalReactivePowerDisplay.Text = signalparams.ReactivePowerString;
            SignalApparentPowerDisplay.Text = signalparams.ApparentPowerString;
            SignalCosPhiDisplay.Text = signalparams.CosPhiString;
            SignalTgPhiDisplay.Text = signalparams.TanPhiString;
        }

        private void UpdateSignalDisplays()
        {
            GetFadersValues();
            DisplaySignalValues();
        }

        private void SignalParamFader_Scroll(object sender, EventArgs e)
        {
            UpdateSignalDisplays();
        }

        private void SignalFlowDirectionBtn_Click(object sender, EventArgs e)
        {
            SwitchFlowDirection();
            UpdateDisplays();
        }

        private void Signal_OnDataReady(object sender, DataReadyArgs args)
        {
            if (adcservice == null)
                adcservice = new ADCService(adcparams);
            var frame = adcservice.CreateFrame(args.Volts, args.Amps, out int nbytes);
            serialportservice.SendBytes(frame, nbytes);
        }

        // --- ADC settings ---

        ADCParams adcparams;
        ADCService adcservice;

        private void ADC_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateADCDisplays();
            SerialCheckRequirements();
        }

        private void GetADCSelectedValues()
        {
            uint resolution, samplerate;
            if(!uint.TryParse(ADCResolutionSelect.Text, out resolution)) return;
            if(!uint.TryParse(ADCSampleRateSelect.Text, out samplerate)) return;

            adcparams.SetAllValues(resolution, samplerate);
        }

        private void DisplayADCValues()
        {
            ADCBitRateDisplay.Text = ADCParamsParser.BitRateString(adcparams);
            ADCNyquistDisplay.Text = ADCParamsParser.NyquistString(adcparams);
        }

        private void UpdateADCDisplays()
        {
            GetADCSelectedValues();
            DisplayADCValues();
        }

        // --- Serial settings ---

        private enum SerialStatus
        {
            Ready,
            Running,
            Warning,
            Error
        }

        SerialStatus serialstatus;
        SerialPortParams serialportparams;
        SerialPortService serialportservice;
        
        private void GetSerialSelectedValues()
        {
            int baud;            
            if (!int.TryParse(SerialBaudSelect.Text, out baud)) return;
            var timeout = (double)SerialTimeoutNum.Value;

            serialportparams.SetValues( SerialPortSelect.Text, baud, timeout);
        }

        private void SerialCheckRequirements()
        {
            // Check for port name is set
            if (SerialPortSelect.Text == string.Empty)
            {
                SerialSetStatus(SerialStatus.Warning, "Choose port name");
                return;
            }

            // Check for bauad rate is enought for ADC bit rate
            var bits = serialportparams.DataBits;
            var neededbitrate = adcparams.BitRate % bits > 0 ? bits * (adcparams.BitRate / bits + 1) : adcparams.BitRate;
            if (adcparams.BitRate > serialportparams.DataFlow)
            {
                SerialSetStatus(SerialStatus.Warning, "Baud rate is to low");
                return;
            }

            SerialSetStatus(SerialStatus.Ready, string.Empty);
        }

        private void SerialSetStatus(SerialStatus status, string msg)
        {
            serialstatus = status;
            switch(status)
            {
                case SerialStatus.Ready:
                    SerialStatusDisplay.ForeColor = Color.LimeGreen;
                    SerialStatusDisplay.Text = "Ready";
                    SerialStartStopButton.Enabled = true;
                    break;

                case SerialStatus.Warning:
                    SerialStatusDisplay.ForeColor = Color.Orange;
                    SerialStatusDisplay.Text = msg;
                    SerialStartStopButton.Enabled = false;
                    break;

                case SerialStatus.Error:
                    SerialStatusDisplay.ForeColor = Color.Red;
                    SerialStatusDisplay.Text = msg;
                    SerialStartStopButton.Enabled = false;
                    break;

                case SerialStatus.Running:
                    SerialStatusDisplay.ForeColor = Color.DarkOrange;
                    SerialStatusDisplay.Text = "Running";             
                    break;
            }
        }

        private void SerialStartStopButton_Click(object sender, EventArgs e)
        {
            if (serialstatus == SerialStatus.Ready)
            {
                SerialStart();
            }
            else if (serialstatus == SerialStatus.Running)
            {
                SerialStop();
            }
        }

        private void SerialCreatePortService()
        {
            serialportservice = new SerialPortService(serialportparams);
            serialportservice.Connected += Serial_OnConnected;
            serialportservice.Disconnected += Serial_OnDisconnected;
            serialportservice.Timeout += Serial_OnTimeout;
        }

        private void SerialStart()
        {
            SerialCreatePortService();
            SerialSetStatus(SerialStatus.Running, "Wainting for receiver");
            SetFormView(FormView.SerialStarted);

            serialportservice.TryConnection(adcparams);
        }

        private void SerialStop()
        {
            SerialSetStatus(SerialStatus.Ready, string.Empty);
            SetFormView(FormView.SerialStopped);

            serialportservice.CloseConnection();
        }

        private void Serial_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetSerialSelectedValues();
            SerialCheckRequirements();
        }

        private void SerialPortSelect_DropDown(object sender, EventArgs e)
        {
            SerialPortSelect.Items.Clear();
            SerialPortSelect.Items.AddRange(serialportparams.GetPortNames());
        }

        private void Serial_OnConnected(object sender)
        {
            signalgenerator.Start();
            adcservice = new ADCService(adcparams);
            SerialSetStatus(SerialStatus.Running, string.Empty);
        }

        private void Serial_OnDisconnected(object sender)
        {
            signalgenerator.Stop();
        }

        private void Serial_OnTimeout(object sender)
        {
            SerialTimeout();
        }

        private void SerialTimeout()
        {
            if(this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(SerialTimeout));
            }
            else
            {
                SetFormView(FormView.SerialStopped);
                SerialSetStatus(SerialStatus.Ready, string.Empty);
                MessageBox.Show("Receiver do not respond", "Timeout", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
