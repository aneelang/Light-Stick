namespace Light_Stick
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.labelReadConfigurationSettings = new System.Windows.Forms.Label();
            this.labelWriteConfigurationSettings = new System.Windows.Forms.Label();
            this.groupBoxReadSettings = new System.Windows.Forms.GroupBox();
            this.labelReadSensitivityLevel = new System.Windows.Forms.Label();
            this.trackBarReadSensitivityLevel = new System.Windows.Forms.TrackBar();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelMhz = new System.Windows.Forms.Label();
            this.labelKbps = new System.Windows.Forms.Label();
            this.labelChannel = new System.Windows.Forms.Label();
            this.labelRFBaudRate = new System.Windows.Forms.Label();
            this.labelPLinkID = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelWriteSensitivityLevel = new System.Windows.Forms.Label();
            this.trackBarWriteSensitivityLevel = new System.Windows.Forms.TrackBar();
            this.comboBoxWriteChannel = new System.Windows.Forms.ComboBox();
            this.comboBoxWriteRFBaudRate = new System.Windows.Forms.ComboBox();
            this.textBoxWritePLinkID = new System.Windows.Forms.TextBox();
            this.labelWriteMHz = new System.Windows.Forms.Label();
            this.labelWriteKbps = new System.Windows.Forms.Label();
            this.labelWriteChannel = new System.Windows.Forms.Label();
            this.labelWriteRFBaudRate = new System.Windows.Forms.Label();
            this.labelWritePLinkID = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxSerialPort = new System.Windows.Forms.ComboBox();
            this.buttonWriteToDevice = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelWriteToDeviceTimeOut = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBoxReadSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarReadSensitivityLevel)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWriteSensitivityLevel)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label1.Location = new System.Drawing.Point(196, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(519, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "p-link Light Stick User Configuration Utility";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBoxTime
            // 
            this.textBoxTime.Location = new System.Drawing.Point(587, 79);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.Size = new System.Drawing.Size(185, 23);
            this.textBoxTime.TabIndex = 1;
            // 
            // labelReadConfigurationSettings
            // 
            this.labelReadConfigurationSettings.AutoSize = true;
            this.labelReadConfigurationSettings.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelReadConfigurationSettings.ForeColor = System.Drawing.Color.Firebrick;
            this.labelReadConfigurationSettings.Location = new System.Drawing.Point(53, 113);
            this.labelReadConfigurationSettings.Name = "labelReadConfigurationSettings";
            this.labelReadConfigurationSettings.Size = new System.Drawing.Size(198, 19);
            this.labelReadConfigurationSettings.TabIndex = 2;
            this.labelReadConfigurationSettings.Text = "Read Configuration Settings";
            // 
            // labelWriteConfigurationSettings
            // 
            this.labelWriteConfigurationSettings.AutoSize = true;
            this.labelWriteConfigurationSettings.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelWriteConfigurationSettings.ForeColor = System.Drawing.Color.Firebrick;
            this.labelWriteConfigurationSettings.Location = new System.Drawing.Point(507, 113);
            this.labelWriteConfigurationSettings.Name = "labelWriteConfigurationSettings";
            this.labelWriteConfigurationSettings.Size = new System.Drawing.Size(200, 19);
            this.labelWriteConfigurationSettings.TabIndex = 3;
            this.labelWriteConfigurationSettings.Text = "Write Configuration Settings";
            // 
            // groupBoxReadSettings
            // 
            this.groupBoxReadSettings.Controls.Add(this.labelReadSensitivityLevel);
            this.groupBoxReadSettings.Controls.Add(this.trackBarReadSensitivityLevel);
            this.groupBoxReadSettings.Controls.Add(this.comboBox2);
            this.groupBoxReadSettings.Controls.Add(this.comboBox1);
            this.groupBoxReadSettings.Controls.Add(this.textBox1);
            this.groupBoxReadSettings.Controls.Add(this.labelMhz);
            this.groupBoxReadSettings.Controls.Add(this.labelKbps);
            this.groupBoxReadSettings.Controls.Add(this.labelChannel);
            this.groupBoxReadSettings.Controls.Add(this.labelRFBaudRate);
            this.groupBoxReadSettings.Controls.Add(this.labelPLinkID);
            this.groupBoxReadSettings.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxReadSettings.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBoxReadSettings.Location = new System.Drawing.Point(20, 146);
            this.groupBoxReadSettings.Name = "groupBoxReadSettings";
            this.groupBoxReadSettings.Size = new System.Drawing.Size(348, 223);
            this.groupBoxReadSettings.TabIndex = 4;
            this.groupBoxReadSettings.TabStop = false;
            this.groupBoxReadSettings.Text = "Read Settings";
            // 
            // labelReadSensitivityLevel
            // 
            this.labelReadSensitivityLevel.AutoSize = true;
            this.labelReadSensitivityLevel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelReadSensitivityLevel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelReadSensitivityLevel.Location = new System.Drawing.Point(80, 141);
            this.labelReadSensitivityLevel.Name = "labelReadSensitivityLevel";
            this.labelReadSensitivityLevel.Size = new System.Drawing.Size(149, 17);
            this.labelReadSensitivityLevel.TabIndex = 9;
            this.labelReadSensitivityLevel.Text = "SENSITIVITY LEVEL";
            // 
            // trackBarReadSensitivityLevel
            // 
            this.trackBarReadSensitivityLevel.Location = new System.Drawing.Point(80, 161);
            this.trackBarReadSensitivityLevel.Maximum = 4;
            this.trackBarReadSensitivityLevel.Minimum = 1;
            this.trackBarReadSensitivityLevel.Name = "trackBarReadSensitivityLevel";
            this.trackBarReadSensitivityLevel.Size = new System.Drawing.Size(151, 45);
            this.trackBarReadSensitivityLevel.TabIndex = 8;
            this.trackBarReadSensitivityLevel.Value = 1;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(113, 105);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(81, 25);
            this.comboBox2.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(113, 61);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(81, 25);
            this.comboBox1.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(113, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(122, 25);
            this.textBox1.TabIndex = 5;
            // 
            // labelMhz
            // 
            this.labelMhz.AutoSize = true;
            this.labelMhz.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMhz.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelMhz.Location = new System.Drawing.Point(200, 113);
            this.labelMhz.Name = "labelMhz";
            this.labelMhz.Size = new System.Drawing.Size(38, 17);
            this.labelMhz.TabIndex = 4;
            this.labelMhz.Text = "MHz";
            this.labelMhz.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelKbps
            // 
            this.labelKbps.AutoSize = true;
            this.labelKbps.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelKbps.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelKbps.Location = new System.Drawing.Point(200, 65);
            this.labelKbps.Name = "labelKbps";
            this.labelKbps.Size = new System.Drawing.Size(35, 17);
            this.labelKbps.TabIndex = 3;
            this.labelKbps.Text = "kbps";
            // 
            // labelChannel
            // 
            this.labelChannel.AutoSize = true;
            this.labelChannel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelChannel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelChannel.Location = new System.Drawing.Point(18, 109);
            this.labelChannel.Name = "labelChannel";
            this.labelChannel.Size = new System.Drawing.Size(56, 17);
            this.labelChannel.TabIndex = 2;
            this.labelChannel.Text = "Channel";
            // 
            // labelRFBaudRate
            // 
            this.labelRFBaudRate.AutoSize = true;
            this.labelRFBaudRate.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRFBaudRate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelRFBaudRate.Location = new System.Drawing.Point(18, 65);
            this.labelRFBaudRate.Name = "labelRFBaudRate";
            this.labelRFBaudRate.Size = new System.Drawing.Size(93, 17);
            this.labelRFBaudRate.TabIndex = 1;
            this.labelRFBaudRate.Text = "RF Baud Rate";
            // 
            // labelPLinkID
            // 
            this.labelPLinkID.AutoSize = true;
            this.labelPLinkID.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPLinkID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelPLinkID.Location = new System.Drawing.Point(18, 24);
            this.labelPLinkID.Name = "labelPLinkID";
            this.labelPLinkID.Size = new System.Drawing.Size(60, 17);
            this.labelPLinkID.TabIndex = 0;
            this.labelPLinkID.Text = "p-link ID";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelWriteSensitivityLevel);
            this.groupBox1.Controls.Add(this.trackBarWriteSensitivityLevel);
            this.groupBox1.Controls.Add(this.comboBoxWriteChannel);
            this.groupBox1.Controls.Add(this.comboBoxWriteRFBaudRate);
            this.groupBox1.Controls.Add(this.textBoxWritePLinkID);
            this.groupBox1.Controls.Add(this.labelWriteMHz);
            this.groupBox1.Controls.Add(this.labelWriteKbps);
            this.groupBox1.Controls.Add(this.labelWriteChannel);
            this.groupBox1.Controls.Add(this.labelWriteRFBaudRate);
            this.groupBox1.Controls.Add(this.labelWritePLinkID);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(424, 146);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 223);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Write Settings";
            // 
            // labelWriteSensitivityLevel
            // 
            this.labelWriteSensitivityLevel.AutoSize = true;
            this.labelWriteSensitivityLevel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelWriteSensitivityLevel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelWriteSensitivityLevel.Location = new System.Drawing.Point(80, 141);
            this.labelWriteSensitivityLevel.Name = "labelWriteSensitivityLevel";
            this.labelWriteSensitivityLevel.Size = new System.Drawing.Size(149, 17);
            this.labelWriteSensitivityLevel.TabIndex = 9;
            this.labelWriteSensitivityLevel.Text = "SENSITIVITY LEVEL";
            // 
            // trackBarWriteSensitivityLevel
            // 
            this.trackBarWriteSensitivityLevel.Location = new System.Drawing.Point(80, 161);
            this.trackBarWriteSensitivityLevel.Maximum = 4;
            this.trackBarWriteSensitivityLevel.Minimum = 1;
            this.trackBarWriteSensitivityLevel.Name = "trackBarWriteSensitivityLevel";
            this.trackBarWriteSensitivityLevel.Size = new System.Drawing.Size(151, 45);
            this.trackBarWriteSensitivityLevel.TabIndex = 8;
            this.trackBarWriteSensitivityLevel.Value = 1;
            // 
            // comboBoxWriteChannel
            // 
            this.comboBoxWriteChannel.FormattingEnabled = true;
            this.comboBoxWriteChannel.Location = new System.Drawing.Point(113, 105);
            this.comboBoxWriteChannel.Name = "comboBoxWriteChannel";
            this.comboBoxWriteChannel.Size = new System.Drawing.Size(81, 25);
            this.comboBoxWriteChannel.TabIndex = 7;
            // 
            // comboBoxWriteRFBaudRate
            // 
            this.comboBoxWriteRFBaudRate.FormattingEnabled = true;
            this.comboBoxWriteRFBaudRate.Location = new System.Drawing.Point(113, 61);
            this.comboBoxWriteRFBaudRate.Name = "comboBoxWriteRFBaudRate";
            this.comboBoxWriteRFBaudRate.Size = new System.Drawing.Size(81, 25);
            this.comboBoxWriteRFBaudRate.TabIndex = 6;
            // 
            // textBoxWritePLinkID
            // 
            this.textBoxWritePLinkID.Location = new System.Drawing.Point(113, 20);
            this.textBoxWritePLinkID.Name = "textBoxWritePLinkID";
            this.textBoxWritePLinkID.Size = new System.Drawing.Size(122, 25);
            this.textBoxWritePLinkID.TabIndex = 5;
            // 
            // labelWriteMHz
            // 
            this.labelWriteMHz.AutoSize = true;
            this.labelWriteMHz.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelWriteMHz.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelWriteMHz.Location = new System.Drawing.Point(200, 109);
            this.labelWriteMHz.Name = "labelWriteMHz";
            this.labelWriteMHz.Size = new System.Drawing.Size(38, 17);
            this.labelWriteMHz.TabIndex = 4;
            this.labelWriteMHz.Text = "MHz";
            this.labelWriteMHz.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelWriteKbps
            // 
            this.labelWriteKbps.AutoSize = true;
            this.labelWriteKbps.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelWriteKbps.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelWriteKbps.Location = new System.Drawing.Point(200, 65);
            this.labelWriteKbps.Name = "labelWriteKbps";
            this.labelWriteKbps.Size = new System.Drawing.Size(35, 17);
            this.labelWriteKbps.TabIndex = 3;
            this.labelWriteKbps.Text = "kbps";
            // 
            // labelWriteChannel
            // 
            this.labelWriteChannel.AutoSize = true;
            this.labelWriteChannel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelWriteChannel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelWriteChannel.Location = new System.Drawing.Point(18, 109);
            this.labelWriteChannel.Name = "labelWriteChannel";
            this.labelWriteChannel.Size = new System.Drawing.Size(56, 17);
            this.labelWriteChannel.TabIndex = 2;
            this.labelWriteChannel.Text = "Channel";
            // 
            // labelWriteRFBaudRate
            // 
            this.labelWriteRFBaudRate.AutoSize = true;
            this.labelWriteRFBaudRate.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelWriteRFBaudRate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelWriteRFBaudRate.Location = new System.Drawing.Point(18, 65);
            this.labelWriteRFBaudRate.Name = "labelWriteRFBaudRate";
            this.labelWriteRFBaudRate.Size = new System.Drawing.Size(93, 17);
            this.labelWriteRFBaudRate.TabIndex = 1;
            this.labelWriteRFBaudRate.Text = "RF Baud Rate";
            // 
            // labelWritePLinkID
            // 
            this.labelWritePLinkID.AutoSize = true;
            this.labelWritePLinkID.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelWritePLinkID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelWritePLinkID.Location = new System.Drawing.Point(18, 24);
            this.labelWritePLinkID.Name = "labelWritePLinkID";
            this.labelWritePLinkID.Size = new System.Drawing.Size(60, 17);
            this.labelWritePLinkID.TabIndex = 0;
            this.labelWritePLinkID.Text = "p-link ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxSerialPort);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox2.Location = new System.Drawing.Point(20, 385);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(348, 53);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PC Setting";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(14, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Serial Port";
            // 
            // comboBoxSerialPort
            // 
            this.comboBoxSerialPort.FormattingEnabled = true;
            this.comboBoxSerialPort.Location = new System.Drawing.Point(113, 17);
            this.comboBoxSerialPort.Name = "comboBoxSerialPort";
            this.comboBoxSerialPort.Size = new System.Drawing.Size(125, 25);
            this.comboBoxSerialPort.TabIndex = 7;
            // 
            // buttonWriteToDevice
            // 
            this.buttonWriteToDevice.Location = new System.Drawing.Point(424, 378);
            this.buttonWriteToDevice.Name = "buttonWriteToDevice";
            this.buttonWriteToDevice.Size = new System.Drawing.Size(94, 45);
            this.buttonWriteToDevice.TabIndex = 11;
            this.buttonWriteToDevice.Text = "Write to Device";
            this.buttonWriteToDevice.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(587, 378);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(94, 45);
            this.buttonExit.TabIndex = 12;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // labelWriteToDeviceTimeOut
            // 
            this.labelWriteToDeviceTimeOut.AutoSize = true;
            this.labelWriteToDeviceTimeOut.Location = new System.Drawing.Point(424, 436);
            this.labelWriteToDeviceTimeOut.Name = "labelWriteToDeviceTimeOut";
            this.labelWriteToDeviceTimeOut.Size = new System.Drawing.Size(168, 15);
            this.labelWriteToDeviceTimeOut.TabIndex = 13;
            this.labelWriteToDeviceTimeOut.Text = "Write to Device Time Out (Sec)";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(598, 433);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(45, 23);
            this.textBox2.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 462);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.labelWriteToDeviceTimeOut);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonWriteToDevice);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxReadSettings);
            this.Controls.Add(this.labelWriteConfigurationSettings);
            this.Controls.Add(this.labelReadConfigurationSettings);
            this.Controls.Add(this.textBoxTime);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "p-Link Light Stick - User Configuration Utility";
            this.groupBoxReadSettings.ResumeLayout(false);
            this.groupBoxReadSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarReadSensitivityLevel)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWriteSensitivityLevel)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private TextBox textBoxTime;
        private Label labelReadConfigurationSettings;
        private Label labelWriteConfigurationSettings;
        private GroupBox groupBoxReadSettings;
        private TrackBar trackBarReadSensitivityLevel;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Label labelMhz;
        private Label labelKbps;
        private Label labelChannel;
        private Label labelRFBaudRate;
        private Label labelPLinkID;
        private ContextMenuStrip contextMenuStrip1;
        private Label labelReadSensitivityLevel;
        private GroupBox groupBox1;
        private Label labelWriteSensitivityLevel;
        private TrackBar trackBarWriteSensitivityLevel;
        private ComboBox comboBoxWriteChannel;
        private ComboBox comboBoxWriteRFBaudRate;
        private TextBox textBoxWritePLinkID;
        private Label labelWriteMHz;
        private Label labelWriteKbps;
        private Label labelWriteChannel;
        private Label labelWriteRFBaudRate;
        private Label labelWritePLinkID;
        private GroupBox groupBox2;
        private ComboBox comboBoxSerialPort;
        private Label label2;
        private Button buttonWriteToDevice;
        private Button buttonExit;
        private Label labelWriteToDeviceTimeOut;
        private TextBox textBox2;
    }
}