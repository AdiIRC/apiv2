namespace AdiIRCAPIv2.Interfaces
{
    using System.Collections.Generic;

    /// <summary>
    /// Represents a Nicklist inside a IWindow.
    /// </summary>
    public interface INicklist
    {
        /// <summary>
        /// Returns a list of selected nicks/items in the Nicklist
        /// </summary>
        List<string> SelectedNicks { get; }

        /// <summary>
        /// Returns a list of all nicks/items in the Nicklist
        /// </summary>
        List<string> Nicks { get; }
    }
}
