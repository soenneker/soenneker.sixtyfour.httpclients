using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Soenneker.Sixtyfour.HttpClients.Abstract;
using Soenneker.Utils.HttpClientCache.Registrar;

namespace Soenneker.Sixtyfour.HttpClients.Registrars;

/// <summary>
/// Registers the OpenAPI HttpClient wrapper for dependency injection.
/// </summary>
public static class SixtyfourOpenApiHttpClientRegistrar
{
    /// <summary>
    /// Adds <see cref="SixtyfourOpenApiHttpClient"/> as a singleton service. <para/>
    /// </summary>
    public static IServiceCollection AddSixtyfourOpenApiHttpClientAsSingleton(this IServiceCollection services)
    {
        services.AddHttpClientCacheAsSingleton()
                .TryAddSingleton<ISixtyfourOpenApiHttpClient, SixtyfourOpenApiHttpClient>();

        return services;
    }

    /// <summary>
    /// Adds <see cref="SixtyfourOpenApiHttpClient"/> as a scoped service. <para/>
    /// </summary>
    public static IServiceCollection AddSixtyfourOpenApiHttpClientAsScoped(this IServiceCollection services)
    {
        services.AddHttpClientCacheAsSingleton()
                .TryAddScoped<ISixtyfourOpenApiHttpClient, SixtyfourOpenApiHttpClient>();

        return services;
    }
}
