namespace AdiIRCAPIv2.Arguments.WindowInteraction
{
    using System;
    using Interfaces;

    /// <summary>
    ///     Arguments class passed to the WindowOpen event
    /// </summary>
    public class WindowOpenArgs : EventArgs
    {
        private readonly IWindow window;

        /// <summary>
        ///     Constructor for arguments class passed to the WindowOpen event
        /// </summary>
        /// <param name="window">IWindow</param>
        public WindowOpenArgs(IWindow window)
        {
            this.window = window;
        }

        /// <summary>
        ///     Returns the IWindow which was opened
        /// </summary>
        public IWindow Window { get { return this.window; } }
    }
}