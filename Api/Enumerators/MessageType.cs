namespace AdiIRCAPIv2.Enumerators
{
    /// <summary>
    ///     Message type for OnMessageSent
    /// </summary>
    public enum MessageType
    {
        /// <summary>
        ///    Indicates the message type is a PRIVMSG
        /// </summary>
        PRIVMSG = 0,

        /// <summary>
        ///    Indicates the message type is a NOTICE
        /// </summary>
        NOTICE = 1,
    }
}
