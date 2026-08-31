[![](https://img.shields.io/nuget/v/soenneker.sixtyfour.httpclients.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.sixtyfour.httpclients/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.sixtyfour.httpclients/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.sixtyfour.httpclients/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.sixtyfour.httpclients.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.sixtyfour.httpclients/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.sixtyfour.httpclients/codeql.yml?style=for-the-badge&label=codeql)](https://github.com/soenneker/soenneker.sixtyfour.httpclients/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Sixtyfour.HttpClients

Provides a reusable `HttpClient` configured for Sixtyfour's people and company enrichment API with bearer-token authentication.

## Installation

```bash
dotnet add package Soenneker.Sixtyfour.HttpClients
```

## Configuration

```json
{
  "Sixtyfour": {
    "ApiKey": "your-sixtyfour-api-key"
  }
}
```

`Sixtyfour:ClientBaseUrl`, `Sixtyfour:AuthHeaderName`, and `Sixtyfour:AuthHeaderValueTemplate` can override the defaults. The value template must contain `{token}`.

## Usage

```csharp
using Soenneker.Sixtyfour.HttpClients.Abstract;
using Soenneker.Sixtyfour.HttpClients.Registrars;

services.AddSixtyfourOpenApiHttpClientAsSingleton();

public sealed class SixtyfourBalanceReader
{
    private readonly ISixtyfourOpenApiHttpClient _sixtyfour;

    public SixtyfourBalanceReader(ISixtyfourOpenApiHttpClient sixtyfour)
    {
        _sixtyfour = sixtyfour;
    }

    public async Task<HttpResponseMessage> GetBalance(CancellationToken cancellationToken)
    {
        HttpClient client = await _sixtyfour.Get(cancellationToken);
        return await client.GetAsync("check-balance", cancellationToken);
    }
}
```

The provider owns the cached `HttpClient`; disposing the provider removes and disposes that client. Scoped registration creates an independently owned client for each scope.
