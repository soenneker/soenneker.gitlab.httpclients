using Soenneker.GitLab.HttpClients.Abstract;
using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.GitLab.HttpClients.Tests;

[Collection("Collection")]
public sealed class GitLabOpenApiHttpClientTests : FixturedUnitTest
{
    private readonly IGitLabOpenApiHttpClient _httpclient;

    public GitLabOpenApiHttpClientTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
        _httpclient = Resolve<IGitLabOpenApiHttpClient>(true);
    }

    [Fact]
    public void Default()
    {

    }
}
