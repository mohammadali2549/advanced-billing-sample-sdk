# Maxio Advanced Billing

[![Built with APIMatic][apimatic-badge]][apimatic-url] [![License: MIT][license-badge]][license-url]

The Maxio Advanced Billing SDK for .NET provides access to the Maxio Advanced Billing REST APIs from .NET applications.


Maxio Advanced Billing (formerly Chargify) provides an HTTP-based API that conforms to the principles of REST.
One of the many reasons to use Advanced Billing is the immense feature set and [client libraries](page:development-tools/client-libraries).
The Maxio API returns JSON responses as the primary and recommended format, but XML is also provided as a backwards compatible option for merchants who require it.

> [!TIP]
> **Looking for a specific signature, model, enum, or error type?** This repo ships a generated,
> machine-readable **[SDK map](sdk-map.md)** — a lookup index of the SDK's entire C# surface. Consult it
> **before** grepping or scanning the source tree; it answers most contract questions directly and, when a
> source file is genuinely needed, names the exact one to open. Details under [SDK map](#sdk-map).

## Steps to make your first Maxio Advanced Billing API call

1. [Sign-up](https://app.chargify.com/signup/maxio-billing-sandbox) or [log-in](https://app.chargify.com/login.html) to your [test site](https://maxio.zendesk.com/hc/en-us/articles/24250712113165-Testing-Overview) account.
2. [Setup authentication](https://maxio.zendesk.com/hc/en-us/articles/24294819360525-API-Keys) credentials.
3. [Submit an API request and verify the response](page:development-tools/client-libraries#make-your-first-maxio-advanced-billing-api-request).
5. Test the Advanced Billing [integrations](https://www.maxio.com/integrations).

Next, you can explore [authentication methods](page:introduction/authentication), [basic concepts](page:introduction/basic-concepts/connected-sites) for interacting with Advanced Billing via the API, and the entire set of [application-based documentation](https://docs.maxio.com/hc/en-us) to aid in your discovery of the product.

### Request Example

The following example uses the curl command-line tool to make an API request.

**Request**

    curl -u <api_key>:x -H Accept:application/json -H Content-Type:application/json https://acme.chargify.com/subscriptions.json

---

## Installation

Add the .NET SDK as a project reference into your solution:

```bash
dotnet add reference <path-to-sdk>/MaxioAdvancedBilling.csproj
```

---

## Quick Start

### Dependency Injection

Register the client with `IServiceCollection` and resolve it from the container. The `HttpClient` is managed by `IHttpClientFactory`. Configure the client's behavior through [MaxioAdvancedBillingClientOptions](MaxioAdvancedBillingClientOptions.cs).

```csharp
services.AddMaxioAdvancedBillingClient(options =>
    {
        options.BasicAuth =
            new BasicAuthCredentials
            {
                Username = "YOUR_USERNAME",
                Password = "YOUR_PASSWORD",
            };
        options.Environment = ServerEnvironment.Us;
        // TODO: configure more client options here
    });
```

### Direct Instantiation

Create the client by passing an `HttpClient` you manage yourself. Configure the client's behavior through [MaxioAdvancedBillingClientOptions](MaxioAdvancedBillingClientOptions.cs).

```csharp
var httpClient = new HttpClient();
// TODO: configure more client options here
var options =
    new MaxioAdvancedBillingClientOptions
    {
        BasicAuth = new BasicAuthCredentials
        {
            Username = "YOUR_USERNAME",
            Password = "YOUR_PASSWORD",
        },
        Environment = ServerEnvironment.Us,
    };
var client = new MaxioAdvancedBillingClient(httpClient, options);
```

---

## Usage

For code examples and error responses, see [API Reference](api-reference.md).

## SDK map

This repository ships a generated **SDK map** — [`sdk-map.md`](sdk-map.md) plus the [`map/`](map/) pages —
a deterministic, lookup-oriented table of contents of the SDK's C# surface, generated from this source by
[apimatic/sdk-map-generator](https://github.com/apimatic/sdk-map-generator).

**Read it before scanning the source.** Whether you are an AI coding assistant or searching by hand, the
map resolves most "what is the exact …" questions by lookup, so you rarely open a source file — and never
need to grep the 600+-file tree:

- **[`sdk-map.md`](sdk-map.md)** — the index: client construction, servers/auth, the options/retry
  reference, and link tables into `map/`.
- **[`map/operations/`](map/operations/)** — one page per controller: HTTP route, the exact C# signature,
  return type, error type with its typed `TryGet…` accessors, and pagination — plus the source file each
  row came from.
- **[`map/models/`](map/models/)** — record fields with their JSON wire names, enums (full value lists),
  and `OneOf`/`AnyOf` unions.

**Workflow:** look the fact up in the map → only if you need a full method or model body, open the **one**
source file the map's row names (e.g. `Api/Customers.cs`) → the compiler is the backstop (a name that isn't
in the map won't build). Don't scan or grep the tree to find things — the map is the locator.

The map is a **contract index**; for prose descriptions, per-parameter documentation, and runnable code
examples, use the [API Reference](api-reference.md) instead. The map is generated from this repo's source,
so it stays in lockstep with the code it describes.

## Best Practices

> [!TIP]
> Use a **single `MaxioAdvancedBillingClient` instance** for the lifetime of your application and
> reuse it across all requests. Creating a new instance per request might exhaust the
> connection pool.

## License

This SDK is distributed under the [MIT License](LICENSE).

---

## Support

Refer to the [API reference](api-reference.md) for detailed information on available operations with code samples.

For further assistance, please contact support at support@maxio.com.

---

[license-url]: LICENSE
[license-badge]: https://img.shields.io/badge/License-MIT-blue.svg
[apimatic-url]: https://www.apimatic.io
[apimatic-badge]: https://www.apimatic.io/hubfs/Built-with-APIMatic-badge.svg
