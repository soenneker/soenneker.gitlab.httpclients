using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Soenneker.GitLab.HttpClients.Abstract;
using Soenneker.Utils.HttpClientCache.Registrar;

namespace Soenneker.GitLab.HttpClients.Registrars;

/// <summary>
/// Registers the OpenAPI HttpClient wrapper for dependency injection.
/// </summary>
public static class GitLabOpenApiHttpClientRegistrar
{
    /// <summary>
    /// Adds <see cref="GitLabOpenApiHttpClient"/> as a singleton service. <para/>
    /// </summary>
    public static IServiceCollection AddGitLabOpenApiHttpClientAsSingleton(this IServiceCollection services)
    {
        services.AddHttpClientCacheAsSingleton()
                .TryAddSingleton<IGitLabOpenApiHttpClient, GitLabOpenApiHttpClient>();

        return services;
    }

    /// <summary>
    /// Adds <see cref="GitLabOpenApiHttpClient"/> as a scoped service. <para/>
    /// </summary>
    public static IServiceCollection AddGitLabOpenApiHttpClientAsScoped(this IServiceCollection services)
    {
        services.AddHttpClientCacheAsSingleton()
                .TryAddScoped<IGitLabOpenApiHttpClient, GitLabOpenApiHttpClient>();

        return services;
    }
}
