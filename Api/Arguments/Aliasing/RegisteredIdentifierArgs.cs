namespace AdiIRCAPIv2.Arguments.Aliasing
{
    using Interfaces;

    /// <summary>
    ///     Arguments class passed to the RegisteredIdentifier event
    /// </summary>
    public class RegisteredIdentifierArgs
    {
        private readonly IWindow window;
        private readonly string identifier;
        private readonly string[] inputParameters;
        private string returnString = string.Empty;

        /// <summary>
        ///     Constructor for arguments class passed to the RegisteredIdentifier event handler
        /// </summary>
        /// <param name="window">IWindow</param>
        /// <param name="identifier">string</param>
        /// <param name="inputParameters">string[]</param>
        public RegisteredIdentifierArgs(IWindow window, string identifier, string[] inputParameters)
        {
            this.window = window;
            this.identifier = identifier;
            this.inputParameters = inputParameters;
        }

        /// <summary>
        ///     Returns the IWindow for which the identifier was called from
        /// </summary>
        /// <remarks>
        ///     If the identifier does not have a window context the window for the active IServer will be used
        /// </remarks>
        public IWindow Window { get { return this.window; } }

        /// <summary>
        ///     Returns the name of the identifer called
        /// </summary>
        public string Identifier { get { return this.identifier; } }

        /// <summary>
        ///     Returns an string array containing the parameters passed into the identifier
        /// </summary>
        public string[] InputParameters {  get { return this.inputParameters; } }

        /// <summary>
        ///     Retrieves/Sets the return value for the identifier.
        /// </summary>
        public string ReturnString {
            get { return this.returnString; }
            set { this.returnString = value; }
        }
    }
}
