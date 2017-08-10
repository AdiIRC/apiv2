namespace AdiIRCAPIv2.Arguments.ChannelModes
{
    using System;
    using System.Collections.Generic;
    using Enumerators;
    using Interfaces;

    /// <summary>
    ///     Arguments class passed to the ChannelModeUserVoiced event
    /// </summary>
    public class ChannelModeUserVoicedArgs : EventArgs
    {
        private readonly IWindow window;
        private readonly IServer server;
        private readonly IChannel channel;
        private readonly IUser user;
        private readonly IChannelUser byUser;
        private readonly bool modeFirst;
        private readonly bool modeLast;
        private readonly string rawMessage;
        private readonly string rawBytes;
        private readonly DateTime serverTime;
        private readonly IDictionary<string, string> messageTags;
        private EatData eatData;

        /// <summary>
        ///     Constructor for arguments class passed to the ChannelModeUserVoiced event
        /// </summary>
        /// <param name="window">IWindow</param>
        /// <param name="server">IServer</param>
        /// <param name="channel">IChannel</param>
        /// <param name="user">IUser</param>
        /// <param name="byUser">IChannelUser</param>
        /// <param name="modeFirst">bool</param>
        /// <param name="modeLast">bool</param>
        /// <param name="rawMessage">string</param>
        /// <param name="rawBytes">string</param>
        /// <param name="serverTime">DateTime</param>
        /// <param name="messageTags">IDictionary></param>
        /// <param name="eatData">EatData></param>
        public ChannelModeUserVoicedArgs(IWindow window, IServer server, IChannel channel, IUser user, IChannelUser byUser, bool modeFirst, bool modeLast, string rawMessage, string rawBytes, DateTime serverTime, IDictionary<string, string> messageTags, EatData eatData)
        {
            this.window = window;
            this.server = server;
            this.channel = channel;
            this.user = user;
            this.byUser = byUser;
            this.modeFirst = modeFirst;
            this.modeLast = modeLast;
            this.rawMessage = rawMessage;
            this.rawBytes = rawBytes;
            this.serverTime = serverTime;
            this.messageTags = messageTags;
            this.eatData = eatData;
        }

        /// <summary>
        ///     Returns the IWindow where the user got voiced
        /// </summary>
        public IWindow Window { get { return this.window; } }

        /// <summary>
        ///     Returns the IServer where the event occured
        /// </summary>
        public IServer Server { get { return this.server; } }

        /// <summary>
        ///     Returns the IChannel where the user got voiced
        /// </summary>
        public IChannel Channel { get { return this.channel; } }

        /// <summary>
        ///     Returns the IUser which got voiced
        /// </summary>
        public IUser User { get { return this.user; } }

        /// <summary>
        ///     Returns the IChannelUser who performed the mode change
        /// </summary>
        public IChannelUser ByUser { get { return this.byUser; } }

        /// <summary>
        ///     Returns true if this was the first mode change in the channel mode event
        /// </summary>
        public bool ModeFirst { get { return this.modeFirst; } }

        /// <summary>
        ///     Returns true if this was the last mode change in the channel mode event
        /// </summary>
        public bool ModeLast { get { return this.modeLast; } }

        /// <summary>
        ///     Returns the raw event message
        /// </summary>
        public string RawMessage { get { return this.rawMessage; } }

        /// <summary>
        ///     Returns the raw event message without decoding
        /// </summary>
        public string RawBytes { get { return this.rawBytes; } }

        /// <summary>
        ///     Returns the time the event was recieved
        /// </summary>
        /// <remarks>
        ///     If no IRCv3 @time tag was found in the raw line, returns the current time in UTC format
        /// </remarks>
        public DateTime ServerTime { get { return this.serverTime; } }

        /// <summary>
        ///     Returns a list of IRCv3 tags found in the raw line
        /// </summary>
        public IDictionary<string, string> MessageTags { get { return this.messageTags; } }

        /// <summary>
        ///     Gets or sets the current event proccessing state
        /// </summary>
        public EatData EatData { get { return this.eatData; } set { this.eatData = value; } }
    }
}