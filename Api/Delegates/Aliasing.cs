//-------------------------------------------------------------------------------
//     Delegates related to scripting-engine interactions
//-------------------------------------------------------------------------------

namespace AdiIRCAPIv2.Delegates
{
    using Arguments.Aliasing;

    /// <summary>
    ///     Delegate gets called when a hooked command is called as a /command
    /// </summary>
    /// <param name="argument">RegisteredCommandArgs</param>
    public delegate void RegisteredCommand(RegisteredCommandArgs argument);

    /// <summary>
    ///     Delegate gets called when a hooked command is called as a $identifier
    /// </summary>
    /// <param name="argument">RegisteredIdentifierArgs</param>
    public delegate void RegisteredIdentifier(RegisteredIdentifierArgs argument);

    /// <summary>
    ///     Delegate gets called when a scripted signal is emitted
    /// </summary>
    /// <remarks>
    ///     Scripted Event Equivalent: <c>on SIGNAL</c>
    /// </remarks>
    /// <param name="argument">ScriptSignalEventArgs</param>
    public delegate void ScriptSignalEvent(ScriptSignalEventArgs argument);
}
