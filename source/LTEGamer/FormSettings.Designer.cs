namespace LTEGamer
{
    partial class FormSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
            this.groupBoxPingWorkaround = new System.Windows.Forms.GroupBox();
            this.labelTrackBarInterval = new System.Windows.Forms.Label();
            this.labelPingInterval = new System.Windows.Forms.Label();
            this.textBoxPingAddress = new System.Windows.Forms.TextBox();
            this.trackBarPingInterval = new System.Windows.Forms.TrackBar();
            this.labelPingAddress = new System.Windows.Forms.Label();
            this.groupBoxDownloadWorkaround = new System.Windows.Forms.GroupBox();
            this.labelTrackBarDownloadSpeed = new System.Windows.Forms.Label();
            this.labelDownloadSpeed = new System.Windows.Forms.Label();
            this.textBoxDownloadFile = new System.Windows.Forms.TextBox();
            this.trackBarDownloadSpeed = new System.Windows.Forms.TrackBar();
            this.labelDownloadFile = new System.Windows.Forms.Label();
            this.errorProviderPingAddress = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderDownloadFile = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxPingWorkaround.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPingInterval)).BeginInit();
            this.groupBoxDownloadWorkaround.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDownloadSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPingAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDownloadFile)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxPingWorkaround
            // 
            this.groupBoxPingWorkaround.Controls.Add(this.labelTrackBarInterval);
            this.groupBoxPingWorkaround.Controls.Add(this.labelPingInterval);
            this.groupBoxPingWorkaround.Controls.Add(this.textBoxPingAddress);
            this.groupBoxPingWorkaround.Controls.Add(this.trackBarPingInterval);
            this.groupBoxPingWorkaround.Controls.Add(this.labelPingAddress);
            this.groupBoxPingWorkaround.Location = new System.Drawing.Point(12, 12);
            this.groupBoxPingWorkaround.Name = "groupBoxPingWorkaround";
            this.groupBoxPingWorkaround.Size = new System.Drawing.Size(252, 111);
            this.groupBoxPingWorkaround.TabIndex = 0;
            this.groupBoxPingWorkaround.TabStop = false;
            this.groupBoxPingWorkaround.Text = "Ping Workaround";
            // 
            // labelTrackBarInterval
            // 
            this.labelTrackBarInterval.AutoSize = true;
            this.labelTrackBarInterval.Location = new System.Drawing.Point(82, 85);
            this.labelTrackBarInterval.Name = "labelTrackBarInterval";
            this.labelTrackBarInterval.Size = new System.Drawing.Size(41, 13);
            this.labelTrackBarInterval.TabIndex = 4;
            this.labelTrackBarInterval.Text = "100 ms";
            // 
            // labelPingInterval
            // 
            this.labelPingInterval.AutoSize = true;
            this.labelPingInterval.Location = new System.Drawing.Point(16, 55);
            this.labelPingInterval.Name = "labelPingInterval";
            this.labelPingInterval.Size = new System.Drawing.Size(45, 13);
            this.labelPingInterval.TabIndex = 1;
            this.labelPingInterval.Text = "Interval:";
            // 
            // textBoxPingAddress
            // 
            this.textBoxPingAddress.Location = new System.Drawing.Point(83, 26);
            this.textBoxPingAddress.Name = "textBoxPingAddress";
            this.textBoxPingAddress.Size = new System.Drawing.Size(139, 20);
            this.textBoxPingAddress.TabIndex = 1;
            this.textBoxPingAddress.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxPingAddress_Validating);
            // 
            // trackBarPingInterval
            // 
            this.trackBarPingInterval.LargeChange = 20;
            this.trackBarPingInterval.Location = new System.Drawing.Point(76, 52);
            this.trackBarPingInterval.Maximum = 200;
            this.trackBarPingInterval.Minimum = 50;
            this.trackBarPingInterval.Name = "trackBarPingInterval";
            this.trackBarPingInterval.Size = new System.Drawing.Size(150, 45);
            this.trackBarPingInterval.SmallChange = 10;
            this.trackBarPingInterval.TabIndex = 2;
            this.trackBarPingInterval.TickFrequency = 10;
            this.trackBarPingInterval.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBarPingInterval.Value = 100;
            this.trackBarPingInterval.ValueChanged += new System.EventHandler(this.trackBarPingInterval_ValueChanged);
            // 
            // labelPingAddress
            // 
            this.labelPingAddress.AutoSize = true;
            this.labelPingAddress.Location = new System.Drawing.Point(16, 29);
            this.labelPingAddress.Name = "labelPingAddress";
            this.labelPingAddress.Size = new System.Drawing.Size(54, 13);
            this.labelPingAddress.TabIndex = 0;
            this.labelPingAddress.Text = "Addresse:";
            // 
            // groupBoxDownloadWorkaround
            // 
            this.groupBoxDownloadWorkaround.Controls.Add(this.labelTrackBarDownloadSpeed);
            this.groupBoxDownloadWorkaround.Controls.Add(this.labelDownloadSpeed);
            this.groupBoxDownloadWorkaround.Controls.Add(this.textBoxDownloadFile);
            this.groupBoxDownloadWorkaround.Controls.Add(this.trackBarDownloadSpeed);
            this.groupBoxDownloadWorkaround.Controls.Add(this.labelDownloadFile);
            this.groupBoxDownloadWorkaround.Location = new System.Drawing.Point(12, 129);
            this.groupBoxDownloadWorkaround.Name = "groupBoxDownloadWorkaround";
            this.groupBoxDownloadWorkaround.Size = new System.Drawing.Size(252, 115);
            this.groupBoxDownloadWorkaround.TabIndex = 1;
            this.groupBoxDownloadWorkaround.TabStop = false;
            this.groupBoxDownloadWorkaround.Text = "Download Workaround";
            // 
            // labelTrackBarDownloadSpeed
            // 
            this.labelTrackBarDownloadSpeed.AutoSize = true;
            this.labelTrackBarDownloadSpeed.Location = new System.Drawing.Point(82, 87);
            this.labelTrackBarDownloadSpeed.Name = "labelTrackBarDownloadSpeed";
            this.labelTrackBarDownloadSpeed.Size = new System.Drawing.Size(52, 13);
            this.labelTrackBarDownloadSpeed.TabIndex = 9;
            this.labelTrackBarDownloadSpeed.Text = "15 Mbit/s";
            // 
            // labelDownloadSpeed
            // 
            this.labelDownloadSpeed.AutoSize = true;
            this.labelDownloadSpeed.Location = new System.Drawing.Point(16, 57);
            this.labelDownloadSpeed.Name = "labelDownloadSpeed";
            this.labelDownloadSpeed.Size = new System.Drawing.Size(41, 13);
            this.labelDownloadSpeed.TabIndex = 6;
            this.labelDownloadSpeed.Text = "Speed:";
            // 
            // textBoxDownloadFile
            // 
            this.textBoxDownloadFile.Location = new System.Drawing.Point(83, 28);
            this.textBoxDownloadFile.Name = "textBoxDownloadFile";
            this.textBoxDownloadFile.Size = new System.Drawing.Size(139, 20);
            this.textBoxDownloadFile.TabIndex = 3;
            this.textBoxDownloadFile.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxDownloadFile_Validating);
            // 
            // trackBarDownloadSpeed
            // 
            this.trackBarDownloadSpeed.Location = new System.Drawing.Point(76, 54);
            this.trackBarDownloadSpeed.Maximum = 50;
            this.trackBarDownloadSpeed.Minimum = 1;
            this.trackBarDownloadSpeed.Name = "trackBarDownloadSpeed";
            this.trackBarDownloadSpeed.Size = new System.Drawing.Size(150, 45);
            this.trackBarDownloadSpeed.TabIndex = 4;
            this.trackBarDownloadSpeed.TickFrequency = 10;
            this.trackBarDownloadSpeed.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBarDownloadSpeed.Value = 15;
            this.trackBarDownloadSpeed.ValueChanged += new System.EventHandler(this.trackBarDownloadSpeed_ValueChanged);
            // 
            // labelDownloadFile
            // 
            this.labelDownloadFile.AutoSize = true;
            this.labelDownloadFile.Location = new System.Drawing.Point(16, 31);
            this.labelDownloadFile.Name = "labelDownloadFile";
            this.labelDownloadFile.Size = new System.Drawing.Size(35, 13);
            this.labelDownloadFile.TabIndex = 5;
            this.labelDownloadFile.Text = "Datei:";
            // 
            // errorProviderPingAddress
            // 
            this.errorProviderPingAddress.ContainerControl = this;
            this.errorProviderPingAddress.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProviderPingAddress.Icon")));
            // 
            // errorProviderDownloadFile
            // 
            this.errorProviderDownloadFile.ContainerControl = this;
            this.errorProviderDownloadFile.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProviderDownloadFile.Icon")));
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 254);
            this.Controls.Add(this.groupBoxDownloadWorkaround);
            this.Controls.Add(this.groupBoxPingWorkaround);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormSettings";
            this.Text = "Einstellungen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSettings_FormClosing);
            this.groupBoxPingWorkaround.ResumeLayout(false);
            this.groupBoxPingWorkaround.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPingInterval)).EndInit();
            this.groupBoxDownloadWorkaround.ResumeLayout(false);
            this.groupBoxDownloadWorkaround.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDownloadSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPingAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDownloadFile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPingWorkaround;
        private System.Windows.Forms.GroupBox groupBoxDownloadWorkaround;
        private System.Windows.Forms.Label labelPingAddress;
        private System.Windows.Forms.Label labelPingInterval;
        private System.Windows.Forms.Label labelTrackBarInterval;
        private System.Windows.Forms.Label labelTrackBarDownloadSpeed;
        private System.Windows.Forms.Label labelDownloadSpeed;
        private System.Windows.Forms.Label labelDownloadFile;
        public System.Windows.Forms.TextBox textBoxPingAddress;
        public System.Windows.Forms.TrackBar trackBarPingInterval;
        public System.Windows.Forms.TextBox textBoxDownloadFile;
        public System.Windows.Forms.TrackBar trackBarDownloadSpeed;
        private System.Windows.Forms.ErrorProvider errorProviderPingAddress;
        private System.Windows.Forms.ErrorProvider errorProviderDownloadFile;
    }
}