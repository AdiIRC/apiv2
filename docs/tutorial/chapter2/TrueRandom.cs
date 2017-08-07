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
            
            _host.HookIdentifier("truerandom",TrueRandomIdentifier);
        }

        private void TrueRandomIdentifier(RegisteredIdentifierArgs argument)
        {
            var input = string.Join(" - ", argument.InputParameters);

            var randomNumber = "4";    // chosen by fair dice roll.
                                       // guaranteed to be random.

            argument.ReturnString = $"Random number between {input} : {randomNumber}";
        }

        public void Dispose()
        {
        }
    }
}
