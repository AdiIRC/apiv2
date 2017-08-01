/// <summary>
///     Delegates related to an IServer's connection
/// </summary>
namespace AdiIRCAPIv2.Delegates
{
    using Arguments.Connection;
    using Arguments.Contextless;

    /// <summary>
    ///     Delegate gets called when an IServer's underlying socket fails to connect
    /// </summary>
    /// <remarks>
    ///     Scripted Event Equivalent: <c>on CONNECTFAIL</c>
    /// </remarks>
    /// <param name="argument">ConnectFailureArgs</param>
    public delegate void ConnectFailure(ConnectFailureArgs argument);

    /// <summary>
    ///     Delegate gets called when an IServer's underlying socket successfully connects
    /// </summary>
    /// <remarks>
    ///     Scripted Event Equivalent: <c>on CONNECT</c>
    /// </remarks>
    /// <param name="argument">ConnectArgs</param>
    public delegate void Connect(ConnectArgs argument);

    /// <summary>
    ///     Delegate gets called when an IServer's underlying socket is closed
    /// </summary>
    /// <remarks>
    ///     Scripted Event Equivalent: <c>on DISCONNECT</c>
    /// </remarks>
    /// <param name="argument">DisconnectArgs</param>
    public delegate void Disconnect(DisconnectArgs argument);

    /// <summary>
    ///     Delegate gets called when any raw data is recieved from an IServer
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The Byte-Array passed in the args can be modified to alter the message that AdiIRC parse.
    ///     </para><para>
    ///         If the array is set to null or zero bytes, the message will not be processed further.
    ///     </para><para>
    ///         Scripted Event Equivalent: <c>on PARSELINE</c>
    ///     </para>
    /// </remarks>
    /// <param name="argument">RawBytesReceivedArgs</param>
    public delegate void RawBytesReceived(RawBytesReceivedArgs argument);

    /// <summary>
    ///     Delegate gets called when any raw data is sent to the IServer.
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The Byte-Array passed in the args can be modified to alter what is sent to the IServer.
    ///     </para><para>
    ///         If the array is set to null or zero bytes, the raw message will not be sent.
    ///     </para><para>
    ///         Scripted Event Equivalent: <c>on PARSELINE</c>
    ///     </para>
    /// </remarks>
    /// <param name="argument">RawBytesSentArgs</param>
    public delegate void RawBytesSent(RawBytesSentArgs argument);

    /// <summary>
    ///     Delegate gets called when any string data is recieved from an IServer
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The raw string passed in the args can be modified to alter the message that AdiIRC will parse.
    ///     <para></para>
    ///         If the string is set to an empty string, the message will not be further processed.
    ///     </para><para>
    ///         Scripted Event Equivalent: <c>on PARSELINE</c>
    ///     </para>
    /// </remarks>
    /// <param name="argument">StringDataReceivedArgs</param>
    public delegate void StringDataReceived(StringDataReceivedArgs argument);

    /// <summary>
    ///     Delegate gets called when any string data is sent to the IServer.
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The raw string passed in the args can be modified to alter the message being sent to the IServer
    ///     <para></para>
    ///         If the string is set to an empty string, the message will not be further processed.
    ///     </para><para>
    ///         Scripted Event Equivalent: <c>on PARSELINE</c>
    ///     </para>
    /// </remarks>
    /// <param name="argument">StringDataSentArgs</param>
    public delegate void StringDataSent(StringDataSentArgs argument);

    /// <summary>
    ///     Delegate gets called after an IServer successfully logs on to an IRC server
    /// </summary>
    /// <remarks>
    ///     Scripted Event Equivalent: <c>on LOGON</c>
    /// </remarks>
    /// <param name="argument">ConnectionLogoSuccessArgs</param>
    public delegate void ConnectionLogonSuccess(ConnectionLogonSuccessArgs argument);

    /// <summary>
    ///     Delegate gets called when a IServer receives a raw server message
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         AdiIRC will have already parsed the data into a string.
    ///     </para><para>
    ///         Scripted Event Equivalent: <c>on RAW</c>
    ///     </para>
    /// </remarks>
    /// <param name="argument">DataArgs</param>
    public delegate void RawServerEventReceived(RawServerEventReceivedArgs argument);

    /// <summary>
    ///     Delegate gets called when a IServer receives a PING event
    /// </summary>
    /// <remarks>
    ///     Scripted Event Equivalent: <c>on PING</c>
    /// </remarks>
    /// <param name="argument">ServerPingReceivedArgs</param>
    public delegate void ServerPingReceived(ServerPingReceivedArgs argument);

    /// <summary>
    ///     Delegate gets called when a IServer receives a PING event
    /// </summary>
    /// <remarks>
    ///     Scripted Event Equivalent: <c>on PoNG</c>
    /// </remarks>
    /// <param name="argument">ServerPongReceivedArgs</param>
    public delegate void ServerPongPreceived(ServerPongReceivedArgs argument);
}