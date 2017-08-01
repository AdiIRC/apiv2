namespace AdiIRCAPIv2.Arguments.ChannelServerModes
{
    using System;
    using System.Collections.Generic;
    using Enumerators;
    using Interfaces;

    public class ChannelServerModeUserDehalfOppedArgs : EventArgs
    {
        private readonly IWindow window;
        private readonly IServer server;
        private readonly IChannel channel;
        private readonly IChannelUser user;
        private readonly bool modeFirst;
        private readonly bool modeLast;
        private readonly string rawMessage;
        private readonly string rawBytes;
        private readonly DateTime serverTime;
        private readonly IDictionary<string, string> messageTags;
        private EatData eatData;

        public ChannelServerModeUserDehalfOppedArgs(IWindow window, IServer server, IChannel channel, IChannelUser user, bool modeFirst, bool modeLast, string rawMessage, string rawBytes, DateTime serverTime, IDictionary<string, string> messageTags, EatData eatData)
        {
            this.window = window;
            this.server = server;
            this.channel = channel;
            this.user = user;
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

        public IChannelUser User { get { return this.user; } }

        public bool ModeFirst { get { return this.modeFirst; } }

        public bool ModeLast { get { return this.modeLast; } }

        public string RawMessage { get { return this.rawMessage; } }

        public string RawBytes { get { return this.rawBytes; } }

        public DateTime ServerTime { get { return this.serverTime; } }

        public IDictionary<string, string> MessageTags { get { return this.messageTags; } }

        public EatData EatData { get { return this.eatData; } set { this.eatData = value; } }
    }
}