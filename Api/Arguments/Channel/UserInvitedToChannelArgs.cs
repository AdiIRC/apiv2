namespace AdiIRCAPIv2.Arguments.Channel
{
    using Enumerators;
    using Interfaces;

    /// <summary>
    ///     Arguments class passed to the UserInvitedToChannel event
    /// </summary>
    public class UserInvitedToChannelArgs
    {
        private readonly IWindow window;
        private readonly IServer server;
        private readonly IChannel channel;
        private readonly IChannelUser user;
        private EatData eatData;

        /// <summary>
        ///     Constructor for arguments class passed to the UserInvitedToChannel event
        /// </summary>
        /// <param name="window">IWindow</param>
        /// <param name="server">IServer</param>
        /// <param name="channel">IChannel</param>
        /// <param name="user">IChannelUser</param>
        /// <param name="eatData">EatData</param>
        public UserInvitedToChannelArgs(IWindow window, IServer server, IChannel channel, IChannelUser user, EatData eatData)
        {
            this.window = window;
            this.server = server;
            this.channel = channel;
            this.user = user;
            this.eatData = eatData;
        }

        /// <summary>
        ///     Returns the IWindow where the invite is shown
        /// </summary>
        public IWindow Window { get { return this.window; } }

        /// <summary>
        ///     Returns the IServer where the event occured
        /// </summary>
        public IServer Server { get { return this.server; } }

        /// <summary>
        ///     Returns the target IChannel for the invite
        /// </summary>
        public IChannel Channel { get { return this.channel; } }

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
