//-------------------------------------------------------------------------------
//  Delegates related to user interactions with a window
//-------------------------------------------------------------------------------

namespace AdiIRCAPIv2.Delegates
{
    using Arguments.WindowInteraction;

    /// <summary>
    ///     Delegate gets called when any IWindow is opened
    /// </summary>
    /// <remarks>
    ///     Scripted Event Equivalent: <c>on OPEN</c>, <c>on JOIN</c>, etc
    /// </remarks>
    /// <param name="argument">WindowOpenArgs</param>
    public delegate void WindowOpened(WindowOpenArgs argument);

    /// <summary>
    ///     Delegate gets called when the window focus changes with in AdiIRC
    /// </summary>
    /// <remarks>
    ///     Scripted Event Equivalent: <c>on ACTIVE</c>
    /// </remarks>
    /// <param name="argument">WindowFocusArgs</param>
    public delegate void WindowFocusChanged(WindowFocusArgs argument);

    /// <summary>
    ///     Delegate gets called any IWindow is closed
    /// </summary>
    /// <remarks>
    ///     Scripted Event Equivalent: extended <c>on CLOSE</c>, <c>on PART</c>, etc
    /// </remarks>
    /// <param name="argument">WindowCloseArgs</param>
    public delegate void WindowClosed(WindowCloseArgs argument);

    /// <summary>
    ///     Delegate gets called any IWindow is renamed
    /// </summary>
    /// <remarks>
    ///     Usually from the commands /renwin, /queryrn or when a user in a private window changes nick.
    /// </remarks>
    /// <param name="argument">WindowRenamedArgs</param>
    public delegate void WindowRenamed(WindowRenamedArgs argument);

    /// <summary>
    ///     Delegate gets called when a menu is opened
    /// </summary>
    /// <param name="argument">MenuEventArgs</param>
    public delegate void Menu(MenuEventArgs argument);

    /// <summary>
    ///     Delegate gets called when a key is pressed down in a Editbox
    /// </summary>
    /// <param name="argument">EditboxKeyDownArgs</param>
    public delegate void EditboxKeyDown(EditboxKeyDownArgs argument);

    /// <summary>
    ///     Delegate gets called when a key is released in a IEditbox
    /// </summary>
    /// <param name="argument">EditboxKeyUpArgs</param>
    public delegate void EditboxKeyUp(EditboxKeyUpArgs argument);

    /// <summary>
    ///     Delegate gets called when a window buffer is scrolled
    /// </summary>
    /// <param name="argument">WindowBufferScrolledArgs</param>
    public delegate void WindowBufferScrolled(WindowBufferScrolledArgs argument);
}