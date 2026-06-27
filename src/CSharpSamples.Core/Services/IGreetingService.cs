using System.Threading.Tasks;

namespace CSharpSamples.Core.Services;

public interface IGreetingService
{
    Task<string> GetGreetingAsync(string name);
}
