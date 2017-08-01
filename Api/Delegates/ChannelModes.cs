/// <summary>
///     Delegates related specifically to channel mode changes
/// </summary>
namespace AdiIRCAPIv2.Delegates
{
    using Arguments.ChannelModes;

    /// <summary>
    ///     Delegate gets called when a IChannel recieves a MODE message
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The modes and parameters are not parsed
    ///     </parm><para>
    ///         Scripted Event Equivalent: <c>on RAWMODE</c>
    ///     </para>
    /// </remarks>
    /// <param name="argument">ChannelRawModeArgs</param>
    public delegate void ChannelRawMode(ChannelRawModeArgs argument);

    /// <summary>
    ///     Delegate gets called for each mode applied to an IChannel
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         User-status related modes are not included
    ///     </para><para>
    ///         Scripted Event Equivalent: <c>on MODE</c>
    ///     </para>
    /// </remarks>
    /// <param name="argument">ChannelModeArgs</param>
    public delegate void ChannelMode(ChannelModeArgs argument);

    /// <summary>
    ///     Delegate gets called when a user is owner'ed in an IChannel
    /// </summary>
    /// <remarks>
    ///     Scripted Event Equivalent: <c>on OWNER</c>
    /// </remarks>
    /// <param name="argument">ChannelModeUserOwneredArgs</param>
    public delegate void ChannelModeUserOwnered(ChannelModeUserOwneredArgs argument);

    /// <summary>
    ///     Delegate gets called when a user is de-owner'ed in an IChannel
    /// </summary>
    /// <remarks>
    ///     Scripted Event Equivalent: <c>on DEOWNER</c>
    /// </remarks>
    /// <param name="argument">ChannelModeUserDeowneredArgs</param>
    public delegate void ChannelModeUserDeownered(ChannelModeUserDeowneredArgs argument);

    /// <summary>
    ///     Delegate gets called when a user is admin'ed in an IChannel
    /// </summary>
    /// <remarks>
    ///     Scripted Event Equivalent: <c>on ADMIN</c>
    /// </remarks>
    /// <param name="argument">ChannelModeUserAdminedArgs</param>
    public delegate void ChannelModeUserAdmined(ChannelModeUserAdminedArgs argument);

    /// <summary>
    ///     Delegate gets called when a user is de-admin'ed in an IChannel
    /// </summary>
    /// <remarks>
    ///     Scripted Event Equivalent: <c>on DEADMIN</c>
    /// </remarks>
    /// <param name="argument">ChannelModeUserDeadminedArgs</param>
    public delegate void ChannelModeUserDeadmined(ChannelModeUserDeadminedArgs argument);

    /// <summary>
    ///     Delegate gets called when a user is op'ed in an IChannel
    /// </summary>
    /// <remarks>
    ///     Scripted Event Equivalent: <c>on OP</c>
    /// </remarks>
    /// <param name="argument">ChannelModeUserOppedArgs</param>
    public delegate void ChannelModeUserOpped(ChannelModeUserOppedArgs argument);

    /// <summary>
    ///     Delegate gets called when a user is de-op'ed in an IChannel
    /// </summary>
    /// <remarks>
    ///     Scripted Event Equivalent: <c>on DEOP</c>
    /// </remarks>
    /// <param name="argument">ChannelModeUserDeoppedArgs</param>
    public delegate void ChannelModeUserDeopped(ChannelModeUserDeoppedArgs argument);

    /// <summary>
    ///     Delegate gets called when a user is halfop'ed in an IChannel
    /// </summary>
    /// <remarks>
    ///     Scripted Event Equivalent: <c>on HELP</c>
    /// </remarks>
    /// <param name="argument">ChannelModeUserHalfOppedArgs</param>
    public delegate void ChannelModeUserHalfOpped(ChannelModeUserHalfOppedArgs argument);

