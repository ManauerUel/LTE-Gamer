namespace LTEGamer
{
    partial class FormManageApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManageApp));
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.labelPfad = new System.Windows.Forms.Label();
            this.buttonSearchPath = new System.Windows.Forms.Button();
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(38, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(56, 6);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(182, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // textBoxPath
            // 
            this.textBoxPath.Location = new System.Drawing.Point(56, 32);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(182, 20);
            this.textBoxPath.TabIndex = 2;
            this.textBoxPath.TextChanged += new System.EventHandler(this.textBoxPath_TextChanged);
            // 
            // labelPfad
            // 
            this.labelPfad.AutoSize = true;
            this.labelPfad.Location = new System.Drawing.Point(12, 35);
            this.labelPfad.Name = "labelPfad";
            this.labelPfad.Size = new System.Drawing.Size(32, 13);
            this.labelPfad.TabIndex = 2;
            this.labelPfad.Text = "Pfad:";
            // 
            // buttonSearchPath
            // 
            this.buttonSearchPath.Location = new System.Drawing.Point(244, 30);
            this.buttonSearchPath.Name = "buttonSearchPath";
            this.buttonSearchPath.Size = new System.Drawing.Size(33, 23);
            this.buttonSearchPath.TabIndex = 3;
            this.buttonSearchPath.Text = "...";
            this.buttonSearchPath.UseVisualStyleBackColor = true;
            this.buttonSearchPath.Click += new System.EventHandler(this.buttonSearchPath_Click);
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.Location = new System.Drawing.Point(245, 6);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(32, 20);
            this.pictureBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxIcon.TabIndex = 8;
            this.pictureBoxIcon.TabStop = false;
            // 
            // FormManageApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 62);
            this.Controls.Add(this.pictureBoxIcon);
            this.Controls.Add(this.buttonSearchPath);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.labelPfad);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormManageApp";
            this.Text = "Neues Spiel";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelPfad;
        private System.Windows.Forms.Button buttonSearchPath;
        private System.Windows.Forms.PictureBox pictureBoxIcon;
        public System.Windows.Forms.TextBox textBoxName;
        public System.Windows.Forms.TextBox textBoxPath;
    }
}