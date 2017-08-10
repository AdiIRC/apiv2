//-------------------------------------------------------------------------------
//  Delegates related to media being played
//-------------------------------------------------------------------------------

namespace AdiIRCAPIv2.Delegates
{
    using Arguments.MediaPlayback;

    /// <summary>
    ///     Delegate gets called when adiirc finishes playing an MIDI file
    /// </summary>
    /// <remarks>
    ///     Scripted Event Equivalent: <c>on MIDIEND</c>
    /// </remarks>
    /// <param name="argument">SoundPlayBackMidiEndArgs</param>
    public delegate void SoundPlayBackMidiEnd(SoundPlayBackMidiEndArgs argument);

    /// <summary>
    ///     Delegate gets called when adiirc finishes playing an WAVE file
    /// </summary>
    /// <remarks>
    ///     Scripted Event Equivalent: <c>on WAVEEND</c>
    /// </remarks>
    /// <param name="argument">SoundPlayBackWaveEndArgs</param>
    public delegate void SoundPlayBackWaveEnd(SoundPlayBackWaveEndArgs argument);

    /// <summary>
    ///     Delegate gets called when adiirc finishes playing an Mp3 file
    /// </summary>
    /// <remarks>
    ///     Scripted Event Equivalent: <c>on MP3END</c>
    /// </remarks>
    /// <param name="argument">SoundPlayBackMp3EndArgs</param>
    public delegate void SoundPlayBackMp3End(SoundPlayBackMp3EndArgs argument);

    /// <summary>
    ///     Delegate gets called when adiirc finishes playing any sound file
    /// </summary>
    /// <remarks>
    ///     Scripted Event Equivalent: <c>on SONGEND</c>
    /// </remarks>
    /// <param name="argument">SoundPlayBackEndArgs</param>
    public delegate void SoundPlayBackEnd(SoundPlayBackEndArgs argument);

    /// <summary>
    ///     Delegate gets called when the selected media player begins playing a media file
    /// </summary>
    /// <remarks>
    ///     Scripted Event Equivalent: <c>on SONG</c>
    /// </remarks>
    /// <param name="argument">MediaPlayerPlaybackStarted</param>
    public delegate void MediaPlayerPlaybackStarted(MediaPlayerPlaybackStartedArgs argument);
}