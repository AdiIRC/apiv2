namespace AdiIRCAPIv2.Arguments.Connection
{
    using System;
    using Interfaces;

    public class ConnectionLogonSuccessArgs : EventArgs
    {
        private readonly IWindow window;
        private readonly IServer server;

        public ConnectionLogonSuccessArgs(IWindow window, IServer server)
        {
            this.window = window;
            this.server = server;
        }

        public IWindow Window { get { return this.window; } }

        public IServer Server { get { return this.server; } }
    }
}