namespace AdiIRCAPIv2.Interfaces
{
    /// <summary>
    /// Interface for returning Messages options
    /// </summary>
    public interface IMessagesOptions
    {
        /// <summary>
        /// Returns the nick prefix/syntax to use for regular messages
        /// </summary>
        string PrefixUser { get; set; }

        /// <summary>
        /// Returns the nick prefix/syntax to use for CTCP messages
        /// </summary>
        string PrefixCtcp { get; set; }

        /// <summary>
        /// Returns the nick prefix/syntax to use for emote messages
        /// </summary>
        string PrefixEmote { get; set; }

        /// <summary>
        /// Returns the nick prefix/syntax to use for system messages
        /// </summary>
        string PrefixSys { get; set; }

        /// <summary>
        /// Returns the time format to use for messages
        /// </summary>
        string TimeFormat { get; set; }

        /// <summary>
        /// Returns whether global timestamps is enabled or disabled
        /// </summary>
        bool UseTimestamp { get; set; }
    }


}
