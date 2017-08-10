namespace AdiIRCAPIv2.Arguments.MediaPlayback
{
    /// <summary>
    ///     Arguments class passed to the MediaPlayerPlaybackStarted event
    /// </summary>
    public class MediaPlayerPlaybackStartedArgs
    {
        private readonly string song;

        /// <summary>
        ///     Constructor for arguments class passed to the MediaPlayerPlaybackStarted event
        /// </summary>
        /// <param name="song">string</param>
        public MediaPlayerPlaybackStartedArgs(string song)
        {
            this.song = song;
        }

        /// <summary>
        ///     Returns the artist - title of the new song playing
        /// </summary>
        public string Song { get { return this.song; } }
    }
}
