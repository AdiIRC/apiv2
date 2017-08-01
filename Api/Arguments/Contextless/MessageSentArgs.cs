namespace AdiIRCAPIv2.Arguments.Contextless
{
    using System;
    using Enumerators;
    using Interfaces;

    public class MessageSentArgs : EventArgs
    {
        private readonly IWindow window;
        private readonly IServer server;
        private readonly string target;
        private string message;
        private readonly string command;
        private readonly MessageType messageType;
        private EatData eatData;

        public MessageSentArgs(IWindow window, IServer server, string target, string message, string command, MessageType messageType, EatData eatData)
        {
            this.window = window;
            this.server = server;
            this.target = target;
            this.message = message;
            this.command = command;
            this.messageType = messageType;
            this.eatData = eatData;
        }

        public IWindow Window { get { return this.window; } }

        public IServer Server { get { return this.server; } }

        public string Target { get { return this.target; } }

        public string Message { get { return this.message; } set { this.message = value; } }

        public string Command { get { return this.command; } }

        public MessageType MessageType { get { return this.messageType; } }

        public EatData EatData { get { return this.eatData; } set { this.eatData = value; } }
    }
}
