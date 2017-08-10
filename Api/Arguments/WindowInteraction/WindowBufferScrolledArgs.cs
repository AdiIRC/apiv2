namespace AdiIRCAPIv2.Arguments.WindowInteraction
{
    using Interfaces;

    /// <summary>
    ///     Arguments class passed to the WindowBufferScrolled event
    /// </summary>
    public class WindowBufferScrolledArgs
    {
        private readonly IWindow window;

        /// <summary>
        ///     Constructor for arguments class passed to the WindowBufferScrolled event
        /// </summary>
        /// <param name="window">IWindow</param>
        public WindowBufferScrolledArgs(IWindow window)
        {
            this.window = window;
        }

        /// <summary>
        ///     Returns the IWindow which was scrolled
        /// </summary>
        public IWindow Window { get { return this.window; } }
    }
}
