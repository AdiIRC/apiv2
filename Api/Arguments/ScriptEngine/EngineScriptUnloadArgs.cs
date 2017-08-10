namespace AdiIRCAPIv2.Arguments.ScriptEngine
{
    using System;

    /// <summary>
    ///     Arguments class passed to the EngineScriptUnload event
    /// </summary>
    public class EngineScriptUnloadArgs : EventArgs
    {
        private readonly string filename;

        /// <summary>
        ///     Constructor for arguments class passed to the EngineScriptUnload event
        /// </summary>
        /// <param name="filename">string</param>
        public EngineScriptUnloadArgs(string filename)
        {
            this.filename = filename;
        }

        /// <summary>
        ///     Returns the filename that was unloaded
        /// </summary>
        public string Filename { get { return filename; } }
    }
}
