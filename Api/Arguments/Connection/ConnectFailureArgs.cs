namespace AdiIRCAPIv2.Arguments.Connection
{
    using System;
    using Enumerators;
    using Interfaces;

    public class ConnectFailureArgs : EventArgs
    {
        private readonly IWindow window;
        private readonly IServer server;
        private readonly string error;
        private readonly EatData eatData;

        public ConnectFailureArgs(IWindow window, IServer server, string error, EatData eatData)
        {
            this.window = window;
            this.server = server;
            this.error = error;
            this.eatData = eatData;
        }

        public IWindow Window { get { return this.window; } }

        public IServer Server { get { return this.server; } }

        public string Error { get { return this.error; } }

        public EatData EatData { get { return this.eatData; } }
    }
}