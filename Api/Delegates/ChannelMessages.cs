//-------------------------------------------------------------------------------
//  Delegates related specifically to received channel messages
//-------------------------------------------------------------------------------

namespace AdiIRCAPIv2.Delegates
{
    using Arguments.ChannelMessages;

    /// <summary>
    ///     Delegate gets called when an IChannel receives a message
    /// </summary>
    /// <remarks>
    ///     Scripted Event Equivalent: <c>on TEXT</c>
    /// </remarks>
    /// <param name="argument">ChannelNormalMessageArgs</param>
    public delegate void ChannelNormalMessage(ChannelNormalMessageArgs argument);

    /// <summary>
    ///     Delegate gets called when an IChannel receives a channel action message
    /// </summary>
    /// <remarks>
    ///     Scripted Event Equivalent: <c>on ACTION</c>
    /// </remarks>
    /// <param name="argument">ChannelActionMessageArgs</param>
    public delegate void ChannelActionMessage(ChannelActionMessageArgs argument);

    /// <summary>
    ///     Delegate gets called when a IChannel receives a notice
    /// </summary>
    /// <remarks>
    ///     Scripted Event Equivalent: <c>on NOTICE</c>
    /// </remarks>
    /// <param name="argument">ChannelNoticeMessageArgs</param>>
    public delegate void ChannelNoticeMessage(ChannelNoticeMessageArgs argument);

    /// <summary>
    ///     Delegate gets called when a IChannel receives a CTCP message
    /// </summary>
    /// <remarks>
    ///     Scripted Event Equivalent: <c>on CTCP</c>
    /// </remarks>
    /// <param name="argument">ChannelCtcpMessageArgs</param>
    public delegate void ChannelCtcpMessage(ChannelCtcpMessageArgs argument);

    /// <summary>
    ///     Delegate gets called when a IChannel receives a CTCP Reply message
    /// </summary>
    /// <remarks>
    ///     Scripted Event Equivalent: <c>on CTCPREPLY</c>
    /// </remarks>
    /// <param name="argument">ChannelCtcpReplyMessageArgs</param>
    public delegate void ChannelCtcpReplyMessage(ChannelCtcpReplyMessageArgs argument);

}