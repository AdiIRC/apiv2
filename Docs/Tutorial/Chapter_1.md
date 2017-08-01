# A basic Plugin: "Hello World"
## The Plugin Interface

The most minimal plugin skeleton looks a little bit like this.

```c#
using AdiIRCAPIv2.Interfaces;

public class ExamplePlugin : IPlugin
{
    public string PluginName => "Example Plugin";
    public string PluginDescription => "Serves as a great example";
    public string PluginAuthor => "";
    public string PluginVersion => "";
    public string PluginEmail => "";

    public void Initialize(IPluginHost host)
    {
    }

    public void Dispose()
    {
    }
}
```

Lets clarify the basic sections of the plugin Interface. Starting with these 5 string fields.

```c#
public string PluginName => "Example Plugin";
public string PluginDescription => "Serves as a great example";
public string PluginAuthor => "";
public string PluginVersion => "";
public string PluginEmail => "";
```


They simply give AdiIRC ( and users ) information about your plugin. Name, Author, Description and Version are displayed in the plugins menu in AdiIRC.

```c#
public void Initialize(IPluginHost host)
{
}
```

Initialize is called when the plugin is loaded by AdiIRC. This where you should probably be doing things like hooking Events and loading settings.

```c#
public void Dispose()
{
}
```

Dispose is called when AdiIRC unloads your plugin but AdiIRC cannot unload .dll plugins while it is running. Dispose will be called while AdiIRC is shutting down. Most of the time you will not need to do anything with Dispose()

The Initialize method gets passed the IPluginHost object as an argument. IPluginHost is actually the main way to interact with AdiIRC. Lets start our first actual plugin by saving that to use it later. This specific tutorial won't need it yet but its a good habit to get into.

```c#
private IPluginHost _host;

public void Initialize(IPluginHost host)
{
    _host = host;
}
```
## Hello World

I promised you a simple "Hello World", as is tradition. So lets get to that.

```c#
public void Initialize(IPluginHost host)
{
    _host = host;

    var activeWindow = _host.ActiveIWindow;
    activeWindow.OutputText("Hello World");            
}
```

[Full Example File](Chapter_1/Hello_World.cs)

_host.ActiveIWindow returns whichever window/buffer is active at the time you call it. This can be a server notification window, a channel, a private message window, etc.

OutputText() will displays some text on that window. But only for your Client. Nothing gets sent to anyone else.

Compile your plugin and load it. And when it loads you should see something like this.

![Hello World Message](http://i.imgur.com/yg0Z7Or.png "Hello World Message" )