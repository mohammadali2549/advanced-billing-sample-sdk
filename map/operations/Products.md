# Products — operations

Accessor: `client.Products` · Source: `Api/Products.cs` · 6 operations


### ArchiveProduct
- **Signature**: `ArchiveProduct(int productId, CancellationToken ct = default)`
- **Returns**: `ProductResponse`
- **Error**: `SdkException<ArchiveProductError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

### CreateProduct
- **Signature**: `CreateProduct(string productFamilyId, CreateOrUpdateProductRequest? body, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `ProductResponse`
- **Error**: `SdkException<CreateProductError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

### ListProducts
- **Signature**: `ListProducts(BasicDateField? dateField, ListProductsFilter? filter, DateTimeOffset? endDate, DateTimeOffset? endDatetime, DateTimeOffset? startDate, DateTimeOffset? startDatetime, bool? includeArchived, ListProductsInclude? include, int? page = 1, int? perPage = 20, CancellationToken ct = default)`
  - 8 params (`dateField` … `include`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
  - defaults: `page` = 1, `perPage` = 20
- **Query params (wire ← C#)**: `date_field` ← `dateField`, `filter` ← `filter`, `end_date` ← `endDate`, `end_datetime` ← `endDatetime`, `start_date` ← `startDate`, `start_datetime` ← `startDatetime`, `page` ← `page`, `per_page` ← `perPage`, `include_archived` ← `includeArchived`, `include` ← `include`
- **Returns**: `IReadOnlyList<ProductResponse>`
- **Error**: `SdkException<RawError>` — **Case B**
- **Pagination**: manual `page`+`perPage`

### ReadProduct
- **Signature**: `ReadProduct(int productId, CancellationToken ct = default)`
- **Returns**: `ProductResponse`
- **Error**: `SdkException<RawError>` — **Case B**

### ReadProductByHandle
- **Signature**: `ReadProductByHandle(string apiHandle, CancellationToken ct = default)`
- **Returns**: `ProductResponse`
- **Error**: `SdkException<RawError>` — **Case B**

### UpdateProduct
- **Signature**: `UpdateProduct(int productId, CreateOrUpdateProductRequest? body, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `ProductResponse`
- **Error**: `SdkException<UpdateProductError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]
