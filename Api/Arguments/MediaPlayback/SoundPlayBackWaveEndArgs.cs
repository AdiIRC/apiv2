namespace AdiIRCAPIv2.Arguments.MediaPlayback
{
    /// <summary>
    ///     Arguments class passed to the SoundPlayBackWaveEnd event
    /// </summary>
    public class SoundPlayBackWaveEndArgs
    {
        private readonly string filename;

        /// <summary>
        ///     Constructor for arguments class passed to the SoundPlayBackWaveEnd event
        /// </summary>
        /// <param name="filename">string</param>
        public SoundPlayBackWaveEndArgs(string filename)
        {
            this.filename = filename;
        }

        /// <summary>
        ///     Returns the filename which stopped playing
        /// </summary>
        public string Filename { get { return this.filename; } }
    }
}
