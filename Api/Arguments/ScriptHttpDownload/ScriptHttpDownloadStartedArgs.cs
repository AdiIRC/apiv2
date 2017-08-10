namespace AdiIRCAPIv2.Arguments.ScriptHttpDownload
{
    /// <summary>
    ///     Arguments class passed to the ScriptHttpDownloadStarted event
    /// </summary>
    public class ScriptHttpDownloadStartedArgs
    {
        private readonly string name;
        private readonly string url;
        private readonly string filename;

        /// <summary>
        ///     Constructor for arguments class passed to the ScriptHttpDownloadStarted event
        /// </summary>
        /// <param name="name">string</param>
        /// <param name="url">string</param>
        /// <param name="filename">filename</param>
        public ScriptHttpDownloadStartedArgs(string name, string url, string filename)
        {
            this.name = name;
            this.url = url;
            this.filename = filename;
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
    }
}
