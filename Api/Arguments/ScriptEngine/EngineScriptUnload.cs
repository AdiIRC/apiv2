namespace AdiIRCAPIv2.Arguments.ScriptEngine
{
    using System;

    public class EngineScriptUnloadArgs : EventArgs
    {
        private readonly string filename;

        public EngineScriptUnloadArgs(string filename)
        {
            this.filename = filename;
        }

        public string Filename { get { return filename; } }
    }
}
