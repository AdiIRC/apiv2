//-------------------------------------------------------------------------------
//  Delegates called when performing a zip or unzip operation
//-------------------------------------------------------------------------------

namespace AdiIRCAPIv2.Delegates
{
    using Arguments.ZipCompression;

    /// <summary>
    ///     Delegate gets called after /zip is called
    /// </summary>
    /// <remarks>
    ///     Scripted Event Equivalent: overriding <c>/zip</c>
    /// </remarks>
    /// <params name="argument">ZipCompressionStartedArgs</params>
    public delegate void ZipCompressionStarted(ZipCompressionStartedArgs argument);

    /// <summary>
    ///     Delegate gets called after a file|directory has finished being zipped
    /// </summary>
    /// <remarks>
    ///     Scripted Event Equivalent: on <c>ZIP</c>
    /// </remarks>
    /// <params name="argument">ZipCompressionEndArgs</params>
    public delegate void ZipCompressionEnd(ZipCompressionEndArgs argument);

    /// <summary>
    ///     Delegate gets called after /unzip is called
    /// </summary>
    /// <remarks>
    ///     Scripted Event Equivalent: overriding <c>/unzip</c>
    /// </remarks>
    /// <params name="argument">ZipDecompressionStartedArgs</params>
    public delegate void ZipDecompressionStarted(ZipDecompressionStartedArgs argument);

    /// <summary>
    ///     Delegate gets called after a .zip has finished being extracted
    /// </summary>
    /// <remarks>
    ///     Scripted Event Equivalent: <c>on UNZIP</c>
    /// </remarks>
    /// <params name="argument">ZipDecompressionEndArgs</params>
    public delegate void ZipDecompressionEnd(ZipDecompressionEndArgs argument);
}