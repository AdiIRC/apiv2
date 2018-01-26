namespace AdiIRCAPIv2.Interfaces
{
    using System;
    using System.Collections;
    using Delegates;

    /// <summary>
    /// Overall plugin manager
    /// </summary>
    public interface IPluginHost
    {
        #region Aliasing
        /// <summary>
        ///     Delegate gets called when a scripted signal is emitted
        /// </summary>
        /// <remarks>
        ///     Scripted Event Equivalent: <c>on SIGNAL</c>
        /// </remarks>
        event ScriptSignalEvent OnScriptSignalEvent;

        #endregion

        #region Application
        /// <summary>
        ///     Delegate gets called after all plugins and scripts have been initialized
        /// </summary>
        /// <remarks>
        ///     Scripted Event Equivalent: <c>on START</c>
        /// </remarks>
        event ApplicationStarted OnApplicationStarted;

        /// <summary>
        ///     Delegate gets called when AdiIRC receives or loses focus
        /// </summary>
        /// <remarks>
        ///     Scripted Event Equivalent: <c>on APPACTIVE</c>
        /// </remarks>
        event ApplicationFocusChanged OnApplicationFocusChanged;

        /// <summary>
        ///     Delegate gets called when the host OS goes into sleep/hibernation mode
        /// </summary>
        /// <remarks>
        ///     Scripted Event Equivalent: <c>on SUSPEND</c>
        /// </remarks>
        event ApplicationHostSuspended OnApplicationHostSuspended;

        /// <summary>
        ///     Delegate gets called when the host OS comes back from sleep/hibernation mode
        /// </summary>
        /// <remarks>
        ///     Scripted Event Equivalent: <c>on RESUME</c>
        /// </remarks>
        event ApplicationHostWoken OnApplicationHostWoken;

        /// <summary>
        ///     Delegate gets called when AdiIRC is closing
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         Called before the plugin's .Dispose() method
        ///     </para><para>
        ///         Scripted Event Equivalent: <c>on EXIT</c>
        ///     </para>
        /// </remarks>
        event ApplicationClosing OnApplicationClosing;

        /// <summary>
        ///     Delegate gets called when the user changes a options and the config file is reloaded
        /// </summary>
        /// <remarks>
        ///     Scripted Event Equivalent: <c>on OPTIONS</c>
        /// </remarks>
        event ApplicationOptionsChanged OnApplicationOptionsChanged;
        #endregion

        #region Channel

        /// <summary>
        ///     Delegate gets called when a IChannelUser joines a IChannel
        /// </summary>
        /// <remarks>
        ///     Scripted Event Equivalent: <c>on JOIN</c>
        /// </remarks>
        event ChannelJoin OnChannelJoin;

        /// <summary>
        ///     Delegate gets called when a IChannelUser changes topic in IChannel
        /// </summary>
        /// <remarks>
        ///     Scripted Event Equivalent: <c>on TOPIC</c>
        /// </remarks>
        event ChannelTopic OnChannelTopic;

        /// <summary>
        ///     Delegate gets called when a user on IChannel revices an invite.
        /// </summary>
        event UserInvitedToChannel OnUserInvitedToChannel;

        /// <summary>
        ///     Delegate gets called when a IChannelUser is kicked from IChannel
        /// </summary>
        /// <remarks>
        ///     Scripted Event Equivalent: <c>on KICK</c>
        /// </remarks>
        event ChannelKick OnChannelKick;

        /// <summary>
        ///     Delegate gets called when a IChannelUser parts a IChannel
        /// </summary>
        /// <remarks>
        ///     Scripted Event Equivalent: <c>on PART</c>
        /// </remarks>
        event ChannelPart OnChannelPart;
        #endregion

        #region ChannelMessages
        /// <summary>
        ///     Delegate gets called when a IChannel revices a message
        /// </summary>
        /// <remarks>
        ///     Scripted Event Equivalent: <c>on TEXT</c>
        /// </remarks>
        event ChannelNormalMessage OnChannelNormalMessage;

        /// <summary>
        ///     Delegate gets called when your IUser recives a channel action message
        /// </summary>
        /// <remarks>
        ///     Scripted Event Equivalent: <c>on ACTION</c>
        /// </remarks>
        event ChannelActionMessage OnChannelActionMessage;

        /// <summary>
        ///     Delegate gets called when a IChannel recives a notice
        /// </summary>
        /// <remarks>
        ///     Scripted Event Equivalent: <c>on NOTICE</c>
        /// </remarks>
        event ChannelNoticeMessage OnChannelNoticeMessage;

        /// <summary>
        ///     Delegate gets called when a IChannel receives a CTCP message
        /// </summary>
        /// <remarks>
        ///     Scripted Event Equivalent: <c>on CTCP</c>
        /// </remarks>
        event ChannelCtcpMessage OnChannelCtcpMessage;

        /// <summary>
        ///     Delegate gets called when a IChannel receives a CTCP Reply message
        /// </summary>
        /// <remarks>
        ///     Scripted Event Equivalent: <c>on CTCPREPLY</c>
        /// </remarks>
        event ChannelCtcpReplyMessage OnChannelCtcpReplyMessage;
        #endregion

        #region ChannelModes

        /// <summary>
        ///     Delegate gets called when a IChannel recieves a MODE message
        /// </summary>
        /// <remarks>
        ///     <param>
        ///         The modes and parameters are not parsed
        ///     </param><param>
        ///         Scripted Event Equivalent: <c>on RAWMODE</c>
        ///     </param>
        /// </remarks>
        event ChannelRawMode OnChannelRawMode;

        /// <summary>
        ///     Delegate gets called for each mode applied to an IChannel
        /// </summary>
        /// <remarks>
        ///     <param>
        ///         User-status related modes are not included
        ///     </param><param>
        ///         Scripted Event Equivalent: <c>on MODE</c>
        ///     </param>
        /// </remarks>
        event ChannelMode OnChannelMode;

        /// <summary>
        ///     Delegate gets called when a user is owner'ed in an IChannel
        /// </summary>
        /// <remarks>
        ///     Scripted Event Equivalent: <c>on OWNER</c>
        /// </remarks>
        event ChannelModeUserOwnered OnChannelModeUserOwnered;

        /// <summary>
        ///     Delegate gets called when a user is de-owner'ed in an IChannel
        /// </summary>
        /// <remarks>
        ///     Scripted Event Equivalent: <c>on DEOWNER</c>
        /// </remarks>
        event ChannelModeUserDeownered OnChannelModeUserDeownered;

        /// <summary>
        ///     Delegate gets called when a user is admin'ed in an IChannel
        /// </summary>
        /// <remarks>
        ///     Scripted Event Equivalent: <c>on ADMIN</c>
        /// </remarks>
        event ChannelModeUserAdmined OnChannelModeUserAdmined;

        /// <summary>
        ///     Delegate gets called when a user is de-admin'ed in an IChannel
        /// </summary>
        /// <remarks>
        ///     Scripted Event Equivalent: <c>on DEADMIN</c>
        /// </remarks>
        event ChannelModeUserDeadmined OnChannelModeUserDeadmined;

        /// <summary>
        ///     Delegate gets called when a user is op'ed in an IChannel
        /// </summary>
        /// <remarks>
        ///     Scripted Event Equivalent: <c>on OP</c>
        /// </remarks>
        event ChannelModeUserOpped OnChannelModeUserOpped;

        /// <summary>
        ///     Delegate gets called when a user is de-op'ed in an IChannel
        /// </summary>
        /// <remarks>
        ///     Scripted Event Equivalent: <c>on DEOP</c>
        /// </remarks>
        event ChannelModeUserDeopped OnChannelModeUserDeopped;

        /// <summary>
        ///     Delegate gets called when a user is halfop'ed in an IChannel
        /// </summary>
        /// <remarks>
        ///     Scripted Event Equivalent: <c>on HELP</c>
        /// </remarks>
        event ChannelModeUserHalfOpped OnChannelModeUserHalfOpped;

        /// <summary>
        ///     Delegate gets called when a user is de-halfop'ed in an IChannel
        /// </summary>
        /// <remarks>
        ///     Scripted Event Equivalent: <c>on DEHELP</c>
        /// </remarks>
        event ChannelModeUserDehalfOpped OnChannelModeUserDehalfOpped;

        /// <summary>
        ///     Delegate gets called when a user is voiced'ed in an IChannel
        /// </summary>
        /// <remarks>
        ///     Scripted Event Equivalent: <c>on VOICE</c>
        /// </remarks>
        event ChannelModeUserVoiced OnChannelModeUserVoiced;

        /// <summary>
        ///     Delegate gets called when a user is devoiced in an IChannel
        /// </summary>
        /// <remarks>
        ///     Scripted Event Equivalent: <c>on DEVOICE</c>
        /// </remarks>
        event ChannelModeUserDevoiced OnChannelModeUserDevoiced;

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
        event ChannelModeListBan OnChannelModeListBan;

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
        event ChannelModeListUnban OnChannelModeListUnban;

        /// <summary>
        ///     Delegate gets called when a ban exempt is set(typically mode +e) for an IChannel
        /// </summary>
        /// <remarks>
        ///     This delegate gets called for each ban exemption set in a received MODE event
        /// </remarks>
        event ChannelModeListBanExempt OnChannelModeListBanExempt;

        /// <summary>
        ///     Delegate gets called when a ban exempt is set(typically mode -e) for an IChannel
        /// </summary>
        /// <remarks>
        ///     This delegate gets called for each ban-exempt unset in a received MODE event
        /// </remarks>
        event ChannelModeListBanUnexempt OnChannelModeListBanUnexempt;

        /// <summary>
        ///     Delegate gets called when a quiet-ban is set(typically mode +q) for an IChannel
        /// </summary>
        /// <remarks>
        ///     This delegate gets called for each quiet-ban set in a received MODE event
        /// </remarks>
        event ChannelModeListQuiet OnChannelModeListQuiet;

        /// <summary>
        ///     Delegate gets called when a quiet-ban is unset(typically mode -q) for an IChannel
        /// </summary>
        /// <remarks>
        ///     This delegate gets called for each quiet-ban unset in a received MODE event
        /// </remarks>
        event ChannelModeListUnquiet OnChannelModeListUnquiet;

        /// <summary>
        ///     Delegate gets called when a invite-exempt is set(typically mode +I) for an IChannel
        /// </summary>
        /// <remarks>
        ///     This delegate gets called for each invite-exempt set in a received MODE event
        /// </remarks>
        event ChannelModeListInviteExempt OnChannelModeListInviteExempt;

        /// <summary>
        ///     Delegate gets called when a invite-exempt is unset(typically mode -I) for an IChannel
        /// </summary>
        /// <remarks>
        ///     This delegate gets called for each invite-exempt unset in a received MODE event
        /// </remarks>
        event ChannelModeListInviteUnexempt OnChannelModeListInviteUnexempt;
        #endregion

        #region ChannelServerModes

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
        event ChannelRawServerMode OnChannelRawServerMode;

        /// <summary>
        ///     Delegate gets called for each mode applied to the IChannel by a server
        /// </summary>
        /// <remarks>
        ///     User-status related modes are not included
        /// </remarks>
        event ChannelServerMode OnChannelServerMode;

        /// <summary>
        ///     Delegate gets called when a user is owner'ed in an IChannel by a server
        /// </summary>
        event ChannelServerModeUserOwnered OnChannelServerModeUserOwnered;

        /// <summary>
        ///     Delegate gets called when a user is de-owner'ed in an IChannel by a server
        /// </summary>
        event ChannelServerModeUserDeownered OnChannelServerModeUserDeownered;

        /// <summary>
        ///     Delegate gets called when a user is admin'ed in an IChannel by a server
        /// </summary>
        event ChannelServerModeUserAdmined OnChannelServerModeUserAdmined;

        /// <summary>
        ///     Delegate gets called when a user is de-admin'ed in an IChannel
        /// </summary>
        event ChannelServerModeUserDeadmined OnChannelServerModeUserDeadmined;

        /// <summary>
        ///     Delegate gets called when a user is op'ed in an IChannel
        /// </summary>
        /// <remarks>
        ///     Scripted Event Equivalent: <c>on SERVEROP</c>
        /// </remarks>
        event ChannelServerModeUserOpped OnChannelServerModeUserOpped;

        /// <summary>
        ///     Delegate gets called when a user is de-op'ed in an IChannel
        /// </summary>
        event ChannelServerModeUserDeopped OnChannelServerModeUserDeopped;

        /// <summary>
        ///     Delegate gets called when a user is halfop'ed in an IChannel by a server
        /// </summary>
        event ChannelServerModeUserHalfOpped OnChannelServerModeUserHalfOpped;

        /// <summary>
        ///     Delegate gets called when a user is de-halfop'ed in an IChannel by a server
        /// </summary>
        event ChannelServerModeUserDehalfOpped OnChannelServerModeUserDehalfOpped;

        /// <summary>
        ///     Delegate gets called when a user is voiced'ed in an IChannel by a server
        /// </summary>
        event ChannelServerModeUserVoiced OnChannelServerModeUserVoiced;

        /// <summary>
        ///     Delegate gets called when a user is devoiced in an IChannel by a server
        /// </summary>
        event ChannelServerModeUserDevoiced OnChannelServerModeUserDevoiced;

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
        event ChannelServerModeListBan OnChannelServerModeListBan;

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
        event ChannelServerModeListUnban OnChannelServerModeListUnban;

        /// <summary>
        ///     Delegate gets called when a ban exempt is set(typically mode +e) for an IChannel
        /// </summary>
        /// <remarks>
        ///     This delegate gets called for each ban exemption set in a received MODE event
        /// </remarks>
        event ChannelServerModeListBanExempt OnChannelServerModeListBanExempt;

        /// <summary>
        ///     Delegate gets called when a ban exempt is set(typically mode -e) for an IChannel
        /// </summary>
        /// <remarks>
        ///     This delegate gets called for each ban-exempt unset in a received MODE event
        /// </remarks>
        event ChannelServerModeListBanUnexempt OnChannelServerModeListBanUnexempt;

        /// <summary>
        ///     Delegate gets called when a quiet-ban is set(typically mode +q) for an IChannel
        /// </summary>
        /// <remarks>
        ///     This delegate gets called for each quiet-ban set in a received MODE event
        /// </remarks>
        event ChannelServerModeListQuiet OnChannelServerModeListQuiet;

        /// <summary>
        ///     Delegate gets called when a quiet-ban is unset(typically mode -q) for an IChannel
        /// </summary>
        /// <remarks>
        ///     This delegate gets called for each quiet-ban unset in a received MODE event
        /// </remarks>
        event ChannelServerModeListUnquiet OnChannelServerModeListUnquiet;

        /// <summary>
        ///     Delegate gets called when a invite-exempt is set(typically mode +I) for an IChannel
        /// </summary>
        /// <remarks>
        ///     This delegate gets called for each invite-exempt set in a received MODE event
        /// </remarks>
        event ChannelServerModeListInviteExempt OnChannelServerModeListInviteExempt;

        /// <summary>
        ///     Delegate gets called when a invite-exempt is unset(typically mode -I) for an IChannel
        /// </summary>
        /// <remarks>
        ///     This delegate gets called for each invite-exempt unset in a received MODE event
        /// </remarks>
        event ChannelServerModeListInviteUnexempt OnChannelServerModeListInviteUnexempt;
        #endregion

        #region Connection

        /// <summary>
        ///     Delegate gets called when an IServer's underlying socket fails to connect
        /// </summary>
        /// <remarks>
        ///     Scripted Event Equivalent: <c>on CONNECTFAIL</c>
        /// </remarks>
        event ConnectFailure OnConnectFailure;

        /// <summary>
        ///     Delegate gets called when an IServer's underlying socket successfully connects
        /// </summary>
        /// <remarks>
        ///     Scripted Event Equivalent: <c>on CONNECT</c>
        /// </remarks>
        event Connect OnConnect;

        /// <summary>
        ///     Delegate gets called when an IServer's underlying socket is closed
        /// </summary>
        /// <remarks>
        ///     Scripted Event Equivalent: <c>on DISCONNECT</c>
        /// </remarks>
        event Disconnect OnDisconnect;

        /// <summary>
        ///     Delegate gets called when any raw data is recieved from an IServer
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         You can modify the byte array args, AdiIRC will then parse this array with the proper encoding.
        ///         If the array is set to null or zero bytes, the raw message is ignored by AdiIRC.
        ///     </para><para>
        ///         Scripted Event Equivalent: <c>on PARSELINE</c>
        ///     </para>
        /// </remarks>
        event RawBytesReceived OnRawBytesReceived;

        /// <summary>
        ///     Delegate gets called when any raw data is sent to the IServer.
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         You can modify the byte array args, AdiIRC will then parse this array with the proper encoding.
        ///         If the array is set to null or zero bytes, the raw message is ignored by AdiIRC.
        ///     </para><para>
        ///         Scripted Event Equivalent: <c>on PARSELINE</c>
        ///     </para>
        /// </remarks>
        event RawBytesSent OnRawBytesSent;

        /// <summary>
        ///     Delegate gets called when any string data is recieved from an IServer
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         You can modify the string args, AdiIRC will then parse this string.
        ///         If the array is set to "", the raw message is ignored by AdiIRC.
        ///     </para><para>
        ///         Scripted Event Equivalent: <c>on PARSELINE</c>
        ///     </para>
        /// </remarks>
        event StringDataReceived OnStringDataReceived;

        /// <summary>
        ///     Delegate gets called when any string data is sent to the IServer.
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         You can modify the string args, AdiIRC will then send the modified string to the server.
        ///         If the string is set to "", the raw message is ignored by AdiIRC.
        ///     </para><para>
        ///         Scripted Event Equivalent: <c>on PARSELINE</c>
        ///     </para>
        /// </remarks>
        event StringDataSent OnStringDataSent;

        /// <summary>
        ///     Delegate gets called after an IServer successfully logs on to an IRC server
        /// </summary>
        /// <remarks>
        ///     Scripted Event Equivalent: <c>on LOGON</c>
        /// </remarks>
        event ConnectionLogonSuccess OnConnectionLogonSuccess;

        /// <summary>
        ///     Delegate gets called when a IServer retrives a raw server message
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         AdiIRC will have already parsed the data into a string.
        ///     </para><para>
        ///         Scripted Event Equivalent: <c>on RAW</c>
        ///     </para>
        /// </remarks>
        event RawServerEventReceived OnRawServerEventReceived;

        /// <summary>
        ///     Delegate gets called when AdiIRC sends a PRIVMSG or NOTICE to a IChannel or IPrivateWindow
        /// </summary>
        /// <remarks>
        ///     Scripted Event Equivalent: overriding <c>/msg</c>, <c>/describe</c>, <c>/notice</c>, etc
        /// </remarks>
        event MessageSent OnMessageSent;

        /// <summary>
        ///     Delegate gets called when a IServer receives a PING event
        /// </summary>
        /// <remarks>
        ///     Scripted Event Equivalent: <c>on PING</c>
        /// </remarks>
        event ServerPingReceived OnServerPingReceived;

        /// <summary>
        ///     Delegate gets called when a IServer receives a PING event
        /// </summary>
        /// <remarks>
        ///     Scripted Event Equivalent: <c>on PoNG</c>
        /// </remarks>
        event ServerPongPreceived OnServerPongPreceived;
        #endregion

        #region Contextless

        /// <summary>
        ///     Delegate gets called when your IUser receives a mode event
        /// </summary>
        /// <remarks>
        ///     Scripted Event Equivalent: <c>on USERMODE</c>
        /// </remarks>
        event UserMode OnUserMode;

        /// <summary>
        ///     Delegate gets called when your IUser recives an IChannel invite
        /// </summary>
        /// <remarks>
        ///     Scripted Event Equivalent: <c>on INVITE</c>
        /// </remarks>
        event ChannelInvite OnChannelInvite;

        /// <summary>
        ///     Delegate gets called when a IUser changes their nick
        /// </summary>
        /// <remarks>
        ///     Scripted Event Equivalent: <c>on NICK</c>
        /// </remarks>
        event Nick OnNick;

        /// <summary>
        ///     Delegate gets called when a IUser quits the IServer
        /// </summary>
        /// <remarks>
        ///     Scripted Event Equivalent: <c>on QUIT</c>
        /// </remarks>
        event Quit OnQuit;

        /// <summary>
        ///     Delegate gets called when a user in the notify list connects to the IServer
        /// </summary>
        /// <remarks>
        ///     Scripted Event Equivalent: <c>on NOTIFY</c>
        /// </remarks>
        event NotifyUserOnline OnNotifyUserOnline;

        /// <summary>
        ///     Delegate gets called when a user in the notify list disconnects from the IServer
        /// </summary>
        /// <remarks>
        ///     Scripted Event Equivalent: <c>on UNOTIFY</c>
        /// </remarks>
        event NotifyUserOffline OnNotifyUserOffline;
        #endregion

        #region Dns

        /// <summary>
        ///     Delegate gets called when a Dns attempt has started
        /// </summary>
        /// <remarks>
        ///     Scripted Event Equivalent: overriding <c>/dns</c>
        /// </remarks>
        event DnsResolveStarted OnDnsResolveStarted;

        /// <summary>
        ///     Delegate gets called when a Dns attempt has finished
        /// </summary>
        /// <remarks>
        ///     Scripted Event Equivalent: <c>on DNS</c>
        /// </remarks>
        event DnsResolveEnd OnDnsResolveEnd;
        #endregion

        #region MediaPlayback

        /// <summary>
        ///     Delegate gets called when adiirc finishes playing an MIDI file
        /// </summary>
        /// <remarks>
        ///     Scripted Event Equivalent: <c>on MIDIEND</c>
        /// </remarks>
        event SoundPlayBackMidiEnd OnSoundPlayBackMidiEnd;

        /// <summary>
        ///     Delegate gets called when adiirc finishes playing an WAVE file
        /// </summary>
        /// <remarks>
        ///     Scripted Event Equivalent: <c>on WAVEEND</c>
        /// </remarks>
        event SoundPlayBackWaveEnd OnSoundPlayBackWaveEnd;

        /// <summary>
        ///     Delegate gets called when adiirc finishes playing an Mp3 file
        /// </summary>
        /// <remarks>
        ///     Scripted Event Equivalent: <c>on MP3END</c>
        /// </remarks>
        event SoundPlayBackMp3End OnSoundPlayBackMp3End;

        /// <summary>
        ///     Delegate gets called when adiirc finishes playing any sound file
        /// </summary>
        /// <remarks>
        ///     Scripted Event Equivalent: <c>on SONGEND</c>
        /// </remarks>
        event SoundPlayBackEnd OnSoundPlaybackEnd;

        /// <summary>
        ///     Delegate gets called when the selected media player begins playing a media file
        /// </summary>
        /// <remarks>
        ///     Scripted Event Equivalent: <c>on SONG</c>
        /// </remarks>
        event MediaPlayerPlaybackStarted OnMediaPlayerPlaybackStarted;
        #endregion

        #region ScriptHttpDownload

        /// <summary>
        ///     Delegate gets called when AdiIRC starts an HTTP download
        /// </summary>
        /// <remarks>
        ///     Scripted Event Equivalent: overriding <c>/download</c>
        /// </remarks>
        event ScriptHttpDownloadStarted OnScriptHttpDownloadStarted;

        /// <summary>
        ///     Delegate gets called when adiirc finishes an HTTP download
        /// </summary>
        /// <remarks>
        ///     Scripted Event Equivalent: <c>on DOWNLOAD</c>
        /// </remarks>
        event ScriptHttpDownloadEnd OnScriptHttpDownloadEnd;

        #endregion

        #region PrivateMessages

        /// <summary>
        ///     Delegate gets called when your IUser receives a server-sent notice
        /// </summary>
        /// <remarks>
        ///     Scripted Event Equivalent: <c>on SNOTICE</c>
        /// </remarks>
        event ServerNoticeMessage OnServerNoticeMessage;

        /// <summary>
        ///     Delegate gets called when your IUser receives a server-sent ERROR message
        /// </summary>
        /// <remarks>
        ///     Scripted Event Equivalent: <c>on ERROR</c>
        /// </remarks>
        event ServerErrorMessage OnServerErrorMessage;

        /// <summary>
        ///     Delegate gets called when your IUser recives a private message
        /// </summary>
        /// <remarks>
        ///     Scripted Event Equivalent: <c>on TEXT</c>
        /// </remarks>
        event PrivateNormalMessage OnPrivateNormalMessage;

        /// <summary>
        ///     Delegate gets called when your IUser recives a private action message
        /// </summary>
        /// <remarks>
        ///     Scripted Event Equivalent: <c>on ACTION</c>
        /// </remarks>
        event PrivateActionMessage OnPrivateActionMessage;

        /// <summary>
        ///     Delegate gets called when your IUser receives a notice
        /// </summary>
        /// <remarks>
        ///     Scripted Event Equivalent: <c>on NOTICE</c>
        /// </remarks>
        event PrivateNoticeMessage OnPrivateNoticeMessage;

        /// <summary>
        ///     Delegate gets called when your IUser receives a CTCP message
        /// </summary>
        /// <remarks>
        ///     Scripted Event Equivalent: <c>on CTCP</c>
        /// </remarks>
        event PrivateCtcpMessage OnPrivateCtcpMessage;

        /// <summary>
        ///     Delegate gets called when your IUser receives a CTCP Reply message
        /// </summary>
        /// <remarks>
        ///     Scripted Event Equivalent: <c>on CTCPREPLY</c>
        /// </remarks>
        event PrivateCtcpReplyMessage OnPrivateCtcpReplyMessage;
        #endregion

        #region ScriptEngine

        /// <summary>
        ///     Delegate gets called when a script is (re)loaded from the Plugins Scripts Editor or from the /load and /reload command
        /// </summary>
        event EngineScriptLoad OnEngineScriptLoad;

        /// <summary>
        ///     Delegate gets called when a script is unloaded from the Plugins Scripts Editor or from the /unload command
        /// </summary>
        event EngineScriptUnload OnEngineScriptUnload;

        #endregion

        #region WindowInteraction

        /// <summary>
        ///     Delegate gets called when any IWindow is opened
        /// </summary>
        /// <remarks>
        ///     Scripted Event Equivalent: <c>on OPEN</c>, <c>on JOIN</c>
        /// </remarks>
        event WindowOpened OnWindowOpened;

        /// <summary>
        ///     Delegate gets called when the window focus changes with in AdiIRC
        /// </summary>
        /// <remarks>
        ///     Scripted Event Equivalent: <c>on ACTIVE</c>
        /// </remarks>
        event WindowFocusChanged OnWindowFocusChanged;

        /// <summary>
        ///     Delegate gets called any IWindow is closed
        /// </summary>
        /// <remarks>
        ///     Scripted Event Equivalent: extended <c>on CLOSE</c>, <c>on PART</c>
        /// </remarks>
        event WindowClosed OnWindowClosed;

        /// <summary>
        ///     Delegate gets called any IWindow is renamed
        /// </summary>
        /// <remarks>
        ///     Usually from the commands /renwin, /queryrn or when a user in a private window changes nick.
        /// </remarks>
        event WindowRenamed OnWindowRenamed;

        /// <summary>
        ///     Delegate gets called when a menu is opened
        /// </summary>
        event Menu OnMenu;

        /// <summary>
        ///     Delegate gets called when a key is pressed down in a Editbox
        /// </summary>
        event EditboxKeyDown OnEditboxKeyDown;

        /// <summary>
        ///     Delegate gets called when a key is released in a IEditbox
        /// </summary>
        event EditboxKeyUp OnEditboxKeyUp;

        /// <summary>
        ///     Delegate gets called when a window buffer is scrolled
        /// </summary>
        event WindowBufferScrolled OnWindowBufferScrolled;

        #endregion

        #region ZipCompression

        /// <summary>
        ///     Delegate gets called after /zip is called
        /// </summary>
        /// <remarks>
        ///     Scripted Event Equivalent: overriding <c>/zip</c>
        /// </remarks>
        event ZipCompressionStarted OnZipCompressionStarted;

        /// <summary>
        ///     Delegate gets called after a file|directory has finished being zipped
        /// </summary>
        /// <remarks>
        ///     Scripted Event Equivalent: on <c>ZIP</c>
        /// </remarks>
        event ZipCompressionEnd OnZipCompressionEnd;

        /// <summary>
        ///     Delegate gets called after /unzip is called
        /// </summary>
        /// <remarks>
        ///     Scripted Event Equivalent: overriding <c>/unzip</c>
        /// </remarks>
        event ZipDecompressionStarted OnZipDecompressionStarted;

        /// <summary>
        ///     Delegate gets called after a .zip has finished being extracted
        /// </summary>
        /// <remarks>
        ///     Scripted Event Equivalent: <c>on UNZIP</c>
        /// </remarks>
        event ZipDecompressionEnd OnZipDecompressionEnd;

        #endregion

        /// <summary>
        /// Returns the main window handle.
        /// </summary>
        IntPtr MainWindowHandle { get; }

        /// <summary>
        /// Returns the current active IWindow.
        /// </summary>
        IWindow ActiveIWindow { get; }

        /// <summary>
        /// IMessagesOptions
        /// </summary>
        IMessagesOptions MessagesOptions { get; }

        /// <summary>
        /// IEditboxOptions
        /// </summary>
        IEditboxOptions EditboxOptions { get; }

        ITools Tools { get; }

        /// <summary>
        /// Returns a list of global variables which are saved across sessions.
        /// </summary>
        IDictionary GetVariables { get; }

        /// <summary>
        /// Register this plugin as a Script Engine
        /// </summary>
        /// <param name="engineName">Name of the engine to show in menus</param>
        /// <param name="fileExtension">Filextension to register for this engine</param>
        /// <returns>True/False depending if the register was successful</returns>
        bool EngineRegistration(string engineName, string fileExtension);

        /// <summary>
        /// Hook a command into AdiIRC, the handler will be triggered when the command is used.
        /// </summary>
        /// <param name="command">Name of the command</param>
        /// <param name="handler">Handler that triggers when the command is used</param>
        /// <returns>True/False depending if hooking the command was successful</returns>
        bool HookCommand(string command, RegisteredCommand handler);

        /// <summary>
        /// Hook a identifier into AdiIRC, the handler will be triggered when the identifier is used.
        /// </summary>
        /// <param name="identifier">Name of the identifier</param>
        /// <param name="handler">Handler that triggers when the identifier is used</param>
        /// <returns>True/False depending if hooking the command was successful</returns>
        void HookIdentifier(string identifier, RegisteredIdentifier handler);

        /// <summary>
        /// Removes a command you have defined.
        /// </summary>
        /// <param name="command">Command to remove</param>
        void UnHookCommand(string command);

        /// <summary>
        /// Removes a identifier you have defined.
        /// </summary>
        /// <param name="identifier">Identifier to remove</param>
        void UnHookIdentifier(string identifier);

        /// <summary>
        /// Get a list of all IServers.
        /// </summary>
        ICollection GetServers
        {
            get;
        }

        /// <summary>
        /// Get a list of all IWindows.
        /// </summary>
        ICollection GetWindows { get; }

        /// <summary>
        /// Returns the AdiIRC config folder.
        /// </summary>
        string ConfigFolder { get; }

        /// <summary>
        /// Returns the AdiIRC program folder.
        /// </summary>
        string ProgramFolder { get; }

        /// <summary>
        /// Returns System Uptime as a TimeSpan.
        /// </summary>
        TimeSpan SystemUptime { get; }

        /// <summary>
        /// Returns AdiIRC Uptime in as a TimeSpan.
        /// </summary>
        TimeSpan Uptime { get; }
    }
}
