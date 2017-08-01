namespace AdiIRCAPIv2.Interfaces
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    /// <summary>
    /// Represents a channel object
    /// </summary>
    public interface IChannel : IWindow
    {
        /// <summary>
        /// Gets the IChannel topic.
        /// </summary>
        string Topic { get; }

        /// <summary>
        /// Get nick of whom set the current topic.
        /// </summary>
        string TopicSetBy { get; }

        /// <summary>
        /// Get date of when the current topic was set.
        /// </summary>
        DateTime TopicSetAt { get; }

        /// <summary>
        /// Gets whether the IChannel is moderated.
        /// </summary>
        bool IsModerated { get; }

        /// <summary>
        /// Gets whether the IChannel is invite only.
        /// </summary>
        bool IsInviteOnly { get; }

        /// <summary>
        /// Gets whether the IChannel is private.
        /// </summary>
        bool IsPrivate { get; }

        /// <summary>
        /// Gets whether the IChannel is secret.
        /// </summary>
        bool IsSecret { get; }

        /// <summary>
        /// Gets whether only operators can set topic in IChannel.
        /// </summary>
        bool OnlyOpsSetTopic { get; }

        /// <summary>
        /// Gets whether the IChannel can recive external messages.
        /// </summary>
        bool NoExternalMsgs { get; }

        /// <summary>
        /// Gets the IChannel channellimit.
        /// </summary>
        int ChannelLimit { get; }

        /// <summary>
        /// Gets the IChannel password (if any).
        /// </summary>
        string ChannelPassword { get; }

        /// <summary>
        /// Gets the IChannel mode.
        /// </summary>
        string ChannelModes { get; }

        /// <summary>
        /// Gets a collection of IChannelUsers in the IChannel.
        /// </summary>
        ICollection GetUsers
        {
            get;
        }

        /// <summary>
        /// Returns the IChannel ban list.
        /// </summary>
        Collection<IChannelMask> BanList { get; }

        /// <summary>
        /// Returns the IChannel except list.
        /// </summary>
        Collection<IChannelMask> ExceptList { get; }

        /// <summary>
        /// Returns the IChannel invite list.
        /// </summary>
        Collection<IChannelMask> InviteList { get; }

        /// <summary>
        /// Returns the IChannel quiet list.
        /// </summary>
        Collection<IChannelMask> QuietList { get; }

        /// <summary>
        /// Returns the IChannel channel modes with arguments.1
        /// </summary>
        SortedDictionary<string, string> ChannelModeArgs { get; }
    }
}
