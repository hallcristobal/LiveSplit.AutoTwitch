using LiveSplit.Model;
using LiveSplit.UI.Components;
using LiveSplit.Model.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using System.Xml;
using LiveSplit.UI;
using TwitchCom;

namespace LiveSplit.AutoTwitch
{
    public class AutoTwitch : LogicComponent, IDeactivatableComponent
    {
        // Variables
        AutoTwitchSettings Settings { get; set; }
        LiveSplitState State { get; set; }
        Chat chat { get; set; }

        public bool Connected { get; set; } = false;

        public event EventHandler Connect;



        // Constructor
        public AutoTwitch(LiveSplitState state)
        {
            Activated = true;
            State = state;
            Settings = new AutoTwitchSettings(state, this);

            state.OnSplit += State_OnSplit;
        }

        // Methods
        private void State_OnSplit(object sender, EventArgs e)
        {

            foreach (var item in Settings.MessageList)
            {
                if(item.Message.Events == MessageEvent.BestSegment)
                {
                    Console.WriteLine(item.Message.BuildMessage());
                }
            }

        }

        public bool TwitchConnect()
        {
            chat = new Chat(new TwitchUser(Settings.UserName.ToLower(), Settings.OAuth));
            try
            {
                chat.Connect();
                if (chat.Connected)
                {
                    chat.joinChannel(Settings.Channel.ToLower());
                    Connected = true;
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        public void TwitchDisconnect()
        {
            //TODO TwitchCom Disconnect
        }

        // Interface Implementation
        public bool Activated { get; set; }
        public override string ComponentName => "Auto Twitch";
        public override XmlNode GetSettings(XmlDocument document) => Settings.GetSettings(document);
        public override Control GetSettingsControl(LayoutMode mode) => Settings;
        public override void SetSettings(XmlNode settings) => Settings.SetSettings(settings);
        public override void Dispose()
        {
            State.OnSplit -= State_OnSplit;
        }
        public override void Update(IInvalidator invalidator, LiveSplitState state, float width, float height, LayoutMode mode) { }
    }
}
