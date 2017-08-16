namespace AdiIRCAPIv2.Arguments.WindowInteraction
{
    using Interfaces;

    /// <summary>
    ///     Arguments class passed to the WindowFocus event
    /// </summary>
    public class WindowFocusArgs
    {
        private readonly IWindow window;
        private readonly IWindow previousWindow;

        /// <summary>
        ///     Constructor for arguments class passed to the WindowFocus event
        /// </summary>
        /// <param name="window">IWindow</param>
        /// <param name="previousWindow">IWindow</param>
        public WindowFocusArgs(IWindow window, IWindow previousWindow)
        {
            this.window = window;
            this.previousWindow = previousWindow;
        }

        /// <summary>
        ///     Returns the IWindow which was focused
        /// </summary>
        public IWindow Window { get { return this.window; } }

        /// <summary>
        ///     Returns the previously focused IWindow
        /// </summary>
        public IWindow PreviousWindow { get { return this.previousWindow; } }
    }
}
