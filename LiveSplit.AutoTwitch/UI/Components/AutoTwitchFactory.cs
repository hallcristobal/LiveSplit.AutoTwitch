using System;
using LiveSplit.AutoTwitch;
using LiveSplit.UI.Components;
using LiveSplit.Model;

[assembly: ComponentFactory(typeof(TwitchFactory))]

namespace LiveSplit.AutoTwitch
{
    class TwitchFactory : IComponentFactory
    {
        public string ComponentName => "Auto Twitch";

        public string Description => "An Twitch component that will automatically send messages on events of your choosing.";

        public ComponentCategory Category => ComponentCategory.Other;

        public IComponent Create(LiveSplitState state) => new AutoTwitch(state);

        public string UpdateName => ComponentName;

        public string XMLURL => "";

        public string UpdateURL => "http://livesplit.org/update/";

        public Version Version => Version.Parse("1.0");
    }
}
