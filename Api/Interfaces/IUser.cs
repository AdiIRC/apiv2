namespace AdiIRCAPIv2.Interfaces
{
    using System.Collections;

    /// <summary>
    /// Represents a user
    /// </summary>
    public interface IUser
    {
        /// <summary>
        /// Get user nick.
        /// </summary>
        string Nick { get; }

        /// <summary>
        /// Get user ident.
        /// </summary>
        string Ident { get; }

        /// <summary>
        /// Get user hostname.
        /// </summary>
        string Host { get; }

        /// <summary>
        /// Get user realname.
        /// </summary>
        string RealName { get; }

        /// <summary>
        /// Get whether user is away.
        /// </summary>
        bool IsAway { get; }

        /// <summary>
        /// Retrive all channels this IUser is joined.
        /// </summary>
        ICollection GetChannels { get; }
    }
}
