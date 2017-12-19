namespace AdiIRCAPIv2.Interfaces
{
    using System;
    using System.Collections;
    using System.Net;
    using System.Text;

    /// <summary>
    /// Represents a server window.
    /// </summary>
    public interface IServer : IWindow
    {
        /// <summary>
        /// Get the IServer network name.
        /// </summary>
        string Network { get; }

        /// <summary>
        /// Get the IServer hostname.
        /// </summary>
        string Host { get; }

        /// <summary>
        /// Get the IServer target hostname entered in the Serverlist or /server.
        /// </summary>
        string HostTarget { get; }

        /// <summary>
        /// Get the IServer IP address.
        /// </summary>
        IPAddress HostIp { get; }

        /// <summary>
        /// Get the external Ip discovered from this IServer.
        /// </summary>
        string ExternalIp { get; }

        /// <summary>
        /// Get the external host discovered from this IServer.
        /// </summary>
        string ExternalHost { get; }

        /// <summary>
        /// Get the IServer port.
        /// </summary>
        int Port { get; }

        /// <summary>
        /// Get whether IServer is using SSL secure connection.
        /// </summary>
        bool IsUsingSsl { get; }

        /// <summary>
        /// Get the encoding used on this IServer.
        /// </summary>
        Encoding Encoding { get; }

        /// <summary>
        /// Get current nick.
        /// </summary>
        string Nick { get; }

        /// <summary>
        /// Get prefered nick.
        /// </summary>
        string PrefNick { get; }

        /// <summary>
        /// Get a list of alternative nicks.
        /// </summary>
        ICollection AlternativeNicks { get; }

        /// <summary>
        /// Get usernick.
        /// </summary>
        string UserNick { get; }

        /// <summary>
        /// Get realname.
        /// </summary>
        string RealName { get; }

        /// <summary>
        /// Get supported userprefix characters on this IServer.
        /// </summary>
        string UserPrefix { get; }

        /// <summary>
        /// Get supported userprefix letters on this IServer.
        /// </summary>
        string UserPrefixChars { get; }

        /// <summary>
        /// Get supported channelprefixes on this IServer.
        /// </summary>
        string ChannelPrefix { get; }

        /// <summary>
        /// Get server lag.
        /// </summary>
        TimeSpan Lag { get; }

        /// <summary>
        /// Returns the custom default BanType on this IServer, if any.
        /// </summary>
        string BanType { get; }

        /// <summary>
        /// Returns the connection id on this IServer.
        /// </summary>
        string ConnectionId { get; }

        /// <summary>
        /// Returns number of modes which can be in one MODE request on this IServer.
        /// </summary>
        int ModesLength { get; }

        /// <summary>
        /// Returns the available channel modes on this IServer. (retrieved from 005 chanmodes=)
        /// </summary>
        string ChannelModes { get; }

        /// <summary>
        /// Returns the available channel modes which can have an argument on this IServer. (retrieved from 005 chanmodes=)
        /// </summary>
        ICollection ChannelModesWithArgs { get; }

        /// <summary>
        /// Returns the available channel modes which must have an argument on this IServer. (retrieved from 005 chanmodes=)
        /// </summary>
        ICollection ChannelModesWithRequiredArgs { get; }

        /// <summary>
        /// Max topic length on this IServer. (retrieved from 005)
        /// </summary>
        int TopicLength { get; }

        /// <summary>
        /// Max ban list count on this IServer. (retrieved from 005)
        /// </summary>
        int BanLength { get; }

        /// <summary>
        /// Max except list count on this IServer. (retrieved from 005)
        /// </summary>
        int ExceptLength { get; }

        /// <summary>
        /// Max invite list count on this IServer. (retrieved from 005)
        /// </summary>
        int InviteLength { get; }

        /// <summary>
        /// Max quiet list count on this IServer. (retrieved from 005)
        /// </summary>
        int QuietLength { get; }

        /// <summary>
        /// Returns whether you are away on this IServer.
        /// </summary>
        bool Away { get; }

        /// <summary>
        /// Returns your away message on this IServer.
        /// </summary>
        string AwayMessage { get; }

        /// <summary>
        /// Returns the time you went away on this IServer. (UTC time)
        /// </summary>
        DateTime AwayTime { get; }

        /// <summary>
        /// Returns the time you connected to this IServer. (UTC time)
        /// </summary>
        DateTime ConnectedAt { get; }

        /// <summary>
        /// Returns the time you last sent a message to this IServer. (UTC time)
        /// </summary>
        DateTime IdleTime { get; }

        /// <summary>
        /// Returns whether the last connect attempt was a success.
        /// </summary>
        bool ConnectionSuccess { get; }

        /// <summary>
        /// Returns whether the IServer is connected.
        /// </summary>
        bool IsConnected { get; }

        /// <summary>
        /// Returns whether the IServer is connecting.
        /// </summary>
        bool IsConnecting { get; }

        /// <summary>
        /// Returns whether the IServer is re-connecting.
        /// </summary>
        bool IsReconnecting { get; }

        /// <summary>
        /// Returns whether you are logging on IServer.
        /// </summary>
        bool IsLoggingOn { get; }

        /// <summary>
        /// Returns whether you are logged on to the IServer.
        /// </summary>
        bool IsRegistered { get; }

        /// <summary>
        /// Returns whether the last connection attempt failed on the IServer.
        /// </summary>
        bool ConnectError { get; }

        /// <summary>
        /// Returns whether the error type of the last connections error. (0 = no error)
        /// </summary>
        int Error { get; }

        /// <summary>
        /// Returns whether the the IServer uses the global or custom quit message.
        /// </summary>
        bool UseGlobalQuitMessage { get; }

        /// <summary>
        /// Returns custom QuitMessage on this IServer, if enabled.
        /// </summary>
        string QuitMessage { get; }

        /// <summary>
        /// Returns the last QuitMessage sent on this IServer.
        /// </summary>
        string LastQuitMessage { get; }

        /// <summary>
        /// Returns the loginmethod for this IServer.
        /// </summary>
        int LoginMethod { get; }

        /// <summary>
        /// Returns whether to use network label on this IServer.
        /// </summary>
        bool UseNetworkLabel { get; }

        /// <summary>
        /// Network label for this IServer.
        /// </summary>
        string NetworkLabel { get; }

        /// <summary>
        /// Returns number of seconds to delay joining channels on this IServer.
        /// </summary>
        int DelayJoin { get; }

        /// <summary>
        /// Returns number of seconds to delay between each channel join on this IServer.
        /// </summary>
        int DelayBetweenJoins { get; }

        /// <summary>
        /// Returs or set whether to use RegainNick on this IServer.
        /// </summary>
        bool RegainNick { get; set; }

        /// <summary>
        /// Sends raw data to the IServer.
        /// </summary>
        /// <param name="data">String</param>
        /// <returns>True/False depending if the send was successful</returns>
        bool SendRaw(string data);

        /// <summary>
        /// Sends raw data to the client IServer, use this to fake messages
        /// E.g when you want to replace something in a PRIVMSG
        /// </summary>
        /// <param name="data">String</param>
        /// <returns>True/False depending if the send was successful</returns>
        bool SendFakeRaw(string data);

        /// <summary>
        /// Get a collection of IChannels in this IServer.
        /// </summary>
        ICollection GetChannels
        {
            get;
        }

        /// <summary>
        /// Get a collection of IUsers in this IServer.
        /// </summary>
        ICollection GetUsers
        {
            get;
        }

        /// <summary>
        /// Returns your own IUser on this IServer.
        /// </summary>
        IUser Self { get; }

        /// <summary>
        /// Returns server variables discovered in RAW 005 messages.
        /// </summary>
        IDictionary ServerVariables { get; }

        /// <summary>
        /// Returns IRCv3 caps discovered during CAP LS/NEW.
        /// </summary>
        IDictionary IRCv3Caps { get; }

        /// <summary>
        /// Returns Server Uptime as a TimeSpan.
        /// </summary>
        TimeSpan Uptime { get; }

        /// <summary>
        /// Sends raw bytes to the IServer, bypasssing any encodings, AdiIRC is not aware when these messages are sent.
        /// </summary>
        /// <param name="data">Byte[]</param>
        /// <returns>True/False depending if the send was successful</returns>
        bool SendRawData(byte[] data);

        /// <summary>
        /// Connect this IServer if it's not connected.
        /// </summary>
        void Connect();

        /// <summary>
        /// Disconnect this IServer if it's connected.
        /// </summary>
        void Disconnect();
    }
}
