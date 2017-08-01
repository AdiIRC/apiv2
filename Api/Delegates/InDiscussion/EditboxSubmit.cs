/// <exclude />
namespace AdiIRCAPIv2.Delegates.InDiscussion
{
    using Arguments.WindowInteractions;

    /// <summary>
    ///     Delegate gets called when enter is pressed in an editbox and the input is about to be processed
    /// </summary>
    /// <remarks>
    ///     Scripted Event Equivalent: <c>on INPUT</c>
    /// </remarks>
    /// <param name="argument">EditboxSubmitArgs</param>
    public delegate void EditboxSubmit(EditboxSubmitArgs argument);
}