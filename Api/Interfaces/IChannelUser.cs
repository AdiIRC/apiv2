namespace AdiIRCAPIv2.Interfaces
{
    using System;

    /// <summary>
    /// Represents a user
    /// </summary>
    public interface IChannelUser : IUser
    {
        /// <summary>
        /// Get whether user is IChannel operator (@)
        /// </summary>
        bool IsOperator { get; }

        /// <summary>
        /// Get whether user is IChannel special operator (!)
        /// </summary>
        bool IsPOperator { get; }

        /// <summary>
        /// Get whether user is IChannel owner (&amp;)
        /// </summary>
        bool IsOwner { get; }

        /// <summary>
        /// Get whether user has IChannel voice (+)
        /// </summary>
        bool HasVoice { get; }

        /// <summary>
        /// Get whether user is IChannel half operator (%)
        /// </summary>
        bool IsHalfOperator { get; }

        /// <summary>
        /// Returns the time user last sent a message to this IChannel (UTC time)
        /// </summary>
        DateTime IdleTime { get; }

        /// <summary>
        /// /// Returns the time the user joined the IChannel (UTC time)
        /// </summary>
        DateTime Joined { get; }

        /// <summary>
        /// /// Returns whether the user has spoken since joining the IChannel
        /// </summary>
        bool HasSpoken { get; }

        /// <summary>
        /// /// Returns the (0-15 numeric) nick color to use for the nick on this IChannel
        /// </summary>
        int NickColor { get; }

        /// <summary>
        /// /// Returns the rgb nick color (RRGGBB format) to use for the nick on this IChannel
        /// </summary>
        string RgbNickColor { get; }
    }
}
