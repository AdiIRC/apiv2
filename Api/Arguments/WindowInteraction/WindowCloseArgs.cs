namespace AdiIRCAPIv2.Arguments.WindowInteraction
{
    using System;
    using Interfaces;

    /// <summary>
    ///     Arguments class passed to the WindowClose event
    /// </summary>
    public class WindowCloseArgs : EventArgs
    {
        private readonly IWindow window;
        private readonly IServer server;

        /// <summary>
        ///     Constructor for arguments class passed to the WindowClose event
        /// </summary>
        /// <param name="window">IWindow</param>
        /// <param name="server">IServer</param>
        public WindowCloseArgs(IWindow window, IServer server)
        {
            this.window = window;
            this.server = server;
        }

        /// <summary>
        ///     Returns the IWindow which was closed
        /// </summary>
        public IWindow Window { get { return this.window; } }

        /// <summary>
        ///     Returns the IServer where the event occured
        /// </summary>
        public IServer Server { get { return this.server; } }
    }
}