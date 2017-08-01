namespace AdiIRCAPIv2.Arguments.Connection
{
    using System;
    using Interfaces;

    public class RawBytesSentArgs : EventArgs
    {
        /// <summary>
        /// RawBytesArgs
        /// </summary>
        /// <param name="server"></param>
        /// <param name="bytes"></param>
        public RawBytesSentArgs(IServer server, byte[] bytes)
        {
            this.Server = server;
            this.Bytes = bytes;
        }

        /// <summary>
        /// The IServer of this event.
        /// </summary>
        public IServer Server { get; set; }

        /// <summary>
        /// The raw bytes of this event.
        /// </summary>
        public byte[] Bytes { get; set; }
    }
}