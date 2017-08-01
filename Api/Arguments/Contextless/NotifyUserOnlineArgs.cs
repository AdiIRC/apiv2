using System;

namespace AdiIRCAPIv2.Arguments.Contextless
{
    using Interfaces;

    public class NotifyUserOnlineArgs
    {
        private readonly IWindow window;
        private readonly IServer server;
        private readonly IUser user;
        private readonly DateTime signedOnTime;

        public NotifyUserOnlineArgs(IWindow window, IServer server, IUser user, DateTime signedOnTime)
        {
            this.window = window;
            this.server = server;
            this.user = user;
            this.signedOnTime = signedOnTime;
        }

        public IWindow Window { get { return this.window; } }

        public IServer Server { get { return this.server; } }

        public IUser User { get { return this.user; } }

        public DateTime SignedOnTime { get { return this.signedOnTime; } }
    }
}
