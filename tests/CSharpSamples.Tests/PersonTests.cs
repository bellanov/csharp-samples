using System;
using Xunit;
using CSharpSamples.Core.Models;

namespace CSharpSamples.Tests;

public class PersonTests
{
    [Fact]
    public void Person_Creation_StoresValues()
    {
        // Arrange
        var firstName = "John";
        var lastName = "Doe";
        var birthDate = new DateTime(1990, 5, 15);

        // Act
        var person = new Person(firstName, lastName, birthDate);

        // Assert
        Assert.Equal(firstName, person.FirstName);
        Assert.Equal(lastName, person.LastName);
        Assert.Equal(birthDate, person.BirthDate);
    }

    [Fact]
    public void Person_FullName_CombinesFirstAndLastName()
    {
        // Arrange
        var person = new Person("Jane", "Smith", new DateTime(1992, 3, 20));

        // Act
        var fullName = person.FullName;

        // Assert
        Assert.Equal("Jane Smith", fullName);
    }

    [Fact]
    public void Person_Equality_SameValuesAreEqual()
    {
        // Arrange
        var person1 = new Person("Alice", "Johnson", new DateTime(1988, 7, 10));
        var person2 = new Person("Alice", "Johnson", new DateTime(1988, 7, 10));

        // Act & Assert
        Assert.Equal(person1, person2);
    }

    [Fact]
    public void Person_Equality_DifferentValuesAreNotEqual()
    {
        // Arrange
        var person1 = new Person("Bob", "Brown", new DateTime(1995, 1, 5));
        var person2 = new Person("Bob", "Green", new DateTime(1995, 1, 5));

        // Act & Assert
        Assert.NotEqual(person1, person2);
    }
}
