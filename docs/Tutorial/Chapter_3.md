# 3 Editing and Eating Events

You've got more options when it comes to events than to merely look at them and perhaps do something. 

## Eating Events

Arguments usually come with an EatData property. Lets look at that in a little bit more details

```
Member Name     Description
---------------------------------------------------------
EatNone	        Continue processing the event as usual
EatText	        Hide the text output from this event
EatAll          Stop default processing of the event 
```

So if you want to simply hide an Event you can use EatText but if you want to stop it from producing any additional effects you use EatAll.

## Editing

Most argument fields are ReadOnly but not all. For instance in most of the Message related events the actual text can be changed. Its a good idea to double check what is and what is not ReadOnly.

## Practical Use of EatData

A very common change many irc users are interested in is hiding Join and Part messages. Those messages that let you know when people enter channels, leave channels and quit the network. They find them distracting especially on larger networks.

Lets write an addon that can accomplish that for us. The events we want are OnChannelJoin, OnChannelPart and OnQuit.

```c#
public void Initialize(IPluginHost host)
{
    _host = host;

    _host.OnChannelJoin += OnChannelJoin;
    _host.OnChannelPart += OnChannelPart;
    _host.OnQuit += OnQuit;
}

private void OnChannelJoin(ChannelJoinArgs argument)
{
}

private void OnChannelPart(ChannelPartArgs argument)
{
}

private void OnQuit(QuitArgs argument)
{
}
```

And to hide those messages we'll want to set their EatData to EatText;

```c#
private void OnChannelJoin(ChannelJoinArgs argument)
{
    argument.EatData = EatData.EatText;
}
```
[Full Example File](Chapter_3/JoinPartSimple.cs)

Try it out. You'll see or rather, you won't see anyone joining or leaving channels. But their names still show up in the nicklist and they can still talk just fine.

## Editing Incoming Messages

What if users still want to know how long ago people joined the channel though. Well, we can change the first message someone writes after joining to display how long ago that was.

To edit a normal message in chat we'll need to hook OnChannelNormalMessage. 

```c#
public void Initialize(IPluginHost host)
{
    _host = host;

    _host.OnChannelNormalMessage += OnChannelNormalMessage;

    _host.OnChannelJoin += OnChannelJoin;
    _host.OnChannelPart += OnChannelPart;
    _host.OnQuit += OnQuit;
}

private void OnChannelNormalMessage(ChannelNormalMessageArgs argument)
{            
}
```

And we can change the message by simply editing the argument.Message field. 


```c#
private void OnChannelNormalMessage(ChannelNormalMessageArgs argument)
{
    argument.Message += " Hello!";
}
```

We can store the time the user joined in OnChannelJoin which we're already using. 

```c#
private Dictionary<string, DateTime> _joinTimes;

private public()
{
    _joinTimes = new Dictionary<string, DateTime>();
}

private void OnChannelJoin(ChannelJoinArgs argument)
{
    if(!_joinTimes.ContainsKey(argument.User.Ident))
    {
        _joinTimes.Add(argument.User.Ident,DateTime.Now);
    }
    else
    {
        _joinTimes[argument.User.Ident] = DateTime.Now;                
    }

    argument.EatData = EatData.EatText;
}
```

And then its simply a case of doing some math with datetime and appending it to the argument.Message in OnChannelNormalMessage;

```c#
private void OnChannelNormalMessage(ChannelNormalMessageArgs argument)
{
    if (_joinTimes.ContainsKey(argument.User.Ident))
    {
        var timeSince = (DateTime.Now - _joinTimes[argument.User.Ident]).TotalMinutes;
        _joinTimes.Remove(argument.User.Ident);

        argument.Message += $" (Joined {timeSince} Minues Ago)";
    }
}
```
[Full Example File](Chapter_3/JoinPart.cs)

Lets compile that, load it and test it.

![Edited User Message](http://i.imgur.com/3eUCUfi.png
 "Edited User Message]" )

Okay, yes. Clearly this has some major flaws still. For one that message is terrible and only counts in minutes, and is not nicely rounded. For another this plugin does not gracefully handle the same user across multiple channels or servers. 

So consider that homework. As another thing to consider imagine and implement a way to show joins and parts in small channels but not large ones. 