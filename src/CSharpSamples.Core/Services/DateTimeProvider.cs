using System;

namespace CSharpSamples.Core.Services;

public class DateTimeProvider : IDateTimeProvider
{
    public DateTime Now => DateTime.Now;
}
