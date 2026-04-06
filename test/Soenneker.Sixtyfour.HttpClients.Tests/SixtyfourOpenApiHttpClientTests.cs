using Soenneker.Sixtyfour.HttpClients.Abstract;
using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Sixtyfour.HttpClients.Tests;

[Collection("Collection")]
public sealed class SixtyfourOpenApiHttpClientTests : FixturedUnitTest
{
    private readonly ISixtyfourOpenApiHttpClient _httpclient;

    public SixtyfourOpenApiHttpClientTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
        _httpclient = Resolve<ISixtyfourOpenApiHttpClient>(true);
    }

    [Fact]
    public void Default()
    {

    }
}
