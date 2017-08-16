namespace AdiIRCAPIv2.Arguments.Channel
{
    using System;
    using System.Collections.Generic;
    using Enumerators;
    using Interfaces;

    /// <summary>
    ///     Arguments class passed to the ChannelPart event
    /// </summary>
    public class ChannelPartArgs : EventArgs
    {
        private readonly IChannel channel;
        private readonly IChannelUser user;
        private readonly string partMessage;
        private readonly string rawMessage;
        private readonly string rawBytes;
        private readonly DateTime serverTime;
        private readonly IDictionary<string, string> messageTags;
        private EatData eatData;

        /// <summary>
        ///     Constructor for arguments class passed to the ChannelPart event handler
        /// </summary>
        /// <param name="channel">IChannel</param>
        /// <param name="user">IChannelUser</param>
        /// <param name="partMessage">string</param>
        /// <param name="rawMessage">string</param>
        /// <param name="rawBytes">string</param>
        /// <param name="serverTime">DateTime</param>
        /// <param name="messageTags">IDictionary></param>
        /// <param name="eatData">EatData></param>
        public ChannelPartArgs(IChannel channel, IChannelUser user, string partMessage, string rawMessage, string rawBytes, DateTime serverTime, IDictionary<string, string> messageTags, EatData eatData)
        {
            this.channel = channel;
            this.user = user;
            this.partMessage = partMessage;
            this.rawMessage = rawMessage;
            this.rawBytes = rawBytes;
            this.serverTime = serverTime;
            this.messageTags = messageTags;
            this.eatData = eatData;
        }

        /// <summary>
        ///     Returns the IChannel where the part occured
        /// </summary>
        public IChannel Channel { get { return this.channel; } }

        /// <summary>
        ///     Returns the IChannelUser who parted the IChannel
        /// </summary>
        public IChannelUser User { get { return this.user; } }

        /// <summary>
        ///     Returns the part message, if any
        /// </summary>
        public string PartMessage { get { return this.partMessage; } }

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
