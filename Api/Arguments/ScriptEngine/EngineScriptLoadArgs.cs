namespace AdiIRCAPIv2.Arguments.ScriptEngine
{
    using System;
    using Enumerators;

    public class EngineScriptLoadArgs : EventArgs
    {
        private readonly string filename;

        private readonly PluginScriptLoadType loadType;

        public EngineScriptLoadArgs(string filename, PluginScriptLoadType loadType)
        {
            this.filename = filename;
            this.loadType = loadType;
        }

        public string Filename { get { return filename; } }

        public PluginScriptLoadType LoadType { get { return loadType; } }
    }
}
