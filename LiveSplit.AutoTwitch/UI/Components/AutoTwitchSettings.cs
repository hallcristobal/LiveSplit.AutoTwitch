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
        public Size StartingSize { get; set; }
        public Size StartingTableLayoutSize { get; set; }

        LiveSplitState State { get; set; }
        AutoTwitch Twitch { get; set; }

        public event EventHandler Connect;

        public AutoTwitchSettings(LiveSplitState state, AutoTwitch twitch)
        {
            InitializeComponent();
            State = state;
            Twitch = twitch;

            StartingSize = Size;
            StartingTableLayoutSize = tlpMessageList.Size;

            ToolTip tip = new ToolTip();
            tip.AutoPopDelay = 400;
            tip.InitialDelay = 300;
            tip.ReshowDelay = 500;
            tip.ShowAlways = false;
            tip.SetToolTip(this.pbHelp, "This is some tool tip text to replace later.");

            tbChannel.DataBindings.Add("Text", this, "Channel", false, DataSourceUpdateMode.OnPropertyChanged);
            tbOAuth.DataBindings.Add("Text", this, "OAuth", false, DataSourceUpdateMode.OnPropertyChanged);
            tbUsername.DataBindings.Add("Text", this, "UserName", false, DataSourceUpdateMode.OnPropertyChanged);

            lblConnect.Text = string.Empty;

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
            message.Anchor = AnchorStyles.None;
            MessageList.Add(message);
            AddMessageToLayout(message, MessageList.Count + 1);
        }

        private void UpdateLayoutForMessage()
        {
            tlpMessageList.RowCount++;
            tlpMessageList.RowStyles.Add(new RowStyle(SizeType.Absolute, 179f));
            tlpMessageList.Size = new Size(tlpMessageList.Size.Width, tlpMessageList.Size.Height + 179);
            Size = new Size(Size.Width, Size.Height + 179);
            gbMessages.Size = new Size(gbMessages.Size.Width, gbMessages.Size.Height + 179);
        }

        private void AddMessageToLayout(MessageSettings messsage, int index)
        {
            tlpMessageList.Controls.Add(messsage, 0, index);
            tlpMessageList.SetColumnSpan(messsage, 2);
        }

        public void btnConnect_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(UserName) || String.IsNullOrWhiteSpace(OAuth) || String.IsNullOrWhiteSpace(Channel))
                return;
            

            if(Twitch.Connected)
            {
                lblConnect.Text = "Disconnected from Twitch Chat";
            }
            else
            {
                Twitch.TwitchConnect();
                if (Twitch.Connected)
                {
                    btnConnect.Text = "Disconnect";
                    lblConnect.Text = "Connected to Chat \"" + Channel + "\" as \"" + UserName + "\" at " + DateTime.Now.ToString("G");

                }
                else
                {
                    lblConnect.Text = "Could not connect to Twitch Chat";
                }
            }
        }
    }
}
