// See https://aka.ms/new-console-template for more information
using DesignPatterns.Singleton;

Console.WriteLine("Hello, World!");

var singleton = Singleton.Instance;

var log = Log.Instance;

log.Save("Prueba");

var a = Singleton.Instance;
var b = Singleton.Instance;

//verifico si es el mismo objeto
Console.WriteLine(a == b);