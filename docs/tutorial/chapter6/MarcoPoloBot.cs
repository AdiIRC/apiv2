using AdiIRCAPIv2.Arguments.ChannelMessages;
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

            _host.OnChannelNormalMessage += OnChannelNormalMessage;
        }

        private void OnChannelNormalMessage(ChannelNormalMessageArgs argument)
        {
            if (argument.Message.Contains("!marco"))
            {
                var message = $"PRIVMSG {argument.Channel.Name} :Polo.";

                argument.Server.SendRaw(message);
            }
        }


        public void Dispose()
        {
        }
    }
}
