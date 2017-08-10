namespace AdiIRCAPIv2.Arguments.Dns
{
    /// <summary>
    ///     Arguments class passed to the DnsResolveStarted event
    /// </summary>
    public class DnsResolveStartedArgs
    {
        private readonly bool ipv4;
        private readonly bool ipv6;
        private readonly string address;

        /// <summary>
        ///     Constructor for arguments class passed to the DnsResolveStarted event
        /// </summary>
        /// <param name="ipv4">bool></param>
        /// <param name="ipv6">bool></param>
        /// <param name="address">string></param>
        public DnsResolveStartedArgs(bool ipv4, bool ipv6, string address)
        {
            this.ipv4 = ipv4;
            this.ipv6 = ipv6;
            this.address = address;
        }

        /// <summary>
        ///     Returns true if looking up ipv4 addresses is enabled for this lookup
        /// </summary>
        public bool Ipv4 { get { return this.ipv4; } }

        /// <summary>
        ///     Returns true if looking up ipv6 addresses is enabled for this lookup
        /// </summary>
        public bool Ipv6 { get { return this.ipv6; } }

        /// <summary>
        ///     Returns the ip address or hostname to lookup
        /// </summary>
        public string Address { get { return this.address; } }
    }
}
