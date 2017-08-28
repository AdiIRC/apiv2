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
            var nickName = argument.Channel.Server.Self.Nick;

            if (argument.Message.Contains(nickName))
            {
                _host.ActiveIWindow.ExecuteCommand("/beep 1");
            }
        }


        public void Dispose()
        {
        }
    }
}
