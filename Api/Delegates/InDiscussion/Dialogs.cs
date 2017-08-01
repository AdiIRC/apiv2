/// <exclude />
namespace AdiIRCAPIv2.Delegates.InDiscussion
{
    using Arguments;

    /// <summary>
    ///     Delegate gets called when a Dialog is opened
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Dialog interactions are not currently usable. More thought on implementation is needed before they are ready to be used by plugins
    ///     </para><para>
    ///         Scripted Event Equivalent: <c>on DIALOG</c>
    ///     </para>
    /// </remarks>
    /// <param name="argument">DialogInteractionArgs</param>
    public delegate void DialogOpen(DialogInteractionArgs argument);

    /// <summary>
    ///     Delegate gets called when a Dialog is closed
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Dialog interactions are not currently usable. More thought on implementation is needed before they are ready to be used by plugins
    ///     </para><para>
    ///         Scripted Event Equivalent: <c>on DIALOG</c>
    ///     </para>
    /// </remarks>
    /// <param name="argument">DialogInteractionArgs</param>
    public delegate void DialogClose(DialogInteractionArgs argument);

    /// <summary>
    ///     Delegate gets called when the contents of a Dialog textbox or combobox are changed
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Dialog interactions are not currently usable. More thought on implementation is needed before they are ready to be used by plugins
    ///     </para><para>
    ///         Scripted Event Equivalent: <c>on DIALOG</c>
    ///     </para>
    /// </remarks>
    /// <param name="argument">DialogInteractionArgs</param>
    public delegate void DialogItemEdited(DialogInteractionArgs argument);

    /// <summary>
    ///     Delegate gets called when a dialog item is clicked
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Dialog interactions are not currently usable. More thought on implementation is needed before they are ready to be used by plugins
    ///     </para><para>
    ///         Scripted Event Equivalent: <c>on DIALOG</c>
    ///     </para>
    /// </remarks>
    /// <param name="argument">DialogInteractionArgs</param>
    public delegate void DialogItemClick(DialogInteractionArgs argument);

    /// <summary>
    ///     Delegate gets called when a dialog item is double clicked
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Dialog interactions are not currently usable. More thought on implementation is needed before they are ready to be used by plugins
    ///     </para><para>
    ///         Scripted Event Equivalent: <c>on DIALOG</c>
    ///     </para>
    /// </remarks>
    /// <param name="argument">DialogInteractionArgs</param>
    public delegate void DialogItemDoubleClick(DialogInteractionArgs argument);

    /// <summary>
    ///     Delegate gets called when a dialog item is scrolled
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Dialog interactions are not currently usable. More thought on implementation is needed before they are ready to be used by plugins
    ///     </para><para>
    ///         Scripted Event Equivalent: <c>on DIALOG</c>
    ///     </para>
    /// </remarks>
    /// <param name="argument">DialogInteractionArgs</param>
    public delegate void DialogItemScroll(DialogInteractionArgs argument);

    /// <summary>
    ///     Delegate gets called when a dialog menu item is clicked
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Dialog interactions are not currently usable. More thought on implementation is needed before they are ready to be used by plugins
    ///     </para><para>
    ///         Scripted Event Equivalent: <c>on DIALOG</c>
    ///     </para>
    /// </remarks>
    /// <param name="argument">DialogInteractionArgs</param>
    public delegate void DialogMenuItemClick(DialogInteractionArgs argument);

    /// <summary>
    ///     Delegate gets called when the mouse pointer moves within a dialog
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Dialog interactions are not currently usable. More thought on implementation is needed before they are ready to be used by plugins
    ///     </para><para>
    ///         Scripted Event Equivalent: <c>on DIALOG</c>
    ///     </para>
    /// </remarks>
    /// <param name="argument">DialogInteractionArgs</param>
    public delegate void DialogMouseMove(DialogInteractionArgs argument);

    /// <summary>
    ///     Delegate gets called when the mouse left button is pressed anywhere within a dialog
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Dialog interactions are not currently usable. More thought on implementation is needed before they are ready to be used by plugins
    ///     </para><para>
    ///         Scripted Event Equivalent: <c>on DIALOG</c>
    ///     </para>
    /// </remarks>
    /// <param name="argument">DialogInteractionArgs</param>
    public delegate void DialogMouseClick(DialogInteractionArgs argument);

    /// <summary>
    ///     Delegate gets called when the mouse left button is released anywhere within a dialog
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Dialog interactions are not currently usable. More thought on implementation is needed before they are ready to be used by plugins
    ///     </para><para>
    ///         Scripted Event Equivalent: <c>on DIALOG</c>
    ///     </para>
    /// </remarks>
    /// <param name="argument">DialogInteractionArgs</param>
    public delegate void DialogMouseUnclick(DialogInteractionArgs argument);

    /// <summary>
    ///     Delegate gets called when the mouse is double clicked anywhere within a dialog
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Dialog interactions are not currently usable. More thought on implementation is needed before they are ready to be used by plugins
    ///     </para><para>
    ///         Scripted Event Equivalent: <c>on DIALOG</c>
    ///     </para>
    /// </remarks>
    /// <param name="argument">DialogInteractionArgs</param>
    public delegate void DialogMouseDoubleClick(DialogInteractionArgs argument);

    /// <summary>
    ///     Delegate gets called when the right mouse button is pressed within a dialog.
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Dialog interactions are not currently usable. More thought on implementation is needed before they are ready to be used by plugins
    ///     </para><para>
    ///         Scripted Event Equivalent: <c>on DIALOG</c>
    ///     </para>
    /// </remarks>
    /// <param name="argument">DialogInteractionArgs</param>
    public delegate void DialogMouseRightClick(DialogInteractionArgs argument);

    /// <summary>
    ///     Delegate gets called when a mouse drop event triggers within a dialog.
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Dialog interactions are not currently usable. More thought on implementation is needed before they are ready to be used by plugins
    ///     </para><para>
    ///         Scripted Event Equivalent: <c>on DIALOG</c>
    ///     </para>
    /// </remarks>
    /// <param name="argument">DialogInteractionArgs</param>
    public delegate void DialogMouseDrop(DialogInteractionArgs argument);
}