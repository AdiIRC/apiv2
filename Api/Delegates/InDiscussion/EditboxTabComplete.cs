/// <exclude />
namespace AdiIRCAPIv2.Delegates.InDiscussion
{
    using Arguments.WindowInteractions;

    /// <summary>
    ///     Delegate gets called when the tab-complete key is pressed in an editbox and AdiIRC is about to perform tab completion
    /// </summary>
    /// <remarks>
    ///     Scripted Event Equivalent: <c>on TABCOMP</c>
    /// </remarks>
    /// <param name="argument">EditboxTabCompleteArgs</param>
    public delegate void EditboxTabComplete(EditboxTabCompleteArgs argument);
}