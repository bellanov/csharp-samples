using System;
using System.Threading.Tasks;
using Xunit;
using CSharpSamples.Core.Services;

namespace CSharpSamples.Tests;

public class GreetingServiceTests
{
    private readonly IGreetingService _greetingService;

    public GreetingServiceTests()
    {
        var dateTimeProvider = new MockDateTimeProvider();
        _greetingService = new GreetingService(dateTimeProvider);
    }

    [Fact]
    public async Task GetGreetingAsync_WithValidName_ReturnsMorningGreeting()
    {
        // Arrange
        var name = "Alice";
        
        // Act
        var result = await _greetingService.GetGreetingAsync(name);
        
        // Assert
        Assert.Contains("Good", result);
        Assert.Contains(name, result);
    }

    [Fact]
    public async Task GetGreetingAsync_WithNullName_ThrowsArgumentException()
    {
        // Act & Assert
#pragma warning disable CS8625
        await Assert.ThrowsAsync<ArgumentException>(() => _greetingService.GetGreetingAsync(null!));
#pragma warning restore CS8625
    }

    [Fact]
    public async Task GetGreetingAsync_WithEmptyName_ThrowsArgumentException()
    {
        // Act & Assert
        await Assert.ThrowsAsync<ArgumentException>(() => _greetingService.GetGreetingAsync(""));
    }

    [Fact]
    public async Task GetGreetingAsync_WithWhitespaceName_ThrowsArgumentException()
    {
        // Act & Assert
        await Assert.ThrowsAsync<ArgumentException>(() => _greetingService.GetGreetingAsync("   "));
    }
}

public class GreetingServiceMorningTests
{
    [Fact]
    public async Task GetGreetingAsync_AtMorning_ReturnsMorningGreeting()
    {
        // Arrange
        var dateTimeProvider = new MockDateTimeProvider(new DateTime(2024, 1, 1, 9, 0, 0));
        var greetingService = new GreetingService(dateTimeProvider);
        var name = "Bob";

        // Act
        var result = await greetingService.GetGreetingAsync(name);

        // Assert
        Assert.StartsWith("Good morning", result);
    }

    [Fact]
    public async Task GetGreetingAsync_AtAfternoon_ReturnsAfternoonGreeting()
    {
        // Arrange
        var dateTimeProvider = new MockDateTimeProvider(new DateTime(2024, 1, 1, 14, 0, 0));
        var greetingService = new GreetingService(dateTimeProvider);
        var name = "Charlie";

        // Act
        var result = await greetingService.GetGreetingAsync(name);

        // Assert
        Assert.StartsWith("Good afternoon", result);
    }

    [Fact]
    public async Task GetGreetingAsync_AtEvening_ReturnsEveningGreeting()
    {
        // Arrange
        var dateTimeProvider = new MockDateTimeProvider(new DateTime(2024, 1, 1, 19, 0, 0));
        var greetingService = new GreetingService(dateTimeProvider);
        var name = "David";

        // Act
        var result = await greetingService.GetGreetingAsync(name);

        // Assert
        Assert.StartsWith("Good evening", result);
    }

    [Fact]
    public async Task GetGreetingAsync_AtNight_ReturnsNightGreeting()
    {
        // Arrange
        var dateTimeProvider = new MockDateTimeProvider(new DateTime(2024, 1, 1, 23, 0, 0));
        var greetingService = new GreetingService(dateTimeProvider);
        var name = "Eve";

        // Act
        var result = await greetingService.GetGreetingAsync(name);

        // Assert
        Assert.StartsWith("Good night", result);
    }
}

// Mock implementation for testing
public class MockDateTimeProvider : IDateTimeProvider
{
    private readonly DateTime _mockNow;

    public MockDateTimeProvider(DateTime? mockNow = null)
    {
        _mockNow = mockNow ?? DateTime.Now;
    }

    public DateTime Now => _mockNow;
}