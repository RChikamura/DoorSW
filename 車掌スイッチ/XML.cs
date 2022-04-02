using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace 車掌スイッチ
{
    public partial class Form1
    {
        private string _xmlFile = @".\\Setting.xml";
        public void XMLRead()
        {
            XElement xml = XElement.Load(_xmlFile);

            IEnumerable<XElement> snd = from item in xml.Elements("Sound") select item;

            foreach (XElement path in snd)
            {
                XElement close = path.Element("Close");
                XElement open = path.Element("Open");

                ClSndpath.Text = close.ToString();
                OpSndpath.Text = open.ToString();
            }
        }
    }
}
