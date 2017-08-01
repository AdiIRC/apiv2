namespace AdiIRCAPIv2.Arguments.WindowInteraction
{
    using System;
    using Interfaces;

    public class WindowCloseArgs : EventArgs
    {
        private readonly IWindow window;
        private readonly IServer server;

        public WindowCloseArgs(IWindow window, IServer server)
        {
            this.window = window;
            this.server = server;
        }

        public IWindow Window { get { return this.window; } }

        public IServer Server { get { return this.server; } }
    }
}