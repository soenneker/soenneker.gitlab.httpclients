[![](https://img.shields.io/nuget/v/soenneker.gitlab.httpclients.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.gitlab.httpclients/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.gitlab.httpclients/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.gitlab.httpclients/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.gitlab.httpclients.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.gitlab.httpclients/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.gitlab.httpclients/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.gitlab.httpclients/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.GitLab.HttpClients

Provide a cached, authenticated `HttpClient` for the generated GitLab OpenAPI client, with support for GitLab.com and self-managed instances.

## Installation

```bash
dotnet add package Soenneker.GitLab.HttpClients
```

## Configuration

GitLab.com with a personal, project, or group access token:

```json
{
  "GitLab": {
    "ApiKey": "gitlab-token"
  }
}
```

The default base URL is `https://gitlab.com/`, and requests use `Authorization: Bearer <token>`.

For a self-managed instance or a different authentication header:

```json
{
  "GitLab": {
    "ApiKey": "gitlab-token",
    "ClientBaseUrl": "https://gitlab.example.com/",
    "AuthHeaderName": "PRIVATE-TOKEN",
    "AuthHeaderValueTemplate": "{token}"
  }
}
```

Use the GitLab host root as `ClientBaseUrl`; the generated client adds `/api/v4` to endpoint paths.

## Registration and usage

```csharp
services.AddGitLabOpenApiHttpClientAsSingleton();

HttpClient client = await gitLabHttpClient.Get(cancellationToken);
```

`Get` returns the same client for the lifetime of that provider instance. `AddGitLabOpenApiHttpClientAsScoped()` creates one provider-owned client per scope. Disposing either provider lifetime removes and disposes the client owned by that provider.
