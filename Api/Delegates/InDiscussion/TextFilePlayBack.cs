/// <summary>
///     Delegates related to /play'ing a text file to an IChannel or IUser
/// </summary>
/// <exclude />
namespace AdiIRCAPIv2.Delegates
{
    using Arguments;
    using Arguments.TextFilePlayBack;

    /// <summary>
    ///     Delegate gets called when text-file playback has started
    /// </summary>
    /// <remarks>
    ///     Scripted Event Equivalent: overriding <c>/play</c>
    /// </remarks>
    /// <param name="argument">TextFilePlayBackStartedArgs</param>
    public delegate void TextFilePlayBackStarted(TextFilePlayBackStartedArgs argument);

    /// <summary>
    ///     Delegate gets called when text-file playback has finished
    /// </summary>
    /// <remarks>
    ///     Scripted Event Equivalent: <c>on PLAYEND</c>
    /// </remarks>
    /// <param name="argument">TextFilePlayBackEndArgs</param>
    public delegate void TextFilePlayBackEnd(TextFilePlayBackEndArgs argument);
}
