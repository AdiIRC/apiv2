using System.Windows.Forms;
using AdiIRCAPIv2.Arguments.WindowInteraction;
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

            _host.OnMenu += OnMenu;
        }

        private void OnMenu(MenuEventArgs argument)
        {
            if (argument.MenuType == MenuType.Menubar)
            {
                var menuItem = new ToolStripMenuItem("Example Menu Item");
                menuItem.Click += delegate {
                    //Do Something
                };

                argument.MenuItems.Add(menuItem);
            }
        }

        public void Dispose()
        {
        }
    }
}
