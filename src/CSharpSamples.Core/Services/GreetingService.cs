using System;
using System.Threading.Tasks;

namespace CSharpSamples.Core.Services;

public class GreetingService : IGreetingService
{
    private readonly IDateTimeProvider _dateTimeProvider;

    public GreetingService(IDateTimeProvider dateTimeProvider)
    {
        _dateTimeProvider = dateTimeProvider ?? throw new ArgumentNullException(nameof(dateTimeProvider));
    }

    public async Task<string> GetGreetingAsync(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("Name cannot be null or empty.", nameof(name));
        }

        await Task.Delay(10);

        var hour = _dateTimeProvider.Now.Hour;
        var timeOfDay = hour switch
        {
            >= 5 and < 12 => "Good morning",
            >= 12 and < 18 => "Good afternoon",
            >= 18 and < 22 => "Good evening",
            _ => "Good night"
        };

        return $"{timeOfDay}, {name}!";
    }
}
