namespace LTEGamer
{
    partial class FormMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAddGame = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEditGame = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDeleteGame = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonWorkaroundPing = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonWorkaroundDownloader = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonSettings = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAbout = new System.Windows.Forms.ToolStripButton();
            this.statusStripMenu = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.listViewApps = new System.Windows.Forms.ListView();
            this.columnHeaderIcon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.richTextBoxLog = new System.Windows.Forms.RichTextBox();
            this.toolStripMenu.SuspendLayout();
            this.statusStripMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAddGame,
            this.toolStripButtonEditGame,
            this.toolStripButtonDeleteGame,
            this.toolStripSeparator1,
            this.toolStripButtonWorkaroundPing,
            this.toolStripButtonWorkaroundDownloader,
            this.toolStripSeparator2,
            this.toolStripButtonSettings,
            this.toolStripButtonAbout});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(508, 55);
            this.toolStripMenu.TabIndex = 0;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // toolStripButtonAddGame
            // 
            this.toolStripButtonAddGame.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAddGame.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAddGame.Image")));
            this.toolStripButtonAddGame.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonAddGame.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAddGame.Name = "toolStripButtonAddGame";
            this.toolStripButtonAddGame.Size = new System.Drawing.Size(52, 52);
            this.toolStripButtonAddGame.Text = "Hinzufügen";
            this.toolStripButtonAddGame.Click += new System.EventHandler(this.toolStripButtonAddGame_Click);
            // 
            // toolStripButtonEditGame
            // 
            this.toolStripButtonEditGame.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEditGame.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEditGame.Image")));
            this.toolStripButtonEditGame.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonEditGame.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEditGame.Name = "toolStripButtonEditGame";
            this.toolStripButtonEditGame.Size = new System.Drawing.Size(52, 52);
            this.toolStripButtonEditGame.Text = "Bearbeiten";
            this.toolStripButtonEditGame.Click += new System.EventHandler(this.toolStripButtonEditGame_Click);
            // 
            // toolStripButtonDeleteGame
            // 
            this.toolStripButtonDeleteGame.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDeleteGame.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDeleteGame.Image")));
            this.toolStripButtonDeleteGame.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonDeleteGame.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDeleteGame.Name = "toolStripButtonDeleteGame";
            this.toolStripButtonDeleteGame.Size = new System.Drawing.Size(52, 52);
            this.toolStripButtonDeleteGame.Text = "Löschen";
            this.toolStripButtonDeleteGame.Click += new System.EventHandler(this.toolStripButtonDeleteGame_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 55);
            // 
            // toolStripButtonWorkaroundPing
            // 
            this.toolStripButtonWorkaroundPing.CheckOnClick = true;
            this.toolStripButtonWorkaroundPing.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonWorkaroundPing.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonWorkaroundPing.Image")));
            this.toolStripButtonWorkaroundPing.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonWorkaroundPing.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonWorkaroundPing.Name = "toolStripButtonWorkaroundPing";
            this.toolStripButtonWorkaroundPing.Size = new System.Drawing.Size(52, 52);
            this.toolStripButtonWorkaroundPing.Text = "Workaround: Pingflooder";
            this.toolStripButtonWorkaroundPing.Click += new System.EventHandler(this.toolStripButtonWorkaroundPing_Click);
            // 
            // toolStripButtonWorkaroundDownloader
            // 
            this.toolStripButtonWorkaroundDownloader.CheckOnClick = true;
            this.toolStripButtonWorkaroundDownloader.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonWorkaroundDownloader.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonWorkaroundDownloader.Image")));
            this.toolStripButtonWorkaroundDownloader.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonWorkaroundDownloader.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonWorkaroundDownloader.Name = "toolStripButtonWorkaroundDownloader";
            this.toolStripButtonWorkaroundDownloader.Size = new System.Drawing.Size(52, 52);
            this.toolStripButtonWorkaroundDownloader.Text = "Workaround: Downloader";
            this.toolStripButtonWorkaroundDownloader.Click += new System.EventHandler(this.toolStripButtonWorkaroundDownloader_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 55);
            // 
            // toolStripButtonSettings
            // 
            this.toolStripButtonSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSettings.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSettings.Image")));
            this.toolStripButtonSettings.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSettings.Name = "toolStripButtonSettings";
            this.toolStripButtonSettings.Size = new System.Drawing.Size(52, 52);
            this.toolStripButtonSettings.Text = "Einstellungen";
            this.toolStripButtonSettings.Click += new System.EventHandler(this.toolStripButtonSettings_Click);
            // 
            // toolStripButtonAbout
            // 
            this.toolStripButtonAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAbout.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAbout.Image")));
            this.toolStripButtonAbout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAbout.Name = "toolStripButtonAbout";
            this.toolStripButtonAbout.Size = new System.Drawing.Size(52, 52);
            this.toolStripButtonAbout.Text = "Info";
            this.toolStripButtonAbout.Click += new System.EventHandler(this.toolStripButtonAbout_Click);
            // 
            // statusStripMenu
            // 
            this.statusStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStripMenu.Location = new System.Drawing.Point(0, 279);
            this.statusStripMenu.Name = "statusStripMenu";
            this.statusStripMenu.Size = new System.Drawing.Size(508, 22);
            this.statusStripMenu.TabIndex = 1;
            this.statusStripMenu.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(139, 17);
            this.toolStripStatusLabel.Text = "Kein Workaround aktiv ...";
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 55);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.listViewApps);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.richTextBoxLog);
            this.splitContainer.Size = new System.Drawing.Size(508, 224);
            this.splitContainer.SplitterDistance = 155;
            this.splitContainer.TabIndex = 2;
            // 
            // listViewApps
            // 
            this.listViewApps.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderIcon,
            this.columnHeaderName,
            this.columnHeaderPath});
            this.listViewApps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewApps.FullRowSelect = true;
            this.listViewApps.Location = new System.Drawing.Point(0, 0);
            this.listViewApps.Name = "listViewApps";
            this.listViewApps.Size = new System.Drawing.Size(508, 155);
            this.listViewApps.TabIndex = 0;
            this.listViewApps.UseCompatibleStateImageBehavior = false;
            this.listViewApps.View = System.Windows.Forms.View.Details;
            this.listViewApps.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listViewApps_ItemSelectionChanged);
            // 
            // columnHeaderIcon
            // 
            this.columnHeaderIcon.Text = "Icon";
            this.columnHeaderIcon.Width = 33;
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Name";
            this.columnHeaderName.Width = 140;
            // 
            // columnHeaderPath
            // 
            this.columnHeaderPath.Text = "Path";
            this.columnHeaderPath.Width = 330;
            // 
            // richTextBoxLog
            // 
            this.richTextBoxLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxLog.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxLog.Name = "richTextBoxLog";
            this.richTextBoxLog.ReadOnly = true;
            this.richTextBoxLog.Size = new System.Drawing.Size(508, 65);
            this.richTextBoxLog.TabIndex = 0;
            this.richTextBoxLog.Text = "";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 301);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.statusStripMenu);
            this.Controls.Add(this.toolStripMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "LTEGamer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.statusStripMenu.ResumeLayout(false);
            this.statusStripMenu.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton toolStripButtonDeleteGame;
        private System.Windows.Forms.ToolStripButton toolStripButtonAbout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonEditGame;
        private System.Windows.Forms.ToolStripButton toolStripButtonAddGame;
        private System.Windows.Forms.StatusStrip statusStripMenu;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.ListView listViewApps;
        private System.Windows.Forms.RichTextBox richTextBoxLog;
        private System.Windows.Forms.ColumnHeader columnHeaderIcon;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderPath;
        private System.Windows.Forms.ToolStripButton toolStripButtonSettings;
        private System.Windows.Forms.ToolStripButton toolStripButtonWorkaroundPing;
        private System.Windows.Forms.ToolStripButton toolStripButtonWorkaroundDownloader;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}

