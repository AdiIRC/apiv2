using System;

namespace AdiIRCAPIv2.Arguments.Contextless
{
    using Interfaces;

    /// <summary>
    ///     Arguments class passed to the NotifyUserOnline event
    /// </summary>
    public class NotifyUserOnlineArgs
    {
        private readonly IServer server;
        private readonly IUser user;
        private readonly DateTime signedOnTime;

        /// <summary>
        ///     Constructor for arguments class passed to the NotifyUserOnline event
        /// </summary>
        /// <param name="server">IServer</param>
        /// <param name="user">IUser</param>
        /// <param name="signedOnTime">DateTime></param>
        public NotifyUserOnlineArgs(IServer server, IUser user, DateTime signedOnTime)
        {
            this.server = server;
            this.user = user;
            this.signedOnTime = signedOnTime;
        }

        /// <summary>
        ///     Returns the IServer where the event occured
        /// </summary>
        public IServer Server { get { return this.server; } }

        /// <summary>
        ///     Returns the IUser who came online
        /// </summary>
        public IUser User { get { return this.user; } }

        /// <summary>
        ///     Returns the user signed on time
        /// </summary>
        /// <remarks>
        ///     If the server does not send a signed on time, current time in UTC is used
        /// </remarks>
        public DateTime SignedOnTime { get { return this.signedOnTime; } }
    }
}
