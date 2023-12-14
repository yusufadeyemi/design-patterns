// See https://aka.ms/new-console-template for more information
using DesignPatterns;

var logistics = new Logistics();
var package = new Package { Name = "Cements", WeightInKg = 75 };
logistics.DispatchMessage(package);
Console.ReadKey();