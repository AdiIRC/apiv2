namespace AdiIRCAPIv2.Arguments.ZipCompression
{
    /// <summary>
    ///     Arguments class passed to the ZipDecompressionEnd event
    /// </summary>
    public class ZipDecompressionEndArgs
    {
        private readonly string name;

        private readonly string zipfile;

        private readonly string targetFolder;

        private readonly string error;

        /// <summary>
        ///     Constructor for arguments class passed to the ZipDecompressionEnd event
        /// </summary>
        /// <param name="name">string</param>
        /// <param name="zipfile">string</param>
        /// <param name="targetFolder">string</param>
        /// <param name="error">string</param>
        public ZipDecompressionEndArgs(string name, string zipfile, string targetFolder, string error)
        {
            this.name = name;
            this.zipfile = zipfile;
            this.targetFolder = targetFolder;
            this.error = error;
        }

        /// <summary>
        ///     Returns the name of this decompression event
        /// </summary>
        public string Name { get { return this.name; } }

        /// <summary>
        ///     Returns the name of the zip file to decompress
        /// </summary>
        public string Zipfile { get { return this.zipfile; } }

        /// <summary>
        ///     Returns the name of the folder to decompress to
        /// </summary>
        public string TargetFolder { get { return this.targetFolder; } }

        /// <summary>
        ///     Returns the decompress error, if any
        /// </summary>
        public string Error { get { return this.error; } }
    }
}
