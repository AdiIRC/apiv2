namespace AdiIRCAPIv2.Arguments.ZipCompression
{
    public class ZipCompressionEndArgs
    {
        private readonly string name;

        private readonly string zipfile;

        private readonly string sourceFileOrFolder;

        private readonly int compressionMethod;

        private readonly string error;

        public ZipCompressionEndArgs(string name, string zipfile, string sourceFileOrFolder, int compressionMethod, string error)
        {
            this.name = name;
            this.zipfile = zipfile;
            this.sourceFileOrFolder = sourceFileOrFolder;
            this.compressionMethod = compressionMethod;
            this.error = error;
        }

        public string Name { get { return this.name; } }

        public string Zipfile { get { return this.zipfile; } }

        public string SourceFileOrFolder { get { return this.sourceFileOrFolder; } }

        public int CompressionMethod { get { return this.compressionMethod; } }

        public string Error { get { return this.error; } }
    }
}
