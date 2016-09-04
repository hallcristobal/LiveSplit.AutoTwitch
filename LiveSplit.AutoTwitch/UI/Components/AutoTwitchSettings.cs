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
using LiveSplit.Model;

namespace LiveSplit.AutoTwitch
{
    public partial class AutoTwitchSettings : UserControl
    {
        public string UserName { get; set; }
        public string OAuth { get; set; }
        public string Channel { get; set; }
        public IList<MessageSettings> MessageList { get; set; }
        LiveSplitState State { get; set; }


        public AutoTwitchSettings(LiveSplitState state)
        {
            InitializeComponent();
            State = state;

            ToolTip tip = new ToolTip();
            tip.AutoPopDelay = 1000;
            tip.InitialDelay = 1000;
            tip.ReshowDelay = 500;
            tip.ShowAlways = false;
            tip.SetToolTip(this.pbHelp, "This is some tool tip text to replace later.");

            tbChannel.DataBindings.Add("Text", this, "Channel", false, DataSourceUpdateMode.OnPropertyChanged);
            tbOAuth.DataBindings.Add("Text", this, "OAuth", false, DataSourceUpdateMode.OnPropertyChanged);
            tbUsername.DataBindings.Add("Text", this, "UserName", false, DataSourceUpdateMode.OnPropertyChanged);

            MessageList = new List<MessageSettings>();


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

        private void btnAddMessage_Click(object sender, EventArgs e)
        {
            UpdateLayoutForMessage();

            var message = new MessageSettings(State, MessageList);
            MessageList.Add(message);
            AddMessageToLayout(message, MessageList.Count);
        }

        private void UpdateLayoutForMessage()
        {
            int add = 150;
            tlpMessageList.RowCount++;
            tlpMessageList.RowStyles.Add(new RowStyle(SizeType.Absolute, add));
            tlpMessageList.Size = new Size(tlpMessageList.Size.Width, tlpMessageList.Size.Height + add);
            Size = new Size(Size.Width, Size.Height + add);
            gbMessages.Size = new Size(gbMessages.Size.Width, gbMessages.Size.Height + add);
        }

        private void AddMessageToLayout(MessageSettings messsage, int index)
        {
            messsage.Anchor = AnchorStyles.None;
            tlpMessageList.Controls.Add(messsage, 0, index);
            tlpMessageList.SetColumnSpan(messsage, 2);
        }
    }
}
