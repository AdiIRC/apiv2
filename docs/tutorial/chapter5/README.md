# Editing the Editbox

The Editbox in case you are not aware is the name of the thing you type words into to chat. There are plenty of reasons you might want to be able to edit whats going in there. 

Imagine for a moment that you are a great fan of emoji. You want to share emoji with everyone else. But they're hard to type so you want to create an addon to replace simple text smileys with emoji as you type.

First we'll need an event for typing in the Editbox. There is two: OnEditboxKeyUp and OnEditboxKeyDown. We'll use KeyUp.

```c#
public void Initialize(IPluginHost host)
{
    _host = host;

    _host.OnEditboxKeyUp += OnEditboxKeyUp;
}

private void OnEditboxKeyUp(EditboxKeyUpArgs argument)
{    
}
```

## IEditbox

Lets examine IEditbox which is part of argument in this event for a moment:

```
Public string   SelectedText        The selected text in the IEditbox
Public int      SelectionLength     The selection length in the IEditbox
Public int      SelectionStart	    The selection start position in the IEditbox
Public string   Text	            The IEditbox text 
```

Okay that seems straightforward enough. We can just edit Text directly. We can just replace our text smilies with emoji like this.

```c#
private void OnEditboxKeyUp(EditboxKeyUpArgs argument)
{
    var text = argument.Editbox.Text;
    
    text = text.Replace(":)", "😊");
    text = text.Replace(":p", "😛");

    if (text != argument.Editbox.Text)
    {
        argument.Editbox.Text = text;
    }            
}
```

We run that, type a sentence add a :) and... Our cursor is now at the start of the line. What happened ?

## Keeping track of Cursor location

Anytime you edit the text of IEditbox its going ot reset the cursor to the starting position. So you'll need to fix that yourself. 

How ? Well if you're aware of how .net textboxes work you probably already know. Cursor position is identical to SelectionStart. Selectionstart is very simply just an int corresponding to the index of the character the cursor is currently "behind".

We can fix our problem by setting the cursor to the old location, minus the amount of characters we removed. 


```c#
private void OnEditboxKeyUp(EditboxKeyUpArgs argument)
{
    var text = argument.Editbox.Text;
    
    text = text.Replace(":)", "😊");
    text = text.Replace(":p", "😛");

    if (text != argument.Editbox.Text)
    {
        var cursorPosition = argument.Editbox.SelectionStart;
        cursorPosition -= argument.Editbox.Text.Length - text.Length;

        argument.Editbox.Text = text;
        argument.Editbox.SelectionStart = cursorPosition;
    }          
}
```
[Full Example File](SmilyBox.cs)

## Exitbox in IWindows

You might want to read or edit the Editbox content outside of KeyUp or KeyDown events. Thats quite possible. Every instance of IWindow ( Servers, Channels, Private Messages, etc ) has an Editbox.

So if you wanted, you could do something like this.

```c#
public void Initialize(IPluginHost host)
{
    _host = host;

    _host.ActiveIWindow.Editbox.Text = "Hello World";
    _host.ActiveIWindow.Editbox.SelectionStart = _host.ActiveIWindow.Editbox.Text.Length;
}
```