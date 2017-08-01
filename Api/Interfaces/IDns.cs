namespace AdiIRCAPIv2.Interfaces
{
    /// <summary>
    /// Represents a ip address entry as a result of a /dns lookup.
    /// </summary>
    public interface IDns
    {
        /// <summary>
        /// The nick whos hostname who was looked up.
        /// </summary>
        string Nick { get; }

        /// <summary>
        /// The hostname which was looked up/resolved.
        /// </summary>
        string Hostname { get; }

        /// <summary>
        /// The ipaddress which looked up/resolved.
        /// </summary>
        string IpAddress { get; }
    }
}
