namespace AdiIRCAPIv2.Arguments.WindowInteraction
{
    using System;
    using Interfaces;

    /// <summary>
    ///     Arguments class passed to the WindowRenamed event
    /// </summary>
    public class WindowRenamedArgs : EventArgs
    {
        private readonly IWindow window;
        
        /// <summary>
        ///     Constructor for arguments class passed to the WindowRenamed event
        /// </summary>
        /// <param name="window">IWindow</param>
        public WindowRenamedArgs(IWindow window)
        {
            this.window = window;
        }

        /// <summary>
        ///     Returns the IWindow which was renamed
        /// </summary>
        public IWindow Window { get { return this.window; } }
    }
}