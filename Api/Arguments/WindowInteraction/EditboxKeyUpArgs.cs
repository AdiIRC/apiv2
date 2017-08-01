namespace AdiIRCAPIv2.Arguments.WindowInteraction
{
    using System;
    using System.Windows.Forms;
    using Interfaces;

    public class EditboxKeyUpArgs : EventArgs
    {
        private readonly IWindow window;
        private readonly IServer server;
        private readonly IEditbox editbox;
        private readonly KeyEventArgs keyEventArgs;

        public EditboxKeyUpArgs(IWindow window, IServer server, IEditbox editbox, KeyEventArgs keyEventArgs)
        {
            this.window = window;
            this.server = server;
            this.editbox = editbox;
            this.keyEventArgs = keyEventArgs;
        }

        public IWindow Window { get { return this.window; } }

        public IServer Server { get { return this.server; } }

        public IEditbox Editbox { get { return this.editbox; } }

        public KeyEventArgs KeyEventArgs { get { return this.keyEventArgs; } }
    }
}