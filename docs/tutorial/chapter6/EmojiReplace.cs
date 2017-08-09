using System.Text.RegularExpressions;
using AdiIRCAPIv2.Arguments.Connection;
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

            _host.OnStringDataReceived += OnStringDataReceived;
        }

        private void OnStringDataReceived(StringDataReceivedArgs argument)
        {
            var messageRegex = @":(.+) PRIVMSG ([#\w]+) :(.+)";
            var messageMatch= Regex.Match(argument.Data, messageRegex);

            if (messageMatch.Success)
            {
                var sender = messageMatch.Groups[1].ToString();
                var target = messageMatch.Groups[2].ToString();
                var message = messageMatch.Groups[3].ToString();

                message = message.Replace(":)", "😊");
                message = message.Replace(":p", "😛");

                var newMessage = $":{sender} PRIVMSG {target} :{message}";
                argument.Data = newMessage;
            }            
        }

        public void Dispose()
        {
        }
    }
}
