namespace AdiIRCAPIv2.Arguments.MediaPlayback
{
    public class SoundPlayBackMidiEndArgs
    {
        private readonly string filename;

        public SoundPlayBackMidiEndArgs(string filename)
        {
            this.filename = filename;
        }

        public string Filename { get { return this.filename; } }
    }
}
