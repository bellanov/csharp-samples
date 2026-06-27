using System;

namespace CSharpSamples.Core.Services;

public interface IDateTimeProvider
{
    DateTime Now { get; }
}
