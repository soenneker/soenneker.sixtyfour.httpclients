using Soenneker.Sixtyfour.HttpClients.Abstract;
using Soenneker.Tests.HostedUnit;

namespace Soenneker.Sixtyfour.HttpClients.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class SixtyfourOpenApiHttpClientTests : HostedUnitTest
{
    private readonly ISixtyfourOpenApiHttpClient _httpclient;

    public SixtyfourOpenApiHttpClientTests(Host host) : base(host)
    {
        _httpclient = Resolve<ISixtyfourOpenApiHttpClient>(true);
    }

    [Test]
    public void Default()
    {

    }
}
