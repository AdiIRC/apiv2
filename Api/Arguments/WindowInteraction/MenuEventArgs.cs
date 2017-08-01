namespace AdiIRCAPIv2.Arguments.WindowInteraction
{
    using System;
    using System.Windows.Forms;
    using Enumerators;
    using Interfaces;

    public class MenuEventArgs : EventArgs
    {
        private readonly IWindow window;
        private readonly IServer server;
        private readonly MenuType menuType;
        private readonly MenuContext menuContext;
        private readonly string text;
        private readonly ToolStripItemCollection menuItems;
        private EatData eataData;

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

        public IWindow Window { get { return this.window; } }

        public IServer Server { get { return this.server; } }

        public MenuType MenuType { get { return this.menuType; } }

        public MenuContext MenuContext { get { return this.menuContext; } }

        public string Text { get { return this.text; } }

        public ToolStripItemCollection MenuItems { get { return this.menuItems; } }

        public EatData EatData { get { return this.eataData; } set { this.eataData = value; } }
    }


}
