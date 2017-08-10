namespace AdiIRCAPIv2.Arguments.Dns
{
    using System.Collections.Generic;
    using Interfaces;

    /// <summary>
    ///     Arguments class passed to the DnsResolveEnd event
    /// </summary>
    public class DnsResolveEndArgs
    {
        private readonly bool ipv4;
        private readonly bool ipv6;
        private readonly string address;
        private readonly ICollection<IDns> addresses;
        private readonly bool error;

        /// <summary>
        ///     Constructor for arguments class passed to the DnsResolveEnd event
        /// </summary>
        /// <param name="ipv4">bool></param>
        /// <param name="ipv6">bool></param>
        /// <param name="address">string></param>
        /// <param name="addresses">ICollection</param>
        /// <param name="error">bool</param>
        public DnsResolveEndArgs(bool ipv4, bool ipv6, string address, ICollection<IDns> addresses, bool error)
        {
            this.ipv4 = ipv4;
            this.ipv6 = ipv6;
            this.address = address;
            this.addresses = addresses;
            this.error = error;
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

        /// <summary>
        ///     Returns a list of ip addresses resolved during the lookup
        /// </summary>
        public ICollection<IDns> Addresses { get { return this.addresses; } }

        /// <summary>
        ///     Returns true if there was an error during the lookup
        /// </summary>
        public bool Error { get { return this.error; } }
    }
}
