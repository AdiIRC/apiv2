
namespace AdiIRCAPIv2.Interfaces
{

    /// <summary>
    /// Represents a Editbox inside a IWindow.
    /// </summary>
    public interface IEditbox
    {
        /// <summary>
        /// Returns the IEditbox text
        /// </summary>
        string Text { get; set; }

        /// <summary>
        /// Returns the selection start position in the IEditbox
        /// </summary>
        int SelectionStart { get; set; }

        /// <summary>
        /// Returns the selection length in the IEditbox
        /// </summary>
        int SelectionLength { get; set; }

        /// <summary>
        /// Returns the selected text in the IEditbox
        /// </summary>
        string SelectedText { get; set; }

        /// <summary>
        /// Selects a substring of the Text
        /// </summary>
        /// <param name="start">The start position to select</param>
        /// <param name="length">The length to select</param>
        void Select(int start, int length);
    }


}
