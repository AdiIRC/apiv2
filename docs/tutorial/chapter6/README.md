# Raw Power

Previous chapters covered fairly abstract processed events. Messages to a specific channel, a user joining a channel, etc. But this is not the level of detail IRC actually works at. Most of the time you'll be covered by these higher level events. However sometimes you'll need to do something a little lower down.

Lets go through them in order of Raw-ness.

## [OnRawBytesReceived](https://adiirc.github.io/apiv2/generated/html/07ef03d8-6cad-b5d1-bb79-725d53973c70.htm) and [OnRawByteSent](https://adiirc.github.io/apiv2/generated/html/0afccdd5-0333-a947-62a7-0495b579593b.htm):

These are lowest level of Event, at this point we're not even using strings anymore just raw Bytes. You'll likely never need to use these unless you are working on some form of encryption or data encoding plugin.

## [OnStringDataReceived](https://adiirc.github.io/apiv2/generated/html/d441c4b8-84d1-8e90-a142-90d8bcec4a48.htm) and [OnStringDataSent ](https://adiirc.github.io/apiv2/generated/html/afe00354-0b1b-6dd8-4a38-7cd2669aafc6.htm)

On this level we're dealing with strings. Straight up irc messages as strings. For these events you only get two arguments, Data and Server. You can modify the message directly through Data. And if for some reason you need it to go away you can set Data to null.

## IRC Messages, A Short Primer.

