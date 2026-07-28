# ProductPricePoints — operations

Accessor: `client.ProductPricePoints` · Source: `Api/ProductPricePoints.cs` · 11 operations


### ArchiveProductPricePoint
- **Signature**: `ArchiveProductPricePoint(ProductIdModel productId, PricePointIdModel pricePointId, CancellationToken ct = default)`
- **Returns**: `ProductPricePointResponse`
- **Error**: `SdkException<ArchiveProductPricePointError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

### BulkCreateProductPricePoints
- **Signature**: `BulkCreateProductPricePoints(int productId, BulkCreateProductPricePointsRequest? body, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `BulkCreateProductPricePointsResponse`
- **Error**: `SdkException<BulkCreateProductPricePointsError>` — **Case A (typed)**
- **Error accessors**: `TryGetMapOfJsonElement(out IReadOnlyDictionary<string, JsonElement>)` [422] · `TryGetRawError(out RawError)` [fallback]

### CreateProductCurrencyPrices
- **Signature**: `CreateProductCurrencyPrices(int productPricePointId, CreateProductCurrencyPricesRequest? body, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `CurrencyPricesResponse`
- **Error**: `SdkException<CreateProductCurrencyPricesError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorArrayMapResponse1(out ErrorArrayMapResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

### CreateProductPricePoint
- **Signature**: `CreateProductPricePoint(ProductIdModel productId, CreateProductPricePointRequest? body, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `ProductPricePointResponse`
- **Error**: `SdkException<CreateProductPricePointError>` — **Case A (typed)**
- **Error accessors**: `TryGetProductPricePointErrorResponse1(out ProductPricePointErrorResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

### ListAllProductPricePoints
- **Signature**: `ListAllProductPricePoints(SortingDirection? direction, ListPricePointsFilter? filter, ListProductsPricePointsInclude? include, int? page = 1, int? perPage = 20, CancellationToken ct = default)`
  - `direction` — nullable, no default → **must pass explicitly**
  - `filter` — nullable, no default → **must pass explicitly**
  - `include` — nullable, no default → **must pass explicitly**
  - defaults: `page` = 1, `perPage` = 20
- **Query params (wire ← C#)**: `direction` ← `direction`, `filter` ← `filter`, `include` ← `include`, `page` ← `page`, `per_page` ← `perPage`
- **Returns**: `ListProductPricePointsResponse`
- **Error**: `SdkException<ListAllProductPricePointsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]
- **Pagination**: manual `page`+`perPage`

### ListProductPricePoints
- **Signature**: `ListProductPricePoints(ProductIdModel productId, bool? currencyPrices, IReadOnlyList<PricePointType>? filterType, bool? archived, int? page = 1, int? perPage = 10, CancellationToken ct = default)`
  - `currencyPrices` — nullable, no default → **must pass explicitly**
  - `filterType` — nullable, no default → **must pass explicitly**
  - `archived` — nullable, no default → **must pass explicitly**
  - defaults: `page` = 1, `perPage` = 10
- **Query params (wire ← C#)**: `page` ← `page`, `per_page` ← `perPage`, `currency_prices` ← `currencyPrices`, `filter[type]` ← `filterType`, `archived` ← `archived`
- **Returns**: `ListProductPricePointsResponse`
- **Error**: `SdkException<RawError>` — **Case B**
- **Pagination**: manual `page`+`perPage`

### PromoteProductPricePointToDefault
- **Signature**: `PromoteProductPricePointToDefault(int productId, int pricePointId, CancellationToken ct = default)`
- **Returns**: `ProductResponse`
- **Error**: `SdkException<RawError>` — **Case B**

### ReadProductPricePoint
- **Signature**: `ReadProductPricePoint(ProductIdModel productId, PricePointIdModel pricePointId, bool? currencyPrices, CancellationToken ct = default)`
  - `currencyPrices` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `currency_prices` ← `currencyPrices`
- **Returns**: `ProductPricePointResponse`
- **Error**: `SdkException<RawError>` — **Case B**

### UnarchiveProductPricePoint
- **Signature**: `UnarchiveProductPricePoint(int productId, int pricePointId, CancellationToken ct = default)`
- **Returns**: `ProductPricePointResponse`
- **Error**: `SdkException<RawError>` — **Case B**

### UpdateProductCurrencyPrices
- **Signature**: `UpdateProductCurrencyPrices(int productPricePointId, UpdateCurrencyPricesRequest? body, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `CurrencyPricesResponse`
- **Error**: `SdkException<UpdateProductCurrencyPricesError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorArrayMapResponse1(out ErrorArrayMapResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

### UpdateProductPricePoint
- **Signature**: `UpdateProductPricePoint(ProductIdModel productId, PricePointIdModel pricePointId, UpdateProductPricePointRequest? body, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `ProductPricePointResponse`
- **Error**: `SdkException<RawError>` — **Case B**
