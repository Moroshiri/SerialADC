namespace SerialADC
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "1",
            "230"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("15");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("3");
            this.SerialSettingBox = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.SerialTimeoutNum = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.SerialStatusDisplay = new System.Windows.Forms.Label();
            this.SerialStartStopButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SerialBaudSelect = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SerialPortSelect = new System.Windows.Forms.ComboBox();
            this.SerialPortComponent = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SignalFlowDirectionBox = new System.Windows.Forms.GroupBox();
            this.SignalFlowDirectionBtn = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SignalTgPhiDisplay = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SignalCosPhiDisplay = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SignalApparentPowerDisplay = new System.Windows.Forms.Label();
            this.SignalReactivePowerDisplay = new System.Windows.Forms.Label();
            this.SignalActivePowerDisplay = new System.Windows.Forms.Label();
            this.SignalFreaquencyBox = new System.Windows.Forms.GroupBox();
            this.SignalFreaquencyFader = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.SignalFreaquencyDisplay = new System.Windows.Forms.Label();
            this.SignalPhaseBox = new System.Windows.Forms.GroupBox();
            this.SignalPhaseFader = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.SignalPhaseDisplay = new System.Windows.Forms.Label();
            this.SignalAmpsBox = new System.Windows.Forms.GroupBox();
            this.SignalAmpsFader = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.SignalAmpsDisplay = new System.Windows.Forms.Label();
            this.SignalVoltsBox = new System.Windows.Forms.GroupBox();
            this.SignalVoltsFader = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.SignalVoltsDisplay = new System.Windows.Forms.Label();
            this.ADCBox = new System.Windows.Forms.GroupBox();
            this.ADCNyquistDisplay = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.ADCBitRateDisplay = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.ADCSampleRateSelect = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ADCResolutionSelect = new System.Windows.Forms.ComboBox();
            this.HarmonicsBox = new System.Windows.Forms.GroupBox();
            this.HarmonicsList = new System.Windows.Forms.ListView();
            this.HarmonicNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HarmonicValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HarmonicsPresetSelect = new System.Windows.Forms.ComboBox();
            this.HarmonicsFreaquencyDisplay = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.HarmonicsValueNum = new System.Windows.Forms.NumericUpDown();
            this.HarmonicsTHDBox = new System.Windows.Forms.GroupBox();
            this.HarmonicsTHDDisplay = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.NarmonicsDeleteBtn = new System.Windows.Forms.Button();
            this.HarmonicsNumberNum = new System.Windows.Forms.NumericUpDown();
            this.HarmonicsAddBtn = new System.Windows.Forms.Button();
            this.SerialSettingBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SerialTimeoutNum)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SignalFlowDirectionBox.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SignalFreaquencyBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SignalFreaquencyFader)).BeginInit();
            this.SignalPhaseBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SignalPhaseFader)).BeginInit();
            this.SignalAmpsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SignalAmpsFader)).BeginInit();
            this.SignalVoltsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SignalVoltsFader)).BeginInit();
            this.ADCBox.SuspendLayout();
            this.HarmonicsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HarmonicsValueNum)).BeginInit();
            this.HarmonicsTHDBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HarmonicsNumberNum)).BeginInit();
            this.SuspendLayout();
            // 
            // SerialSettingBox
            // 
            this.SerialSettingBox.Controls.Add(this.label18);
            this.SerialSettingBox.Controls.Add(this.SerialTimeoutNum);
            this.SerialSettingBox.Controls.Add(this.label3);
            this.SerialSettingBox.Controls.Add(this.SerialStatusDisplay);
            this.SerialSettingBox.Controls.Add(this.SerialStartStopButton);
            this.SerialSettingBox.Controls.Add(this.label2);
            this.SerialSettingBox.Controls.Add(this.SerialBaudSelect);
            this.SerialSettingBox.Controls.Add(this.label1);
            this.SerialSettingBox.Controls.Add(this.SerialPortSelect);
            this.SerialSettingBox.Location = new System.Drawing.Point(12, 12);
            this.SerialSettingBox.Name = "SerialSettingBox";
            this.SerialSettingBox.Size = new System.Drawing.Size(136, 229);
            this.SerialSettingBox.TabIndex = 0;
            this.SerialSettingBox.TabStop = false;
            this.SerialSettingBox.Text = "Serial";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(81, 115);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(20, 13);
            this.label18.TabIndex = 10;
            this.label18.Text = "ms";
            // 
            // SerialTimeoutNum
            // 
            this.SerialTimeoutNum.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.SerialTimeoutNum.Location = new System.Drawing.Point(6, 112);
            this.SerialTimeoutNum.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.SerialTimeoutNum.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.SerialTimeoutNum.Name = "SerialTimeoutNum";
            this.SerialTimeoutNum.Size = new System.Drawing.Size(69, 20);
            this.SerialTimeoutNum.TabIndex = 9;
            this.SerialTimeoutNum.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Timeout";
            // 
            // SerialStatusDisplay
            // 
            this.SerialStatusDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SerialStatusDisplay.ForeColor = System.Drawing.Color.LimeGreen;
            this.SerialStatusDisplay.Location = new System.Drawing.Point(6, 136);
            this.SerialStatusDisplay.Name = "SerialStatusDisplay";
            this.SerialStatusDisplay.Size = new System.Drawing.Size(121, 33);
            this.SerialStatusDisplay.TabIndex = 7;
            this.SerialStatusDisplay.Text = "Ready";
            this.SerialStatusDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SerialStartStopButton
            // 
            this.SerialStartStopButton.Location = new System.Drawing.Point(9, 172);
            this.SerialStartStopButton.Name = "SerialStartStopButton";
            this.SerialStartStopButton.Size = new System.Drawing.Size(116, 46);
            this.SerialStartStopButton.TabIndex = 6;
            this.SerialStartStopButton.Text = "Start";
            this.SerialStartStopButton.UseVisualStyleBackColor = true;
            this.SerialStartStopButton.Click += new System.EventHandler(this.SerialStartStopButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Baud Rate";
            // 
            // SerialBaudSelect
            // 
            this.SerialBaudSelect.FormattingEnabled = true;
            this.SerialBaudSelect.Items.AddRange(new object[] {
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200",
            "128000",
            "256000"});
            this.SerialBaudSelect.Location = new System.Drawing.Point(6, 72);
            this.SerialBaudSelect.Name = "SerialBaudSelect";
            this.SerialBaudSelect.Size = new System.Drawing.Size(121, 21);
            this.SerialBaudSelect.TabIndex = 2;
            this.SerialBaudSelect.SelectedIndexChanged += new System.EventHandler(this.Serial_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Port";
            // 
            // SerialPortSelect
            // 
            this.SerialPortSelect.FormattingEnabled = true;
            this.SerialPortSelect.Location = new System.Drawing.Point(6, 32);
            this.SerialPortSelect.Name = "SerialPortSelect";
            this.SerialPortSelect.Size = new System.Drawing.Size(121, 21);
            this.SerialPortSelect.TabIndex = 0;
            this.SerialPortSelect.DropDown += new System.EventHandler(this.SerialPortSelect_DropDown);
            this.SerialPortSelect.SelectedIndexChanged += new System.EventHandler(this.Serial_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SignalFlowDirectionBox);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.SignalFreaquencyBox);
            this.groupBox1.Controls.Add(this.SignalPhaseBox);
            this.groupBox1.Controls.Add(this.SignalAmpsBox);
            this.groupBox1.Controls.Add(this.SignalVoltsBox);
            this.groupBox1.Location = new System.Drawing.Point(154, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(511, 229);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Signal";
            // 
            // SignalFlowDirectionBox
            // 
            this.SignalFlowDirectionBox.Controls.Add(this.SignalFlowDirectionBtn);
            this.SignalFlowDirectionBox.Controls.Add(this.label12);
            this.SignalFlowDirectionBox.Controls.Add(this.label11);
            this.SignalFlowDirectionBox.Location = new System.Drawing.Point(402, 19);
            this.SignalFlowDirectionBox.Name = "SignalFlowDirectionBox";
            this.SignalFlowDirectionBox.Size = new System.Drawing.Size(100, 148);
            this.SignalFlowDirectionBox.TabIndex = 18;
            this.SignalFlowDirectionBox.TabStop = false;
            this.SignalFlowDirectionBox.Text = "Flow Direction";
            // 
            // SignalFlowDirectionBtn
            // 
            this.SignalFlowDirectionBtn.FlatAppearance.BorderSize = 0;
            this.SignalFlowDirectionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignalFlowDirectionBtn.Image = global::SerialADC.Properties.Resources.ArrowDown1;
            this.SignalFlowDirectionBtn.Location = new System.Drawing.Point(15, 39);
            this.SignalFlowDirectionBtn.Name = "SignalFlowDirectionBtn";
            this.SignalFlowDirectionBtn.Size = new System.Drawing.Size(64, 64);
            this.SignalFlowDirectionBtn.TabIndex = 2;
            this.SignalFlowDirectionBtn.UseVisualStyleBackColor = true;
            this.SignalFlowDirectionBtn.Click += new System.EventHandler(this.SignalFlowDirectionBtn_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(21, 109);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 17);
            this.label12.TabIndex = 1;
            this.label12.Text = "Devices";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(30, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Grid";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.SignalTgPhiDisplay);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.SignalCosPhiDisplay);
            this.groupBox3.Location = new System.Drawing.Point(295, 115);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(101, 103);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "PF";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(7, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "tg φ";
            // 
            // SignalTgPhiDisplay
            // 
            this.SignalTgPhiDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SignalTgPhiDisplay.Location = new System.Drawing.Point(19, 74);
            this.SignalTgPhiDisplay.Name = "SignalTgPhiDisplay";
            this.SignalTgPhiDisplay.Size = new System.Drawing.Size(74, 20);
            this.SignalTgPhiDisplay.TabIndex = 8;
            this.SignalTgPhiDisplay.Text = "1.000";
            this.SignalTgPhiDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(7, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "cos φ";
            // 
            // SignalCosPhiDisplay
            // 
            this.SignalCosPhiDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SignalCosPhiDisplay.Location = new System.Drawing.Point(19, 33);
            this.SignalCosPhiDisplay.Name = "SignalCosPhiDisplay";
            this.SignalCosPhiDisplay.Size = new System.Drawing.Size(74, 20);
            this.SignalCosPhiDisplay.TabIndex = 6;
            this.SignalCosPhiDisplay.Text = "0.854 i";
            this.SignalCosPhiDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SignalApparentPowerDisplay);
            this.groupBox2.Controls.Add(this.SignalReactivePowerDisplay);
            this.groupBox2.Controls.Add(this.SignalActivePowerDisplay);
            this.groupBox2.Location = new System.Drawing.Point(295, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(101, 90);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Power";
            // 
            // SignalApparentPowerDisplay
            // 
            this.SignalApparentPowerDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SignalApparentPowerDisplay.Location = new System.Drawing.Point(6, 63);
            this.SignalApparentPowerDisplay.Name = "SignalApparentPowerDisplay";
            this.SignalApparentPowerDisplay.Size = new System.Drawing.Size(87, 20);
            this.SignalApparentPowerDisplay.TabIndex = 5;
            this.SignalApparentPowerDisplay.Text = "2300 VA";
            this.SignalApparentPowerDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SignalReactivePowerDisplay
            // 
            this.SignalReactivePowerDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SignalReactivePowerDisplay.Location = new System.Drawing.Point(6, 39);
            this.SignalReactivePowerDisplay.Name = "SignalReactivePowerDisplay";
            this.SignalReactivePowerDisplay.Size = new System.Drawing.Size(87, 20);
            this.SignalReactivePowerDisplay.TabIndex = 4;
            this.SignalReactivePowerDisplay.Text = "0 var";
            this.SignalReactivePowerDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SignalActivePowerDisplay
            // 
            this.SignalActivePowerDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SignalActivePowerDisplay.Location = new System.Drawing.Point(6, 16);
            this.SignalActivePowerDisplay.Name = "SignalActivePowerDisplay";
            this.SignalActivePowerDisplay.Size = new System.Drawing.Size(81, 20);
            this.SignalActivePowerDisplay.TabIndex = 3;
            this.SignalActivePowerDisplay.Text = "2300 W";
            this.SignalActivePowerDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SignalFreaquencyBox
            // 
            this.SignalFreaquencyBox.Controls.Add(this.SignalFreaquencyFader);
            this.SignalFreaquencyBox.Controls.Add(this.label8);
            this.SignalFreaquencyBox.Controls.Add(this.SignalFreaquencyDisplay);
            this.SignalFreaquencyBox.Location = new System.Drawing.Point(223, 19);
            this.SignalFreaquencyBox.Name = "SignalFreaquencyBox";
            this.SignalFreaquencyBox.Size = new System.Drawing.Size(66, 199);
            this.SignalFreaquencyBox.TabIndex = 15;
            this.SignalFreaquencyBox.TabStop = false;
            // 
            // SignalFreaquencyFader
            // 
            this.SignalFreaquencyFader.LargeChange = 20;
            this.SignalFreaquencyFader.Location = new System.Drawing.Point(10, 39);
            this.SignalFreaquencyFader.Maximum = 510;
            this.SignalFreaquencyFader.Minimum = 490;
            this.SignalFreaquencyFader.Name = "SignalFreaquencyFader";
            this.SignalFreaquencyFader.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.SignalFreaquencyFader.Size = new System.Drawing.Size(45, 135);
            this.SignalFreaquencyFader.SmallChange = 10;
            this.SignalFreaquencyFader.TabIndex = 1;
            this.SignalFreaquencyFader.TickFrequency = 5;
            this.SignalFreaquencyFader.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.SignalFreaquencyFader.Value = 500;
            this.SignalFreaquencyFader.Scroll += new System.EventHandler(this.SignalParamFader_Scroll);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Freaquency";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SignalFreaquencyDisplay
            // 
            this.SignalFreaquencyDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SignalFreaquencyDisplay.Location = new System.Drawing.Point(1, 16);
            this.SignalFreaquencyDisplay.Name = "SignalFreaquencyDisplay";
            this.SignalFreaquencyDisplay.Size = new System.Drawing.Size(64, 20);
            this.SignalFreaquencyDisplay.TabIndex = 0;
            this.SignalFreaquencyDisplay.Text = "50.0 Hz";
            this.SignalFreaquencyDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SignalPhaseBox
            // 
            this.SignalPhaseBox.Controls.Add(this.SignalPhaseFader);
            this.SignalPhaseBox.Controls.Add(this.label7);
            this.SignalPhaseBox.Controls.Add(this.SignalPhaseDisplay);
            this.SignalPhaseBox.Location = new System.Drawing.Point(152, 19);
            this.SignalPhaseBox.Name = "SignalPhaseBox";
            this.SignalPhaseBox.Size = new System.Drawing.Size(65, 199);
            this.SignalPhaseBox.TabIndex = 14;
            this.SignalPhaseBox.TabStop = false;
            // 
            // SignalPhaseFader
            // 
            this.SignalPhaseFader.LargeChange = 20;
            this.SignalPhaseFader.Location = new System.Drawing.Point(10, 39);
            this.SignalPhaseFader.Maximum = 90;
            this.SignalPhaseFader.Minimum = -90;
            this.SignalPhaseFader.Name = "SignalPhaseFader";
            this.SignalPhaseFader.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.SignalPhaseFader.Size = new System.Drawing.Size(45, 135);
            this.SignalPhaseFader.SmallChange = 10;
            this.SignalPhaseFader.TabIndex = 1;
            this.SignalPhaseFader.TickFrequency = 10;
            this.SignalPhaseFader.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.SignalPhaseFader.Scroll += new System.EventHandler(this.SignalParamFader_Scroll);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Phase";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SignalPhaseDisplay
            // 
            this.SignalPhaseDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SignalPhaseDisplay.Location = new System.Drawing.Point(10, 16);
            this.SignalPhaseDisplay.Name = "SignalPhaseDisplay";
            this.SignalPhaseDisplay.Size = new System.Drawing.Size(45, 20);
            this.SignalPhaseDisplay.TabIndex = 0;
            this.SignalPhaseDisplay.Text = "0 °";
            this.SignalPhaseDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SignalAmpsBox
            // 
            this.SignalAmpsBox.Controls.Add(this.SignalAmpsFader);
            this.SignalAmpsBox.Controls.Add(this.label6);
            this.SignalAmpsBox.Controls.Add(this.SignalAmpsDisplay);
            this.SignalAmpsBox.Location = new System.Drawing.Point(81, 19);
            this.SignalAmpsBox.Name = "SignalAmpsBox";
            this.SignalAmpsBox.Size = new System.Drawing.Size(65, 199);
            this.SignalAmpsBox.TabIndex = 13;
            this.SignalAmpsBox.TabStop = false;
            // 
            // SignalAmpsFader
            // 
            this.SignalAmpsFader.Location = new System.Drawing.Point(10, 39);
            this.SignalAmpsFader.Maximum = 25;
            this.SignalAmpsFader.Name = "SignalAmpsFader";
            this.SignalAmpsFader.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.SignalAmpsFader.Size = new System.Drawing.Size(45, 135);
            this.SignalAmpsFader.SmallChange = 2;
            this.SignalAmpsFader.TabIndex = 1;
            this.SignalAmpsFader.TickFrequency = 5;
            this.SignalAmpsFader.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.SignalAmpsFader.Value = 10;
            this.SignalAmpsFader.Scroll += new System.EventHandler(this.SignalParamFader_Scroll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Amps";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SignalAmpsDisplay
            // 
            this.SignalAmpsDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SignalAmpsDisplay.Location = new System.Drawing.Point(10, 16);
            this.SignalAmpsDisplay.Name = "SignalAmpsDisplay";
            this.SignalAmpsDisplay.Size = new System.Drawing.Size(45, 20);
            this.SignalAmpsDisplay.TabIndex = 0;
            this.SignalAmpsDisplay.Text = "10 A";
            this.SignalAmpsDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SignalVoltsBox
            // 
            this.SignalVoltsBox.Controls.Add(this.SignalVoltsFader);
            this.SignalVoltsBox.Controls.Add(this.label5);
            this.SignalVoltsBox.Controls.Add(this.SignalVoltsDisplay);
            this.SignalVoltsBox.Location = new System.Drawing.Point(10, 19);
            this.SignalVoltsBox.Name = "SignalVoltsBox";
            this.SignalVoltsBox.Size = new System.Drawing.Size(65, 199);
            this.SignalVoltsBox.TabIndex = 12;
            this.SignalVoltsBox.TabStop = false;
            // 
            // SignalVoltsFader
            // 
            this.SignalVoltsFader.LargeChange = 10;
            this.SignalVoltsFader.Location = new System.Drawing.Point(10, 39);
            this.SignalVoltsFader.Maximum = 253;
            this.SignalVoltsFader.Minimum = 207;
            this.SignalVoltsFader.Name = "SignalVoltsFader";
            this.SignalVoltsFader.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.SignalVoltsFader.Size = new System.Drawing.Size(45, 135);
            this.SignalVoltsFader.SmallChange = 5;
            this.SignalVoltsFader.TabIndex = 1;
            this.SignalVoltsFader.TickFrequency = 5;
            this.SignalVoltsFader.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.SignalVoltsFader.Value = 230;
            this.SignalVoltsFader.Scroll += new System.EventHandler(this.SignalParamFader_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Volts";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SignalVoltsDisplay
            // 
            this.SignalVoltsDisplay.AutoSize = true;
            this.SignalVoltsDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SignalVoltsDisplay.Location = new System.Drawing.Point(6, 16);
            this.SignalVoltsDisplay.Name = "SignalVoltsDisplay";
            this.SignalVoltsDisplay.Size = new System.Drawing.Size(51, 20);
            this.SignalVoltsDisplay.TabIndex = 0;
            this.SignalVoltsDisplay.Text = "230 V";
            this.SignalVoltsDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ADCBox
            // 
            this.ADCBox.Controls.Add(this.ADCNyquistDisplay);
            this.ADCBox.Controls.Add(this.label17);
            this.ADCBox.Controls.Add(this.ADCBitRateDisplay);
            this.ADCBox.Controls.Add(this.label16);
            this.ADCBox.Controls.Add(this.label15);
            this.ADCBox.Controls.Add(this.label14);
            this.ADCBox.Controls.Add(this.label13);
            this.ADCBox.Controls.Add(this.ADCSampleRateSelect);
            this.ADCBox.Controls.Add(this.label4);
            this.ADCBox.Controls.Add(this.ADCResolutionSelect);
            this.ADCBox.Location = new System.Drawing.Point(12, 247);
            this.ADCBox.Name = "ADCBox";
            this.ADCBox.Size = new System.Drawing.Size(228, 110);
            this.ADCBox.TabIndex = 2;
            this.ADCBox.TabStop = false;
            this.ADCBox.Text = "ADC";
            // 
            // ADCNyquistDisplay
            // 
            this.ADCNyquistDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ADCNyquistDisplay.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ADCNyquistDisplay.Location = new System.Drawing.Point(129, 73);
            this.ADCNyquistDisplay.Name = "ADCNyquistDisplay";
            this.ADCNyquistDisplay.Size = new System.Drawing.Size(78, 17);
            this.ADCNyquistDisplay.TabIndex = 11;
            this.ADCNyquistDisplay.Text = "2 kHz";
            this.ADCNyquistDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(121, 56);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(101, 13);
            this.label17.TabIndex = 10;
            this.label17.Text = "Nyquist Freaquency";
            // 
            // ADCBitRateDisplay
            // 
            this.ADCBitRateDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ADCBitRateDisplay.Location = new System.Drawing.Point(124, 29);
            this.ADCBitRateDisplay.Name = "ADCBitRateDisplay";
            this.ADCBitRateDisplay.Size = new System.Drawing.Size(98, 18);
            this.ADCBitRateDisplay.TabIndex = 9;
            this.ADCBitRateDisplay.Text = "12 kbit/s";
            this.ADCBitRateDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(153, 16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(45, 13);
            this.label16.TabIndex = 8;
            this.label16.Text = "Bit Rate";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(93, 75);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(30, 13);
            this.label15.TabIndex = 7;
            this.label15.Text = "Sa/s";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(93, 35);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(18, 13);
            this.label14.TabIndex = 6;
            this.label14.Text = "bit";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 56);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "Sample Rate";
            // 
            // ADCSampleRateSelect
            // 
            this.ADCSampleRateSelect.FormattingEnabled = true;
            this.ADCSampleRateSelect.Items.AddRange(new object[] {
            "1024",
            "2048",
            "4096",
            "8192",
            "16384",
            "32768",
            "44100"});
            this.ADCSampleRateSelect.Location = new System.Drawing.Point(7, 72);
            this.ADCSampleRateSelect.Name = "ADCSampleRateSelect";
            this.ADCSampleRateSelect.Size = new System.Drawing.Size(80, 21);
            this.ADCSampleRateSelect.TabIndex = 4;
            this.ADCSampleRateSelect.SelectedIndexChanged += new System.EventHandler(this.ADC_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Resolution";
            // 
            // ADCResolutionSelect
            // 
            this.ADCResolutionSelect.Items.AddRange(new object[] {
            "10",
            "12",
            "16",
            "24",
            "32"});
            this.ADCResolutionSelect.Location = new System.Drawing.Point(6, 32);
            this.ADCResolutionSelect.Name = "ADCResolutionSelect";
            this.ADCResolutionSelect.Size = new System.Drawing.Size(81, 21);
            this.ADCResolutionSelect.TabIndex = 2;
            this.ADCResolutionSelect.SelectedIndexChanged += new System.EventHandler(this.ADC_SelectedIndexChanged);
            // 
            // HarmonicsBox
            // 
            this.HarmonicsBox.Controls.Add(this.HarmonicsList);
            this.HarmonicsBox.Controls.Add(this.HarmonicsPresetSelect);
            this.HarmonicsBox.Controls.Add(this.HarmonicsFreaquencyDisplay);
            this.HarmonicsBox.Controls.Add(this.label21);
            this.HarmonicsBox.Controls.Add(this.label20);
            this.HarmonicsBox.Controls.Add(this.HarmonicsValueNum);
            this.HarmonicsBox.Controls.Add(this.HarmonicsTHDBox);
            this.HarmonicsBox.Controls.Add(this.label19);
            this.HarmonicsBox.Controls.Add(this.NarmonicsDeleteBtn);
            this.HarmonicsBox.Controls.Add(this.HarmonicsNumberNum);
            this.HarmonicsBox.Controls.Add(this.HarmonicsAddBtn);
            this.HarmonicsBox.Location = new System.Drawing.Point(246, 247);
            this.HarmonicsBox.Name = "HarmonicsBox";
            this.HarmonicsBox.Size = new System.Drawing.Size(419, 110);
            this.HarmonicsBox.TabIndex = 3;
            this.HarmonicsBox.TabStop = false;
            this.HarmonicsBox.Text = "Harmonics";
            // 
            // HarmonicsList
            // 
            this.HarmonicsList.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.HarmonicsList.AllowColumnReorder = true;
            this.HarmonicsList.BackColor = System.Drawing.SystemColors.Window;
            this.HarmonicsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.HarmonicNumber,
            this.HarmonicValue});
            this.HarmonicsList.FullRowSelect = true;
            this.HarmonicsList.GridLines = true;
            this.HarmonicsList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.HarmonicsList.HideSelection = false;
            this.HarmonicsList.HoverSelection = true;
            this.HarmonicsList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            listViewItem1.Checked = true;
            listViewItem1.StateImageIndex = 1;
            listViewItem2.ToolTipText = "nie ma go";
            this.HarmonicsList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.HarmonicsList.LabelWrap = false;
            this.HarmonicsList.Location = new System.Drawing.Point(203, 19);
            this.HarmonicsList.MultiSelect = false;
            this.HarmonicsList.Name = "HarmonicsList";
            this.HarmonicsList.OwnerDraw = true;
            this.HarmonicsList.ShowGroups = false;
            this.HarmonicsList.Size = new System.Drawing.Size(147, 82);
            this.HarmonicsList.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.HarmonicsList.TabIndex = 12;
            this.HarmonicsList.TileSize = new System.Drawing.Size(168, 20);
            this.HarmonicsList.UseCompatibleStateImageBehavior = false;
            this.HarmonicsList.View = System.Windows.Forms.View.Details;
            this.HarmonicsList.VirtualListSize = 10;
            // 
            // HarmonicNumber
            // 
            this.HarmonicNumber.Text = "No.";
            this.HarmonicNumber.Width = 40;
            // 
            // HarmonicValue
            // 
            this.HarmonicValue.Text = "Value";
            // 
            // HarmonicsPresetSelect
            // 
            this.HarmonicsPresetSelect.FormattingEnabled = true;
            this.HarmonicsPresetSelect.Location = new System.Drawing.Point(6, 19);
            this.HarmonicsPresetSelect.Name = "HarmonicsPresetSelect";
            this.HarmonicsPresetSelect.Size = new System.Drawing.Size(105, 21);
            this.HarmonicsPresetSelect.TabIndex = 11;
            // 
            // HarmonicsFreaquencyDisplay
            // 
            this.HarmonicsFreaquencyDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HarmonicsFreaquencyDisplay.Location = new System.Drawing.Point(121, 56);
            this.HarmonicsFreaquencyDisplay.Name = "HarmonicsFreaquencyDisplay";
            this.HarmonicsFreaquencyDisplay.Size = new System.Drawing.Size(76, 23);
            this.HarmonicsFreaquencyDisplay.TabIndex = 10;
            this.HarmonicsFreaquencyDisplay.Text = "150 Hz";
            this.HarmonicsFreaquencyDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(129, 42);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(63, 13);
            this.label21.TabIndex = 9;
            this.label21.Text = "Freaquency";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(93, 83);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(50, 13);
            this.label20.TabIndex = 8;
            this.label20.Text = "Value [V]";
            // 
            // HarmonicsValueNum
            // 
            this.HarmonicsValueNum.Location = new System.Drawing.Point(149, 81);
            this.HarmonicsValueNum.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.HarmonicsValueNum.Name = "HarmonicsValueNum";
            this.HarmonicsValueNum.Size = new System.Drawing.Size(48, 20);
            this.HarmonicsValueNum.TabIndex = 6;
            // 
            // HarmonicsTHDBox
            // 
            this.HarmonicsTHDBox.Controls.Add(this.HarmonicsTHDDisplay);
            this.HarmonicsTHDBox.Location = new System.Drawing.Point(6, 57);
            this.HarmonicsTHDBox.Name = "HarmonicsTHDBox";
            this.HarmonicsTHDBox.Size = new System.Drawing.Size(81, 44);
            this.HarmonicsTHDBox.TabIndex = 4;
            this.HarmonicsTHDBox.TabStop = false;
            this.HarmonicsTHDBox.Text = "THD";
            // 
            // HarmonicsTHDDisplay
            // 
            this.HarmonicsTHDDisplay.AutoSize = true;
            this.HarmonicsTHDDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HarmonicsTHDDisplay.Location = new System.Drawing.Point(6, 16);
            this.HarmonicsTHDDisplay.Name = "HarmonicsTHDDisplay";
            this.HarmonicsTHDDisplay.Size = new System.Drawing.Size(68, 17);
            this.HarmonicsTHDDisplay.TabIndex = 3;
            this.HarmonicsTHDDisplay.Text = "000.00 %";
            this.HarmonicsTHDDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(119, 21);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(24, 13);
            this.label19.TabIndex = 7;
            this.label19.Text = "No.";
            // 
            // NarmonicsDeleteBtn
            // 
            this.NarmonicsDeleteBtn.Location = new System.Drawing.Point(356, 53);
            this.NarmonicsDeleteBtn.Name = "NarmonicsDeleteBtn";
            this.NarmonicsDeleteBtn.Size = new System.Drawing.Size(49, 28);
            this.NarmonicsDeleteBtn.TabIndex = 2;
            this.NarmonicsDeleteBtn.Text = "Delete";
            this.NarmonicsDeleteBtn.UseVisualStyleBackColor = true;
            // 
            // HarmonicsNumberNum
            // 
            this.HarmonicsNumberNum.Location = new System.Drawing.Point(149, 19);
            this.HarmonicsNumberNum.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.HarmonicsNumberNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.HarmonicsNumberNum.Name = "HarmonicsNumberNum";
            this.HarmonicsNumberNum.Size = new System.Drawing.Size(48, 20);
            this.HarmonicsNumberNum.TabIndex = 5;
            this.HarmonicsNumberNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // HarmonicsAddBtn
            // 
            this.HarmonicsAddBtn.Location = new System.Drawing.Point(356, 19);
            this.HarmonicsAddBtn.Name = "HarmonicsAddBtn";
            this.HarmonicsAddBtn.Size = new System.Drawing.Size(49, 28);
            this.HarmonicsAddBtn.TabIndex = 1;
            this.HarmonicsAddBtn.Text = "Add";
            this.HarmonicsAddBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 370);
            this.Controls.Add(this.HarmonicsBox);
            this.Controls.Add(this.ADCBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SerialSettingBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "SerialACD";
            this.SerialSettingBox.ResumeLayout(false);
            this.SerialSettingBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SerialTimeoutNum)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.SignalFlowDirectionBox.ResumeLayout(false);
            this.SignalFlowDirectionBox.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.SignalFreaquencyBox.ResumeLayout(false);
            this.SignalFreaquencyBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SignalFreaquencyFader)).EndInit();
            this.SignalPhaseBox.ResumeLayout(false);
            this.SignalPhaseBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SignalPhaseFader)).EndInit();
            this.SignalAmpsBox.ResumeLayout(false);
            this.SignalAmpsBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SignalAmpsFader)).EndInit();
            this.SignalVoltsBox.ResumeLayout(false);
            this.SignalVoltsBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SignalVoltsFader)).EndInit();
            this.ADCBox.ResumeLayout(false);
            this.ADCBox.PerformLayout();
            this.HarmonicsBox.ResumeLayout(false);
            this.HarmonicsBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HarmonicsValueNum)).EndInit();
            this.HarmonicsTHDBox.ResumeLayout(false);
            this.HarmonicsTHDBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HarmonicsNumberNum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SerialSettingBox;
        private System.IO.Ports.SerialPort SerialPortComponent;
        private System.Windows.Forms.ComboBox SerialPortSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox SerialBaudSelect;
        private System.Windows.Forms.Button SerialStartStopButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar SignalVoltsFader;
        private System.Windows.Forms.Label SignalVoltsDisplay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox SignalVoltsBox;
        private System.Windows.Forms.GroupBox SignalAmpsBox;
        private System.Windows.Forms.TrackBar SignalAmpsFader;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label SignalAmpsDisplay;
        private System.Windows.Forms.GroupBox SignalPhaseBox;
        private System.Windows.Forms.TrackBar SignalPhaseFader;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label SignalPhaseDisplay;
        private System.Windows.Forms.GroupBox SignalFreaquencyBox;
        private System.Windows.Forms.TrackBar SignalFreaquencyFader;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label SignalFreaquencyDisplay;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label SignalActivePowerDisplay;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label SignalCosPhiDisplay;
        private System.Windows.Forms.Label SignalApparentPowerDisplay;
        private System.Windows.Forms.Label SignalReactivePowerDisplay;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label SignalTgPhiDisplay;
        private System.Windows.Forms.GroupBox SignalFlowDirectionBox;
        private System.Windows.Forms.Button SignalFlowDirectionBtn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox ADCBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox ADCSampleRateSelect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ADCResolutionSelect;
        private System.Windows.Forms.Label ADCBitRateDisplay;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox HarmonicsBox;
        private System.Windows.Forms.Label HarmonicsTHDDisplay;
        private System.Windows.Forms.Button NarmonicsDeleteBtn;
        private System.Windows.Forms.Button HarmonicsAddBtn;
        private System.Windows.Forms.GroupBox HarmonicsTHDBox;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.NumericUpDown HarmonicsNumberNum;
        private System.Windows.Forms.NumericUpDown HarmonicsValueNum;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox HarmonicsPresetSelect;
        private System.Windows.Forms.Label HarmonicsFreaquencyDisplay;
        private System.Windows.Forms.ListView HarmonicsList;
        public System.Windows.Forms.ColumnHeader HarmonicNumber;
        public System.Windows.Forms.ColumnHeader HarmonicValue;
        private System.Windows.Forms.Label ADCNyquistDisplay;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label SerialStatusDisplay;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.NumericUpDown SerialTimeoutNum;
        private System.Windows.Forms.Label label3;
    }
}

