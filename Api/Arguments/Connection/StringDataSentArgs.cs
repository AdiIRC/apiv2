namespace AdiIRCAPIv2.Arguments.Connection
{
    using Interfaces;

    public class StringDataSentArgs
    {
        private IServer server;
        private string data;

        public StringDataSentArgs(IServer server, string data)
        {
            this.Server = server;
            this.data = data;
        }

        public IServer Server { get { return this.server; } set { this.server = value; } }

        public string Data { get { return this.data; } set { this.data = value; } }
    }
}
