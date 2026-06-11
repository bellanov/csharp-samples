using System;

namespace CSharpSamples.Core.Models;

public record Person(string FirstName, string LastName, DateTime BirthDate)
{
    public string FullName => $"{FirstName} {LastName}";

    public int Age => DateTime.Today.Year - BirthDate.Year - 
        (BirthDate.Date > DateTime.Today.AddYears(-Age) ? 1 : 0);
}
