using System;

namespace AdiIRCAPIv2.Arguments.Contextless
{
    using Enumerators;
    using Interfaces;

    /// <summary>
    ///     Arguments class passed to the NotifyUserOnline event
    /// </summary>
    public class NotifyUserOnlineArgs
    {
        private readonly IServer server;
        private readonly IUser user;
        private readonly DateTime signedOnTime;
        private EatData eatData;

        /// <summary>
        ///     Constructor for arguments class passed to the NotifyUserOnline event
        /// </summary>
        /// <param name="server">IServer</param>
        /// <param name="user">IUser</param>
        /// <param name="signedOnTime">DateTime></param>
        /// <param name="eatData">EatData></param>
        public NotifyUserOnlineArgs(IServer server, IUser user, DateTime signedOnTime, EatData eatData)
        {
            this.server = server;
            this.user = user;
            this.signedOnTime = signedOnTime;
            this.eatData = eatData;
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

        /// <summary>
        ///     Gets or sets the current event proccessing state
        /// </summary>
        public EatData EatData { get { return this.eatData; } set { this.eatData = value; } }
    }
}
