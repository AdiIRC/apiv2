# 2 Commands and Events

## Hooking Commands
In order for plugins to actually do anything you'll need to interact with the AdiIRC client, or  be able to be interacted with. One of the most common ways scripts and plugins have added functionality to irc clients over the years has been in the forms of slash commands. 

AdiIRC already has [many](https://dev.adiirc.com/projects/adiirc/wiki/Scripting_Commands) such commands built in by default. Commands like /advertise which lets other people know what client you are using and /echo which is used to display text in a window.

Here is the simplest form of registering such a command.

```c#        
public void Initialize(IPluginHost host)
{            
    host.HookCommand("/commandName", CommandHandler);
}

private void CommandHandler(RegisteredCommandArgs argument)
{
    //Do Something            
}
```

HookCommand takes a string for the command itself and a Handler Method. And you can create as many commands this way as you need. But what if you try to register a command that already  exists though ? 

Well HookCommand returns a boolean. If it did not succeed for some reason it'll return false. Lets rewrite that hook to take that into account.

```c#
if(!host.HookCommand("/commandName", CommandHandler))
{
    host.ActiveIWindow.OutputText("Could not create the /commandName command.");
}
```

## Executing Commands

Not only can you create your own commands. You can also use other commands yourself. For instance to use those made by other plugins or scripts. Or to use commands that don't have an API equivalent yet. 

You can do so by using the ExecuteCommand() method you can find on IWindow objects. Lets pull all of that together into a working practical example.

```c#
public void Initialize(IPluginHost host)
{
    _host = host;

    if(!_host.HookCommand("/marco", CommandHandler))
    {
        _host.ActiveIWindow.OutputText("Could not create the /marco command.");
    }
}

private void CommandHandler(RegisteredCommandArgs argument)
{
    _host.ActiveIWindow.ExecuteCommand(".echo ExamplePlugin Polo");
}
``` 
[Full Example File](Chapter_2/MarcoPolo.cs)

Commands that are invoked with a . instead of a / are silent. That means they'll execute without producing additional text. 

[Echo](https://dev.adiirc.com/projects/adiirc/wiki/Echo) will output text to a window but gives us much more control over what that text will look like than OutputText() does. The first obvious difference here is that the first argument after /echo populates the nickname portion of a message. So we are using that to let the user know that our plugin is responsible for the message. /echo is a complex command with many options and I recommend looking at them in detail before using i.t 

Lets build our code and load it in AdiIRC. Now when you pause the /marco in any window, you will see the following response.

![Marco Polo Message](http://i.imgur.com/zxqXwld.png "Marco Polo Message" )

## argument

One part of CommandHandler we have not yet discussed is that RegisteredCommandArgs argument. Lets have a look at that shall we. If you use intellisense you'll something like this 

![RegisteredCommandArgs Intellisense](http://i.imgur.com/areeRZZ.png "RegisteredCommandArgs Intellisense" )


Okay that could be more clear. Luckily, there is [Documentation](https://adiirc.com/docsv2/html/b188f817-d351-7802-e9a1-6907dc8377be.htm).  Lets see what it has to say about [RegisteredCommandArgs](https://adiirc.com/docsv2/html/ed81f664-3e35-fcb5-0893-a19382ce145b.htm)

```
Public string	Command	- Returns the name of the command called
Public IWindow	Window  - Returns the IWindow for which the command was called from 
```

argument.Window is a reference to the window the user was on when they used the commands. And argument.Command holds the entire string for the command that was used.

So we can replace our dependance on _host.CurrentIWindow by using argument.Window. 

```c#
private void CommandHandler(RegisteredCommandArgs argument)
{
    argument.Window.OutputText("polo");
}
```

And we can use argument.Command to pass different arguments to our command.

```c#
private void CommandHandler(RegisteredCommandArgs argument)
{
    if (argument.Command.Contains("shout"))
    {
        argument.Window.OutputText("POLO");
    }
    else
    {
        argument.Window.OutputText("polo");
    }            
}
```
[Full Example File](Chapter_2/MarcoPoloShout.cs)

Now if we compile and load this. And use the command "/marco shout" we'll get an all caps POLO instead.

![Marco Polo shout](http://i.imgur.com/4eYvFXP.png
 "Marco Polo shout" )

Argument objects are a core part of the AdiIRC API, they keep method signatures for events clean and helps prevent breaking changes to the API with updates. Its always a good idea to look up the arguments class for whatever event you are using. 

## Events
