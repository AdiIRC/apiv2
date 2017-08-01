namespace AdiIRCAPIv2.Enumerators
{
    /// <summary>
    ///     Used to determine the menu type during a OnMenu event
    /// </summary>
    public enum MenuType
    {
        /// <summary>
        ///     Indicates the OnMenu event has no type
        /// </summary>
        None = 0,

        /// <summary>
        ///     Indicates the OnMenu event is for a Server window
        /// </summary>
        Server = 1,

        /// <summary>
        ///     Indicates the OnMenu event is for a Channel window
        /// </summary>
        Channel = 2,

        /// <summary>
        ///     Indicates the OnMenu event is for a Private window
        /// </summary>
        Private = 3,

        /// <summary>
        ///     Indicates the OnMenu event is for a Custom window
        /// </summary>
        Custom = 4,

        /// <summary>
        ///     Indicates the OnMenu event is for a Nicklist nick
        /// </summary>
        Nicklist = 5,

        /// <summary>
        ///     Indicates the OnMenu event is for the Menubar
        /// </summary>
        Menubar = 6,

        /// <summary>
        ///     Indicates the OnMenu event is for a Channel link
        /// </summary>
        ChannelLink = 7,

        /// <summary>
        ///     Indicates the OnMenu event is for a link
        /// </summary>
        Link = 8
    }
}
