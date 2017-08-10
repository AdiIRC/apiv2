namespace AdiIRCAPIv2.Arguments.Connection
{
    using System;
    using Interfaces;

    /// <summary>
    ///     Arguments class passed to the ConnectionLogonSuccess event
    /// </summary>
    public class ConnectionLogonSuccessArgs : EventArgs
    {
        private readonly IWindow window;
        private readonly IServer server;

        /// <summary>
        ///     Constructor for arguments class passed to the ConnectionLogonSuccess event
        /// </summary>
        /// <param name="window">IWindow</param>
        /// <param name="server">IServer</param>
        public ConnectionLogonSuccessArgs(IWindow window, IServer server)
        {
            this.window = window;
            this.server = server;
        }

        /// <summary>
        ///     The IWindow where the event occured
        /// </summary>
        public IWindow Window { get { return this.window; } }

        /// <summary>
        ///     The IServer where the event occured
        /// </summary>
        public IServer Server { get { return this.server; } }
    }
}