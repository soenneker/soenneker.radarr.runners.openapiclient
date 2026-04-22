using Soenneker.Tests.HostedUnit;

namespace Soenneker.Radarr.Runners.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class RadarrOpenApiClientRunnerTests : HostedUnitTest
{
    public RadarrOpenApiClientRunnerTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
