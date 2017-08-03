using AdiIRCAPIv2.Arguments.Aliasing;
using AdiIRCAPIv2.Interfaces;

namespace TestPlugin
{
    public class ExamplePlugin : IPlugin
    {
        public string PluginName => "Example Plugin";
        public string PluginDescription => "Serves as an example";
        public string PluginAuthor => "";
        public string PluginVersion => "1";
        public string PluginEmail => "";

        private IPluginHost _host;

        public void Initialize(IPluginHost host)
        {
            _host = host;

            if(!_host.HookCommand("/marco", CommandHandler))
            {
                _host.ActiveIWindow.OutputText("Could not create the /marco command.");
            }
        }

        private void CommandHandler(RegisteredCommandArgs argument)
        {
            if (argument.Command.Contains("shout"))
            {
                argument.Window.OutputText("POLO");
            }
            else
            {
                argument.Window.OutputText("polo");
            }            
        }

        public void Dispose()
        {
        }
    }
}
