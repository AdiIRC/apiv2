//-------------------------------------------------------------------------------
//  Delegates related to Channel specific interactions
//  Delegates for various channel messages can be found at /Delegates/ChannelMessages.cs
//  Delegates related to channel modes can be found at /Delegates/ChannelModes.cs
//-------------------------------------------------------------------------------

namespace AdiIRCAPIv2.Delegates
{
    using Arguments.Channel;

    /// <summary>
    ///     Delegate gets called when a IChannelUser joins a channel
    /// </summary>
    /// <remarks>
    ///     Scripted Event Equivalent: <c>on JOIN</c>
    /// </remarks>
    /// <param name="argument">ChannelJoinArgs</param>
    public delegate void ChannelJoin(ChannelJoinArgs argument);

    /// <summary>
    ///     Delegate gets called when a IChannelUser changes the channel's topic
    /// </summary>
    /// <remarks>
    ///     Scripted Event Equivalent: <c>on TOPIC</c>
    /// </remarks>
    /// <param name="argument">ChannelTopicArgs</param>
    public delegate void ChannelTopic(ChannelTopicArgs argument);

    /// <summary>
    ///     Delegate gets called when a user receives an invite to an IChannelInvite
    /// </summary>
    /// <remarks>
    ///     This it not to be confused with /Delegates/Contextless.cs#ChannelInviteReceived
    /// </remarks>
    /// <param name="argument">ChannelInvitedUserArgs</param>
    public delegate void UserInvitedToChannel(UserInvitedToChannelArgs argument);

    /// <summary>
    ///     Delegate gets called when a IChannelUser is kicked from IChannel
    /// </summary>
    /// <remarks>
    ///     Scripted Event Equivalent: <c>on KICK</c>
    /// </remarks>
    /// <param name="argument">ChannelKickArgs</param>
    public delegate void ChannelKick(ChannelKickArgs argument);

    /// <summary>
    ///     Delegate gets called when a IChannelUser parts a IChannel
    /// </summary>
    /// <remarks>
    ///     Scripted Event Equivalent: <c>on PART</c>
    /// </remarks>
    /// <param name="argument">ChannelPartArgs</param>
    public delegate void ChannelPart(ChannelPartArgs argument);
}