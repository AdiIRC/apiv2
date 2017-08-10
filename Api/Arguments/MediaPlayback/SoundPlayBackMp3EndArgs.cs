namespace AdiIRCAPIv2.Arguments.MediaPlayback
{
    /// <summary>
    ///     Arguments class passed to the SoundPlayBackMp3End event
    /// </summary>
    public class SoundPlayBackMp3EndArgs
    {
        private readonly string filename;

        /// <summary>
        ///     Constructor for arguments class passed to the SoundPlayBackMp3End event
        /// </summary>
        /// <param name="filename">string</param>
        public SoundPlayBackMp3EndArgs(string filename)
        {
            this.filename = filename;
        }

        /// <summary>
        ///     Returns the filename which stopped playing
        /// </summary>
        public string Filename { get { return this.filename; } }
    }
}
