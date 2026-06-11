using System;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using CSharpSamples.Core.Services;
using CSharpSamples.Core.Models;

var services = new ServiceCollection();
services.AddScoped<IGreetingService, GreetingService>();
services.AddScoped<IDateTimeProvider, DateTimeProvider>();

var serviceProvider = services.BuildServiceProvider();

var greetingService = serviceProvider.GetRequiredService<IGreetingService>();

Console.WriteLine("=== C# Samples - Modern Design Patterns Demo ===\n");

await RunGreetingServiceDemo(greetingService);
DemoPersonModel();

Console.WriteLine("\n=== Demo Complete ===");

async Task RunGreetingServiceDemo(IGreetingService service)
{
    Console.WriteLine("--- Greeting Service Demo (Async/Await Pattern) ---");
    var names = new[] { "Alice", "Bob", "Charlie" };
    
    foreach (var name in names)
    {
        var greeting = await service.GetGreetingAsync(name);
        Console.WriteLine(greeting);
    }
}

void DemoPersonModel()
{
    Console.WriteLine("\n--- Model Demo (Records Pattern) ---");
    var person = new Person("John", "Doe", new DateTime(1990, 5, 15));
    Console.WriteLine($"Name: {person.FullName}");
    Console.WriteLine($"Birth Date: {person.BirthDate:yyyy-MM-dd}");
}
