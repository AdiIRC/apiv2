namespace AdiIRCAPIv2.Arguments.ZipCompression
{
    public class ZipDecompressionEndArgs
    {
        private readonly string name;

        private readonly string zipfile;

        private readonly string targetFolder;

        private readonly string error;

        public ZipDecompressionEndArgs(string name, string zipfile, string targetFolder, string error)
        {
            this.name = name;
            this.zipfile = zipfile;
            this.targetFolder = targetFolder;
            this.error = error;
        }

        public string Name { get { return this.name; } }

        public string Zipfile { get { return this.zipfile; } }

        public string TargetFolder { get { return this.targetFolder; } }

        public string Error { get { return this.error; } }
    }
}
