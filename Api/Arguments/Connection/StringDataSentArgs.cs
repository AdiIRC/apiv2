namespace AdiIRCAPIv2.Arguments.Connection
{
    using Interfaces;

    /// <summary>
    ///     Arguments class passed to the StringDataSent event
    /// </summary>
    public class StringDataSentArgs
    {
        private readonly IServer server;
        private string data;

        /// <summary>
        ///     Constructor for arguments class passed to the StringDataSent event
        /// </summary>
        /// <param name="server">IServer</param>
        /// <param name="data">string</param>
        public StringDataSentArgs(IServer server, string data)
        {
            this.server = server;
            this.data = data;
        }

        /// <summary>
        ///     The IServer where the event occured
        /// </summary>
        public IServer Server { get { return this.server; } }

        /// <summary>
        ///     The string data sent
        /// </summary>
        public string Data { get { return this.data; } set { this.data = value; } }
    }
}
