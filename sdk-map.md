# SDK map — Maxio Advanced Billing (.NET)

> A generated table-of-contents for this SDK. Consult this map and its sub-pages to learn signatures, error
> types, and server/auth wiring **by lookup**. Model shapes and enum values are *not* duplicated here — the map
> names the file declaring each type; read the shape there. The compiler is the backstop: a wrong name fails to build.

| | |
|---|---|
| SDK display name | Maxio Advanced Billing (formerly Chargify) — sample SDK |
| Root namespace/module | `MaxioAdvancedBilling` |
<!-- gen:stamp -->
| NuGet package | `AsadAli.AdvancedBilling.Sdk` |
| Target framework(s) | `netstandard2.0` (C# `LangVersion 14`, `Nullable enable`) |
| Source commit (spec stamp) | `15db14b` (`15db14b2e663ebe9e957e061bd67634630429035`, tagged `v1.0.2`) |
<!-- /gen:stamp -->
| Generator | APIMatic |
| Repo | https://github.com/asadali214/advanced-billing-sample-sdk |

Staleness check: if the SDK is regenerated, the source commit/tag stamp above changes. If a lookup here fails to
compile, trust the compiler and re-read the source file linked in the row.

All `Source` paths on this map and its sub-pages are **repo-root-relative**, not relative to the page that
carries them — open `Models/Invoice.cs` as-is from the repo root, from any page.

---

## Getting a client

```csharp
using MaxioAdvancedBilling;
using MaxioAdvancedBilling.Core.Authentication.Basic;
using MaxioAdvancedBilling.Servers; // ServerEnvironment lives here

var options = new MaxioAdvancedBillingClientOptions
{
    // Basic auth: Username = your Maxio/Chargify API key, Password = the literal "x"
    BasicAuth = new BasicAuthCredentials { Username = "<api_key>", Password = "x" },
    // Environment selects US (default) or EU hosting; see Servers & auth below
    Environment = ServerEnvironment.Us,
};
var client = new MaxioAdvancedBillingClient(httpClient, options); // httpClient: System.Net.Http.HttpClient
```

DI alternative (`ServiceCollectionExtensions.cs`):

```csharp
services.AddMaxioAdvancedBillingClient(o =>
{
    o.BasicAuth = new BasicAuthCredentials { Username = "<api_key>", Password = "x" };
});
```

Every API group is a property on the client (e.g. `client.Customers`, `client.Subscriptions`). Source:
`MaxioAdvancedBillingClient.cs`. The only constructor is
`MaxioAdvancedBillingClient(HttpClient httpClient, MaxioAdvancedBillingClientOptions options)`.

All `MaxioAdvancedBillingClientOptions` properties (source: `MaxioAdvancedBillingClientOptions.cs`):

| Property | Type |
|---|---|
| `Environment` | `ServerEnvironment` |
| `Retry` | `RetryOptions` |
| `Server` | `ServerOptions` |
| `BasicAuth` | `BasicAuthCredentials?` |

`RetryOptions` members (namespace `MaxioAdvancedBilling.Core.Configuration` — add `using
MaxioAdvancedBilling.Core.Configuration;`; source: `Core/Configuration/RetryOptions.cs`; all members are
`required`, so build a full instance or start from `RetryOptions.Default()`):

| Member | Type |
|---|---|
| `StatusCodesToRetry` | `IReadOnlyList<HttpStatusCode>` |
| `HttpMethodsToRetry` | `IReadOnlyList<HttpMethod>` |
| `MaxRetries` | `int` |
| `Delay` | `TimeSpan` |
| `Timeout` | `TimeSpan?` |
| `BackOffFactor` | `int` |
| `UseExponentialBackoff` | `bool` |
| `MaxJitter` | `TimeSpan` |
| `OnRetry` | `Action<RetryAttempt>?` |

---

## Error-handling model (read once — applies to every operation)

Operations are **throw-based**. On an error status the SDK throws `SdkException<TError>`
(`Core/Exceptions/SdkException.cs`) exposing `.Error` of type `TError`. There are two cases:

- **Case A — typed error.** `TError` is a generated `…Error : ApiError` class with status-specific
  `TryGet…(out …)` accessors (returns `true` when that shape is present) plus the inherited
  `TryGetRawError(out RawError)` fallback. The per-operation rows name the exact `TryGet…` methods and the HTTP
  status each maps to.
- **Case B — raw error.** `TError` is `RawError` (`Core/ErrorResponse/RawError.cs`): `StatusCode`,
  `ReadAsString()`, `ReadAsJson<T>()`, `ReadAsBytes()`.

<!-- gen:error-core -->
Core error types (`Core/ErrorResponse/`) — public members with their **declared types**, verbatim from source:

| Type | Public members | Source |
|---|---|---|
| `ApiError` — abstract base of all 163 typed error classes in `Errors/` | `TryGetRawError(out RawError error): bool` | `Core/ErrorResponse/ApiError.cs` |
| `RawError` | `StatusCode: HttpStatusCode` · `ReadAsBytes(): ReadOnlyMemory<byte>` · `ReadAsString(): string` · `ReadAsJson<T>(): T?` | `Core/ErrorResponse/RawError.cs` |

Typed-error payload shapes (the `out` types in each operation page's error-accessor cells) are ordinary records/unions — no special handling. The operation's **Type sources** table gives the file that declares each one; read field names, declared types, and JSON wire names there, as for any other model.
<!-- /gen:error-core -->

```csharp
try { var resp = await client.Customers.CreateCustomer(body); }
catch (SdkException<CreateCustomerError> ex)          // Case A
{
    if (ex.Error.TryGetCustomerErrorResponse1(out var e422)) { /* handle 422 */ }
    else if (ex.Error.TryGetRawError(out var raw))    { /* other statuses */ }
}
catch (SdkException<RawError> ex)                     // Case B
{
    var status = ex.Error.StatusCode;
    var body   = ex.Error.ReadAsString();
}
```

**No-throw ("`…Result`") variants: absent across this SDK** — every operation is throw-only.
Of **247 operations**, **163 are Case A (typed)** and **84 are Case B (raw)**.

---

## Operations — by controller (33 groups, 247 operations)

Each links to a sub-page with one row per operation: signature with must-pass-explicitly params and defaults,
query-param wire names, return type, error Case A/B, and Case A's typed accessors with their statuses. Each
operation also carries a **Type sources** table — every type it names, with the file that declares it — so
resolving a body, return, or error payload to its source is a lookup, never a search. `RawError` is excluded
there (its members and path are above); an operation with no table names nothing but primitives and `RawError`.

**Each row states what is specific to its operation. Everything below holds for EVERY operation unless that
operation's row says otherwise, so a row silent on one of these points is telling you the default here
applies — take it and move on rather than opening the source to confirm it.**

| Applies to every operation | Stated where | A row appears only when |
|---|---|---|
| **Throw-only — no `…Result`/no-throw variant exists anywhere in this SDK** | this page, Error-handling model | a no-throw sibling exists (none do at this SDK version) |
| **No pagination** — the operation takes neither `page` nor `perPage` | here | pagination is offered: `manual page+perPage`, or the `page`-without-`perPage` case |
| **Case B error accessors are always these four** — `StatusCode: HttpStatusCode` · `ReadAsBytes(): ReadOnlyMemory<byte>` · `ReadAsString(): string` · `ReadAsJson<T>(): T?` | the `RawError` row above | never — a `Case B` label always implies exactly these four; Case A rows list their own typed accessors |
| **Server group `Production`** — base URL per Servers & auth below | here | the operation is on another group, e.g. `- **Server group**: Ebb (events)` (2 event-ingest operations) |
| **Parameter names are literal** — signatures are generated code verbatim; in named arguments use the exact parameter names shown (the cancellation-token parameter is named `ct`) | here | never — it always holds |

**The HTTP verb and route live on the operation in `Api/<Controller>.cs`.** This map is method-first: the C#
method is the interface you call. When something wire-level needs the route — reproducing a raw request,
pointing the client at a mock, reading a provider-side log — read it from that file; do not reconstruct it
from memory or infer it from the method name.

**The endpoint's behavioural prose lives there too**, as the XML `<remarks>` on the method. Rows here give
you the contract — names, types, shapes, errors. Where an operation's *semantics* decide what you must pass
— a parameter whose value changes server-side behaviour, an ordering or exclusivity rule between fields —
that is what `<remarks>` settles; read it there rather than filling it in from memory.

| Controller (`client.X`) | Ops | Page |
|---|---:|---|
| `Subscriptions` | 12 | [map/operations/Subscriptions.md](map/operations/Subscriptions.md) |
| `SubscriptionComponents` | 17 | [map/operations/SubscriptionComponents.md](map/operations/SubscriptionComponents.md) |
| `SubscriptionGroups` | 9 | [map/operations/SubscriptionGroups.md](map/operations/SubscriptionGroups.md) |
| `SubscriptionGroupStatus` | 4 | [map/operations/SubscriptionGroupStatus.md](map/operations/SubscriptionGroupStatus.md) |
| `SubscriptionGroupInvoiceAccount` | 4 | [map/operations/SubscriptionGroupInvoiceAccount.md](map/operations/SubscriptionGroupInvoiceAccount.md) |
| `SubscriptionInvoiceAccount` | 7 | [map/operations/SubscriptionInvoiceAccount.md](map/operations/SubscriptionInvoiceAccount.md) |
| `SubscriptionStatus` | 10 | [map/operations/SubscriptionStatus.md](map/operations/SubscriptionStatus.md) |
| `SubscriptionNotes` | 5 | [map/operations/SubscriptionNotes.md](map/operations/SubscriptionNotes.md) |
| `SubscriptionProducts` | 2 | [map/operations/SubscriptionProducts.md](map/operations/SubscriptionProducts.md) |
| `SubscriptionRenewals` | 11 | [map/operations/SubscriptionRenewals.md](map/operations/SubscriptionRenewals.md) |
| `Invoices` | 17 | [map/operations/Invoices.md](map/operations/Invoices.md) |
| `ProformaInvoices` | 10 | [map/operations/ProformaInvoices.md](map/operations/ProformaInvoices.md) |
| `AdvanceInvoice` | 3 | [map/operations/AdvanceInvoice.md](map/operations/AdvanceInvoice.md) |
| `Coupons` | 14 | [map/operations/Coupons.md](map/operations/Coupons.md) |
| `Components` | 12 | [map/operations/Components.md](map/operations/Components.md) |
| `ComponentPricePoints` | 12 | [map/operations/ComponentPricePoints.md](map/operations/ComponentPricePoints.md) |
| `Products` | 6 | [map/operations/Products.md](map/operations/Products.md) |
| `ProductPricePoints` | 11 | [map/operations/ProductPricePoints.md](map/operations/ProductPricePoints.md) |
| `ProductFamilies` | 4 | [map/operations/ProductFamilies.md](map/operations/ProductFamilies.md) |
| `Customers` | 7 | [map/operations/Customers.md](map/operations/Customers.md) |
| `PaymentProfiles` | 12 | [map/operations/PaymentProfiles.md](map/operations/PaymentProfiles.md) |
| `CustomFields` | 9 | [map/operations/CustomFields.md](map/operations/CustomFields.md) |
| `Offers` | 5 | [map/operations/Offers.md](map/operations/Offers.md) |
| `ReasonCodes` | 5 | [map/operations/ReasonCodes.md](map/operations/ReasonCodes.md) |
| `ReferralCodes` | 1 | [map/operations/ReferralCodes.md](map/operations/ReferralCodes.md) |
| `SalesCommissions` | 3 | [map/operations/SalesCommissions.md](map/operations/SalesCommissions.md) |
| `Sites` | 3 | [map/operations/Sites.md](map/operations/Sites.md) |
| `Events` | 3 | [map/operations/Events.md](map/operations/Events.md) |
| `EventsBasedBillingSegments` | 6 | [map/operations/EventsBasedBillingSegments.md](map/operations/EventsBasedBillingSegments.md) |
| `Insights` | 4 | [map/operations/Insights.md](map/operations/Insights.md) |
| `BillingPortal` | 4 | [map/operations/BillingPortal.md](map/operations/BillingPortal.md) |
| `Webhooks` | 6 | [map/operations/Webhooks.md](map/operations/Webhooks.md) |
| `ApiExports` | 9 | [map/operations/ApiExports.md](map/operations/ApiExports.md) |

---

## Models — where they live, how to build them

**Shapes live only in the source.** Every file under `Models/` and `Errors/` declares exactly one public type,
named after the file, and no two share a name — so a type name *is* its path. Take it from the operation's
**Type sources** table, or build it from the kind's directory below. Never grep for a type.

<!-- gen:models-table -->
| Group | Count | Directory (file = `<TypeName>.cs`) |
|---|---:|---|
| Records (plain `record` data models) | 555 | `Models/` |
| Unions (`OneOf` / `AnyOf`) — variant factories + `TryGet…` | 7 + 83 | `Models/OneOf/` · `Models/AnyOf/` |
| Enums (`StringEnum<T>` / `IntEnum<T>`) — C# member names + wire values | 98 | `Models/Enums/` |
| Typed error classes (`: ApiError`, one per Case A operation) | 163 | `Errors/` |
<!-- /gen:models-table -->

Conventions: records are immutable, `init`-only; `required` properties must be set in the object initializer;
`T?` is optional. A field's wire name is its `[JsonPropertyName]` and often differs from the C# name
(`AmountInCents` ↔ `amount_in_cents`) — read it off the property, don't derive it. Unions wrap `Optional<T>`
variants — build via static factory or implicit conversion, read via `TryGet…(out …)`. Enums are **not** C#
enums — build with `Type.FromValue("wire")` or the static members, whose names are PascalCase even when the
wire value isn't (`CollectionMethod.Invoice`, not `.invoice`).

<!-- gen:namespaces -->
Namespaces by content type (add `using` accordingly):

| Contents | Namespace(s) |
|---|---|
| Client & options (root) | `MaxioAdvancedBilling` |
| Operation controllers (`Api/`) | `MaxioAdvancedBilling.Api` |
| Records (`Models/`) | `MaxioAdvancedBilling.Models` |
| Enums (`Models/Enums/`) | `MaxioAdvancedBilling.Models.Enums` |
| Unions (`Models/AnyOf/`, `Models/OneOf/`) | `MaxioAdvancedBilling.Models.AnyOf` · `MaxioAdvancedBilling.Models.OneOf` |
| Error classes (`Errors/`) | `MaxioAdvancedBilling.Errors` |
<!-- /gen:namespaces -->

---

## Servers & auth

**Auth — Basic only.** Set `options.BasicAuth = new BasicAuthCredentials { Username = "<api_key>", Password = "x" }`.
Convention: **`Username` = your Maxio/Chargify API key, `Password` = the literal string `"x"`**.
Source: `MaxioAdvancedBillingClientOptions.cs`, `Core/Authentication/Basic/BasicAuthCredentials.cs`.

**Environments.** `options.Environment` is a `ServerEnvironment` (`Servers/ServerEnvironment.cs`):

| Environment | Value | Hosting |
|---|---|---|
| `ServerEnvironment.Us` *(default)* | `US` | US-hosted (default for most accounts) |
| `ServerEnvironment.Eu` | `EU` | EU-hosted (only if your account requested EU hosting) |

**Two server groups** (most operations use Production; only `SubscriptionComponents` event-ingest endpoints use
Ebb). Base-URL templates and the **override points** (`options.Server.…`):

| Group | US base-URL template | EU base-URL template | Override point |
|---|---|---|---|
| Production | `https://{site}.chargify.com` | `https://{site}.ebilling.maxio.com` | `options.Server.Production.Us.BaseUrl` / `.Us.Site` (and `.Eu.*`) |
| Ebb (events) | `https://events.chargify.com/{site}` | `https://events.chargify.com/{site}` | `options.Server.Ebb.Us.BaseUrl` / `.Us.Site` (and `.Eu.*`) |

`{site}` defaults to `subdomain` — set `options.Server.Production.Us.Site = "your-subdomain"`.
**To redirect to a mock/dev host**, override `BaseUrl` on the relevant group, e.g.
`options.Server.Production.Us.BaseUrl = "http://localhost:8080"`. Sources: `Server.cs`, `ServerOptions.cs`,
`Servers/ProductionOptions.cs`, `Servers/EbbOptions.cs`.

Retry/resilience is configurable via `options.Retry` (`RetryOptions`, backed by Polly).
