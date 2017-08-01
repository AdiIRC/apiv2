namespace AdiIRCAPIv2.Arguments.Aliasing
{
    using Enumerators;

    /// <summary>
    ///     Arguments class passed to the ScriptSignal event
    /// </summary>
    public class ScriptSignalEventArgs
    {
        private readonly string signal;
        private string parameters;
        private EatData eatData;

        /// <summary>
        ///     Constructor for arguments class passed to the ScriptSignal event handler
        /// </summary>
        /// <param name="signal">signal</param>
        /// <param name="parameters">string</param>
        /// <param name="eatData">sEatData</param>
        public ScriptSignalEventArgs(string signal, string parameters, EatData eatData)
        {
            this.signal = signal;
            this.parameters = parameters;
            this.eatData = eatData;
        }

        /// <summary>
        ///     The name of the signal called.
        /// </summary>
        public string Signal { get { return this.signal; } }

        /// <summary>
        ///     The parameters of the signal called.
        /// </summary>
        public string Parameters { get { return this.parameters; } set { this.parameters = value; } }

        /// <summary>
        ///     Gets or sets the current event proccessing state
        /// </summary>
        public EatData EatData { get { return this.eatData; } set { this.eatData = value; } }
    }
}