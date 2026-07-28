# SalesCommissions — operations

Accessor: `client.SalesCommissions` · Source: `Api/SalesCommissions.cs` · 3 operations


### ListSalesCommissionSettings
- **Signature**: `ListSalesCommissionSettings(string sellerId, bool? liveMode, int? page = 1, int? perPage = 100, string? authorization = "Bearer <<apiKey>>", CancellationToken ct = default)`
  - `liveMode` — nullable, no default → **must pass explicitly**
  - defaults: `page` = 1, `perPage` = 100, `authorization` = "Bearer <<apiKey>>"
- **Query params (wire ← C#)**: `live_mode` ← `liveMode`, `page` ← `page`, `per_page` ← `perPage`
- **Returns**: `IReadOnlyList<SaleRepSettings>`
- **Error**: `SdkException<RawError>` — **Case B**
- **Pagination**: manual `page`+`perPage`

### ListSalesReps
- **Signature**: `ListSalesReps(string sellerId, bool? liveMode, int? page = 1, int? perPage = 100, string? authorization = "Bearer <<apiKey>>", CancellationToken ct = default)`
  - `liveMode` — nullable, no default → **must pass explicitly**
  - defaults: `page` = 1, `perPage` = 100, `authorization` = "Bearer <<apiKey>>"
- **Query params (wire ← C#)**: `live_mode` ← `liveMode`, `page` ← `page`, `per_page` ← `perPage`
- **Returns**: `IReadOnlyList<ListSaleRepItem>`
- **Error**: `SdkException<RawError>` — **Case B**
- **Pagination**: manual `page`+`perPage`

### ReadSalesRep
- **Signature**: `ReadSalesRep(string sellerId, string salesRepId, bool? liveMode, int? page = 1, int? perPage = 100, string? authorization = "Bearer <<apiKey>>", CancellationToken ct = default)`
  - `liveMode` — nullable, no default → **must pass explicitly**
  - defaults: `page` = 1, `perPage` = 100, `authorization` = "Bearer <<apiKey>>"
- **Query params (wire ← C#)**: `live_mode` ← `liveMode`, `page` ← `page`, `per_page` ← `perPage`
- **Returns**: `SaleRep`
- **Error**: `SdkException<RawError>` — **Case B**
- **Pagination**: manual `page`+`perPage`
