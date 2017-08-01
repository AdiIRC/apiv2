namespace AdiIRCAPIv2.Arguments.Dns
{
    using System.Collections.Generic;
    using Interfaces;

    public class DnsResolveEndArgs
    {
        private readonly bool ipv4;
        private readonly bool ipv6;
        private readonly string address;
        private readonly ICollection<IDns> addresses;
        private readonly bool error;

        public DnsResolveEndArgs(bool ipv4, bool ipv6, string address, ICollection<IDns> addresses, bool error)
        {
            this.ipv4 = ipv4;
            this.ipv6 = ipv6;
            this.address = address;
            this.addresses = addresses;
            this.error = error;
        }

        public bool Ipv4 { get { return this.ipv4; } }

        public bool Ipv6 { get { return this.ipv6; } }

        public string Address { get { return this.address; } }

        public ICollection<IDns> Addresses { get { return this.addresses; } }

        public bool Error { get { return this.error; } }
    }
}
