/// <summary>
///     Delegates related to scripted socket handling
/// </summary>
/// <exclude />
namespace AdiIRCAPIv2.Delegates
{
    using Arguments;
    using Arguments.ScriptSockets;

    /// <summary>
    ///     Delegate gets called when a scripted socket opens
    /// </summary>
    /// <remarks>
    ///     Scripted Event Equivalent: <c>on SOCKOPEN</c>
    /// </remarks>
    /// <param name="argument">ScriptedSocketOpenArgs</param>
    public delegate void ScriptedSocketOpen(ScriptedSocketOpenArgs argument);

    /// <summary>
    ///     Delegate gets called when a scripted socket writes
    /// </summary>
    /// <remarks>
    ///     Scripted Event Equivalent: <c>on SOCKWRITE</c>
    /// </remarks>
    /// <param name="argument">ScriptedSocketWriteArgs</param>
    public delegate void ScriptedSocketWrite(ScriptedSocketWriteArgs argument);

    /// <summary>
    ///     Delegate gets called when a scripted socket reads
    /// </summary>
    /// <remarks>
    ///     Scripted Event Equivalent: <c>on SOCKREAD</c>
    /// </remarks>
    /// <param name="argument">ScriptedSocketReadArgs</param>
    public delegate void ScriptedSocketRead(ScriptedSocketReadArgs argument);

    /// <summary>
    ///     Delegate gets called when a scripted socket closes
    /// </summary>
    /// <remarks>
    ///     Scripted Event Equivalent: <c>on SOCKCLOSE</c>
    /// </remarks>
    /// <param name="argument">ScriptedSocketCloseArgs</param>
    public delegate void ScriptedSocketClose(ScriptedSocketCloseArgs argument);

    /// <summary>
    ///     Delegate gets called when a scripted upd socket reads
    /// </summary>
    /// <remarks>
    ///     Scripted Event Equivalent: <c>on UPDREAD</c>
    /// </remarks>
    /// <param name="argument">ScriptedUPDSocketReadArgs</param>
    public delegate void ScriptedUPDSocketRead(ScriptedUPDSocketReadArgs argument);
}
