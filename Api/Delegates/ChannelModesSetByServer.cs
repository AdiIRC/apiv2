//-------------------------------------------------------------------------------
//  Delegates that get called when a server sets a channel mode
//-------------------------------------------------------------------------------

namespace AdiIRCAPIv2.Delegates
{
    using Arguments.ChannelServerModes;

    /// <summary>
    ///     Delegate gets called when a IChannel recieves a MODE event by a server
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The modes and parameters are not parsed
    ///     </para><para>
    ///         Scripted Event Equivalent: <c>on SERVERMODE</c>
    ///     </para>
    /// </remarks>
    /// <param name="argument">ChannelRawServerModeArgs</param>
    public delegate void ChannelRawServerMode(ChannelRawServerModeArgs argument);

    /// <summary>
    ///     Delegate gets called for each mode applied to the IChannel by a server
    /// </summary>
    /// <remarks>
    ///     User-status related modes are not included
    /// </remarks>
    /// <param name="argument">ChannelServerModeArgs</param>
    public delegate void ChannelServerMode(ChannelServerModeArgs argument);

    /// <summary>
    ///     Delegate gets called when a user is owner'ed in an IChannel by a server
    /// </summary>
    /// <param name="argument">ChannelServerModeUserOwneredArgs</param>
    public delegate void ChannelServerModeUserOwnered(ChannelServerModeUserOwneredArgs argument);

    /// <summary>
    ///     Delegate gets called when a user is de-owner'ed in an IChannel by a server
    /// </summary>
    /// <param name="argument">ChannelServerModeUserDeowneredArgs</param>
    public delegate void ChannelServerModeUserDeownered(ChannelServerModeUserDeowneredArgs argument);

    /// <summary>
    ///     Delegate gets called when a user is admin'ed in an IChannel by a server
    /// </summary>
    /// <param name="argument">ChannelServerModeUserAdminedArgs</param>
    public delegate void ChannelServerModeUserAdmined(ChannelServerModeUserAdminedArgs argument);

    /// <summary>
    ///     Delegate gets called when a user is de-admin'ed in an IChannel
    /// </summary>
    /// <param name="argument">ChannelServerModeUserDeadminedArgs</param>
    public delegate void ChannelServerModeUserDeadmined(ChannelServerModeUserDeadminedArgs argument);

    /// <summary>
    ///     Delegate gets called when a user is op'ed in an IChannel
    /// </summary>
    /// <remarks>
    ///     Scripted Event Equivalent: <c>on SERVEROP</c>
    /// </remarks>
    /// <param name="argument">ChannelServerModeUserOppedArgs</param>
    public delegate void ChannelServerModeUserOpped(ChannelServerModeUserOppedArgs argument);

    /// <summary>
    ///     Delegate gets called when a user is de-op'ed in an IChannel
    /// </summary>
    /// <param name="argument">ChannelServerModeUserDeoppedArgs</param>
    public delegate void ChannelServerModeUserDeopped(ChannelServerModeUserDeoppedArgs argument);

    /// <summary>
    ///     Delegate gets called when a user is halfop'ed in an IChannel by a server
    /// </summary>
    /// <param name="argument">ChannelServerModeUserHalfOppedArgs</param>
    public delegate void ChannelServerModeUserHalfOpped(ChannelServerModeUserHalfOppedArgs argument);

    /// <summary>
    ///     Delegate gets called when a user is de-halfop'ed in an IChannel by a server
    /// </summary>
    /// <param name="argument">ChannelServerModeUserDehalfOppedArgs</param>
    public delegate void ChannelServerModeUserDehalfOpped(ChannelServerModeUserDehalfOppedArgs argument);

    /// <summary>
    ///     Delegate gets called when a user is voiced'ed in an IChannel by a server
    /// </summary>
    /// <param name="argument">ChannelServerModeUserVoicedArgs</param>
    public delegate void ChannelServerModeUserVoiced(ChannelServerModeUserVoicedArgs argument);

