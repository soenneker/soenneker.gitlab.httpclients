using Soenneker.GitLab.HttpClients.Abstract;
using Soenneker.Tests.HostedUnit;

namespace Soenneker.GitLab.HttpClients.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class GitLabOpenApiHttpClientTests : HostedUnitTest
{
    private readonly IGitLabOpenApiHttpClient _httpclient;

    public GitLabOpenApiHttpClientTests(Host host) : base(host)
    {
        _httpclient = Resolve<IGitLabOpenApiHttpClient>(true);
    }

    [Test]
    public void Default()
    {

    }
}
