namespace AdiIRCAPIv2.Arguments.ScriptHttpDownload
{
    public class ScriptHttpDownloadStartedArgs
    {
        private readonly string name;
        private readonly string url;
        private readonly string filename;

        public ScriptHttpDownloadStartedArgs(string name, string url, string filename)
        {
            this.name = name;
            this.url = url;
            this.filename = filename;
        }

        public string Name { get { return this.name; } }

        public string Url { get { return this.url; } }

        public string Filename { get { return this.filename; } }
    }
}
