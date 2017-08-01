/// <summary>
///     Enumerator used to indicate how further processing of an event should continue
/// </summary>
namespace AdiIRCAPIv2.Enumerators
{
    /// <summary>
    ///     Return data for delegates to indicate whether AdiIRC should continue with the event processing.
    /// </summary>
    public enum EatData
    {
        /// <summary>
        ///    Continue processing the event as usual
        /// </summary>
        EatNone = 0,

        /// <summary>
        ///     Hide the text output from this event.
        /// </summary>
        /// <remarks>
        ///     Scripted Equivalent: /haltdef
        /// </remarks>
        EatText = 1,

        /// <summary>
        ///     Stop default processing of the event
        /// </summary>
        /// <remarks>
        ///     Scripted Equivalent: /halt
        /// </remarks>
        EatAll = 2
    }
}
