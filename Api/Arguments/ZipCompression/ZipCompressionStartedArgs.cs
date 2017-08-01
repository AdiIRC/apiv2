namespace AdiIRCAPIv2.Arguments.ZipCompression
{
    public class ZipCompressionStartedArgs
    {
        private readonly string name;

        private readonly string zipfile;

        private readonly string sourceFileOrFolder;

        private readonly int compressionMethod;

        public ZipCompressionStartedArgs(string name, string zipfile, string sourceFileOrFolder, int compressionMethod)
        {
            this.name = name;
            this.zipfile = zipfile;
            this.sourceFileOrFolder = sourceFileOrFolder;
            this.compressionMethod = compressionMethod;
        }

        public string Name { get { return this.name; } }

        public string Zipfile { get { return this.zipfile; } }

        public string SourceFileOrFolder { get { return this.sourceFileOrFolder; } }

        public int CompressionMethod { get { return this.compressionMethod; } }
    }
}
