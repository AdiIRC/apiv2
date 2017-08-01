namespace AdiIRCAPIv2.Arguments.Channel
{
    using Enumerators;
    using Interfaces;

    public class UserInvitedToChannelArgs
    {
        private readonly IWindow window;
        private readonly IServer server;
        private readonly IChannel channel;
        private readonly IChannelUser user;
        private EatData eatData;

        /// <summary>
        ///     Arguments class passed to the UserInvitedToChannel event
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

        public IWindow Window { get { return this.window; } }

        public IServer Server { get { return this.server; } }

        public IChannel Channel { get { return this.channel; } }

        public IChannelUser User { get { return this.user; } }

        public EatData EatData { get { return this.eatData; } set { this.eatData = value; } }
    }
}
