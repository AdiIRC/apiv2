namespace AdiIRCAPIv2.Arguments.ScriptEngine
{
    using System;
    using Enumerators;

    /// <summary>
    ///     Arguments class passed to the EngineScriptLoad event
    /// </summary>
    public class EngineScriptLoadArgs : EventArgs
    {
        private readonly string filename;

        private readonly PluginScriptLoadType loadType;

        /// <summary>
        ///     Constructor for arguments class passed to the EngineScriptLoad event
        /// </summary>
        /// <param name="filename">string</param>
        /// <param name="loadType">PluginScriptLoadType</param>
        public EngineScriptLoadArgs(string filename, PluginScriptLoadType loadType)
        {
            this.filename = filename;
            this.loadType = loadType;
        }

        /// <summary>
        ///     Returns the filename that was (re)loaded
        /// </summary>
        public string Filename { get { return filename; } }

        /// <summary>
        ///     Returns the load type for this filename
        /// </summary>
        public PluginScriptLoadType LoadType { get { return loadType; } }
    }
}
