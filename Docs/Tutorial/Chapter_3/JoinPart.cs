using System;
using System.Collections.Generic;
using AdiIRCAPIv2.Arguments.Channel;
using AdiIRCAPIv2.Arguments.ChannelMessages;
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
        private Dictionary<string, DateTime> _joinTimes;

        public ExamplePlugin()
        {
            _joinTimes = new Dictionary<string, DateTime>();
        }

        public void Initialize(IPluginHost host)
        {
            _host = host;

            _host.OnChannelNormalMessage += OnChannelNormalMessage;

            _host.OnChannelJoin += OnChannelJoin;
            _host.OnChannelPart += OnChannelPart;
            _host.OnQuit += OnQuit;
        }

        private void OnChannelNormalMessage(ChannelNormalMessageArgs argument)
        {
            if (_joinTimes.ContainsKey(argument.User.Ident))
            {
                var timeSince = (DateTime.Now - _joinTimes[argument.User.Ident]).TotalMinutes;
                _joinTimes.Remove(argument.User.Ident);

                argument.Message += $" (Joined {timeSince} Minues Ago)";
            }
        }

        private void OnChannelJoin(ChannelJoinArgs argument)
        {
            if(!_joinTimes.ContainsKey(argument.User.Ident))
            {
                _joinTimes.Add(argument.User.Ident,DateTime.Now);
            }
            else
            {
                _joinTimes[argument.User.Ident] = DateTime.Now;                
            }

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
