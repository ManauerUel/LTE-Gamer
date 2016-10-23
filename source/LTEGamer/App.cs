using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace LTEGamer
{

    public class App
    {

        private String name;
        public String Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        private String executablePath;
        public String ExecutablePath
        {
            get { return this.executablePath; }
            set {
                this.executablePath = value;
                this.icon = App.getIconFromFile(value);
            }
        }

        private Icon icon;
        [XmlIgnore]
        public Icon Icon
        {
            get { return this.icon; }
        }


        public App()
        {

        }

        public App(String name, String executablePath)
        {
            this.Name = name;
            this.ExecutablePath = executablePath;
        }



        public static Icon getIconFromFile(string filePath)
        {
            Icon result;
            try
            {
                if (filePath.ToUpper().EndsWith(".EXE"))
                {
                    result = Icon.ExtractAssociatedIcon(filePath);
                }
                else if (filePath.ToUpper().EndsWith(".ICO"))
                {
                    result = new Icon(filePath);
                }
                else
                {
                    result = Icon.FromHandle(new Bitmap(filePath).GetHicon());
                }
            }
            catch (Exception)
            {
                result = Icon.FromHandle(new Bitmap(LTEGamer.Properties.Resources.IconGame).GetHicon());
            }
            return result;
        }


    }
}
