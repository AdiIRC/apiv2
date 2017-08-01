namespace AdiIRCAPIv2.Arguments.MediaPlayback
{
    public class SoundPlayBackMp3EndArgs
    {
        private readonly string filename;

        public SoundPlayBackMp3EndArgs(string filename)
        {
            this.filename = filename;
        }

        public string Filename { get { return this.filename; } }
    }
}
