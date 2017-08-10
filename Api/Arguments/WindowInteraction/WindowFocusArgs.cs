namespace AdiIRCAPIv2.Arguments.WindowInteraction
{
    using Interfaces;

    /// <summary>
    ///     Arguments class passed to the WindowFocus event
    /// </summary>
    public class WindowFocusArgs
    {
        private readonly IWindow window;
        private readonly IServer server;
        private readonly IWindow previousWindow;

        /// <summary>
        ///     Constructor for arguments class passed to the WindowFocus event
        /// </summary>
        /// <param name="window">IWindow</param>
        /// <param name="server">IServer</param>
        /// <param name="previousWindow">IWindow</param>
        public WindowFocusArgs(IWindow window, IServer server, IWindow previousWindow)
        {
            this.window = window;
            this.server = server;
            this.previousWindow = previousWindow;
        }

        /// <summary>
        ///     Returns the IWindow which was focused
        /// </summary>
        public IWindow Window { get { return this.window; } }

        /// <summary>
        ///     Returns the IServer where the event occured
        /// </summary>
        public IServer Server { get { return this.server; } }

        /// <summary>
        ///     Returns the previously focused IWindow
        /// </summary>
        public IWindow PreviousWindow { get { return this.previousWindow; } }
    }
}
