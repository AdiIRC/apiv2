namespace AdiIRCAPIv2.Arguments.Connection
{
    using System;
    using Interfaces;

    /// <summary>
    ///     Arguments class passed to the ConnectionLogonSuccess event
    /// </summary>
    public class ConnectionLogonSuccessArgs : EventArgs
    {
        private readonly IServer server;

        /// <summary>
        ///     Constructor for arguments class passed to the ConnectionLogonSuccess event
        /// </summary>
        /// <param name="server">IServer</param>
        public ConnectionLogonSuccessArgs(IServer server)
        {
            this.server = server;
        }

        /// <summary>
        ///     The IServer where the event occured
        /// </summary>
        public IServer Server { get { return this.server; } }
    }
}