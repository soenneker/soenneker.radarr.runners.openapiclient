using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Radarr.Runners.OpenApiClient.Tests;

[Collection("Collection")]
public sealed class RadarrOpenApiClientRunnerTests : FixturedUnitTest
{
    public RadarrOpenApiClientRunnerTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
