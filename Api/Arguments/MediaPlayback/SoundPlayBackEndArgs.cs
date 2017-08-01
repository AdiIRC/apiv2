namespace AdiIRCAPIv2.Arguments.MediaPlayback
{
    public class SoundPlayBackEndArgs
    {
        private readonly string filename;

        public SoundPlayBackEndArgs(string filename)
        {
            this.filename = filename;
        }

        public string Filename { get { return this.filename; } }
    }
}
