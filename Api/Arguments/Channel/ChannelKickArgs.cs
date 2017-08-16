namespace AdiIRCAPIv2.Arguments.Channel
{
    using System;
    using System.Collections.Generic;
    using Enumerators;
    using Interfaces;

    /// <summary>
    ///     Arguments class passed to the ChannelKick event
    /// </summary>
    public class ChannelKickArgs : EventArgs
    {
        private readonly IChannel channel;
        private readonly IChannelUser kickedUser;
        private readonly IChannelUser byUser;
        private readonly string kickReason;
        private readonly string rawMessage;
        private readonly string rawBytes;
        private readonly DateTime serverTime;
        private readonly IDictionary<string, string> messageTags;
        private EatData eatData;

        /// <summary>
        ///     Constructor for arguments class passed to the ChannelKick event
        /// </summary>
        /// <param name="channel">IChannel</param>
        /// <param name="kickedUser">IChannelUser</param>
        /// <param name="byUser">IChannelUser</param>
        /// <param name="kickReason">string</param>
        /// <param name="rawMessage">string</param>
        /// <param name="rawBytes">string</param>
        /// <param name="serverTime">DateTime</param>
        /// <param name="messageTags">IDictionary></param>
        /// <param name="eatData">EatData></param>
        public ChannelKickArgs(IChannel channel, IChannelUser kickedUser, IChannelUser byUser, string kickReason, string rawMessage, string rawBytes, DateTime serverTime, IDictionary<string, string> messageTags, EatData eatData)
        {
            this.channel = channel;
            this.kickedUser = kickedUser;
            this.byUser = byUser;
            this.kickReason = kickReason;
            this.rawMessage = rawMessage;
            this.rawBytes = rawBytes;
            this.serverTime = serverTime;
            this.messageTags = messageTags;
            this.eatData = eatData;
        }

        /// <summary>
        ///     Returns the IChannel where the kick occured
        /// </summary>
        public IChannel Channel { get { return this.channel; } }

        /// <summary>
        ///     Returns the IChannelUser which was kicked
        /// </summary>
        public IChannelUser KickedUser { get { return this.kickedUser; } }

        /// <summary>
        ///     Returns the IChannelUser who performed the kick
        /// </summary>
        public IChannelUser ByUser { get { return this.byUser; } }

        /// <summary>
        ///     Returns the kick reason, if any
        /// </summary>
        public string KickReason { get { return this.kickReason; } }

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
