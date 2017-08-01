namespace AdiIRCAPIv2.Arguments.MediaPlayback
{
    public class MediaPlayerPlaybackStartedArgs
    {
        private readonly string song;

        public MediaPlayerPlaybackStartedArgs(string song)
        {
            this.song = song;
        }

        public string Song { get { return this.song; } }
    }
}
