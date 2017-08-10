namespace AdiIRCAPIv2.Arguments.ZipCompression
{
    /// <summary>
    ///     Arguments class passed to the ZipCompressionEnd event
    /// </summary>
    public class ZipCompressionEndArgs
    {
        private readonly string name;

        private readonly string zipfile;

        private readonly string sourceFileOrFolder;

        private readonly int compressionMethod;

        private readonly string error;

        /// <summary>
        ///     Constructor for arguments class passed to the ZipCompressionEnd event
        /// </summary>
        /// <param name="name">string</param>
        /// <param name="zipfile">string</param>
        /// <param name="sourceFileOrFolder">string</param>
        /// <param name="compressionMethod">int</param>
        /// <param name="error">string</param>
        public ZipCompressionEndArgs(string name, string zipfile, string sourceFileOrFolder, int compressionMethod, string error)
        {
            this.name = name;
            this.zipfile = zipfile;
            this.sourceFileOrFolder = sourceFileOrFolder;
            this.compressionMethod = compressionMethod;
            this.error = error;
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

        /// <summary>
        ///     Returns the compression error, if any
        /// </summary>
        public string Error { get { return this.error; } }
    }
}
