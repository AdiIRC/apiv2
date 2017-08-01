namespace AdiIRCAPIv2.Arguments.ScriptHttpDownload
{
    public class ScriptHttpDownloadEndArgs
    {
        private readonly string name;
        private readonly string url;
        private readonly string filename;
        private readonly string error;

        public ScriptHttpDownloadEndArgs(string name, string url, string filename, string error)
        {
            this.name = name;
            this.url = url;
            this.filename = filename;
            this.error = error;
        }

        public string Name { get { return this.name; } }

        public string Url { get { return this.url; } }

        public string Filename { get { return this.filename; } }

        public string Error { get { return this.error; } }
    }
}
