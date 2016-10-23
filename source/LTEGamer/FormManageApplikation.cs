using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTEGamer
{
    public partial class FormManageApp : Form
    {
        public FormManageApp()
        {
            InitializeComponent();
        }


        private void textBoxPath_TextChanged(object sender, EventArgs e)
        {
            updatePictureBox(textBoxPath.Text);
        }

        private void buttonSearchPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Ausführbare Dateien (*.exe)|*.exe";
            ofd.Multiselect = false;
            if (ofd.ShowDialog() != DialogResult.OK)
                return;

            if (File.Exists(ofd.FileName))
            {
                textBoxPath.Text = ofd.FileName;
                if(textBoxName.Text == "")
                {
                    textBoxName.Text = Path.GetFileName(ofd.FileName);
                }
            }
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

        private void updatePictureBox(String path)
        {
            Icon result = null;
            try
            {
                if (path.ToUpper().EndsWith(".EXE"))
                {
                    result = Icon.ExtractAssociatedIcon(path);
                }
                else
                {
                    result = Icon.FromHandle(new Bitmap(LTEGamer.Properties.Resources.IconGame).GetHicon());
                }
            }
            catch (Exception)
            {
                result = Icon.FromHandle(new Bitmap(LTEGamer.Properties.Resources.IconGame).GetHicon());
            }

            pictureBoxIcon.Image = Bitmap.FromHicon(result.Handle);

        }

        
    }
}
