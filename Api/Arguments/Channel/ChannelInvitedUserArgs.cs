namespace AdiIRCAPIv2.Arguments.Channel
{
    using System;
    using Enumerators;
    using Interfaces;

    /// <summary>
    ///     Arguments class passed to the ChannelInvitedUser event
    /// </summary>
    public class ChannelInvitedUserArgs : EventArgs
    {
        private readonly IServer server;
        private readonly string channelName;
        private readonly IChannelUser user;
        private EatData eatData;

        /// <summary>
        ///     Arguments class passed to the ChannelInvitedUser event
        /// </summary>
        /// <param name="server">IServer</param>
        /// <param name="channelName">string</param>
        /// <param name="user">IChannelUser</param>
        /// <param name="eatData">EatData</param>
        public ChannelInvitedUserArgs(IServer server, string channelName, IChannelUser user, EatData eatData)
        {
            this.server = server;
            this.channelName = channelName;
            this.user = user;
            this.eatData = eatData;
        }

        /// <summary>
        ///     Returns the IServer where the event occured
        /// </summary>
        public IServer Server { get { return this.server; } }

        /// <summary>
        ///     Returns the IChannel where the invite occured
        /// </summary>
        public string ChannelName { get { return this.channelName; } }

        /// <summary>
        ///     Returns the IChannelUser who performed the invite
        /// </summary>
        public IChannelUser User { get { return this.user; } }

        /// <summary>
        ///     Gets or sets the current event proccessing state
        /// </summary>
        public EatData EatData { get { return this.eatData; } set { this.eatData = value; } }
    }
}
