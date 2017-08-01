namespace AdiIRCAPIv2.Arguments.MediaPlayback
{
    public class SoundPlayBackWaveEndArgs
    {
        private readonly string filename;

        public SoundPlayBackWaveEndArgs(string filename)
        {
            this.filename = filename;
        }

        public string Filename { get { return this.filename; } }
    }
}
