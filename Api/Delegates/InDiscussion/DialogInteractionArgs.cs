namespace AdiIRCAPIv2.Arguments
{
    using System;
    using Interfaces;

    public class DialogInteractionArgs : EventArgs
    {
        private readonly IServer server;
        private readonly string dialogName;
        private readonly string dialogEvent;

        // zero for DialogOpen, DialogClose, and DialogMouse* events
        private readonly int    dialogItemId;

        // position is relative to the dialog
        private readonly int mouseXPosition;
        private readonly int mouseYPosition;
        private readonly int mouseKey;

        /*public void DialogInteractionArgs(IServer server, string dialogName, string dialogEvent, int dialogItemId, int mouseXPosition, int mouseYPosition, int mouseKey)
        {
            throw new Exception("NOT_READY_FOR_USE");
        }*/

        public IServer Server { get { return this.server; } }

        public string DialogName { get { return this.dialogName; } }

        public string DialogEvent { get { return this.dialogEvent; } }

        public int DialogItemId { get { return this.dialogItemId; } }

        public int MouseXPosition { get { return this.mouseXPosition; } }

        public int MouseYPosition { get { return this.mouseYPosition; } }

        public int MouseKey { get { return this.mouseKey; } }
    }
}
