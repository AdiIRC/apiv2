using AdiIRCAPIv2.Interfaces;

namespace TestPlugin
{
    public class ExamplePlugin : IPlugin
    {
        public string PluginName => "Example Plugin";
        public string PluginDescription => "Serves as a great example";
        public string PluginAuthor => "";
        public string PluginVersion => "";
        public string PluginEmail => "";

        private IPluginHost _host;

        public void Initialize(IPluginHost host)
        {
            _host = host;

            var activeWindow = _host.ActiveIWindow;
            activeWindow.OutputText("Hello World");            
        }

        public void Dispose()
        {
        }
    }
}
