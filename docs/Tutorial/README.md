# AdiIRC Plugins
### Writing .Net Plugins for AdiIRC Targeting API v2 and using C#


## Introduction 

This series of tutorials expects you to have a basic understanding of .Net, C#, Visual Studio, IRC and AdiIRC. Additionally they will assume you are working with a copy of Visual Studio 2017 ( Community Version ), which is available for [free](https://www.visualstudio.com/thank-you-downloading-visual-studio/?sku=Community&rel=15) online. 

## Resources

Besides these tutorials you should also be aware of the official [Documentation](https://adiirc.com/docsv2/html/b188f817-d351-7802-e9a1-6907dc8377be.htm) and the [Wiki](https://dev.adiirc.com/projects/adiirc/wiki). You can also ask questions in the official irc support channel [#adiirc](irc://chat.freenode.net/#AdiIRC)

# Tutorials

## 0 - [Setting up a Project](Chapter_0.md)

Covers setting up a project, references and installing compiled plugins into AdiIRC.

## 1 - [A basic Plugin: "Hello World"](Chapter_1.md)

Covers the Iplugin Interface and showing a simple text message. 

## 2 - [Commands and Events](Chapter_2.md)

Covers creating slash Commands, using other Commands from your plugin and using API Events.

## 3 - [Editing and Eating Events](Chapter_3.md)

Covers using the EatData field of argument and changing incoming messages. Gives examples on how to implement a very simple join/part filter.