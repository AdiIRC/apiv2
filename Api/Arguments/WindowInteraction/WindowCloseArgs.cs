namespace AdiIRCAPIv2.Arguments.WindowInteraction
{
    using System;
    using Interfaces;

    /// <summary>
    ///     Arguments class passed to the WindowClose event
    /// </summary>
    public class WindowCloseArgs : EventArgs
    {
        private readonly IWindow window;

        /// <summary>
        ///     Constructor for arguments class passed to the WindowClose event
        /// </summary>
        /// <param name="window">IWindow</param>
        public WindowCloseArgs(IWindow window)
        {
            this.window = window;
        }

        /// <summary>
        ///     Returns the IWindow which was closed
        /// </summary>
        public IWindow Window { get { return this.window; } }
    }
}