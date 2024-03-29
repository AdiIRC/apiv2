namespace AdiIRCAPIv2.Arguments.ChannelServerModes
{
    using System;
    using System.Collections.Generic;
    using Enumerators;
    using Interfaces;

    /// <summary>
    ///     Arguments class passed to the ChannelRawServerMode event
    /// </summary>
    public class ChannelRawServerModeArgs : EventArgs
    {
        private readonly IChannel channel;
        private readonly string byServer;
        private readonly string modes;
        private readonly string rawMessage;
        private readonly string rawBytes;
        private readonly DateTime serverTime;
        private readonly IDictionary<string, string> messageTags;
        private EatData eatData;

        /// <summary>
        ///     Constructor for arguments class passed to the ChannelRawServerMode event
        /// </summary>
        /// <param name="channel">IChannel</param>
        /// <param name="byServer">string</param>
        /// <param name="modes">string</param>
        /// <param name="rawMessage">string</param>
        /// <param name="rawBytes">string</param>
        /// <param name="serverTime">DateTime</param>
        /// <param name="messageTags">IDictionary></param>
        /// <param name="eatData">EatData></param>
        public ChannelRawServerModeArgs(IChannel channel, string byServer, string modes, string rawMessage, string rawBytes, DateTime serverTime, IDictionary<string, string> messageTags, EatData eatData)
        {
            this.channel = channel;
            this.byServer = byServer;
            this.modes = modes;
            this.rawMessage = rawMessage;
            this.rawBytes = rawBytes;
            this.serverTime = serverTime;
            this.messageTags = messageTags;
            this.eatData = eatData;
        }

        /// <summary>
        ///     Returns the IChannel where the mode change occured
        /// </summary>
        public IChannel Channel { get { return this.channel; } }

        /// <summary>
        ///     Returns the server who made the mode change
        /// </summary>
        public string ByServer { get { return this.byServer; } }

        /// <summary>
        ///     Returns the mode changes
        /// </summary>
        public string Modes { get { return this.modes; } }

        /// <summary>
        ///     Returns the raw event message
        /// </summary>
        public string RawMessage { get { return this.rawMessage; } }

        /// <summary>
        ///     Returns the raw event message without decoding
        /// </summary>
        public string RawBytes { get { return this.rawBytes; } }

        /// <summary>
        ///     Returns the time the event was recieved
        /// </summary>
        /// <remarks>
        ///     If no IRCv3 @time tag was found in the raw line, returns the current time in UTC format
        /// </remarks>
        public DateTime ServerTime { get { return this.serverTime; } }

        /// <summary>
        ///     Returns a list of IRCv3 tags found in the raw line
        /// </summary>
        public IDictionary<string, string> MessageTags { get { return this.messageTags; } }

        /// <summary>
        ///     Gets or sets the current event proccessing state
        /// </summary>
        public EatData EatData { get { return this.eatData; } set { this.eatData = value; } }
    }
}