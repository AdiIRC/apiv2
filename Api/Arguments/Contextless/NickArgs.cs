namespace AdiIRCAPIv2.Arguments.Contextless
{
    using System;
    using System.Collections.Generic;
    using Enumerators;
    using Interfaces;

    public class NickArgs : EventArgs
    {
        private readonly IWindow window;
        private readonly IServer server;
        private readonly IUser user;
        private readonly string newNick;
        private readonly string rawMessage;
        private readonly string rawBytes;
        private readonly DateTime serverTime;
        private readonly IDictionary<string, string> messageTags;
        private EatData eatData;

        public NickArgs(IWindow window, IServer server, IUser user, string newNick, string rawMessage, string rawBytes, DateTime serverTime, IDictionary<string, string> messageTags, EatData eatData)
        {
            this.window = window;
            this.server = server;
            this.user = user;
            this.newNick = newNick;
            this.rawMessage = rawMessage;
            this.rawBytes = rawBytes;
            this.serverTime = serverTime;
            this.messageTags = messageTags;
            this.eatData = eatData;
        }

        public IWindow Window { get { return this.window; } }

        public IServer Server { get { return this.server; } }

        public IUser User { get { return this.user; } }

        public string NewNick { get { return this.newNick; } }

        public string RawMessage { get { return this.rawMessage; } }

        public string RawBytes { get { return this.rawBytes; } }

        public DateTime ServerTime { get { return this.serverTime; } }

        public IDictionary<string, string> MessageTags { get { return this.messageTags; } }

        public EatData EatData { get { return this.eatData; } set { this.eatData = value; } }
    }
}
