namespace AdiIRCAPIv2.Interfaces
{
    using System.Collections;

    /// <summary>
    /// Represents a TextView inside a IWindow
    /// </summary>
    public interface ITextView
    {
        /// <summary>
        /// Returns whether time stamps is enabled for this ITextView buffer.
        /// </summary>
        bool UseTimestamp { get; }

        /// <summary>
        /// Returns the maxmimum buffer for this ITextView.
        /// </summary>
        int MaxBuffer { get; set; }

        /// <summary>
        /// Returns the maxmimum number the scrollbar can scroll to (wrapped) lines.
        /// </summary>
        int MaxScrollbar { get; }

        /// <summary>
        /// Returns the current scrollbar position. (wrapped lines)
        /// </summary>
        int ScrollbarPos { get; }

        /// <summary>
        /// Returns the !TextView buffer lines.
        /// </summary>
        ICollection Lines { get; }

        /// <summary>
        /// Returns the Nth ITextView buffer line.
        /// </summary>
        /// <param name="line">Line number to get</param>
        string GetLine(int line);

        /// <summary>
        ///     Adds a line of text to the ITextView buffer
        ///     Adding lines manually requires all formatting to be done manually as well, format = 
        ///     timestamp + " " + ITools.NickColumChar + nick + ITools.NickColumChar + " " + text
        /// </summary>
        /// <param name="text">Text to add</param>
        /// <param name="lineColor">Linecolor to use for this line</param>
        /// <param name="rgbLineColor">Optional rgb linecolor to use for this line in hex format RRGGBB</param>
        void Add(string text, int lineColor, string rgbLineColor);

        /// <summary>
        ///     Inserts a line of text at the Nth line in the ITextView buffer
        ///     Adding lines manually requires all formatting to be done manually as well, format = 
        ///     timestamp + " " + ITools.NickColumChar + nick + ITools.NickColumChar + " " + text
        /// </summary>
        /// <param name="text">Text to insert</param>
        /// <param name="line">Line number to insert at</param>
        /// <param name="lineColor">Linecolor to use for this line</param>
        /// <param name="rgbLineColor">Optional rgb linecolor to use for this line in hex format RRGGBB</param>
        void Insert(string text, int line, int lineColor, string rgbLineColor);

        /// <summary>
        ///     Replaces the Nth line in the ITextView buffer with a new text
        ///     Adding lines manually requires all formatting to be done manually as well, format = 
        ///     timestamp + " " + ITools.NickColumChar + nick + ITools.NickColumChar + " " + text
        /// </summary>
        /// <param name="text">Text to replace with</param>
        /// <param name="line">Line number to replace at</param>
        /// <param name="lineColor">Linecolor to use for this line</param>
        /// <param name="rgbLineColor">Optional rgb linecolor to use for this line in hex format RRGGBB</param>
        void Replace(string text, int line, int lineColor, string rgbLineColor);

        /// <summary>
        ///     Removes the Nth ITextView buffer line.
        /// </summary>
        /// <param name="start">The first line number(s) to remove</param>
        /// <param name="end">End of line number(s) to remove</param>
        void Remove(int start, int end);

        /// <summary>
        /// Clears the ITextView buffer.
        /// </summary>
        void Clear();

        /// <summary>
        /// Scrolls the scrollbar to the Nth (wrapped) line.
        /// </summary>
        /// <param name="line">The line to scroll to</param>
        void ScrollTo(int line);

        /// <summary>
        /// Scrolls the scrollbar to the unread line marker.
        /// </summary>
        void ScrollToUnreadLine();

        /// <summary>
        /// Scrolls the scrollbar to the start.
        /// </summary>
        void ScrollHome();

        /// <summary>
        /// Scrolls the scrollbar to the end.
        /// </summary>
        void ScrollEnd();

        /// <summary>
        /// Scrolls the scrollbar down 1 (wrapped) line.
        /// </summary>
        void ScrollDown();

        /// <summary>
        /// Scrolls the scrollbar up 1 (wrapped) line.
        /// </summary>
        void ScrollUp();

        /// <summary>
        /// Scrolls the scrollbar 1 page up.
        /// </summary>
        void ScrollPageUp();

        /// <summary>
        /// Scrolls the scrollbar 1 page down.
        /// </summary>
        void ScrollPageDown();
    }
}
