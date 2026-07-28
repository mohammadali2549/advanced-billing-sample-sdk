# Subscriptions — operations

Accessor: `client.Subscriptions` · Source: `Api/Subscriptions.cs` · 12 operations


### ActivateSubscription
- **Signature**: `ActivateSubscription(int subscriptionId, ActivateSubscriptionRequest? body, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `SubscriptionResponse`
- **Error**: `SdkException<ActivateSubscriptionError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorArrayMapResponse1(out ErrorArrayMapResponse1)` [400] · `TryGetRawError(out RawError)` [fallback]

### ApplyCouponsToSubscription
- **Signature**: `ApplyCouponsToSubscription(int subscriptionId, string? code, AddCouponsRequest? body, CancellationToken ct = default)`
  - `code` — nullable, no default → **must pass explicitly**
  - `body` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `code` ← `code`
- **Returns**: `SubscriptionResponse`
- **Error**: `SdkException<ApplyCouponsToSubscriptionError>` — **Case A (typed)**
- **Error accessors**: `TryGetSubscriptionAddCouponError1(out SubscriptionAddCouponError1)` [422] · `TryGetRawError(out RawError)` [fallback]

### CreateSubscription
- **Signature**: `CreateSubscription(CreateSubscriptionRequest? body, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `SubscriptionResponse`
- **Error**: `SdkException<CreateSubscriptionError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

### FindSubscription
- **Signature**: `FindSubscription(string? reference, CancellationToken ct = default)`
  - `reference` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `reference` ← `reference`
- **Returns**: `SubscriptionResponse`
- **Error**: `SdkException<FindSubscriptionError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetRawError(out RawError)` [fallback]

### ListSubscriptions
- **Signature**: `ListSubscriptions(SubscriptionStateFilter? state, int? product, int? productPricePointId, int? coupon, string? couponCode, SubscriptionDateField? dateField, DateTimeOffset? startDate, DateTimeOffset? endDate, DateTimeOffset? startDatetime, DateTimeOffset? endDatetime, IReadOnlyDictionary<string, string>? metadata, SortingDirection? direction, SubscriptionSort? sort, IReadOnlyList<SubscriptionListInclude>? include, int? page = 1, int? perPage = 20, CancellationToken ct = default)`
  - 14 params (`state` … `include`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
  - defaults: `page` = 1, `perPage` = 20
- **Query params (wire ← C#)**: `page` ← `page`, `per_page` ← `perPage`, `state` ← `state`, `product` ← `product`, `product_price_point_id` ← `productPricePointId`, `coupon` ← `coupon`, `coupon_code` ← `couponCode`, `date_field` ← `dateField`, `start_date` ← `startDate`, `end_date` ← `endDate`, `start_datetime` ← `startDatetime`, `end_datetime` ← `endDatetime`, `metadata` ← `metadata`, `direction` ← `direction`, `sort` ← `sort`, `include` ← `include`
- **Returns**: `IReadOnlyList<SubscriptionResponse>`
- **Error**: `SdkException<RawError>` — **Case B**
- **Pagination**: manual `page`+`perPage`

### OverrideSubscription
- **Signature**: `OverrideSubscription(int subscriptionId, OverrideSubscriptionRequest? body, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `void` (Task)
- **Error**: `SdkException<OverrideSubscriptionError>` — **Case A (typed)**
- **Error accessors**: `TryGetSingleErrorResponse1(out SingleErrorResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

### PreviewSubscription
- **Signature**: `PreviewSubscription(CreateSubscriptionRequest? body, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `SubscriptionPreviewResponse`
- **Error**: `SdkException<RawError>` — **Case B**

### PurgeSubscription
- **Signature**: `PurgeSubscription(int subscriptionId, int ack, IReadOnlyList<SubscriptionPurgeType>? cascade, CancellationToken ct = default)`
  - `cascade` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `ack` ← `ack`, `cascade` ← `cascade`
- **Returns**: `SubscriptionResponse`
- **Error**: `SdkException<PurgeSubscriptionError>` — **Case A (typed)**
- **Error accessors**: `TryGetSubscriptionResponse(out SubscriptionResponse)` [400] · `TryGetRawError(out RawError)` [fallback]

### ReadSubscription
- **Signature**: `ReadSubscription(int subscriptionId, IReadOnlyList<SubscriptionInclude>? include, CancellationToken ct = default)`
  - `include` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `include` ← `include`
- **Returns**: `SubscriptionResponse`
- **Error**: `SdkException<RawError>` — **Case B**

### RemoveCouponFromSubscription
- **Signature**: `RemoveCouponFromSubscription(int subscriptionId, string? couponCode, CancellationToken ct = default)`
  - `couponCode` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `coupon_code` ← `couponCode`
- **Returns**: `string`
- **Error**: `SdkException<RemoveCouponFromSubscriptionError>` — **Case A (typed)**
- **Error accessors**: `TryGetSubscriptionRemoveCouponErrors1(out SubscriptionRemoveCouponErrors1)` [422] · `TryGetRawError(out RawError)` [fallback]

### UpdatePrepaidSubscriptionConfiguration
- **Signature**: `UpdatePrepaidSubscriptionConfiguration(int subscriptionId, UpsertPrepaidConfigurationRequest? body, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `PrepaidConfigurationResponse`
- **Error**: `SdkException<UpdatePrepaidSubscriptionConfigurationError>` — **Case A (typed)**
- **Error accessors**: `TryGetPrepaidConfigurationErrorResponse(out PrepaidConfigurationErrorResponse)` [422] · `TryGetRawError(out RawError)` [fallback]

### UpdateSubscription
- **Signature**: `UpdateSubscription(int subscriptionId, UpdateSubscriptionRequest? body, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `SubscriptionResponse`
- **Error**: `SdkException<UpdateSubscriptionError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]
