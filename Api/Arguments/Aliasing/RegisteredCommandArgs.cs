namespace AdiIRCAPIv2.Arguments.Aliasing
{
    using Interfaces;

    /// <summary>
    ///     Arguments class passed to the RegisteredCommand event
    /// </summary>
    public class RegisteredCommandArgs
    {
        private readonly IWindow window;
        private readonly string command;

        /// <summary>
        ///     Constructor for the Arguments class passed to the RegisteredCommand event handler
        /// </summary>
        /// <param name="window">IWindow</param>
        /// <param name="command">string</param>
        public RegisteredCommandArgs(IWindow window, string command)
        {
            this.window = window;
            this.command = command;
        }

        /// <summary>
        ///     Returns the IWindow for which the command was called from
        /// </summary>
        /// <remarks>
        ///     If the command does not have a window context the window for the active IServer will be used
        /// </remarks>
        public IWindow Window { get { return this.window; } }

        /// <summary>
        ///     Returns the name of the command called
        /// </summary>
        public string Command { get { return this.command; } }
    }
}
