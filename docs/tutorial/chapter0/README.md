# Setting up a Project

After starting visual studio create a New Project (File->New->Project). Plugins are standard dekstop .net .dll files so we'll be making a Windows Classic Desktop Class Library ( .NET Framework )

![New Project Window Settings](http://i.imgur.com/bU9BbNq.png "New Project Window Settings")

The plugin will need to implement an Interface provided by AdiIRC. To access that Interface we'll need to reference a library. 

![Project Add Reference](http://i.imgur.com/APlCTYM.png "Project Add Reference")

Since its not in the default references, go to the browse section and click the browse button. AdiIRC automatically keeps an up to date version of the current API .dll's in its config folder. If its installed normally this can usually be found in "%USERPROFILE%\AppData\Local\AdiIRC" but in Portable versions it should be in the normal directory.

![References Browse Dialog](http://i.imgur.com/8zfqUTg.png" )

Add a reference to "AdiIRCAPIv2.dll", make sure the reference is checked, then press OK. 

Now that we have access to the API we can actually get started. You'll want to  have your class inherit from IPlugin.

First add a using statement for the API library.

```c#
using AdiIRCAPIv2.Interfaces;
```

Then add the actual Interface to your class.

```c#
public class ExamplePlugin : IPlugin
{
}
```

It won't compile because you're not implementing the required members yet. Here is a copy of the above class with all the required members. Just copy and paste them in place for now.

```c#
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

Build it (ctrl-shift-b or through the Build menu), it should build without errors. Now we'll want to add it to AdiIRC. 

[Open](http://i.imgur.com/q50S6YB.png) your project in your file explorer and navigate to "bin\Debug" here you can find your plugins .dll file ( not AdiIRCAPIv2.dll ). 

We're going to add it to AdiIRC, plugins go into the Plugin folder of AdiIRC's configuration folder. So "%USERPROFILE%\AppData\Local\AdiIRC\Plugins" for normal installations or just the directory you have the portable version in. 

Copy the .dll and bring up the AdiIRC window. Go to File->Plugins, your new plugin should be in the list.

![AdiIRC - Plugins dialog](http://i.imgur.com/LdpsjaI.png" "AdiIRC - Plugins dialog")

Click "Load", that is it. Though it doesn't do anything yet your new plugin is now loaded. 