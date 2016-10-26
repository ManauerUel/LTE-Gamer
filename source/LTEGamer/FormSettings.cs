using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTEGamer
{
    public partial class FormSettings : Form
    {

        private static readonly int VALIDATE_PING_TIMEOUT = 1000;
        private static readonly int VALIDATE_HTTP_TIMEOUT = 1000;

        public FormSettings()
        {
            InitializeComponent();
        }

        private void trackBarPingInterval_ValueChanged(object sender, EventArgs e)
        {
            labelTrackBarInterval.Text = trackBarPingInterval.Value + " ms";
        }

        private void trackBarDownloadSpeed_ValueChanged(object sender, EventArgs e)
        {
            labelTrackBarDownloadSpeed.Text = trackBarDownloadSpeed.Value + " Mbit/s";
        }


        private void textBoxPingAddress_Validating(object sender, CancelEventArgs e)
        {
            //validatePingAddress();
        }

        private void textBoxDownloadFile_Validating(object sender, CancelEventArgs e)
        {
            //validateDownloadFile();
        }


        private void FormSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            Plexiglass plexiglass = new Plexiglass(this);

            bool downloadFileValid = validateDownloadFile();
            bool pingAddressValid = validatePingAddress();

            if(!downloadFileValid || !pingAddressValid)
            {
                e.Cancel = true;
            }

            plexiglass.Close();
            this.Cursor = Cursors.Default;
        }


        private bool validatePingAddress()
        {
            try
            {
                Ping ping = new Ping();
                if (ping.Send(textBoxPingAddress.Text, VALIDATE_PING_TIMEOUT).Status == IPStatus.Success)
                {
                    errorProviderPingAddress.Clear();
                    return true;
                }
            }
            catch (Exception)
            {
            }

            errorProviderPingAddress.SetError(textBoxPingAddress, "URL/IP ist nicht gültig!");
            return false;
        }

        private bool validateDownloadFile()
        {

            if(!textBoxDownloadFile.Text.ToLower().StartsWith("http://") &&
               !textBoxDownloadFile.Text.ToLower().StartsWith("https://"))
            {
                textBoxDownloadFile.Text = "http://" + textBoxDownloadFile.Text;
            }


            try
            {
                HttpWebRequest request = WebRequest.Create(textBoxDownloadFile.Text) as HttpWebRequest;
                request.Timeout = VALIDATE_HTTP_TIMEOUT;
                request.Credentials = CredentialCache.DefaultCredentials;
                request.Method = WebRequestMethods.Http.Get;

                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                response.Close();
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    errorProviderDownloadFile.Clear();
                    return true;
                }
            }
            catch (Exception)
            {
            }

            errorProviderDownloadFile.SetError(textBoxDownloadFile, "Datei ist nicht gültig!");
            return false;
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && (keyData == Keys.Escape) || keyData == Keys.Enter)
            {
                this.Close();
                return true;
            }

            return base.ProcessDialogKey(keyData);
        }


    }
}
