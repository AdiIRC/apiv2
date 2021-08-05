namespace AdiIRCAPIv2.Arguments.Contextless
{
    using Enumerators;
    using Interfaces;

    /// <summary>
    ///     Arguments class passed to the NotifyUserOffline event
    /// </summary>
    public class NotifyUserOfflineArgs
    {
        private readonly IServer server;
        private readonly IUser user;
        private EatData eatData;

        /// <summary>
        ///     Constructor for arguments class passed to the NotifyUserOffline event
        /// </summary>
        /// <param name="server">IServer</param>
        /// <param name="user">IUser</param>
        /// <param name="eatData">EatData</param
        public NotifyUserOfflineArgs(IServer server, IUser user, EatData eatData)
        {
            this.server = server;
            this.user = user;
            this.eatData = eatData;
        }

        /// <summary>
        ///     Returns the IServer where the event occured
        /// </summary>
        public IServer Server { get { return this.server; } }

        /// <summary>
        ///     Returns the IUser who went offline
        /// </summary>
        public IUser User { get { return this.user; } }

        /// <summary>
        ///     Gets or sets the current event proccessing state
        /// </summary>
        public EatData EatData { get { return this.eatData; } set { this.eatData = value; } }
    }
}
