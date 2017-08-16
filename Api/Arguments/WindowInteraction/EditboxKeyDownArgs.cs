namespace AdiIRCAPIv2.Arguments.WindowInteraction
{
    using System;
    using System.Windows.Forms;
    using Interfaces;

    /// <summary>
    ///     Arguments class passed to the EditboxKeyDown event
    /// </summary>
    public class EditboxKeyDownArgs : EventArgs
    {
        private readonly IWindow window;
        private readonly IEditbox editbox;
        private readonly KeyEventArgs keyEventArgs;

        /// <summary>
        ///     Constructor for arguments class passed to the EditboxKeyDown event
        /// </summary>
        /// <param name="window">IWindow</param>
        /// <param name="editbox">IEditbox</param>
        /// <param name="keyEventArgs">KeyEventArgs</param>
        public EditboxKeyDownArgs(IWindow window, IEditbox editbox, KeyEventArgs keyEventArgs)
        {
            this.window = window;
            this.editbox = editbox;
            this.keyEventArgs = keyEventArgs;
        }

        /// <summary>
        ///     Returns the IWindow where they key was pressed
        /// </summary>
        public IWindow Window { get { return this.window; } }

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
