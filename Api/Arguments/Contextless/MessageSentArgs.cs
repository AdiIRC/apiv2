namespace AdiIRCAPIv2.Arguments.Contextless
{
    using System;
    using Enumerators;
    using Interfaces;

    /// <summary>
    ///     Arguments class passed to the MessageSent event
    /// </summary>
    public class MessageSentArgs : EventArgs
    {
        private readonly IServer server;
        private readonly string target;
        private string message;
        private readonly string command;
        private readonly MessageType messageType;
        private EatData eatData;

        /// <summary>
        ///     Constructor for arguments class passed to the MessageSent event
        /// </summary>
        /// <param name="server">IServer</param>
        /// <param name="target">string</param>
        /// <param name="message">string</param>
        /// <param name="command">string</param>
        /// <param name="messageType">MessageType</param>
        /// <param name="eatData">EatData></param>
        public MessageSentArgs(IServer server, string target, string message, string command, MessageType messageType, EatData eatData)
        {
            this.server = server;
            this.target = target;
            this.message = message;
            this.command = command;
            this.messageType = messageType;
            this.eatData = eatData;
        }

        /// <summary>
        ///     Returns the IServer where the event occured
        /// </summary>
        public IServer Server { get { return this.server; } }

        /// <summary>
        ///     Returns the message target
        /// </summary>
        /// <remarks>
        ///     The target can be a channel, or nick, @channel, or multiple channels.
        /// </remarks>
        public string Target { get { return this.target; } }

        /// <summary>
        ///     Returns the message to be sent
        /// </summary>
        public string Message { get { return this.message; } set { this.message = value; } }

        /// <summary>
        ///     Returns the command that was triggered
        /// </summary>
        public string Command { get { return this.command; } }

        /// <summary>
        ///     Returns the message type
        /// </summary>
        public MessageType MessageType { get { return this.messageType; } }

        /// <summary>
        ///     Gets or sets the current event proccessing state
        /// </summary>
        public EatData EatData { get { return this.eatData; } set { this.eatData = value; } }
    }
}
