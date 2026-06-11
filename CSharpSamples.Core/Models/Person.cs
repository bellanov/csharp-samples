using System;

namespace CSharpSamples.Core.Models;

public record Person(string FirstName, string LastName, DateTime BirthDate)
{
    public string FullName => $"{FirstName} {LastName}";

    public int Age
    {
        get
        {
            var age = DateTime.Today.Year - BirthDate.Year;
            if (BirthDate.Date > DateTime.Today.AddYears(-age))
            {
                age--;
            }
            return age;
        }
    }
}
