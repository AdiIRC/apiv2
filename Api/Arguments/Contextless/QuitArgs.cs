namespace AdiIRCAPIv2.Arguments.Contextless
{
    using System;
    using System.Collections.Generic;
    using Enumerators;
    using Interfaces;

    public class QuitArgs : EventArgs
    {
        private readonly IWindow window;
        private readonly IServer server;
        private readonly IUser user;
        private readonly string quitMessage;
        private readonly string rawMessage;
        private readonly string rawBytes;
        private readonly DateTime serverTime;
        private readonly IDictionary<string, string> messageTags;
        private EatData eatData;

        public QuitArgs(IWindow window, IServer server, IUser user, string quitMessage, string rawMessage, string rawBytes, DateTime serverTime, IDictionary<string, string> messageTags, EatData eatData)
        {
            this.window = window;
            this.server = server;
            this.user = user;
            this.quitMessage = quitMessage;
            this.rawMessage = rawMessage;
            this.rawBytes = rawBytes;
            this.serverTime = serverTime;
            this.messageTags = messageTags;
            this.eatData = eatData;
        }

        public IWindow Window { get { return this.window; } }

        public IServer Server { get { return this.server; } }

        public IUser User { get { return this.user; } }

        public string QuitMessage { get { return this.quitMessage; } }

        public string RawMessage { get { return this.rawMessage; } }

        public string RawBytes { get { return this.rawBytes; } }

        public DateTime ServerTime { get { return this.serverTime; } }

        public IDictionary<string, string> MessageTags { get { return this.messageTags; } }

        public EatData EatData { get { return this.eatData; } set { this.eatData = value; } }
    }
}
