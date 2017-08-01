namespace AdiIRCAPIv2.Arguments.WindowInteraction
{
    using System;
    using Interfaces;

    public class WindowOpenArgs : EventArgs
    {
        private readonly IWindow window;
        private readonly IServer server;

        public WindowOpenArgs(IWindow window, IServer server)
        {
            this.window = window;
            this.server = server;
        }

        public IWindow Window { get { return this.window; } }

        public IServer Server { get { return this.server; } }
    }
}