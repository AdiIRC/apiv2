/// <summary>
///     Delegates related to Dns'ing a host|ip
/// </summary>
namespace AdiIRCAPIv2.Delegates
{
    using Arguments.Dns;

    /// <summary>
    ///     Delegate gets called when a Dns attempt has started
    /// </summary>
    /// <remarks>
    ///     Scripted Event Equivalent: overriding <c>/dns</c>
    /// </remarks>
    /// <params name="argument">DnsResolveStartedArgs</params>
    public delegate void DnsResolveStarted(DnsResolveStartedArgs argument);

    /// <summary>
    ///     Delegate gets called when a Dns attempt has finished
    /// </summary>
    /// <remarks>
    ///     Scripted Event Equivalent: <c>on DNS</c>
    /// </remarks>
    /// <params name="argument">DnsResolveEndArgs</params>
    public delegate void DnsResolveEnd(DnsResolveEndArgs argument);
}