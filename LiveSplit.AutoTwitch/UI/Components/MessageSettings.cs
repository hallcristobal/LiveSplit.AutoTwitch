using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveSplit.Model;
using LiveSplit.Model.Comparisons;

namespace LiveSplit.AutoTwitch
{
    public enum MessageEvent
    {
        Split,
        Reset,
        BestSegment,
        PersonalBest,
        FinishRun,

    }
    public enum TimeAccuracy
    {
        Seconds,
        Tenths,
        Hundredths,
        Thousandths
    }

    public partial class MessageSettings : UserControl
    {
        string[] MessageEvents = new string[] { "Split", "Reset", "Best Segment", "Personal Best", "Finish Run" };
        string[] Accuracys = new string[] { "", ".1", ".12", ".123" };
        string[] TimingMethods = new string[] { "Current Timing Method", "Real Time", "Game Time" };
        string[] TimeFormats = new string[] { "00:00:00", "0:00:00", "00:00", "0:00", "0" };


        public Message Message { get; set; }
        public string Value { get { return Message.Value; } set { Message.Value = value; } }
        public string Accuracy
        {
            get
            {
                switch (Message.Accuracy)
                {
                    //TODO switch to if statements
                    case TimeAccuracy.Seconds:
                        return "";
                    case TimeAccuracy.Tenths:
                        return ".1";
                    case TimeAccuracy.Hundredths:
                        return ".12";
                    case TimeAccuracy.Thousandths:
                        return ".123";
                    default:
                        return "";
                }
            }
            set
            {
                if (value == "")
                    Message.Accuracy = TimeAccuracy.Seconds;
                else if (value == ".1")
                    Message.Accuracy = TimeAccuracy.Tenths;
                else if (value == ".123")
                    Message.Accuracy = TimeAccuracy.Thousandths;
                else
                    Message.Accuracy = TimeAccuracy.Hundredths;
            }
        }
        public string Event
        {
            get
            {
                    if(Message.Events == MessageEvent.BestSegment) return "Best Segment";
                    else if(Message.Events == MessageEvent.FinishRun) return "Finish Run";
                    else if(Message.Events == MessageEvent.PersonalBest) return "Personal Best";
                    else if(Message.Events == MessageEvent.Reset) return "Reset";
                    else return "Split";
            }
            set
            {
                Message.Events = (MessageEvent)Enum.Parse(typeof(MessageEvent), value.Replace(" ", String.Empty));
            }
        }
        public bool SendOnNewSplit { get { return Message.SendOnNewSplit; } set { Message.SendOnNewSplit = value; } }
        public string TimeFormat
        {
            get
            {
                if (Message.TimeFormat == "hh':'mm':'ss")
                    return TimeFormats[0];
                else if (Message.TimeFormat == "h':'mm':'ss")
                    return TimeFormats[1];
                else if (Message.TimeFormat == "mm':'ss")
                    return TimeFormats[2];
                else if (Message.TimeFormat == "m':'ss")
                    return TimeFormats[3];
                else
                    return TimeFormats[4];

            }
            set
            {
                if (value == TimeFormats[0])
                    Message.TimeFormat = "hh':'mm':'ss";
                else if (value == TimeFormats[1])
                    Message.TimeFormat = "h':'mm':'ss";
                else if (value == TimeFormats[2])
                    Message.TimeFormat = "mm':'ss";
                else if (value == TimeFormats[3])
                    Message.TimeFormat = "m':'ss";
                else
                    Message.TimeFormat = "s";
            }
        }
        public string Method
        {
            get
            {
                if(curTime)
                    return "Current Timing Method";

                if (Message.TimingMethod == TimingMethod.RealTime)
                    return "Real Time";
                else
                    return "Game Time";
            }
            set
            {
                if (value == "Current Timing Method")
                {
                    Message.TimingMethod = State.CurrentTimingMethod;
                    curTime = true;
                }
                else
                { 
                    Message.TimingMethod = (TimingMethod)Enum.Parse(typeof(TimingMethod), value.Replace(" ", string.Empty));
                    curTime = false;
                }
            }
        }

        private bool curTime { get; set; } = true;


        IList<MessageSettings> MessageList { get; set; }
        public LiveSplitState State { get; set; }


        public MessageSettings(LiveSplitState state, IList<MessageSettings> messageList)
        {
            InitializeComponent();

            cbEvents.Items.AddRange(MessageEvents);
            cbAccuracy.Items.AddRange(Accuracys);
            cbTimingMethod.Items.AddRange(TimingMethods);
            cbTimeFormat.Items.AddRange(TimeFormats.Reverse().ToArray());
            

            Message = new Message(state, TimingMethod.GameTime);

            MessageList = messageList;
            State = state;
            

            tbMessage.DataBindings.Add("Text", this, "Value", false, DataSourceUpdateMode.OnPropertyChanged);
            cbEvents.DataBindings.Add("SelectedItem", this, "Event", false, DataSourceUpdateMode.OnPropertyChanged);
            cbAccuracy.DataBindings.Add("SelectedItem", this, "Accuracy", false, DataSourceUpdateMode.OnPropertyChanged);
            cbTimeFormat.DataBindings.Add("SelectedItem", this, "TimeFormat", false, DataSourceUpdateMode.OnPropertyChanged);
            cbTimingMethod.DataBindings.Add("SelectedItem", this, "Method", false, DataSourceUpdateMode.OnPropertyChanged);
            cbSendOnNewSplit.DataBindings.Add("Checked", this, "SendOnNewSplit", false, DataSourceUpdateMode.OnPropertyChanged);
        }
        //TODO Remove Button
    }



    public class Message
    {
        public string Value { get; set; }
        public MessageEvent Events { get; set; }
        public LiveSplitState State { get; set; }
        public TimeAccuracy Accuracy { get; set; }
        public bool SendOnNewSplit { get; set; }
        public string TimeFormat { get; set; }
        public TimingMethod TimingMethod { get; set; }

        private bool formatSet { get; set; } = false;

        //string[] Variables = new string[] { "%t", "%n", "%d" };

        //ctor
        public Message(LiveSplitState state, TimingMethod timingMethod)
        {
            State = state;
            TimingMethod = timingMethod;
        }


        public string BuildMessage()
        {
            string ret = Value;
            int lastSplit = State.CurrentSplitIndex - 1;
            

            TimeSpan? deltaTime = LiveSplitStateHelper.GetPreviousSegmentDelta(State, lastSplit, State.CurrentComparison, this.TimingMethod);
            TimeSpan? curSegment = LiveSplitStateHelper.GetPreviousSegmentTime(State, lastSplit, this.TimingMethod);

            if (!formatSet)
            {
                if (Accuracy == TimeAccuracy.Tenths) TimeFormat += "'.'f";
                else if (Accuracy == TimeAccuracy.Hundredths) TimeFormat += "'.'ff";
                else if (Accuracy == TimeAccuracy.Thousandths) TimeFormat += "'.'fff";
                formatSet = true;
            }

            ret = ret.Replace("%t", curSegment.Value.ToString(TimeFormat));
            ret = ret.Replace("%n", State.Run[lastSplit].Name);
            if(deltaTime.HasValue)
                ret = ret.Replace("%d", deltaTime.Value.ToString((deltaTime < TimeSpan.Zero ? "\\-" : "") + TimeFormat));

            return ret;
        }
    }
}
