namespace AdiIRCAPIv2.Arguments.ScriptHttpDownload
{
    /// <summary>
    ///     Arguments class passed to the ScriptHttpDownloadEnd event
    /// </summary>
    public class ScriptHttpDownloadEndArgs
    {
        private readonly string name;
        private readonly string url;
        private readonly string filename;
        private readonly string error;

        /// <summary>
        ///     Constructor for arguments class passed to the ScriptHttpDownloadEnd event
        /// </summary>
        /// <param name="name">string</param>
        /// <param name="url">string</param>
        /// <param name="filename">filename</param>
        /// <param name="error">filename</param>
        public ScriptHttpDownloadEndArgs(string name, string url, string filename, string error)
        {
            this.name = name;
            this.url = url;
            this.filename = filename;
            this.error = error;
        }

        /// <summary>
        ///     Returns the name of the download
        /// </summary>
        public string Name { get { return this.name; } }

        /// <summary>
        ///     Returns the url to download
        /// </summary>
        public string Url { get { return this.url; } }

        /// <summary>
        ///     Returns the filename to save the download as
        /// </summary>
        public string Filename { get { return this.filename; } }

        /// <summary>
        ///     Returns the error message of the download, if any
        /// </summary>
        public string Error { get { return this.error; } }
    }
}
