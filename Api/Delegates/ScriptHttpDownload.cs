//-------------------------------------------------------------------------------
//  Delegates related to scripted initiated HTTP downloading
//-------------------------------------------------------------------------------

namespace AdiIRCAPIv2.Delegates
{
    using Arguments.ScriptHttpDownload;


    /// <summary>
    ///     Delegate gets called when AdiIRC starts an HTTP download
    /// </summary>
    /// <remarks>
    ///     Scripted Event Equivalent: overriding <c>/download</c>
    /// </remarks>
    /// <param name="argument">ScriptHttpDownloadStartedArgs</param>
    public delegate void ScriptHttpDownloadStarted(ScriptHttpDownloadStartedArgs argument);

    /// <summary>
    ///     Delegate gets called when adiirc finishes an HTTP download
    /// </summary>
    /// <remarks>
    ///     Scripted Event Equivalent: <c>on DOWNLOAD</c>
    /// </remarks>
    /// <param name="argument">ScriptHttpDownloadEndArgs</param>
    public delegate void ScriptHttpDownloadEnd(ScriptHttpDownloadEndArgs argument);
}