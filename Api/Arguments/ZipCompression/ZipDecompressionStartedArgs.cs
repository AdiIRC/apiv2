namespace AdiIRCAPIv2.Arguments.ZipCompression
{
    public class ZipDecompressionStartedArgs
    {
        private readonly string name;

        private readonly string zipfile;

        private readonly string targetFolder;

        public ZipDecompressionStartedArgs(string name, string zipfile, string targetFolder)
        {
            this.name = name;
            this.zipfile = zipfile;
            this.targetFolder = targetFolder;
        }

        public string Name { get { return this.name; } }

        public string Zipfile { get { return this.zipfile; } }

        public string TargetFolder { get { return this.targetFolder; } }
    }
}
