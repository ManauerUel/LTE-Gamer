using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace LTEGamer
{
    public partial class FormMain : Form
    {
        private MessageHandler MessageHandler { get; set; }
        

        private List<App> appList = new List<App>();
        private ProcessFinder processChecker;

        private IWorkaround activeWorkaround;
        private WorkaroundPingflooder pingFlooder;
        private WorkaroundDownloader downloader;


        public FormMain()
        {
            InitializeComponent();

            MessageHandler += writeToLogTextbox;
            MessageHandler += setStatusLabel;

            pingFlooder = new WorkaroundPingflooder(Properties.Settings.Default.pingAddress, Properties.Settings.Default.pingInterval);
            pingFlooder.StatusHandler += delegate (String message)
            {
                MessageHandler.Invoke(message, MessageType.STATUS);
            };

            downloader = new WorkaroundDownloader(Properties.Settings.Default.downloadFile, Properties.Settings.Default.downloadSpeed);
            downloader.StatusHandler += delegate (String message)
            {
                MessageHandler.Invoke(message, MessageType.STATUS);
            };

            if (Properties.Settings.Default.activeWorkaround == "pingflooder")
            {
                activeWorkaround = pingFlooder;
                toolStripButtonWorkaroundPing.Checked = true;
                toolStripButtonWorkaroundDownloader.Checked = false;
            }
            else
            {
                activeWorkaround = downloader;
                toolStripButtonWorkaroundDownloader.Checked = true;
                toolStripButtonWorkaroundPing.Checked = false;
            }

            processChecker = new ProcessFinder();
            processChecker.ChangedStatusHandler += handleFinderStatusChange;
            processChecker.start();

            loadAppList();
            refreshAppList();
            

            if (Properties.Settings.Default.startMinimized)
            {
                Visible = false;
            }
            else
            {
                Visible = true;
            }

            MessageHandler.Invoke("Bereit.", MessageType.STATUS);            
        }



        private void toolStripButtonAddGame_Click(object sender, EventArgs e)
        {
            newApp();
        }

        private void toolStripButtonEditGame_Click(object sender, EventArgs e)
        {
            editApp();
        }

        private void toolStripButtonDeleteGame_Click(object sender, EventArgs e)
        {
            removeApp();
        }

        private void toolStripButtonWorkaroundPing_Click(object sender, EventArgs e)
        {
            MessageHandler.Invoke("Ping-Workaround bereit ...", MessageType.MESSAGE);
            toolStripButtonWorkaroundPing.Checked = true;
            toolStripButtonWorkaroundDownloader.Checked = false;
            
            if(activeWorkaround != pingFlooder)
            {
                bool running = activeWorkaround.Running;
                activeWorkaround.stop();
                activeWorkaround = pingFlooder;
                if (running)
                {
                    pingFlooder.start();
                }
            }

            Properties.Settings.Default.activeWorkaround = "pingflooder";
            Properties.Settings.Default.Save();
        }

        private void toolStripButtonWorkaroundDownloader_Click(object sender, EventArgs e)
        {
            MessageHandler.Invoke("Download-Workaround bereit ...", MessageType.MESSAGE);
            toolStripButtonWorkaroundDownloader.Checked = true;
            toolStripButtonWorkaroundPing.Checked = false;

            if (activeWorkaround != downloader)
            {
                bool running = activeWorkaround.Running;
                activeWorkaround.stop();
                activeWorkaround = downloader;
                if (running)
                {
                    downloader.start();
                }
            }

            Properties.Settings.Default.activeWorkaround = "downloader";
            Properties.Settings.Default.Save();
        }

        private void toolStripButtonSettings_Click(object sender, EventArgs e)
        {
            showSettings();
        }

        private void toolStripButtonAbout_Click(object sender, EventArgs e)
        {
            showAbout();
        }

        private void listViewApps_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            refreshButtons();
        }


        private void handleFinderStatusChange(ProcessStatus status)
        {
            if (status == ProcessStatus.PROCESS_FOUND)
            {
                MessageHandler.Invoke("Starte Workaround ...", MessageType.MESSAGE);
                activeWorkaround.start();
            }
            else if (status == ProcessStatus.NO_PROCESS_FOUND)
            {
                MessageHandler.Invoke("Stoppe Workaround ...", MessageType.MESSAGE);
                activeWorkaround.stop();
                MessageHandler.Invoke("Bereit", MessageType.STATUS);
            }

            
        }


        private void loadAppList()
        {
            if (Properties.Settings.Default.xmlAppList == null) return;
            if (Properties.Settings.Default.xmlAppList == "")   return;

            XmlSerializer xmlSerializer = new XmlSerializer(appList.GetType());
            using (StringReader reader = new StringReader(Properties.Settings.Default.xmlAppList))
            {
                List<App> readList = (List<App>) xmlSerializer.Deserialize(reader);
                if(readList != null)
                {
                    appList = readList;
                }
            }
            MessageHandler.Invoke(appList.Count() + " Programmeinträge geladen ...", MessageType.MESSAGE);
        }

        private void saveAppList()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(appList.GetType());
            using (StringWriter textWriter = new StringWriter())
            {
                xmlSerializer.Serialize(textWriter, appList);
                Properties.Settings.Default.xmlAppList = textWriter.ToString();
                Properties.Settings.Default.Save();
            }
        }

        private void newApp()
        {
            FormManageApp newAppDialog = new FormManageApp();
            newAppDialog.FormClosed += delegate (object sender, FormClosedEventArgs e)
            {
                String name = newAppDialog.textBoxName.Text;
                String path = newAppDialog.textBoxPath.Text;

                if (path != "" && name != "") {
                    appList.Add(new App(name, path));

                    refreshAppList();
                    saveAppList();

                    MessageHandler.Invoke(name + " hinzugefügt ...", MessageType.MESSAGE);
                }
            };

            showSmoothDialog(newAppDialog);
        }

        

        private void editApp()
        {
            foreach (ListViewItem listViewItem in listViewApps.SelectedItems)
            {
                App app = listViewItem.Tag as App;

                FormManageApp newAppDialog = new FormManageApp();
                newAppDialog.textBoxName.Text = app.Name;
                newAppDialog.textBoxPath.Text = app.ExecutablePath;

                newAppDialog.FormClosed += delegate (object sender, FormClosedEventArgs e)
                {
                    app.Name = newAppDialog.textBoxName.Text;
                    app.ExecutablePath = newAppDialog.textBoxPath.Text;

                    refreshAppList();
                    saveAppList();

                    MessageHandler.Invoke(app.Name + " editiert ...", MessageType.MESSAGE);
                };

                showSmoothDialog(newAppDialog);
            }
            refreshAppList();
        }

        private void removeApp()
        {
            foreach(ListViewItem listViewItem in listViewApps.SelectedItems)
            {
                App app = listViewItem.Tag as App;
                appList.Remove(app);
                MessageHandler.Invoke(app.Name + " gelöscht ...", MessageType.MESSAGE);
            }
            refreshAppList();
            saveAppList();
        }

        private void showSettings()
        {
            FormSettings settingsDialog = new FormSettings();
            settingsDialog.textBoxPingAddress.Text = Properties.Settings.Default.pingAddress;
            settingsDialog.trackBarPingInterval.Value = Properties.Settings.Default.pingInterval;
            settingsDialog.textBoxDownloadFile.Text = Properties.Settings.Default.downloadFile;
            settingsDialog.trackBarDownloadSpeed.Value = Properties.Settings.Default.downloadSpeed;
            settingsDialog.checkBoxMinimized.Checked = Properties.Settings.Default.startMinimized;

            settingsDialog.FormClosed += delegate (object sender, FormClosedEventArgs e)
            {
                String pingAddress = settingsDialog.textBoxPingAddress.Text;
                int pingInterval = settingsDialog.trackBarPingInterval.Value;
                String downloadFile = settingsDialog.textBoxDownloadFile.Text;
                int downloadSpeed = settingsDialog.trackBarDownloadSpeed.Value;

                Properties.Settings.Default.pingAddress = pingAddress;
                Properties.Settings.Default.pingInterval = pingInterval;
                Properties.Settings.Default.downloadFile = downloadFile;
                Properties.Settings.Default.downloadSpeed = downloadSpeed;
                Properties.Settings.Default.startMinimized = settingsDialog.checkBoxMinimized.Checked;
                Properties.Settings.Default.Save();

                pingFlooder.Interval = pingInterval;
                pingFlooder.Destination = pingAddress;
                downloader.File = downloadFile;
                downloader.MbitsPerSecond = downloadSpeed;

                MessageHandler.Invoke("Neue Einstellungen gespeichert ...", MessageType.MESSAGE);
            };

            showSmoothDialog(settingsDialog);
        }

        private void showAbout()
        {
            FormAbout aboutDialog = new FormAbout();
            showSmoothDialog(aboutDialog);
        }


        private void refreshAppList()
        {
            listViewApps.Items.Clear();
            ImageList imageList = new ImageList();
            for(int i=0; i<appList.Count; i++)
            {
                App app = appList.ElementAt(i);
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Tag = app;
                listViewItem.SubItems.Add(app.Name);
                listViewItem.SubItems.Add(app.ExecutablePath);
                listViewItem.ImageIndex = i;
                imageList.Images.Add(app.Icon);
                listViewApps.Items.Add(listViewItem);
            }

            listViewApps.SmallImageList = imageList;
            refreshButtons();
            refreshProcessChecker();
        }

        private void refreshProcessChecker()
        {
            processChecker.clearExecutablePaths();
            foreach(App app in appList)
            {
                processChecker.addExecutablePath(app.ExecutablePath);
            }
        }

        private void refreshButtons()
        {
            if(listViewApps.SelectedItems.Count == 0)
            {
                toolStripButtonAddGame.Enabled = true;
                toolStripButtonEditGame.Enabled = false;
                toolStripButtonDeleteGame.Enabled = false;
            }
            if (listViewApps.SelectedItems.Count == 1)
            {
                toolStripButtonAddGame.Enabled = true;
                toolStripButtonEditGame.Enabled = true;
                toolStripButtonDeleteGame.Enabled = true;
            }
            if (listViewApps.SelectedItems.Count > 1)
            {
                toolStripButtonAddGame.Enabled = true;
                toolStripButtonEditGame.Enabled = false;
                toolStripButtonDeleteGame.Enabled = true;
            }
        }

        private void writeToLogTextbox(String message, MessageType type)
        {
            if (type == MessageType.STATUS) return;

            String textToAppend = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss") + " | " + message;
            Action writeToTextbox = new Action(() =>
            {
                if (richTextBoxLog.Text != "") richTextBoxLog.AppendText(Environment.NewLine);
                richTextBoxLog.AppendText(textToAppend);
                richTextBoxLog.ScrollToCaret();

                if (type == MessageType.ERROR)
                {
                    richTextBoxLog.Find(textToAppend);
                    richTextBoxLog.SelectionColor = Color.DarkRed;
                }
            });

            // HIGHLY DIRTY HACK, TO DO LOG-MESSAGES FROM OTHER THREADS
            if (richTextBoxLog.IsHandleCreated)
            {
                richTextBoxLog.Invoke(writeToTextbox);
            }
            else
            {
                writeToTextbox.Invoke();
            }
        }

        private void setStatusLabel(String message, MessageType type)
        {
            // SAME HACK AS ABOVE - THIS SHOULD BE REMOVED!
            if(type == MessageType.STATUS)
            {
                if (statusStripMenu.IsHandleCreated)
                {
                    statusStripMenu.Invoke(new Action(() =>
                    {
                        toolStripStatusLabel.Text = message;
                    }));
                }
                else
                {
                    toolStripStatusLabel.Text = message;
                }
            }
        }

        private void showSmoothDialog(Form dialogToShow)
        {
            dialogToShow.StartPosition = FormStartPosition.Manual;
            dialogToShow.Visible = true;
            int currX = this.Location.X + this.Width - dialogToShow.Width / 3;
            for (int i = currX; i <= this.Location.X + this.Width + 3; i += 3)
            {
                dialogToShow.Location = new Point(i, this.Location.Y);
                dialogToShow.Refresh();
                Thread.Sleep(1);
            }
            dialogToShow.Visible = false;
            dialogToShow.ShowDialog(this);
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            activeWorkaround.stop();
            processChecker.stop();
            //Application.Exit(); // a thread is always still running, dunno which one
        }

        private void FormMain_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                this.Hide();
            }
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

    
    }
}
