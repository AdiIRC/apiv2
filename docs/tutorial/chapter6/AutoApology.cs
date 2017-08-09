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
                if (argument.Message.Contains("damn"))
                {
                    var user = argument.User;

                    var sender = $"{user.Nick}!{user.Ident}@{user.Host}";
                    var apology = $":{sender} PRIVMSG {argument.Channel.Name} :Sorry, my next message is going to be very rude.";

                    argument.Server.SendFakeRaw(apology);
                }
            }


        public void Dispose()
        {
        }
    }
}
