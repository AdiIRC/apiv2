/// <summary>
///     Delegates related to when your IUser receives a direct message
/// </summary>
namespace AdiIRCAPIv2.Delegates
{
    using Arguments.PrivateMessages;

    /// <summary>
    ///     Delegate gets called when your IUser receives a server-sent notice
    /// </summary>
    /// <remarks>
    ///     Scripted Event Equivalent: <c>on SNOTICE</c>
    /// </remarks>
    /// <param name="argument">ServerNoticeMessageArgs</param>
    public delegate void ServerNoticeMessage(ServerNoticeMessageArgs argument);

    /// <summary>
    ///     Delegate gets called when your IUser receives a server-sent ERROR message
    /// </summary>
    /// <remarks>
    ///     Scripted Event Equivalent: <c>on ERROR</c>
    /// </remarks>
    /// <param name="argument">ServerErrorMessageArgs</param>
    public delegate void ServerErrorMessage(ServerErrorMessageArgs argument);

    /// <summary>
    ///     Delegate gets called when your IUser receives a private message
    /// </summary>
    /// <remarks>
    ///     Scripted Event Equivalent: <c>on TEXT</c>
    /// </remarks>
    /// <param name="argument">PrivateNormalMessageArgs</param>
    public delegate void PrivateNormalMessage(PrivateNormalMessageArgs argument);

    /// <summary>
    ///     Delegate gets called when your IUser receives a private action message
    /// </summary>
    /// <remarks>
    ///     Scripted Event Equivalent: <c>on ACTION</c>
    /// </remarks>
    /// <param name="argument">PrivateActionMessageArgs</param>
    public delegate void PrivateActionMessage(PrivateActionMessageArgs argument);

    /// <summary>
    ///     Delegate gets called when your IUser receives a private notice
    /// </summary>
    /// <remarks>
    ///     Scripted Event Equivalent: <c>on NOTICE</c>
    /// </remarks>
    /// <param name="argument">PrivateNoticeMessageArgs</param>
    public delegate void PrivateNoticeMessage(PrivateNoticeMessageArgs argument);

    /// <summary>
    ///     Delegate gets called when your IUser receives a private CTCP message
    /// </summary>
    /// <remarks>
    ///     Scripted Event Equivalent: <c>on CTCP</c>
    /// </remarks>
    /// <param name="argument">PrivateCtcpMessageArgs</param>
    public delegate void PrivateCtcpMessage(PrivateCtcpMessageArgs argument);

    /// <summary>
    ///     Delegate gets called when your IUser receives a private CTCP Reply message
    /// </summary>
    /// <remarks>
    ///     Scripted Event Equivalent: <c>on CTCPREPLY</c>
    /// </remarks>
    /// <param name="argument">PrivateCtcpReplyMessageArgs</param>
    public delegate void PrivateCtcpReplyMessage(PrivateCtcpReplyMessageArgs argument);
}