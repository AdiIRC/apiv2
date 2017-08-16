namespace AdiIRCAPIv2.Arguments.Connection
{
    using System;
    using Enumerators;
    using Interfaces;

    /// <summary>
    ///     Arguments class passed to the Connect event
    /// </summary>
    public class ConnectArgs : EventArgs
    {
        private readonly IServer server;
        private readonly EatData eatData;

        /// <summary>
        ///     Constructor for arguments class passed to the Connect event
        /// </summary>
        /// <param name="server">IServer</param>
        /// <param name="eatData">EatData</param>
        public ConnectArgs(IServer server, EatData eatData)
        {
            this.server = server;
            this.eatData = eatData;
        }

        /// <summary>
        ///     The IServer where the event occured
        /// </summary>
        public IServer Server { get { return this.server; } }

        /// <summary>
        ///     Gets or sets the current event proccessing state
        /// </summary>
        public EatData EatData { get { return this.eatData; } }
    }
}