    /// <summary>
    ///     Delegate gets called when a user is devoiced in an IChannel by a server
    /// </summary>
    /// <param name="argument">ChannelServerModeUserDevoicedArgs</param>
    public delegate void ChannelServerModeUserDevoiced(ChannelServerModeUserDevoicedArgs argument);

    /// <summary>
    ///     Delegate gets called when a ban is set(typically mode +b) for an IChannel
    /// </summary>
    /// <remarks>
    ///     <para>
    ///        This delegate gets called for each ban set in a received MODE event
    ///     </para><para>
    ///         Scripted Event Equivalent: <c>on BAN</c>
    ///     </para>
    /// </remarks>
    /// <param name="argument">ChannelServerModeListBanArgs</param>
    public delegate void ChannelServerModeListBan(ChannelServerModeListBanArgs argument);

    /// <summary>
    ///     Delegate gets called when a ban is unset(typically mode -b) for an IChannel
    /// </summary>
    /// <remarks>
    ///     <para>
    ///        This delegate gets called for each ban unset in a received MODE event
    ///     </para><para>
    ///         Scripted Event Equivalent: <c>on UNBAN</c>
    ///     </para>
    /// </remarks>
    /// <param name="argument">ChannelServerModeListUnbanArgs</param>
    public delegate void ChannelServerModeListUnban(ChannelServerModeListUnbanArgs argument);

    /// <summary>
    ///     Delegate gets called when a ban exempt is set(typically mode +e) for an IChannel
    /// </summary>
    /// <remarks>
    ///     This delegate gets called for each ban exemption set in a received MODE event
    /// </remarks>
    /// <param name="argument">ChannelModeListBanExemptArgs</param>
    public delegate void ChannelServerModeListBanExempt(ChannelServerModeListBanExemptArgs argument);

    /// <summary>
    ///     Delegate gets called when a ban exempt is set(typically mode -e) for an IChannel
    /// </summary>
    /// <remarks>
    ///     This delegate gets called for each ban-exempt unset in a received MODE event
    /// </remarks>
    /// <param name="argument">ChannelServerModeListBanUnexemptArgs</param>
    public delegate void ChannelServerModeListBanUnexempt(ChannelServerModeListBanUnexemptArgs argument);

    /// <summary>
    ///     Delegate gets called when a quiet-ban is set(typically mode +q) for an IChannel
    /// </summary>
    /// <remarks>
    ///     This delegate gets called for each quiet-ban set in a received MODE event
    /// </remarks>
    /// <param name="argument">ChannelServerModeListQuietArgs</param>
    public delegate void ChannelServerModeListQuiet(ChannelServerModeListQuietArgs argument);

    /// <summary>
    ///     Delegate gets called when a quiet-ban is unset(typically mode -q) for an IChannel
    /// </summary>
    /// <remarks>
    ///     This delegate gets called for each quiet-ban unset in a received MODE event
    /// </remarks>
    /// <param name="argument">ChannelServerModeListUnquietArgs</param>
    public delegate void ChannelServerModeListUnquiet(ChannelServerModeListUnquietArgs argument);

    /// <summary>
    ///     Delegate gets called when a invite-exempt is set(typically mode +I) for an IChannel
    /// </summary>
    /// <remarks>
    ///     This delegate gets called for each invite-exempt set in a received MODE event
    /// </remarks>
    /// <param name="argument">ChannelServerModeListInviteExemptArgs</param>
    public delegate void ChannelServerModeListInviteExempt(ChannelServerModeListInviteExemptArgs argument);

    /// <summary>
    ///     Delegate gets called when a invite-exempt is unset(typically mode -I) for an IChannel
    /// </summary>
    /// <remarks>
    ///     This delegate gets called for each invite-exempt unset in a received MODE event
    /// </remarks>
    /// <param name="argument">ChannelServerModeListInviteUnexemptArgs</param>
    public delegate void ChannelServerModeListInviteUnexempt(ChannelServerModeListInviteUnexemptArgs argument);
}