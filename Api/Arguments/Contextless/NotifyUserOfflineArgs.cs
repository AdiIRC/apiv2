namespace AdiIRCAPIv2.Arguments.Contextless
{
    using Interfaces;

    public class NotifyUserOfflineArgs
    {
        private readonly IWindow window;
        private readonly IServer server;
        private readonly IUser user;

        public NotifyUserOfflineArgs(IWindow window, IServer server, IUser user)
        {
            this.window = window;
            this.server = server;
            this.user = user;
        }

        public IWindow Window { get { return this.window; } }

        public IServer Server { get { return this.server; } }

        public IUser User { get { return this.user; } }
    }
}
