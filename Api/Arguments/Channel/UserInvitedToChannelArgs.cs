namespace AdiIRCAPIv2.Arguments.Channel
{
    using Enumerators;
    using Interfaces;

    /// <summary>
    ///     Arguments class passed to the UserInvitedToChannel event
    /// </summary>
    public class UserInvitedToChannelArgs
    {
        private readonly IServer server;
        private readonly string channelName;
        private readonly IChannelUser user;
        private EatData eatData;

        /// <summary>
        ///     Constructor for arguments class passed to the UserInvitedToChannel event
        /// </summary>
        /// <param name="server">IServer</param>
        /// <param name="channelName">string</param>
        /// <param name="user">IChannelUser</param>
        /// <param name="eatData">EatData</param>
        public UserInvitedToChannelArgs(IServer server, string channelName, IChannelUser user, EatData eatData)
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
        ///     Returns the target channel for the invite
        /// </summary>
        public string ChannelName { get { return this.channelName; } }

        /// <summary>
        ///     Returns the target IChannelUser who made the invite
        /// </summary>
        public IChannelUser User { get { return this.user; } }

        /// <summary>
        ///     Gets or sets the current event proccessing state
        /// </summary>
        public EatData EatData { get { return this.eatData; } set { this.eatData = value; } }
    }
}
