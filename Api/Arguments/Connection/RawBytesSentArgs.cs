namespace AdiIRCAPIv2.Arguments.Connection
{
    using System;
    using Interfaces;

    /// <summary>
    ///     Arguments class passed to the RawBytesSent event
    /// </summary>
    public class RawBytesSentArgs : EventArgs
    {
        private readonly IServer server;
        private byte[] bytes;

        /// <summary>
        ///     Constructor for arguments class passed to the RawBytesSent event
        /// </summary>
        /// <param name="server">IServer</param>
        /// <param name="bytes">byte[]</param>
        public RawBytesSentArgs(IServer server, byte[] bytes)
        {
            this.server = server;
            this.bytes = bytes;
        }

        /// <summary>
        ///     The IServer where the event occured
        /// </summary>
        public IServer Server { get { return this.server; } }

        /// <summary>
        ///     The raw bytes sent
        /// </summary>
        public byte[] Bytes { get { return this.bytes; } set { this.bytes = value; } }
    }
}