namespace AdiIRCAPIv2.Arguments.ZipCompression
{
    /// <summary>
    ///     Arguments class passed to the ZipDecompressionStarted event
    /// </summary>
    public class ZipDecompressionStartedArgs
    {
        private readonly string name;

        private readonly string zipfile;

        private readonly string targetFolder;

        /// <summary>
        ///     Constructor for arguments class passed to the ZipDecompressionStartedArgs event
        /// </summary>
        /// <param name="name">string</param>
        /// <param name="zipfile">string</param>
        /// <param name="targetFolder">string</param>
        public ZipDecompressionStartedArgs(string name, string zipfile, string targetFolder)
        {
            this.name = name;
            this.zipfile = zipfile;
            this.targetFolder = targetFolder;
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
    }
}
