/// <summary>
///     Delegates called for messages from a server that do not have an IChannel context and are not discussion-related
/// </summary>
namespace AdiIRCAPIv2.Delegates
{
    using Arguments.Contextless;

    /// <summary>
    ///     Delegate gets called when AdiIRC sends a PRIVMSG or NOTICE to a IChannel or IPrivateWindow
    /// </summary>
    /// <remarks>
    ///     Scripted Event Equivalent: overriding <c>/msg</c>, <c>/describe</c>, <c>/notice</c>, etc
    /// </remarks>
    /// <param name="argument">MessageSentArgs</param>
    public delegate void MessageSent(MessageSentArgs argument);

    /// <summary>
    ///     Delegate gets called when your IUser receives a mode event
    /// </summary>
    /// <remarks>
    ///     Scripted Event Equivalent: <c>on USERMODE</c>
    /// </remarks>
    /// <param name="argument">UserModeArgs</param>
    public delegate void UserMode(UserModeArgs argument);

    /// <summary>
    ///     Delegate gets called when your IUser recives an IChannel invite
    /// </summary>
    /// <remarks>
    ///     Scripted Event Equivalent: <c>on INVITE</c>
    /// </remarks>
    /// <param name="argument">InviteArgs</param>
    public delegate void ChannelInvite(ChannelInviteArgs argument);

    /// <summary>
    ///     Delegate gets called when a IUser changes their nick
    /// </summary>
    /// <remarks>
    ///     Scripted Event Equivalent: <c>on NICK</c>
    /// </remarks>
    /// <param name="argument">NickArgs</param>
    public delegate void Nick(NickArgs argument);

    /// <summary>
    ///     Delegate gets called when a IUser quits the IServer
    /// </summary>
    /// <remarks>
    ///     Scripted Event Equivalent: <c>on QUIT</c>
    /// </remarks>
    /// <param name="argument">QuitArgs</param>
    public delegate void Quit(QuitArgs argument);

    /// <summary>
    ///     Delegate gets called when a user in the notify list connects to the IServer
    /// </summary>
    /// <remarks>
    ///     Scripted Event Equivalent: <c>on NOTIFY</c>
    /// </remarks>
    /// <param name="argument">QuitArgs</param>
    public delegate void NotifyUserOnline(NotifyUserOnlineArgs argument);

    /// <summary>
    ///     Delegate gets called when a user in the notify list disconnects from the IServer
    /// </summary>
    /// <remarks>
    ///     Scripted Event Equivalent: <c>on UNOTIFY</c>
    /// </remarks>
    /// <param name="argument">QuitArgs</param>
    public delegate void NotifyUserOffline(NotifyUserOfflineArgs argument);
}