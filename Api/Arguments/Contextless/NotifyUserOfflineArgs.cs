namespace AdiIRCAPIv2.Arguments.Contextless
{
    using Interfaces;

    /// <summary>
    ///     Arguments class passed to the NotifyUserOffline event
    /// </summary>
    public class NotifyUserOfflineArgs
    {
        private readonly IWindow window;
        private readonly IServer server;
        private readonly IUser user;

        /// <summary>
        ///     Constructor for arguments class passed to the NotifyUserOffline event
        /// </summary>
        /// <param name="window">IWindow</param>
        /// <param name="server">IServer</param>
        /// <param name="user">IUser</param>
        public NotifyUserOfflineArgs(IWindow window, IServer server, IUser user)
        {
            this.window = window;
            this.server = server;
            this.user = user;
        }

        /// <summary>
        ///     Returns the IWindow where the notify was received
        /// </summary>
        public IWindow Window { get { return this.window; } }

        /// <summary>
        ///     Returns the IServer where the event occured
        /// </summary>
        public IServer Server { get { return this.server; } }

        /// <summary>
        ///     Returns the IUser who went offline
        /// </summary>
        public IUser User { get { return this.user; } }
    }
}
