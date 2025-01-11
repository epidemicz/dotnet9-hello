// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("args:");

var i = 0;
foreach (var a in args)
{
    Console.WriteLine($"arg[{i++}]: {a}");
}