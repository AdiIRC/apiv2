namespace AdiIRCAPIv2.Arguments.ZipCompression
{
    /// <summary>
    ///     Arguments class passed to the ZipCompressionStarted event
    /// </summary>
    public class ZipCompressionStartedArgs
    {
        private readonly string name;

        private readonly string zipfile;

        private readonly string sourceFileOrFolder;

        private readonly int compressionMethod;

        /// <summary>
        ///     Constructor for arguments class passed to the ZipCompressionStarted event
        /// </summary>
        /// <param name="name">string</param>
        /// <param name="zipfile">string</param>
        /// <param name="sourceFileOrFolder">string</param>
        /// <param name="compressionMethod">int</param>
        public ZipCompressionStartedArgs(string name, string zipfile, string sourceFileOrFolder, int compressionMethod)
        {
            this.name = name;
            this.zipfile = zipfile;
            this.sourceFileOrFolder = sourceFileOrFolder;
            this.compressionMethod = compressionMethod;
        }

        /// <summary>
        ///     Returns the name of this compression event
        /// </summary>
        public string Name { get { return this.name; } }

        /// <summary>
        ///     Returns the name of the zip file to compress to
        /// </summary>
        public string Zipfile { get { return this.zipfile; } }

        /// <summary>
        ///     Returns the file name or folder to compress
        /// </summary>
        public string SourceFileOrFolder { get { return this.sourceFileOrFolder; } }

        /// <summary>
        ///     Returns the compression method
        /// </summary>
        /// <remarks>
        ///     0 = no compression, 1 = fastest compression, 2 = optimal compression
        /// </remarks>
        public int CompressionMethod { get { return this.compressionMethod; } }
    }
}
