namespace AdiIRCAPIv2.Arguments.Connection
{
    using Interfaces;

    /// <summary>
    ///     Arguments class passed to the StringDataReceived event
    /// </summary>
    public class StringDataReceivedArgs
    {
        private IServer server;
        private string data;

        /// <summary>
        ///     Constructor for arguments class passed to the StringDataReceived event
        /// </summary>
        /// <param name="server">IServer</param>
        /// <param name="data">string</param>
        public StringDataReceivedArgs(IServer server, string data)
        {
            this.Server = server;
            this.data = data;
        }

        /// <summary>
        ///     The IServer where the event occured
        /// </summary>
        public IServer Server { get { return this.server; } set { this.server = value; } }

        /// <summary>
        ///     The string data received
        /// </summary>
        public string Data { get { return this.data; } set { this.data = value; } }
    }
}
