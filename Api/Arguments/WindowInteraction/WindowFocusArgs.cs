namespace AdiIRCAPIv2.Arguments.WindowInteraction
{
    using Interfaces;

    public class WindowFocusArgs
    {
        private readonly IWindow window;
        private readonly IServer server;
        private readonly IWindow previousWindow;

        public WindowFocusArgs(IWindow window, IServer server, IWindow previousWindow)
        {
            this.window = window;
            this.server = server;
            this.previousWindow = previousWindow;
        }

        public IWindow Window { get { return this.window; } }

        public IServer Server { get { return this.server; } }

        public IWindow PreviousWindow { get { return this.previousWindow; } }
    }
}
