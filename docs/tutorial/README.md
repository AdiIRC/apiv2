# AdiIRC Plugins
### Writing .Net Plugins for AdiIRC Targeting API v2 and using C#


## Introduction 

This series of tutorials expects you to have a basic understanding of .Net, C#, Visual Studio, IRC and AdiIRC. Additionally they will assume you are working with a copy of Visual Studio 2017 ( Community Version ), which is available for [free](https://www.visualstudio.com/thank-you-downloading-visual-studio/?sku=Community&rel=15) online. 

## Resources

Besides these tutorials you should also be aware of the official [Documentation](https://adiirc.github.io/apiv2/generated) and the [Wiki](https://dev.adiirc.com/projects/adiirc/wiki). You can also ask questions in the official irc support channel on freenode [#adiirc-api](irc://chat.freenode.net/#AdiIRC-api)

# Tutorials

## 0 - [Setting up a Project](chapter0/README.md)

Covers setting up a project, references and installing compiled plugins into AdiIRC.

## 1 - [A basic Plugin: "Hello World"](chapter1/README.md)

Covers the Iplugin Interface and showing a simple text message. 

## 2 - [Commands and Events](chapter2/README.md)

Covers creating slash Commands, using other Commands from your plugin and using API Events.

## 3 - [Editing and Eating Events](chapter3/README.md)

Covers using the EatData field of argument and changing incoming messages. Gives examples on how to implement a very simple join/part filter.

## 4 - [Magnificent Menus](chapter4/README.md)

Covers hooking into a variety of menu's, displaying Forms. 

## 5 - [Editing the Editbox](chapter5/README.md)

Covers making use of the Editbox.

## 6 - [Raw Power](chapter6/README.md)

Covers hooking into Raw events, the basics of IRC messages, Fake Raw Messages and finally Sending Messages.