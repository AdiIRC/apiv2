using AdiIRCAPIv2.Arguments.WindowInteraction;
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

            _host.OnEditboxKeyUp += OnEditboxKeyUp;
        }

        private void OnEditboxKeyUp(EditboxKeyUpArgs argument)
        {
            var text = argument.Editbox.Text;
            
            text = text.Replace(":)", "😊");
            text = text.Replace(":p", "😛");

            if (text != argument.Editbox.Text)
            {
                var cursorPosition = argument.Editbox.SelectionStart;
                cursorPosition -= argument.Editbox.Text.Length - text.Length;

                argument.Editbox.Text = text;
                argument.Editbox.SelectionStart = cursorPosition;
            }            
        }


        public void Dispose()
        {
        }
    }
}
