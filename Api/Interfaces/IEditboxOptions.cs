namespace AdiIRCAPIv2.Interfaces
{
    /// <summary>
    /// Interface for returning Editbox options
    /// </summary>
    public interface IEditboxOptions
    {
        /// <summary>
        /// Text to add when tabbing nicks
        /// </summary>
        string TabCompleteSuffix { get; set; }

        /// <summary>
        /// Text to add when tabbing nicks and the nick is the first word in the IEditbox
        /// </summary>
        string TabCompleteSuffixFirstWord { get; set; }
    }
}
