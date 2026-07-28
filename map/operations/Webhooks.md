# Webhooks — operations

Accessor: `client.Webhooks` · Source: `Api/Webhooks.cs` · 6 operations


### CreateEndpoint
- **Signature**: `CreateEndpoint(CreateOrUpdateEndpointRequest? body, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `EndpointResponse`
- **Error**: `SdkException<CreateEndpointError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

### EnableWebhooks
- **Signature**: `EnableWebhooks(EnableWebhooksRequest? body, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `EnableWebhooksResponse`
- **Error**: `SdkException<RawError>` — **Case B**

### ListEndpoints
- **Signature**: `ListEndpoints(CancellationToken ct = default)`
- **Returns**: `IReadOnlyList<Endpoint>`
- **Error**: `SdkException<RawError>` — **Case B**

### ListWebhooks
- **Signature**: `ListWebhooks(WebhookStatus? status, string? sinceDate, string? untilDate, WebhookOrder? order, int? subscription, int? page = 1, int? perPage = 20, CancellationToken ct = default)`
  - 5 params (`status` … `subscription`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
  - defaults: `page` = 1, `perPage` = 20
- **Query params (wire ← C#)**: `status` ← `status`, `since_date` ← `sinceDate`, `until_date` ← `untilDate`, `page` ← `page`, `per_page` ← `perPage`, `order` ← `order`, `subscription` ← `subscription`
- **Returns**: `IReadOnlyList<WebhookResponse>`
- **Error**: `SdkException<RawError>` — **Case B**
- **Pagination**: manual `page`+`perPage`

### ReplayWebhooks
- **Signature**: `ReplayWebhooks(ReplayWebhooksRequest? body, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `ReplayWebhooksResponse`
- **Error**: `SdkException<RawError>` — **Case B**

### UpdateEndpoint
- **Signature**: `UpdateEndpoint(int endpointId, CreateOrUpdateEndpointRequest? body, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `EndpointResponse`
- **Error**: `SdkException<UpdateEndpointError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]
