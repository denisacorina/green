using Xunit;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace GreenPipeline.Tests;
public class ProgramTests
{
    [Fact]
    public void TestHttpClientConfiguration()
    {
        var builder = WebAssemblyHostBuilder.CreateDefault(Array.Empty<string>());
        var services = builder.Services;
        

        var serviceProvider = services.BuildServiceProvider();
        var httpClient = serviceProvider.GetService(typeof(HttpClient)) as HttpClient;

        Assert.NotNull(httpClient);
        Assert.Equal("https://localhost:7183/", httpClient.BaseAddress.ToString());
    }
}
