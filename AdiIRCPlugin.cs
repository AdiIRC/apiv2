namespace $safeprojectname$
{
    using AdiIRCAPIv2.Interfaces;

    public class $safeprojectname$ : IPlugin
    {
        public string Description { get { return "Description"; } }

        public string Author { get { return "Bob Jones"; } }

        public string Name { get { return "$safeprojectname$"; } }

        public string Version { get { return "1.0"; } }

        public string Email { get { return "bob@jones.com"; } }

        public IPluginHost Host { get; set; }

        public ITools Tools { get; set; }

        public void Initialize()
        {
            // Called when the plugin is loaded, subscribe to host events here.
        }

        public void Dispose()
        {
            // Called when the plugin is unloaded/closed, do clean up here
        }
    }
}
