namespace AdiIRCAPIv2.Interfaces
{
    using System;

    /// <summary>
    /// Interface for ban/except/invite/quiet lists
    /// </summary>
    public interface IChannelMask
    {
        /// <summary>
        /// The nick!ident@host mask for this item.
        /// </summary>
        string Mask { get; }

        /// <summary>
        /// The date/time this mask was set.
        /// </summary>
        DateTime SetAt { get; }

        /// <summary>
        /// The nick who set the mask.
        /// </summary>
        string SetBy { get; }
    }
}
