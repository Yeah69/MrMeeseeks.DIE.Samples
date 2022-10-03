// See https://aka.ms/new-console-template for more information

using MrMeeseeks.DIE.Samples.GettingStarted;

await using var container = new Container();
var mrMeeseeks = container.Create();
mrMeeseeks.Greet();