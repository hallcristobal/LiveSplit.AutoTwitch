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

namespace LiveSplit.AutoTwitch
{
    class AutoTwitch : LogicComponent, IDeactivatableComponent
    {
        // Variables
        AutoTwitchSettings Settings { get; set; }
        LiveSplitState State { get; set; }

        // Constructor
        public AutoTwitch(LiveSplitState state)
        {
            Activated = true;
            State = state;
            Settings = new AutoTwitchSettings();

            state.OnSplit += State_OnSplit;
        }
        private void State_OnSplit(object sender, EventArgs e)
        {
            var lastSplit = State.CurrentSplitIndex - 1;

            TimeSpan? curSegment = LiveSplitStateHelper.GetPreviousSegmentTime(State, lastSplit, State.CurrentTimingMethod);
            
            //Best Split
            if (curSegment != null)
            {
                if (State.Run[lastSplit].BestSegmentTime[State.CurrentTimingMethod] == null || curSegment < State.Run[lastSplit].BestSegmentTime[State.CurrentTimingMethod])
                {
                    
                }
            }
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