    /// <summary>
    ///     Delegate gets called when a user is de-halfop'ed in an IChannel
    /// </summary>
    /// <remarks>
    ///     Scripted Event Equivalent: <c>on DEHELP</c>
    /// </remarks>
    /// <param name="argument">ChannelModeUserDehalfOppedArgs</param>
    public delegate void ChannelModeUserDehalfOpped(ChannelModeUserDehalfOppedArgs argument);

    /// <summary>
    ///     Delegate gets called when a user is voiced'ed in an IChannel
    /// </summary>
    /// <remarks>
    ///     Scripted Event Equivalent: <c>on VOICE</c>
    /// </remarks>
    /// <param name="argument">ChannelModeUserVoicedArgs</param>
    public delegate void ChannelModeUserVoiced(ChannelModeUserVoicedArgs argument);

    /// <summary>
    ///     Delegate gets called when a user is devoiced in an IChannel
    /// </summary>
    /// <remarks>
    ///     Scripted Event Equivalent: <c>on DEVOICE</c>
    /// </remarks>
    /// <param name="argument">ChannelModeUserDevoicedArgs</param>
    public delegate void ChannelModeUserDevoiced(ChannelModeUserDevoicedArgs argument);

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
    /// <param name="argument">ChannelModeListBanArgs</param>
    public delegate void ChannelModeListBan(ChannelModeListBanArgs argument);

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
    /// <param name="argument">ChannelModeListUnbanArgs</param>
    public delegate void ChannelModeListUnban(ChannelModeListUnbanArgs argument);

    /// <summary>
    ///     Delegate gets called when a ban exempt is set(typically mode +e) for an IChannel
    /// </summary>
    /// <remarks>
    ///     This delegate gets called for each ban exemption set in a received MODE event
    /// </remarks>
    /// <param name="argument">ChannelModeListBanExemptArgs</param>
    public delegate void ChannelModeListBanExempt(ChannelModeListBanExemptArgs argument);

    /// <summary>
    ///     Delegate gets called when a ban exempt is set(typically mode -e) for an IChannel
    /// </summary>
    /// <remarks>
    ///     This delegate gets called for each ban-exempt unset in a received MODE event
    /// </remarks>
    /// <param name="argument">ChannelModeListBanUnexemptArgs</param>
    public delegate void ChannelModeListBanUnexempt(ChannelModeListBanUnexemptArgs argument);

    /// <summary>
    ///     Delegate gets called when a quiet-ban is set(typically mode +q) for an IChannel
    /// </summary>
    /// <remarks>
    ///     This delegate gets called for each quiet-ban set in a received MODE event
    /// </remarks>
    /// <param name="argument">ChannelModeListQuietArgs</param>
    public delegate void ChannelModeListQuiet(ChannelModeListQuietArgs argument);

    /// <summary>
    ///     Delegate gets called when a quiet-ban is unset(typically mode -q) for an IChannel
    /// </summary>
    /// <remarks>
    ///     This delegate gets called for each quiet-ban unset in a received MODE event
    /// </remarks>
    /// <param name="argument">ChannelModeListUnquietArgs</param>
    public delegate void ChannelModeListUnquiet(ChannelModeListUnquietArgs argument);

    /// <summary>
    ///     Delegate gets called when a invite-exempt is set(typically mode +I) for an IChannel
    /// </summary>
    /// <remarks>
    ///     This delegate gets called for each invite-exempt set in a received MODE event
    /// </remarks>
    /// <param name="argument">ChannelModeListInviteExemptArgs</param>
    public delegate void ChannelModeListInviteExempt(ChannelModeListInviteExemptArgs argument);

    /// <summary>
    ///     Delegate gets called when a invite-exempt is unset(typically mode -I) for an IChannel
    /// </summary>
    /// <remarks>
    ///     This delegate gets called for each invite-exempt unset in a received MODE event
    /// </remarks>
    /// <param name="argument">ChannelModeListInviteUnexemptArgs</param>
    public delegate void ChannelModeListInviteUnexempt(ChannelModeListInviteUnexemptArgs argument);
}