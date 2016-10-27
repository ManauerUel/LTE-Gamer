using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTEGamer
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using System.Runtime.InteropServices;

    class Plexiglass : Form
    {

        Form tocover;
        public Plexiglass(Form tocover)
        {
            this.tocover = tocover;
            //this.BackColor = Color.DarkGray;
            //this.Opacity = 0.30;      // Tweak as desired
            this.FormBorderStyle = FormBorderStyle.None;
            this.ControlBox = false;
            this.ShowInTaskbar = false;
            this.StartPosition = FormStartPosition.Manual;
            this.AutoScaleMode = AutoScaleMode.None;
            this.Location = tocover.PointToScreen(Point.Empty);
            this.ClientSize = tocover.ClientSize;
            tocover.LocationChanged += Cover_LocationChanged;
            tocover.ClientSizeChanged += Cover_ClientSizeChanged;
            this.Show(tocover);
            tocover.Focus();


            // Disable Aero transitions, the plexiglass gets too visible
            //if (Environment.OSVersion.Version.Major >= 6)
            //{
            //    int value = 1;
            //    DwmSetWindowAttribute(tocover.Handle, DWMWA_TRANSITIONS_FORCEDISABLED, ref value, 4);
            //}
        }
        private void Cover_LocationChanged(object sender, EventArgs e)
        {
            // Ensure the plexiglass follows the owner
            this.Location = this.Owner.PointToScreen(Point.Empty);
        }
        private void Cover_ClientSizeChanged(object sender, EventArgs e)
        {
            // Ensure the plexiglass keeps the owner covered
            this.ClientSize = this.Owner.ClientSize;
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            // Restore owner
            this.Owner.LocationChanged -= Cover_LocationChanged;
            this.Owner.ClientSizeChanged -= Cover_ClientSizeChanged;
            if (!this.Owner.IsDisposed && Environment.OSVersion.Version.Major >= 6)
            {
                int value = 1;
                DwmSetWindowAttribute(this.Owner.Handle, DWMWA_TRANSITIONS_FORCEDISABLED, ref value, 4);
            }
            base.OnFormClosing(e);
        }
        protected override void OnActivated(EventArgs e)
        {
            // Always keep the owner activated instead
            this.BeginInvoke(new Action(() => this.Owner.Activate()));
        }
        private const int DWMWA_TRANSITIONS_FORCEDISABLED = 3;
        [DllImport("dwmapi.dll")]
        private static extern int DwmSetWindowAttribute(IntPtr hWnd, int attr, ref int value, int attrLen);
    

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;


            Bitmap backPanel = new Bitmap(tocover.Width, tocover.Height);
            tocover.DrawToBitmap(backPanel, new Rectangle(0, 0, tocover.Width, tocover.Height));
            Point p = tocover.PointToScreen(Point.Empty);
            Bitmap target = new Bitmap(tocover.ClientSize.Width, tocover.ClientSize.Height);
            using (Graphics ge = Graphics.FromImage(target))
            {
                ge.DrawImage(backPanel, 0, 0, new Rectangle(p.X - tocover.Location.X, p.Y - tocover.Location.Y,target.Width, target.Height),GraphicsUnit.Pixel);
            }
            backPanel.Dispose();
            g.DrawImage(target, 0, 0);


            g.FillRectangle(new SolidBrush(Color.FromArgb(100, Color.DarkGray)), this.ClientRectangle);


            Bitmap loadingImage = Properties.Resources.IconLoading;
            Point pointToDraw = new Point((this.Width / 2) - (loadingImage.Width / 2), (this.Height / 2) - (loadingImage.Height / 2));
            g.DrawImage(loadingImage, pointToDraw);            
        }



    }
}
