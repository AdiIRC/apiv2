namespace AdiIRCAPIv2.Arguments.Connection
{
    using System;
    using Interfaces;

    /// <summary>
    ///     Arguments class passed to the RawBytesReceived event
    /// </summary>
    public class RawBytesReceivedArgs : EventArgs
    {
        /// <summary>
        ///     Constructor for arguments class passed to the RawBytesReceived event
        /// </summary>
        /// <param name="server">IServer</param>
        /// <param name="bytes">byte[]</param>
        public RawBytesReceivedArgs(IServer server, byte[] bytes)
        {
            this.Server = server;
            this.Bytes = bytes;
        }

        /// <summary>
        ///     The IServer where the event occured
        /// </summary>
        public IServer Server { get; set; }

        /// <summary>
        ///     The raw bytes received
        /// </summary>
        public byte[] Bytes { get; set; }
    }
}