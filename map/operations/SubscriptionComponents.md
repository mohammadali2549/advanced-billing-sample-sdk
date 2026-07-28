# SubscriptionComponents — operations

Accessor: `client.SubscriptionComponents` · Source: `Api/SubscriptionComponents.cs` · 17 operations


### ActivateEventBasedComponent
- **Signature**: `ActivateEventBasedComponent(int subscriptionId, int componentId, ActivateEventBasedComponent? body, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `void` (Task)
- **Error**: `SdkException<RawError>` — **Case B**

### AllocateComponent
- **Signature**: `AllocateComponent(int subscriptionId, int componentId, CreateAllocationRequest? body, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `AllocationResponse`
- **Error**: `SdkException<AllocateComponentError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

### AllocateComponents
- **Signature**: `AllocateComponents(int subscriptionId, AllocateComponents? body, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `IReadOnlyList<AllocationResponse>`
- **Error**: `SdkException<AllocateComponentsError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

### BulkRecordEvents
- **Server group**: Ebb (events)
- **Signature**: `BulkRecordEvents(string apiHandle, string? storeUid, IReadOnlyList<EbbEvent>? body, CancellationToken ct = default)`
  - `storeUid` — nullable, no default → **must pass explicitly**
  - `body` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `store_uid` ← `storeUid`
- **Returns**: `void` (Task)
- **Error**: `SdkException<RawError>` — **Case B**

### BulkResetSubscriptionComponentsPricePoints
- **Signature**: `BulkResetSubscriptionComponentsPricePoints(int subscriptionId, CancellationToken ct = default)`
- **Returns**: `SubscriptionResponse`
- **Error**: `SdkException<RawError>` — **Case B**

### BulkUpdateSubscriptionComponentsPricePoints
- **Signature**: `BulkUpdateSubscriptionComponentsPricePoints(int subscriptionId, BulkComponentsPricePointAssignment? body, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `BulkComponentsPricePointAssignment`
- **Error**: `SdkException<BulkUpdateSubscriptionComponentsPricePointsError>` — **Case A (typed)**
- **Error accessors**: `TryGetComponentPricePointError1(out ComponentPricePointError1)` [422] · `TryGetRawError(out RawError)` [fallback]

### CreateUsage
- **Signature**: `CreateUsage(SubscriptionIdOrReference subscriptionIdOrReference, ComponentIdModel componentId, CreateUsageRequest? body, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `UsageResponse`
- **Error**: `SdkException<CreateUsageError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

### DeactivateEventBasedComponent
- **Signature**: `DeactivateEventBasedComponent(int subscriptionId, int componentId, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<RawError>` — **Case B**

### DeletePrepaidUsageAllocation
- **Signature**: `DeletePrepaidUsageAllocation(int subscriptionId, int componentId, int allocationId, CreditSchemeRequest? body, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `void` (Task)
- **Error**: `SdkException<DeletePrepaidUsageAllocationError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetSubscriptionComponentAllocationError1(out SubscriptionComponentAllocationError1)` [422] · `TryGetRawError(out RawError)` [fallback]

### ListAllocations
- **Signature**: `ListAllocations(int subscriptionId, int componentId, int? page = 1, CancellationToken ct = default)`
  - defaults: `page` = 1
- **Query params (wire ← C#)**: `page` ← `page`
- **Returns**: `IReadOnlyList<AllocationResponse>`
- **Error**: `SdkException<ListAllocationsError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]
- **Pagination**: none (only `page`, no `perPage`)

### ListSubscriptionComponents
- **Signature**: `ListSubscriptionComponents(int subscriptionId, SubscriptionListDateField? dateField, SortingDirection? direction, ListSubscriptionComponentsFilter? filter, string? endDate, string? endDatetime, IncludeNotNull? pricePointIds, IReadOnlyList<int>? productFamilyIds, ListSubscriptionComponentsSort? sort, string? startDate, string? startDatetime, IReadOnlyList<ListSubscriptionComponentsInclude>? include, bool? inUse, CancellationToken ct = default)`
  - 12 params (`dateField` … `inUse`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `date_field` ← `dateField`, `direction` ← `direction`, `filter` ← `filter`, `end_date` ← `endDate`, `end_datetime` ← `endDatetime`, `price_point_ids` ← `pricePointIds`, `product_family_ids` ← `productFamilyIds`, `sort` ← `sort`, `start_date` ← `startDate`, `start_datetime` ← `startDatetime`, `include` ← `include`, `in_use` ← `inUse`
- **Returns**: `IReadOnlyList<SubscriptionComponentResponse>`
- **Error**: `SdkException<RawError>` — **Case B**

### ListSubscriptionComponentsForSite
- **Signature**: `ListSubscriptionComponentsForSite(ListSubscriptionComponentsSort? sort, SortingDirection? direction, ListSubscriptionComponentsForSiteFilter? filter, SubscriptionListDateField? dateField, string? startDate, string? startDatetime, string? endDate, string? endDatetime, IReadOnlyList<int>? subscriptionIds, IncludeNotNull? pricePointIds, IReadOnlyList<int>? productFamilyIds, ListSubscriptionComponentsInclude? include, int? page = 1, int? perPage = 20, CancellationToken ct = default)`
  - 12 params (`sort` … `include`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
  - defaults: `page` = 1, `perPage` = 20
- **Query params (wire ← C#)**: `page` ← `page`, `per_page` ← `perPage`, `sort` ← `sort`, `direction` ← `direction`, `filter` ← `filter`, `date_field` ← `dateField`, `start_date` ← `startDate`, `start_datetime` ← `startDatetime`, `end_date` ← `endDate`, `end_datetime` ← `endDatetime`, `subscription_ids` ← `subscriptionIds`, `price_point_ids` ← `pricePointIds`, `product_family_ids` ← `productFamilyIds`, `include` ← `include`
- **Returns**: `ListSubscriptionComponentsResponse`
- **Error**: `SdkException<RawError>` — **Case B**
- **Pagination**: manual `page`+`perPage`

### ListUsages
- **Signature**: `ListUsages(SubscriptionIdOrReference subscriptionIdOrReference, ComponentIdModel componentId, long? sinceId, long? maxId, DateTimeOffset? sinceDate, DateTimeOffset? untilDate, int? page = 1, int? perPage = 20, CancellationToken ct = default)`
  - 4 params (`sinceId` … `untilDate`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
  - defaults: `page` = 1, `perPage` = 20
- **Query params (wire ← C#)**: `since_id` ← `sinceId`, `max_id` ← `maxId`, `since_date` ← `sinceDate`, `until_date` ← `untilDate`, `page` ← `page`, `per_page` ← `perPage`
- **Returns**: `IReadOnlyList<UsageResponse>`
- **Error**: `SdkException<RawError>` — **Case B**
- **Pagination**: manual `page`+`perPage`

### PreviewAllocations
- **Signature**: `PreviewAllocations(int subscriptionId, PreviewAllocationsRequest? body, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `AllocationPreviewResponse`
- **Error**: `SdkException<PreviewAllocationsError>` — **Case A (typed)**
- **Error accessors**: `TryGetComponentAllocationError1(out ComponentAllocationError1)` [422] · `TryGetRawError(out RawError)` [fallback]

### ReadSubscriptionComponent
- **Signature**: `ReadSubscriptionComponent(int subscriptionId, int componentId, CancellationToken ct = default)`
- **Returns**: `SubscriptionComponentResponse`
- **Error**: `SdkException<ReadSubscriptionComponentError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetRawError(out RawError)` [fallback]

### RecordEvent
- **Server group**: Ebb (events)
- **Signature**: `RecordEvent(string apiHandle, string? storeUid, EbbEvent? body, CancellationToken ct = default)`
  - `storeUid` — nullable, no default → **must pass explicitly**
  - `body` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `store_uid` ← `storeUid`
- **Returns**: `void` (Task)
- **Error**: `SdkException<RawError>` — **Case B**

### UpdatePrepaidUsageAllocationExpirationDate
- **Signature**: `UpdatePrepaidUsageAllocationExpirationDate(int subscriptionId, int componentId, int allocationId, UpdateAllocationExpirationDate? body, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `void` (Task)
- **Error**: `SdkException<UpdatePrepaidUsageAllocationExpirationDateError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetSubscriptionComponentAllocationError1(out SubscriptionComponentAllocationError1)` [422] · `TryGetRawError(out RawError)` [fallback]
