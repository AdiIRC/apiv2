namespace AdiIRCAPIv2.Arguments.WindowInteraction
{
    using Interfaces;

    public class WindowBufferScrolledArgs
    {
        private readonly IWindow window;

        public WindowBufferScrolledArgs(IWindow window)
        {
            this.window = window;
        }

        public IWindow Window { get { return this.window; } }
    }
}
