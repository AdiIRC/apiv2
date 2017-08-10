namespace AdiIRCAPIv2.Arguments.WindowInteraction
{
    using System;
    using System.Windows.Forms;
    using Interfaces;

    /// <summary>
    ///     Arguments class passed to the EditboxKeyUp event
    /// </summary>
    public class EditboxKeyUpArgs : EventArgs
    {
        private readonly IWindow window;
        private readonly IServer server;
        private readonly IEditbox editbox;
        private readonly KeyEventArgs keyEventArgs;

        /// <summary>
        ///     Constructor for arguments class passed to the EditboxKeyUp event
        /// </summary>
        /// <param name="window">IWindow</param>
        /// <param name="server">IServer</param>
        /// <param name="editbox">IEditbox</param>
        /// <param name="keyEventArgs">KeyEventArgs</param>
        public EditboxKeyUpArgs(IWindow window, IServer server, IEditbox editbox, KeyEventArgs keyEventArgs)
        {
            this.window = window;
            this.server = server;
            this.editbox = editbox;
            this.keyEventArgs = keyEventArgs;
        }

        /// <summary>
        ///     Returns the IWindow where they key was pressed
        /// </summary>
        public IWindow Window { get { return this.window; } }

        /// <summary>
        ///     Returns the IServer where the event occured
        /// </summary>
        public IServer Server { get { return this.server; } }

        /// <summary>
        ///     Returns the IEditbox where they key was pressed
        /// </summary>
        public IEditbox Editbox { get { return this.editbox; } }

        /// <summary>
        ///     Returns the keyeventargs for this key
        /// </summary>
        public KeyEventArgs KeyEventArgs { get { return this.keyEventArgs; } }
    }
}