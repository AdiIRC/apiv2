namespace AdiIRCAPIv2.Arguments.ChannelModes
{
    using System;
    using System.Collections.Generic;
    using Enumerators;
    using Interfaces;

    public class ChannelModeUserVoicedArgs : EventArgs
    {
        private readonly IWindow window;
        private readonly IServer server;
        private readonly IChannel channel;
        private readonly IUser user;
        private readonly IChannelUser byUser;
        private readonly bool modeFirst;
        private readonly bool modeLast;
        private readonly string rawMessage;
        private readonly string rawBytes;
        private readonly DateTime serverTime;
        private readonly IDictionary<string, string> messageTags;
        private EatData eatData;

        public ChannelModeUserVoicedArgs(IWindow window, IServer server, IChannel channel, IUser user, IChannelUser byUser, bool modeFirst, bool modeLast, string rawMessage, string rawBytes, DateTime serverTime, IDictionary<string, string> messageTags, EatData eatData)
        {
            this.window = window;
            this.server = server;
            this.channel = channel;
            this.user = user;
            this.byUser = byUser;
            this.modeFirst = modeFirst;
            this.modeLast = modeLast;
            this.rawMessage = rawMessage;
            this.rawBytes = rawBytes;
            this.serverTime = serverTime;
            this.messageTags = messageTags;
            this.eatData = eatData;
        }

        public IWindow Window { get { return this.window; } }

        public IServer Server { get { return this.server; } }

        public IChannel Channel { get { return this.channel; } }

        public IUser User { get { return this.user; } }

        public IChannelUser ByUser { get { return this.byUser; } }

        public bool ModeFirst { get { return this.modeFirst; } }

        public bool ModeLast { get { return this.modeLast; } }

        public string RawMessage { get { return this.rawMessage; } }

        public string RawBytes { get { return this.rawBytes; } }

        public DateTime ServerTime { get { return this.serverTime; } }

        public IDictionary<string, string> MessageTags { get { return this.messageTags; } }

        public EatData EatData { get { return this.eatData; } set { this.eatData = value; } }
    }
}