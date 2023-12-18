// See https://aka.ms/new-console-template for more information

using BuilderPatternApp;

CakeBuilder cakeBuilderEsther = new CakeBuilder();
var estherCake = cakeBuilderEsther.AddButterCream()
    .AddStrawberry()
    .AddChocolote().Build();

CakeBuilder cakeBuilderWahab = new CakeBuilder();
var wahabCake = cakeBuilderWahab.AddChocolote()
    .AddSprinkles()
    .AddFlowers().Build();

Console.WriteLine($"Esther's Cake: {estherCake.GetContentAsString()}");

Console.WriteLine($"Wahab's Cake: {wahabCake.GetContentAsString()}");
Console.ReadKey();


