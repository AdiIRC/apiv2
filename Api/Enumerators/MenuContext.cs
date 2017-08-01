namespace AdiIRCAPIv2.Enumerators
{
    /// <summary>
    ///     Enumerator used to indicate what type of menu is being interacted with
    /// </summary>
    public enum MenuContext
    {
        /// <summary>
        ///     The menu was opened by right clicking a window instance
        /// </summary>
        Window = 0,

        /// <summary>
        ///     The menu was opened from text being hotlinked
        /// </summary>
        Hotlink = 1,

        /// <summary>
        ///     The menu was opened by right clicking the main toolbar
        /// </summary>
        Toolbar = 2,

        /// <summary>
        ///     The menu was opened by right clicking the switchbar
        /// </summary>
        Switchbar = 3,

        /// <summary>
        ///     The menu was opened by right clicking the toolbar
        /// </summary>
        Treebar = 4
    }
}
