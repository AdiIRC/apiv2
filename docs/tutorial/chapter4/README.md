# Magnificent Menus

Commands are nice but they are very limited and by their very nature text only. AdiIRC is a GUI program, there are GUI elements you might want to hook into for interaction. And for most situations you'll want to hook into menus.

## OnMenu

IPluginHost.OnMenu(MenuEventArgs argument) is called for virtually all right-click menus and for the Commands menu. That is a lot of menus it could potentially be. However we get two fields that give information on how it was fired.

First argument.MenuType will inform us about the nature of the Menu

```
None		    Indicates the OnMenu event has no type
Server		    Indicates the OnMenu event is for a Server window
Channel		    Indicates the OnMenu event is for a Channel window
Private		    Indicates the OnMenu event is for a Private window
Custom		    Indicates the OnMenu event is for a Custom window
Nicklist            Indicates the OnMenu event is for a Nicklist nick
Menubar		    Indicates the OnMenu event is for the Menubar
ChannelLink	    Indicates the OnMenu event is for a Channel link
Link		    Indicates the OnMenu event is for a link 
```
OnMenu
And second argument.MenuContext informs us as to how this menu was opened. 

```
Window		The menu was opened by right clicking a window instance
Hotlink		The menu was opened from text being hotlinked
Toolbar		The menu was opened by right clicking the main toolbar
Switchbar	The menu was opened by right clicking the switchbar
Treebar		The menu was opened by right clicking the treebar 
```

Say you wanted to add another entry to the rightclick menu of hyperlinks.

```c#
public void Initialize(IPluginHost host)
{
    _host = host;

    _host.OnMenu += OnMenu;
}

private void OnMenu(MenuEventArgs argument)
{
    if (argument.MenuContext == MenuContext.Hotlink)
    {        
    }
}
```

Now that we know how to determine what menu to change. How do we change it ? Well if we inspect argument.MenuItems we find its a standard .net [ToolStripItemCollection](https://msdn.microsoft.com/en-us/library/system.windows.forms.toolstripitemcollection(v=vs.110).aspx) and the internet has plenty of examples and documentation on those. 

Lets implement something practical. You've got a plugin with a lot of options and you want to add a menu to access those. The easiest and most logical place to add that is the Commands menu in the main menu bar.

```c#
private void OnMenu(MenuEventArgs argument)
{
    if (argument.MenuType == MenuType.Menubar)
    {
        var menuItem = new ToolStripMenuItem("Example Menu Item");
        menuItem.Click += delegate {
            //Do Something
        };

        argument.MenuItems.Add(menuItem);
    }
}
```
[Full Example File](SimpleMenu.cs)

Oh but you might be running into an issue now. We started this plugin as a Class Library. And that means you don't get built in reference to System.Windows.Forms, or System.Drawing. So [add](https://msdn.microsoft.com/en-us/library/wkze6zky.aspx) references to those and a using statement for System.Windows.Forms.

Compile that, load it and lets check the Commands menu:

![Menu Example](http://i.imgur.com/G5SJgA4.png "Menu Example" )

Of course it doesn't actually do anything since we neglected to put any code in the Click delegate. 

## Windows Forms

Despite being "just" a plugin we are actually operating in a full normal .net environment. And just because we created a Application Library process doesn't mean we can't have normal .net Forms. 

So if we want to we can simply just show a form on our menu click action. So lets do that. 

```c#
private Form _menuForm;

public void Initialize(IPluginHost host)
{
    _host = host;

    _host.OnMenu += OnMenu;

    var menuCloseButton = new Button { Text = "Close" };
    menuCloseButton.Click += (sender, args) => { _menuForm.Hide(); };

    _menuForm = new Form
    {
        Size = new Size(200, 200),                
        Controls = { menuCloseButton}                
    };                        
}

private void OnMenu(MenuEventArgs argument)
{
    if (argument.MenuType == MenuType.Menubar)
    {
        var menuItem = new ToolStripMenuItem("Example Menu Item");
        menuItem.Click += delegate {
            _menuForm.Show();
        };

        argument.MenuItems.Add(menuItem);
    }
}
```
[Full Example File](Form.cs)

![Form Example](http://i.imgur.com/hD0Cj4f.png "Form Example" )

This is of course a pretty quick and dirty bare-bones form. You'll want to use the form designer instead of building one in Initialize. 

## Toolbar

One major place left where we can put buttons. The Toolbar. Right now AdiIRC's API does not let us actually do anything with the toolbar. Once it does this tutorial will be updated.

