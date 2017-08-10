//-------------------------------------------------------------------------------
//  Delegates related to loading/unloading plugin scripts when the plugin is acting like a script engine
//-------------------------------------------------------------------------------

namespace AdiIRCAPIv2.Delegates
{
    using Arguments.ScriptEngine;

    /// <summary>
    ///     Delegate gets called when a script is (re)loaded from the Plugins Scripts Editor or from the /load and /reload command
    /// </summary>
    /// <param name="argument">EngineScriptLoadArgs</param>
    public delegate void EngineScriptLoad(EngineScriptLoadArgs argument);

    /// <summary>
    ///     Delegate gets called when a script is unloaded from the Plugins Scripts Editor or from the /unload command
    /// </summary>
    /// <param name="argument">EngineScriptUnloadArgs</param>
    public delegate void EngineScriptUnload(EngineScriptUnloadArgs argument);
}
