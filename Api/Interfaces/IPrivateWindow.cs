namespace AdiIRCAPIv2.Interfaces
{
    using System.Collections;

    /// <summary>
    /// Represents a private window.
    /// </summary>
    public interface IPrivateWindow : IWindow
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
        /// Get whether the user is away or not.
        /// </summary>
        bool IsAway { get; }

        /// <summary>
        /// Retrive all shared IChannels this IUser and your user is joined.
        /// </summary>
        ICollection GetChannels { get; }
    }
}
