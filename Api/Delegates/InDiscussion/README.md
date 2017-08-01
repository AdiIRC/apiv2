# Directory Items
The various delegate items in this directory are still under implementation consideration/discussion.
There is no guarantee that any item found in this directory will be implemented in the future. Nor is
there a guarantee that items in this directory that do make it into the api will be the same as what
is seen here.If you find an item in this directory that you are in need of, please feel free to open
an issue ticket to inform us.

# Consideration Items  
The following listed items have yet to have source applied to them but are under
consideration/discussion.  

* **DCCChatOpening** - Triggered before an underlying DCC Chat socket is created  
* **DCCChatOpened** - Triggered when an underlying DCC Chat socket is connects  
* **DCCChatRawbytesReceived** - Triggered when raw data is received from a DCC Chat socket  
* **DCCChatMessageReceived** - `on CHAT`  
* **DCCChatMessageSent** - Triggered when a message is being sent to a connected DCC Chat  
* **DCCChatRawBytesSent** - Triggered when raw bytes are about to be passed to the DCC Chat socket  
* **DCCChatClosing** - Triggered when an underlying DCC Chat socket is being closed(sockerr, requested FIN, closing the DCC Chat window, etc)  
* **DCCChatClosed** - Triggered when an underlying DCC Chat socket is closed  
* **DCCGetStart** - Triggered when a DCCGet is starting  
* **DCCGetFailure** - `on GETFAIL`  
* **DCCGetEnd** - `on FILERCVD`   
* **DCCSendStart** - Triggered when a DCCSend is starting  
* **DCCSendFailure** - `on SENDFAIL`  
* **DCCSendEnd** - `on FILESENT`  