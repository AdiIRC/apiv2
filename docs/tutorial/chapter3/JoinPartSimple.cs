using AdiIRCAPIv2.Arguments.Channel;
using AdiIRCAPIv2.Arguments.Contextless;
using AdiIRCAPIv2.Enumerators;
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

            _host.OnChannelJoin += OnChannelJoin;
            _host.OnChannelPart += OnChannelPart;
            _host.OnQuit += OnQuit;
        }

        private void OnChannelJoin(ChannelJoinArgs argument)
        {
            argument.EatData = EatData.EatText;
        }

        private void OnChannelPart(ChannelPartArgs argument)
        {
            argument.EatData = EatData.EatText;
        }

        private void OnQuit(QuitArgs argument)
        {
            argument.EatData = EatData.EatText;
        }

        public void Dispose()
        {
        }
    }
}
