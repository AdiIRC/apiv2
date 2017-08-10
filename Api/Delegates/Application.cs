//-------------------------------------------------------------------------------
//     Delegates related to the application's overall state.
//-------------------------------------------------------------------------------

namespace AdiIRCAPIv2.Delegates
{
    using Arguments.Application;

    /// <summary>
    ///     Delegate gets called after all plugins and scripts have been initialized
    /// </summary>
    /// <remarks>
    ///     Scripted Event Equivalent: <c>on START</c>
    /// </remarks>
    /// <param name="argument">ApplicationStartedArgs</param>
    public delegate void ApplicationStarted(ApplicationStartedArgs argument);

    /// <summary>
    ///     Delegate gets called when AdiIRC receives or loses focus
    /// </summary>
    /// <remarks>
    ///     Scripted Event Equivalent: <c>on APPACTIVE</c>
    /// </remarks>
    /// <param name="argument">ApplicationFocusChangedArgs</param>
    public delegate void ApplicationFocusChanged(ApplicationFocusChangedArgs argument);

    /// <summary>
    ///     Delegate gets called when the host OS goes into sleep/hibernation mode
    /// </summary>
    /// <remarks>
    ///     Scripted Event Equivalent: <c>on SUSPEND</c>
    /// </remarks>
    /// <param name="argument">ApplicationHostSuspendedArgs</param>
    public delegate void ApplicationHostSuspended(ApplicationHostSuspendedArgs argument);

    /// <summary>
    ///     Delegate gets called when the host OS comes back from sleep/hibernation mode
    /// </summary>
    /// <remarks>
    ///     Scripted Event Equivalent: <c>on RESUME</c>
    /// </remarks>
    /// <param name="argument">ApplicationHostWokenArgs</param>
    public delegate void ApplicationHostWoken(ApplicationHostWokenArgs argument);

    /// <summary>
    ///     Delegate gets called when AdiIRC is closing
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Called before the plugin's .Dispose() method
    ///     </para><para>
    ///         Scripted Event Equivalent: <c>on EXIT</c>
    ///     </para>
    /// </remarks>
    public delegate void ApplicationClosing(ApplicationClosingArgs argument);

    /// <summary>
    ///     Delegate gets called when the user changes options and the config file is reloaded
    /// </summary>
    /// <remarks>
    ///     Scripted Event Equivalent: <c>on OPTIONS</c>
    /// </remarks>
    public delegate void ApplicationOptionsChanged(ApplicationOptionsChangedArgs argument);
}