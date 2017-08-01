namespace AdiIRCAPIv2.Arguments.ChannelModes
{
    using System;
    using System.Collections.Generic;
    using Enumerators;
    using Interfaces;

    public class ChannelRawModeArgs : EventArgs
    {
        private readonly IWindow window;
        private readonly IServer server;
        private readonly IChannel channel;
        private readonly IChannelUser user;
        private readonly string modes;
        private readonly string rawMessage;
        private readonly string rawBytes;
        private readonly DateTime serverTime;
        private readonly IDictionary<string, string> messageTags;
        private EatData eatData;

        public ChannelRawModeArgs(IWindow window, IServer server, IChannel channel, IChannelUser user, string modes, string rawMessage, string rawBytes, DateTime serverTime, IDictionary<string, string> messageTags, EatData eatData)
        {
            this.window = window;
            this.server = server;
            this.channel = channel;
            this.user = user;
            this.modes = modes;
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

        public string Modes { get { return this.modes; } }

        public string RawMessage { get { return this.rawMessage; } }

        public string RawBytes { get { return this.rawBytes; } }

        public DateTime ServerTime { get { return this.serverTime; } }

        public IDictionary<string, string> MessageTags { get { return this.messageTags; } }

        public EatData EatData { get { return this.eatData; } set { this.eatData = value; } }
    }
}