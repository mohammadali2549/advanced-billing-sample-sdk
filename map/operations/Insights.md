# Insights — operations

Accessor: `client.Insights` · Source: `Api/Insights.cs` · 4 operations


### ListMrrMovements
- **Signature**: `ListMrrMovements(int? subscriptionId, SortingDirection? direction, int? page = 1, int? perPage = 10, CancellationToken ct = default)`
  - `subscriptionId` — nullable, no default → **must pass explicitly**
  - `direction` — nullable, no default → **must pass explicitly**
  - defaults: `page` = 1, `perPage` = 10
- **Query params (wire ← C#)**: `subscription_id` ← `subscriptionId`, `page` ← `page`, `per_page` ← `perPage`, `direction` ← `direction`
- **Returns**: `ListMrrResponse`
- **Error**: `SdkException<RawError>` — **Case B**
- **Pagination**: manual `page`+`perPage`

### ListMrrPerSubscription
- **Signature**: `ListMrrPerSubscription(ListMrrFilter? filter, string? atTime, Direction? direction, int? page = 1, int? perPage = 20, CancellationToken ct = default)`
  - `filter` — nullable, no default → **must pass explicitly**
  - `atTime` — nullable, no default → **must pass explicitly**
  - `direction` — nullable, no default → **must pass explicitly**
  - defaults: `page` = 1, `perPage` = 20
- **Query params (wire ← C#)**: `filter` ← `filter`, `at_time` ← `atTime`, `page` ← `page`, `per_page` ← `perPage`, `direction` ← `direction`
- **Returns**: `SubscriptionMrrResponse`
- **Error**: `SdkException<ListMrrPerSubscriptionError>` — **Case A (typed)**
- **Error accessors**: `TryGetSubscriptionsMrrErrorResponse1(out SubscriptionsMrrErrorResponse1)` [400] · `TryGetRawError(out RawError)` [fallback]
- **Pagination**: manual `page`+`perPage`

### ReadMrr
- **Signature**: `ReadMrr(DateTimeOffset? atTime, int? subscriptionId, CancellationToken ct = default)`
  - `atTime` — nullable, no default → **must pass explicitly**
  - `subscriptionId` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `at_time` ← `atTime`, `subscription_id` ← `subscriptionId`
- **Returns**: `MrrResponse`
- **Error**: `SdkException<RawError>` — **Case B**

### ReadSiteStats
- **Signature**: `ReadSiteStats(CancellationToken ct = default)`
- **Returns**: `SiteSummary`
- **Error**: `SdkException<RawError>` — **Case B**
