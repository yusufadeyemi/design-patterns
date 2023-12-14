// See https://aka.ms/new-console-template for more information
using SingletonApp;

var counter1 = Counter.GetInstance();
counter1.IncrementCounter();

var counter2 = Counter.GetInstance();
counter2.IncrementCounter();

Console.WriteLine($"No of Visitor {counter1.NoOfVisitor}");
Console.WriteLine($"No of Visitor {counter2.NoOfVisitor}");
Console.ReadKey();
