namespace AdiIRCAPIv2.Arguments.Dns
{
    public class DnsResolveStartedArgs
    {
        private readonly bool ipv4;
        private readonly bool ipv6;
        private readonly string address;

        public DnsResolveStartedArgs(bool ipv4, bool ipv6, string address)
        {
            this.ipv4 = ipv4;
            this.ipv6 = ipv6;
            this.address = address;
        }

        public bool Ipv4 { get { return this.ipv4; } }

        public bool Ipv6 { get { return this.ipv6; } }

        public string Address { get { return this.address; } }
    }
}