So in order to actually use these events we'll need to know what IRC Messages actually look like. There are many places you could learn this and I'm going to link you to the Ur-Source for them. The [Client Protocol](https://tools.ietf.org/html/rfc2812#section-2.1) and [Server Protocol](https://tools.ietf.org/html/rfc2813) RFCs.

Lets see some messages,go to AdiIRC and type in "/rawlog". Make sure you are connected to a channel with some actual activity and you'll see something a lot like this: 

```
<- :misosoup!~hassa_000@88.98.214.35 PRIVMSG ##csharp :LambdaSix, unless I've missed an update, they haven't since they were introduced
<- :LambdaSix!~nicola@unaffiliated/vesicant PRIVMSG ##csharp :I thought they did on the basis of being valuetypes/structs and the default behaviour for structs is to do memberwise comparison for equality checking
-> PING :wolfe.freenode.net
<- :wolfe.freenode.net PONG wolfe.freenode.net :wolfe.freenode.net
-> PING :wolfe.freenode.net
<- :wolfe.freenode.net PONG wolfe.freenode.net :wolfe.freenode.net
<- :misosoup!~hassa_000@88.98.214.35 PRIVMSG ##csharp :LambdaSix, that's .Equals(). Afaik the == != operators need to be implemented separately,
<- :LambdaSix!~nicola@unaffiliated/vesicant PRIVMSG ##csharp :'Tuples are value types, and their elements are simply public, mutable fields. They have value equality, meaning that two tuples are equal (and have the same hash code) if all their elements are pairwise equal (and have the same hash code).'
<- :Buuu!5be3d702@gateway/web/freenode/ip.91.227.215.2 JOIN ##csharp * :91.227.215.2 - http://webchat.freenode.net
-> PING :wolfe.freenode.net
<- :wolfe.freenode.net PONG wolfe.freenode.net :wolfe.freenode.net
-> PING :wolfe.freenode.net
<- :wolfe.freenode.net PONG wolfe.freenode.net :wolfe.freenode.net
<- :Buuu!5be3d702@gateway/web/freenode/ip.91.227.215.2 PRIVMSG ##csharp :I have method 'public T ReadParam<T>(){ return serializer.Deserialize(reader, T//what should I write here to achieve type?)}
```

Ignoring the -> and <- , those simply indicate input/output. This is literally whats being sent to and from your client. And if you're working with OnStringDataSent/Received this is what you'll have to be parsing.

The PING and PONG lines are simply the server and client checking if they are still connected to each other so lets just forget about those for now. 

```
:misosoup!~hassa_000@88.98.214.35 PRIVMSG ##csharp :LambdaSix, unless I've missed an update, they haven't since they were introduced

:LambdaSix!~nicola@unaffiliated/vesicant PRIVMSG ##csharp :I thought they did on the basis of being valuetypes/structs and the default behaviour for structs is to do memberwise comparison for equality checking

:misosoup!~hassa_000@88.98.214.35 PRIVMSG ##csharp :LambdaSix, that's .Equals(). Afaik the == != operators need to be implemented separately,

:LambdaSix!~nicola@unaffiliated/vesicant PRIVMSG ##csharp :'Tuples are value types, and their elements are simply public, mutable fields. They have value equality, meaning that two tuples are equal (and have the same hash code) if all their elements are pairwise equal (and have the same hash code).'

:Buuu!5be3d702@gateway/web/freenode/ip.91.227.215.2 JOIN ##csharp * :91.227.215.2 - http://webchat.freenode.net

:Buuu!5be3d702@gateway/web/freenode/ip.91.227.215.2 PRIVMSG ##csharp :I have method 'public T ReadParam<T>(){ return serializer.Deserialize(reader, T//what should I write here to achieve type?)}
```

We see two different types of events here PRIVMSG and JOIN. JOIN together with its siblings PART and QUIT inform about people joining, leaving and quitting the channel/network. 

PRIVMSG is responsible for all the hard lifting of irc. Its the actual messages. Yes, channel messages too. 

Lets dissect messages in general for a moment. 

```
:<prefix> <message>
```

Prefix is either the servername or a user identifier. You should be familiar with nicknames, idents and hostmasks already.

Most messages then follow the following format

```
<command> <target> [:<text>]
```

So if we apply this all to PRIVMSG. We see the user its being sent by, the command, the target followed by a space and : and finally the actual message text.

Now this is a highly simplified and by no means complete explanation of the IRC protocol. But it will suffice for the examples to follow. 

## Parsing OnStringDataReceived Messages

Lets imagine an actual reason we need to use OnStringDataReceived. Once again we are just in love with emoji. We want all smilies to be emoji based, and we are so lazy we don't want to hook many different events. 

```c#
public void Initialize(IPluginHost host)
{
    _host = host;

    _host.OnStringDataReceived += OnStringDataReceived;
}

private void OnStringDataReceived(StringDataReceivedArgs argument)
{            
}
```

We only really care about PRIVMSG's, the easiest way to make sure it is actually one of those is with some regex.

```c#
private void OnStringDataReceived(StringDataReceivedArgs argument)
{
    var messageRegex = @":(.+) PRIVMSG ([#\w]+) :(.+)";
    var messageMatch= Regex.Match(argument.Data, messageRegex);

    if (messageMatch.Success)
    {
        var sender = messageMatch.Groups[1].ToString();
        var target = messageMatch.Groups[2].ToString();
        var message = messageMatch.Groups[2].ToString();
    }            
}
```

Now its tempting to simply do a string replace on argument.Data however we have to consider that text smilies start with colons and the text part of the message is separated on a colon. We could accidentally turn the message into one AdiIRC does not understand. 

So we'll have to do our work on message and then reassemble it manually.

```c#
private void OnStringDataReceived(StringDataReceivedArgs argument)
{
    var messageRegex = @":(.+) PRIVMSG ([#\w]+) :(.+)";
    var messageMatch= Regex.Match(argument.Data, messageRegex);

    if (messageMatch.Success)
    {
        var sender = messageMatch.Groups[1].ToString();
        var target = messageMatch.Groups[2].ToString();
        var message = messageMatch.Groups[3].ToString();

        message = message.Replace(":)", "😊");
        message = message.Replace(":p", "😛");

        var newMessage = $":{sender} PRIVMSG {target} :{message}";
        argument.Data = newMessage;
    }            
}
```
[Full Example File](EmojiReplace.cs)

## Faking It ( With FakeRaw )

Sometimes you might need to have AdiIRC receive a message that never actually happened. Maybe because you're building a IRC gateway plugin for a different chat service like Slack or Discord. 

Okay good example but not really useful for a tutorial. Lets just pretend you'd wish people were more polite than they really are, making them apologize for using bad words automatically. Just for you.

```c#
public void Initialize(IPluginHost host)
{
    _host = host;

    _host.OnChannelNormalMessage += OnChannelNormalMessage;
}

private void OnChannelNormalMessage(ChannelNormalMessageArgs argument)
{
    if (argument.Message.Contains("damn"))
    {
        var user = argument.User;

        var sender = $"{user.Nick}!{user.Ident}@{user.Host}";
        var apology = $":{sender} PRIVMSG {argument.Channel.Name} :Sorry, my next message is going to be very rude.";

        argument.Channel.Server.SendFakeRaw(apology);
    }
}
```
[Full Example File](AutoApology.cs)

Lets fire that up and test it:

![Apology](http://i.imgur.com/uxNHtET.png
 "Apology" )

 As you can see the Fake message arrives before the original, since its being called from the Event and it stops handling until the fake message has been sent. Additionally FakeRaw messages do not pass through the event system the same way so you cannot end up in an endless loop.

## Sending Messages

Sending messages, its a core part of an irc client but we've not discussed it before now. There is a good reason for that. Sending messages through this API is a strictly Raw affair, so we had to cover some ground on how that all worked before we could broach the topic. 

But we've covered all the required ground and finally, we can send text to other people. Why ? Many reasons. But lets pretend we're just really stoked to turn that Marco Polo plugin we made at the start into a Marco Polo Irc Bot.

```c#        
public void Initialize(IPluginHost host)
{
    _host = host;

    _host.OnChannelNormalMessage += OnChannelNormalMessage;
}

private void OnChannelNormalMessage(ChannelNormalMessageArgs argument)
{
    if (argument.Message.Contains("!marco"))
    {

    }
}
```

Bots have a long tradition of only reacting to commands that are preceded by a specific character. Often "!" so lets do the same for our new ircbot. 

SendRaw has many similarities with SendFakeRaw but a few key differences. Unlike SendFakeRaw we don't have to supply the nick, hostmask, etc section ourselves AdiIRC will take care of that. And its a message we are actually sending to a server so we are limited in things that the server actually accepts from users. 

Taking that into account sending a Polo back is fairly easy.

```c#        
private void OnChannelNormalMessage(ChannelNormalMessageArgs argument)
{
    if (argument.Message.Contains("!marco"))
    {
        var message = $"PRIVMSG {argument.Channel.Name} :Polo.";

        argument.Channel.Server.SendRaw(message);
    }
}
```
[Full Example File](MarcoPoloBot.cs)

And if we fire that example up and have someone test it out: 

![Marko Polo Bot Reaction](http://i.imgur.com/QEdrL6d.png
 "Marko Polo Bot Reaction" )
