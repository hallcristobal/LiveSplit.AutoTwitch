using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Diagnostics;

namespace LiveSplit.AutoTwitch
{
    public partial class AutoTwitchSettings : UserControl
    {
        public AutoTwitchSettings()
        {
            InitializeComponent();
            ToolTip tip = new ToolTip();
            tip.AutoPopDelay = 1000;
            tip.InitialDelay = 1000;
            tip.ReshowDelay = 500;
            tip.ShowAlways = false;
            tip.SetToolTip(this.pbHelp, "This is some tool tip text to replace later.");

        }

        internal XmlNode GetSettings(XmlDocument document)
        {
            return document.CreateElement("Settings");
        }

        internal void SetSettings(XmlNode settings)
        {
            
        }

        private void pbHelp_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.twitchapps.com/tmi/");
        }

        private void pbHelp_MouseEnter(object sender, EventArgs e)
        {
            pbHelp.Cursor = Cursors.Hand;
        }

        private void pbHelp_MouseLeave(object sender, EventArgs e)
        {
            pbHelp.Cursor = Cursors.Default;
        }
    }
}
