namespace AdiIRCAPIv2.Arguments.Connection
{
    using System;
    using System.Collections.Generic;
    using Enumerators;
    using Interfaces;

    public class RawServerEventReceivedArgs : EventArgs
    {
        private readonly IWindow window;
        private readonly IServer server;
        private readonly string numeric;
        private readonly string message;
        private readonly string rawMessage;
        private readonly string rawBytes;
        private readonly DateTime serverTime;
        private readonly IDictionary<string, string> messageTags;
        private EatData eatData;

        public RawServerEventReceivedArgs(IWindow window, IServer server, string numeric, string message, string rawMessage, string rawBytes, DateTime serverTime, IDictionary<string, string> messageTags, EatData eatData)
        {
            this.window = window;
            this.server = server;
            this.numeric = numeric;
            this.message = message;
            this.rawMessage = rawMessage;
            this.rawBytes = rawBytes;
            this.serverTime = serverTime;
            this.messageTags = messageTags;
            this.eatData = eatData;
        }

        public IWindow Window { get { return this.window; } }

        public IServer Server { get { return this.server; } }

        public string Numeric { get { return this.numeric; } }

        public string Message { get { return this.message; } }

        public string RawMessage { get { return this.rawMessage; } }

        public string RawBytes { get { return this.rawBytes; } }

        public DateTime ServerTime { get { return this.serverTime; } }

        public IDictionary<string, string> MessageTags { get { return this.messageTags; } }

        public EatData EatData { get { return this.eatData; } set { this.eatData = value; } }
    }
}