using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;

namespace Soenneker.Sixtyfour.HttpClients.Abstract;

/// <summary>
/// Provides an authenticated HTTP client for the Sixtyfour API.
/// </summary>
public interface ISixtyfourOpenApiHttpClient : IDisposable, IAsyncDisposable
{
    /// <summary>
    /// Gets the shared HTTP client owned by this provider instance.
    /// </summary>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>A task containing the result of the operation.</returns>
    ValueTask<HttpClient> Get(CancellationToken cancellationToken = default);

    /// <summary>
    /// Removes and disposes the HTTP client owned by this provider.
    /// </summary>
    new void Dispose();

    /// <summary>
    /// Asynchronously removes and disposes the HTTP client owned by this provider.
    /// </summary>
    /// <returns>A task that represents the asynchronous operation.</returns>
    new ValueTask DisposeAsync();
}
