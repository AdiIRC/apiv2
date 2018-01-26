namespace AdiIRCAPIv2.Interfaces
{
    using System;

    /// <summary>
    /// Interface for various Tools
    /// </summary>
    public interface ITools
    {
        /// <summary>
        /// Strip all color/font control codes
        /// </summary>
        /// <param name="text">Text to strip</param>
        /// <returns>The stripped text</returns>
        string Strip(string text);

        /// <summary>
        /// Strip all color control codes
        /// </summary>
        /// <param name="text">Text to strip</param>
        /// <returns>The stripped text</returns>
        string StripColors(string text);

        /// <summary>
        /// Strip all bold control codes
        /// </summary>
        /// <param name="text">Text to strip</param>
        /// <returns>The stripped text</returns>
        string StripBold(string text);

        /// <summary>
        /// Strip all italic control codes
        /// </summary>
        /// <param name="text">Text to strip</param>
        /// <returns>The stripped text</returns>
        string StripItalic(string text);

        /// <summary>
        /// Strip all underline control codes
        /// </summary>
        /// <param name="text">Text to strip</param>
        /// <returns>The stripped text</returns>
        string StripUnderline(string text);

        /// <summary>
        /// Print a debug text to the Rawlog -> Debug window
        /// </summary>
        /// <param name="text">Text to print</param>
        void Debug(string text);

        /// <summary>
        /// Formats a DateTime to a string
        /// </summary>
        /// <param name="format">The Format to use</param>
        /// <param name="datetime">The DateTime to format</param>
        /// <returns>The formatted text</returns>
        string FormatTime(string format, DateTime datetime);

        /// <summary>
        /// Format the text with bold characters if enabled in Options
        /// </summary>
        /// <param name="text">The text to format</param>
        /// <returns>The formatted text</returns>
        string Boldify(string text);
    }
}
