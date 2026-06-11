# C# Samples

A comprehensive collection of modern C# design patterns and best practices using .NET and the dotnet CLI.

## Project Structure

This solution demonstrates modern design patterns and best practices in C#:

```
CSharpSamples/
├── CSharpSamples.Core/        # Core library with business logic and services
│   ├── Models/                # Data models (e.g., Person record)
│   └── Services/              # Service interfaces and implementations
├── CSharpSamples.Console/     # Console application showcasing usage
└── CSharpSamples.Tests/       # Unit tests with code coverage
```

## Modern Design Patterns Showcased

### 1. **Dependency Injection (DI)**
- Uses Microsoft.Extensions.DependencyInjection
- Demonstrates loose coupling and testability
- See: `CSharpSamples.Console/Program.cs`

### 2. **Interface Segregation Principle (ISP)**
- Small, focused interfaces
- `IGreetingService` and `IDateTimeProvider` examples
- Easy to mock for testing

### 3. **Async/Await Pattern**
- `GreetingService.GetGreetingAsync()` demonstrates modern async patterns
- Proper use of `Task` and `await`

### 4. **Records (C# 9+)**
- Immutable value types with built-in equality
- `Person` record example with computed properties
- Cleaner syntax than traditional classes for data models

### 5. **Pattern Matching**
- Switch expressions for elegant logic
- Time-based greeting example using switch expressions

### 6. **Unit Testing Best Practices**
- xUnit testing framework
- Arrange-Act-Assert (AAA) pattern
- Mock implementations for testing
- Comprehensive test coverage

## Prerequisites

- .NET 8.0 or later
- dotnet CLI

## Getting Started

### Build the Solution

```bash
dotnet build
```

### Run the Console Application

```bash
dotnet run --project CSharpSamples.Console
```

Expected output:
```
=== C# Samples - Modern Design Patterns Demo ===

--- Greeting Service Demo (Async/Await Pattern) ---
Good morning, Alice!
Good morning, Bob!
Good morning, Charlie!

--- Model Demo (Records Pattern) ---
Name: John Doe
Birth Date: 1990-05-15

=== Demo Complete ===
```

## Testing

### Run All Tests

```bash
dotnet test
```

### Run Tests with Code Coverage

```bash
dotnet test --collect:"XPlat Code Coverage" --results-directory coverage
```

The coverage report will be generated in the `coverage` directory as `coverage.cobertura.xml`.

## Project Details

### CSharpSamples.Core
Core library containing:
- **Models**: Data structures (e.g., `Person` record)
- **Services**: 
  - `IGreetingService` / `GreetingService`: Demonstrates DI, async/await
  - `IDateTimeProvider` / `DateTimeProvider`: Demonstrates abstraction for testability

### CSharpSamples.Console
Console application that:
- Demonstrates dependency injection setup
- Uses services from Core library
- Shows practical usage patterns

### CSharpSamples.Tests
Comprehensive unit tests covering:
- Service functionality with mocked dependencies
- Edge cases and error handling
- Different code paths for coverage
- Record equality and properties

## CI/CD Pipeline

This project includes a GitHub Actions workflow (`.github/workflows/ci-cd.yml`) that:

1. **Builds** the solution in Release configuration
2. **Tests** with XPlat Code Coverage
3. **Generates** coverage reports
4. **Uploads** results to Codecov (optional, requires token)
5. **Archives** test artifacts

### Workflow Triggers
- Push to `main` or `develop` branches
- Pull requests to `main` or `develop` branches

## Code Coverage

Code coverage is automatically collected during test execution using:
- **Coverlet**: .NET code coverage library
- **XPlat Code Coverage**: Cross-platform coverage format (Cobertura XML)

Coverage reports are generated in `coverage/` directory.

## Dependencies

### Core
- None (targets .NET Standard 8.0)

### Console
- Microsoft.Extensions.DependencyInjection (10.0.9)

### Tests
- xUnit (latest)
- Microsoft.NET.Test.Sdk (18.6.0)
- Coverlet.Collector (10.0.1)

## Best Practices Demonstrated

1. ✅ **Separation of Concerns**: Clear project structure
2. ✅ **Dependency Injection**: Loose coupling and testability
3. ✅ **Interface Segregation**: Small, focused contracts
4. ✅ **Testability**: Mock implementations and unit tests
5. ✅ **Async/Await**: Modern async patterns
6. ✅ **Code Coverage**: Comprehensive test coverage tracking
7. ✅ **CI/CD**: Automated build, test, and coverage reporting
8. ✅ **Modern C#**: Records, pattern matching, nullable reference types

## License

Apache License 2.0 - See LICENSE file for details

## Contributing

Contributions are welcome! Please feel free to submit pull requests or open issues for suggestions and improvements.

