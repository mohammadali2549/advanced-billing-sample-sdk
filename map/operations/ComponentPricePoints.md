# ComponentPricePoints — operations

Accessor: `client.ComponentPricePoints` · Source: `Api/ComponentPricePoints.cs` · 12 operations


### ArchiveComponentPricePoint
- **Signature**: `ArchiveComponentPricePoint(ComponentIdModel componentId, PricePointIdModel pricePointId, CancellationToken ct = default)`
- **Returns**: `ComponentPricePointResponse`
- **Error**: `SdkException<ArchiveComponentPricePointError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

### BulkCreateComponentPricePoints
- **Signature**: `BulkCreateComponentPricePoints(string componentId, CreateComponentPricePointsRequest? body, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `ComponentPricePointsResponse`
- **Error**: `SdkException<BulkCreateComponentPricePointsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

### CloneComponentPricePoint
- **Signature**: `CloneComponentPricePoint(ComponentIdModel componentId, PricePointIdModel pricePointId, CloneComponentPricePointRequest? body, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `ComponentPricePointCurrencyOverageResponse`
- **Error**: `SdkException<CloneComponentPricePointError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

### CreateComponentPricePoint
- **Signature**: `CreateComponentPricePoint(int componentId, CreateComponentPricePointRequest? body, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `ComponentPricePointResponse`
- **Error**: `SdkException<CreateComponentPricePointError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorArrayMapResponse1(out ErrorArrayMapResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

### CreateCurrencyPrices
- **Signature**: `CreateCurrencyPrices(int pricePointId, CreateCurrencyPricesRequest? body, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `ComponentCurrencyPricesResponse`
- **Error**: `SdkException<CreateCurrencyPricesError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorArrayMapResponse1(out ErrorArrayMapResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

### ListAllComponentPricePoints
- **Signature**: `ListAllComponentPricePoints(ListComponentsPricePointsInclude? include, SortingDirection? direction, ListPricePointsFilter? filter, int? page = 1, int? perPage = 20, CancellationToken ct = default)`
  - `include` — nullable, no default → **must pass explicitly**
  - `direction` — nullable, no default → **must pass explicitly**
  - `filter` — nullable, no default → **must pass explicitly**
  - defaults: `page` = 1, `perPage` = 20
- **Query params (wire ← C#)**: `include` ← `include`, `page` ← `page`, `per_page` ← `perPage`, `direction` ← `direction`, `filter` ← `filter`
- **Returns**: `ListComponentsPricePointsResponse`
- **Error**: `SdkException<ListAllComponentPricePointsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]
- **Pagination**: manual `page`+`perPage`

### ListComponentPricePoints
- **Signature**: `ListComponentPricePoints(int componentId, bool? currencyPrices, IReadOnlyList<PricePointType>? filterType, int? page = 1, int? perPage = 20, CancellationToken ct = default)`
  - `currencyPrices` — nullable, no default → **must pass explicitly**
  - `filterType` — nullable, no default → **must pass explicitly**
  - defaults: `page` = 1, `perPage` = 20
- **Query params (wire ← C#)**: `currency_prices` ← `currencyPrices`, `page` ← `page`, `per_page` ← `perPage`, `filter[type]` ← `filterType`
- **Returns**: `ComponentPricePointsResponse`
- **Error**: `SdkException<RawError>` — **Case B**
- **Pagination**: manual `page`+`perPage`

### PromoteComponentPricePointToDefault
- **Signature**: `PromoteComponentPricePointToDefault(int componentId, int pricePointId, CancellationToken ct = default)`
- **Returns**: `ComponentResponse`
- **Error**: `SdkException<RawError>` — **Case B**

### ReadComponentPricePoint
- **Signature**: `ReadComponentPricePoint(ComponentIdModel componentId, PricePointIdModel pricePointId, bool? currencyPrices, CancellationToken ct = default)`
  - `currencyPrices` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `currency_prices` ← `currencyPrices`
- **Returns**: `ComponentPricePointCurrencyOverageResponse`
- **Error**: `SdkException<RawError>` — **Case B**

### UnarchiveComponentPricePoint
- **Signature**: `UnarchiveComponentPricePoint(int componentId, int pricePointId, CancellationToken ct = default)`
- **Returns**: `ComponentPricePointResponse`
- **Error**: `SdkException<RawError>` — **Case B**

### UpdateComponentPricePoint
- **Signature**: `UpdateComponentPricePoint(ComponentIdModel componentId, PricePointIdModel pricePointId, UpdateComponentPricePointRequest? body, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `ComponentPricePointResponse`
- **Error**: `SdkException<UpdateComponentPricePointError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorArrayMapResponse1(out ErrorArrayMapResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

### UpdateCurrencyPrices
- **Signature**: `UpdateCurrencyPrices(int pricePointId, UpdateCurrencyPricesRequest? body, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `ComponentCurrencyPricesResponse`
- **Error**: `SdkException<UpdateCurrencyPricesError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorArrayMapResponse1(out ErrorArrayMapResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]
