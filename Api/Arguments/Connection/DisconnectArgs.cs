namespace AdiIRCAPIv2.Arguments.Connection
{
    using System;
    using Enumerators;
    using Interfaces;

    public class DisconnectArgs : EventArgs
    {
        private readonly IWindow window;
        private readonly IServer server;
        private readonly EatData eatData;

        public DisconnectArgs(IWindow window, IServer server, EatData eatData)
        {
            this.window = window;
            this.server = server;
            this.eatData = eatData;
        }

        public IWindow Window { get { return this.window; } }

        public IServer Server { get { return this.server; } }

        public EatData EatData { get { return this.eatData; } }
    }
}