namespace AdiIRCAPIv2.Arguments.WindowInteraction
{
    using System;
    using System.Windows.Forms;
    using Enumerators;
    using Interfaces;

    /// <summary>
    ///     Arguments class passed to the MenuEvent event
    /// </summary>
    public class MenuEventArgs : EventArgs
    {
        private readonly IWindow window;
        private readonly IServer server;
        private readonly MenuType menuType;
        private readonly MenuContext menuContext;
        private readonly string text;
        private readonly ToolStripItemCollection menuItems;
        private EatData eataData;

        /// <summary>
        ///     Constructor for arguments class passed to the MenuEvent event
        /// </summary>
        /// <param name="window">IWindow</param>
        /// <param name="server">IServer</param>
        /// <param name="menuType">MenuType</param>
        /// <param name="menuContext">MenuContext</param>
        /// <param name="text">string</param>
        /// <param name="menuItems">ToolStripItemCollection</param>
        /// <param name="eatData">EatData</param>
        public MenuEventArgs(IWindow window, IServer server, MenuType menuType, MenuContext menuContext, string text, ToolStripItemCollection menuItems, EatData eatData)
        {
            this.window = window;
            this.server = server;
            this.menuType = menuType;
            this.menuContext = menuContext;
            this.text = text;
            this.menuItems = menuItems;
            this.eataData = eatData;
        }

        /// <summary>
        ///     Returns the IWindow where the menu is to be shown
        /// </summary>
        public IWindow Window { get { return this.window; } }

        /// <summary>
        ///     Returns the IServer where the event occured
        /// </summary>
        public IServer Server { get { return this.server; } }

        /// <summary>
        ///     Returns the menu type of this menu
        /// </summary>
        public MenuType MenuType { get { return this.menuType; } }

        /// <summary>
        ///     Returns the menu context of this menu
        /// </summary>
        public MenuContext MenuContext { get { return this.menuContext; } }

        /// <summary>
        ///     Returns the text parameter of this menu
        /// </summary>
        /// <remarks>
        ///     It can be a window name or a nick
        /// </remarks>
        public string Text { get { return this.text; } }

        /// <summary>
        ///     Returns a list of all the menu items in this menu
        /// </summary>
        public ToolStripItemCollection MenuItems { get { return this.menuItems; } }

        /// <summary>
        ///     Gets or sets the current event proccessing state
        /// </summary>
        public EatData EatData { get { return this.eataData; } set { this.eataData = value; } }
    }


}
