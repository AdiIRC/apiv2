namespace AdiIRCAPIv2.Interfaces
{
    /// <summary>
    /// Inherit from this class in your plugin, e.g class MyPlugin : IPlugin
    /// </summary>
    public interface IPlugin
    {
        /// <summary>
        /// Get/Set plugin name. (optional)
        /// </summary>
        string PluginName { get; }

        /// <summary>
        /// Get/Set plugin description. (optional)
        /// </summary>
        string PluginDescription { get; }

        /// <summary>
        /// Get/Set your name/nick. (optional)
        /// </summary>
        string PluginAuthor { get; }

        /// <summary>
        /// Get/Set plugin version. (optional)
        /// </summary>
        string PluginVersion { get; }

        /// <summary>
        /// Your email for support. (optional)
        /// </summary>
        string PluginEmail { get; }

        /// <summary>
        /// Called when plugin is loaded
        /// </summary>
        /// <param name="pluginHost">Reference to the IPluginHost hosting this plugin</param>
        void Initialize(IPluginHost pluginHost);

        /// <summary>
        /// Called when plugin is unloaded
        /// </summary>
        void Dispose();
    }


}
