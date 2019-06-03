namespace AdiIRCAPIv2.Interfaces
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// Represents a form window
    /// </summary>
    public interface IWindow
    {
        /// <summary>
        /// Return the name of the IWindow.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Return the internal window name of the IWindow.
        /// </summary>
        string RealWindowName { get; }

        /// <summary>
        /// Returns the IWindow title text.
        /// </summary>
        string Title { get; }

        /// <summary>
        /// Return the IWindow window handle.
        /// </summary>
        IntPtr WindowHandle { get; }

        /// <summary>
        /// Returns whether the IWindow is a MDI child.
        /// </summary>
        bool IsMdiChild { get; }

        /// <summary>
        /// Returns the IWindow window state.
        /// </summary>
        FormWindowState WindowState { get; set; }

        /// <summary>
        /// Returns whether the IWindow is visible.
        /// </summary>
        bool Visible { get; set; }

        /// <summary>
        /// Returns the name of the log file associated with this IWindow.
        /// </summary>
        string LogFile { get; }

        /// <summary>
        /// Returns the window id of this IWindow.
        /// </summary>
        int WindowId { get; }

        /// <summary>
        /// Returns the IServer associated with this IWindow.
        /// </summary>
        IServer Server { get; }

        /// <summary>
        /// Returns the IEditbox associated with this IWindow.
        /// </summary>
        /// <remarks>
        ///     Can return null on windows without a Editbox
        /// </remarks>
        IEditbox Editbox { get; }

        /// <summary>
        /// Returns the ITextView associated with this IWindow.
        /// </summary>
        /// <remarks>
        ///     Can return null on windows without a TextView
        /// </remarks>
        ITextView TextView { get; }

        /// <summary>
        /// Returns number of unread messages in this IWindow.
        /// </summary>
        int UnreadMessages { get; }

        /// <summary>
        /// Returns whether the IWindow is a picture window.
        /// </summary>
        bool PictureWindow { get; }

        /// <summary>
        /// Evaluates identifiers in a script line to this IWindow.
        /// </summary>
        /// <param name="text">Text to evaluate</param>
        /// <param name="parameters">Optional parameters to use for $1-</param>
        /// <returns>The evaluated text</returns>
        string Evaluate(string text, string parameters);

        /// <summary>
        /// Outputs a message to this IWindow.
        /// </summary>
        /// <param name="message">Message to output</param>
        /// <returns>True/False depending if the output was successful</returns>
        /// <remarks>
        ///     Some windows does not have a TextView, the output will be ignored and return false in these cases.
        /// </remarks>
        bool OutputText(string message);

        /// <summary>
        /// Executes a /command to this IWindow.
        /// </summary>
        /// <param name="command">Command to execute</param>
        /// <returns>True/False depending if the send was successful</returns>
        bool ExecuteCommand(string command);
    }
}
