namespace LTEGamer
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.linkLabelLocation = new System.Windows.Forms.LinkLabel();
            this.labelCreator = new System.Windows.Forms.Label();
            this.labelProgramm = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLabelIcons8 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabelLocation
            // 
            this.linkLabelLocation.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkLabelLocation.AutoSize = true;
            this.linkLabelLocation.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelLocation.LinkColor = System.Drawing.Color.Black;
            this.linkLabelLocation.Location = new System.Drawing.Point(82, 47);
            this.linkLabelLocation.Name = "linkLabelLocation";
            this.linkLabelLocation.Size = new System.Drawing.Size(79, 14);
            this.linkLabelLocation.TabIndex = 6;
            this.linkLabelLocation.TabStop = true;
            this.linkLabelLocation.Text = "@lteforum.at";
            this.linkLabelLocation.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.linkLabelLocation.VisitedLinkColor = System.Drawing.Color.Black;
            this.linkLabelLocation.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLocation_LinkClicked);
            // 
            // labelCreator
            // 
            this.labelCreator.AutoSize = true;
            this.labelCreator.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreator.Location = new System.Drawing.Point(81, 28);
            this.labelCreator.Name = "labelCreator";
            this.labelCreator.Size = new System.Drawing.Size(87, 23);
            this.labelCreator.TabIndex = 5;
            this.labelCreator.Text = "Blaubeere";
            // 
            // labelProgramm
            // 
            this.labelProgramm.AutoSize = true;
            this.labelProgramm.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProgramm.Location = new System.Drawing.Point(80, 7);
            this.labelProgramm.Name = "labelProgramm";
            this.labelProgramm.Size = new System.Drawing.Size(97, 26);
            this.labelProgramm.TabIndex = 4;
            this.labelProgramm.Text = "LTEGamer";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // linkLabelIcons8
            // 
            this.linkLabelIcons8.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkLabelIcons8.AutoSize = true;
            this.linkLabelIcons8.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelIcons8.LinkColor = System.Drawing.Color.Black;
            this.linkLabelIcons8.Location = new System.Drawing.Point(82, 66);
            this.linkLabelIcons8.Name = "linkLabelIcons8";
            this.linkLabelIcons8.Size = new System.Drawing.Size(121, 14);
            this.linkLabelIcons8.TabIndex = 8;
            this.linkLabelIcons8.TabStop = true;
            this.linkLabelIcons8.Text = "Icons von icons8.com";
            this.linkLabelIcons8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.linkLabelIcons8.VisitedLinkColor = System.Drawing.Color.Black;
            this.linkLabelIcons8.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelIcons8_LinkClicked);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 90);
            this.Controls.Add(this.linkLabelIcons8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linkLabelLocation);
            this.Controls.Add(this.labelCreator);
            this.Controls.Add(this.labelProgramm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAbout";
            this.Text = "Über LTEGamer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabelLocation;
        private System.Windows.Forms.Label labelCreator;
        private System.Windows.Forms.Label labelProgramm;
        private System.Windows.Forms.LinkLabel linkLabelIcons8;
    }
}