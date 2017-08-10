namespace AdiIRCAPIv2.Enumerators
{
    /// <summary>
    ///     Used to determine the loading status of a Plugin Script file
    /// </summary>
    public enum PluginScriptLoadType
    {
        /// <summary>
        ///     Indicates the script file is loaded during plugin load
        /// </summary>
        Starting = 0,

        /// <summary>
        ///     Indicates the script file is loading for the first time
        /// </summary>
        Loading = 1,

        /// <summary>
        ///     Indicates the script file is reloading
        /// </summary>
        Reloading = 2
    }
}
