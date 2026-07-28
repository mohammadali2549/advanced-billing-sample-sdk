# CustomFields — operations

Accessor: `client.CustomFields` · Source: `Api/CustomFields.cs` · 9 operations


### CreateMetadata
- **Signature**: `CreateMetadata(ResourceType resourceType, int resourceId, CreateMetadataRequest? body, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `IReadOnlyList<Metadata>`
- **Error**: `SdkException<CreateMetadataError>` — **Case A (typed)**
- **Error accessors**: `TryGetSingleErrorResponse1(out SingleErrorResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

### CreateMetafields
- **Signature**: `CreateMetafields(ResourceType resourceType, CreateMetafieldsRequest? body, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `IReadOnlyList<Metafield>`
- **Error**: `SdkException<CreateMetafieldsError>` — **Case A (typed)**
- **Error accessors**: `TryGetSingleErrorResponse1(out SingleErrorResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

### DeleteMetadata
- **Signature**: `DeleteMetadata(ResourceType resourceType, int resourceId, string? name, IReadOnlyList<string>? names, CancellationToken ct = default)`
  - `name` — nullable, no default → **must pass explicitly**
  - `names` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `name` ← `name`, `names` ← `names`
- **Returns**: `void` (Task)
- **Error**: `SdkException<DeleteMetadataError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetRawError(out RawError)` [fallback]

### DeleteMetafield
- **Signature**: `DeleteMetafield(ResourceType resourceType, string? name, CancellationToken ct = default)`
  - `name` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `name` ← `name`
- **Returns**: `void` (Task)
- **Error**: `SdkException<DeleteMetafieldError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetRawError(out RawError)` [fallback]

### ListMetadata
- **Signature**: `ListMetadata(ResourceType resourceType, int resourceId, int? page = 1, int? perPage = 20, CancellationToken ct = default)`
  - defaults: `page` = 1, `perPage` = 20
- **Query params (wire ← C#)**: `page` ← `page`, `per_page` ← `perPage`
- **Returns**: `PaginatedMetadata`
- **Error**: `SdkException<RawError>` — **Case B**
- **Pagination**: manual `page`+`perPage`

### ListMetadataForResourceType
- **Signature**: `ListMetadataForResourceType(ResourceType resourceType, BasicDateField? dateField, DateTimeOffset? startDate, DateTimeOffset? endDate, DateTimeOffset? startDatetime, DateTimeOffset? endDatetime, bool? withDeleted, IReadOnlyList<int>? resourceIds, SortingDirection? direction, int? page = 1, int? perPage = 20, CancellationToken ct = default)`
  - 8 params (`dateField` … `direction`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
  - defaults: `page` = 1, `perPage` = 20
- **Query params (wire ← C#)**: `page` ← `page`, `per_page` ← `perPage`, `date_field` ← `dateField`, `start_date` ← `startDate`, `end_date` ← `endDate`, `start_datetime` ← `startDatetime`, `end_datetime` ← `endDatetime`, `with_deleted` ← `withDeleted`, `resource_ids` ← `resourceIds`, `direction` ← `direction`
- **Returns**: `PaginatedMetadata`
- **Error**: `SdkException<RawError>` — **Case B**
- **Pagination**: manual `page`+`perPage`

### ListMetafields
- **Signature**: `ListMetafields(ResourceType resourceType, string? name, SortingDirection? direction, int? page = 1, int? perPage = 20, CancellationToken ct = default)`
  - `name` — nullable, no default → **must pass explicitly**
  - `direction` — nullable, no default → **must pass explicitly**
  - defaults: `page` = 1, `perPage` = 20
- **Query params (wire ← C#)**: `name` ← `name`, `page` ← `page`, `per_page` ← `perPage`, `direction` ← `direction`
- **Returns**: `ListMetafieldsResponse`
- **Error**: `SdkException<RawError>` — **Case B**
- **Pagination**: manual `page`+`perPage`

### UpdateMetadata
- **Signature**: `UpdateMetadata(ResourceType resourceType, int resourceId, UpdateMetadataRequest? body, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `IReadOnlyList<Metadata>`
- **Error**: `SdkException<UpdateMetadataError>` — **Case A (typed)**
- **Error accessors**: `TryGetSingleErrorResponse1(out SingleErrorResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

### UpdateMetafield
- **Signature**: `UpdateMetafield(ResourceType resourceType, UpdateMetafieldsRequest? body, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `IReadOnlyList<Metafield>`
- **Error**: `SdkException<UpdateMetafieldError>` — **Case A (typed)**
- **Error accessors**: `TryGetSingleErrorResponse1(out SingleErrorResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]
