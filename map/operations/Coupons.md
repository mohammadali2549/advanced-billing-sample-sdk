# Coupons — operations

Accessor: `client.Coupons` · Source: `Api/Coupons.cs` · 14 operations


### ArchiveCoupon
- **Signature**: `ArchiveCoupon(int productFamilyId, int couponId, CancellationToken ct = default)`
- **Returns**: `CouponResponse`
- **Error**: `SdkException<RawError>` — **Case B**

### CreateCoupon
- **Signature**: `CreateCoupon(int productFamilyId, CouponRequest? body, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `CouponResponse`
- **Error**: `SdkException<CreateCouponError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

### CreateCouponSubcodes
- **Signature**: `CreateCouponSubcodes(int couponId, CouponSubcodes? body, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `CouponSubcodesResponse`
- **Error**: `SdkException<RawError>` — **Case B**

### CreateOrUpdateCouponCurrencyPrices
- **Signature**: `CreateOrUpdateCouponCurrencyPrices(int couponId, CouponCurrencyRequest? body, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `CouponCurrencyResponse`
- **Error**: `SdkException<CreateOrUpdateCouponCurrencyPricesError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorStringMapResponse1(out ErrorStringMapResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

### DeleteCouponSubcode
- **Signature**: `DeleteCouponSubcode(int couponId, string subcode, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<DeleteCouponSubcodeError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetRawError(out RawError)` [fallback]

### FindCoupon
- **Signature**: `FindCoupon(int? productFamilyId, string? code, bool? currencyPrices, CancellationToken ct = default)`
  - `productFamilyId` — nullable, no default → **must pass explicitly**
  - `code` — nullable, no default → **must pass explicitly**
  - `currencyPrices` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `product_family_id` ← `productFamilyId`, `code` ← `code`, `currency_prices` ← `currencyPrices`
- **Returns**: `CouponResponse`
- **Error**: `SdkException<RawError>` — **Case B**

### ListCouponSubcodes
- **Signature**: `ListCouponSubcodes(int couponId, int? page = 1, int? perPage = 20, CancellationToken ct = default)`
  - defaults: `page` = 1, `perPage` = 20
- **Query params (wire ← C#)**: `page` ← `page`, `per_page` ← `perPage`
- **Returns**: `CouponSubcodes`
- **Error**: `SdkException<RawError>` — **Case B**
- **Pagination**: manual `page`+`perPage`

### ListCoupons
- **Signature**: `ListCoupons(ListCouponsFilter? filter, bool? currencyPrices, int? page = 1, int? perPage = 30, CancellationToken ct = default)`
  - `filter` — nullable, no default → **must pass explicitly**
  - `currencyPrices` — nullable, no default → **must pass explicitly**
  - defaults: `page` = 1, `perPage` = 30
- **Query params (wire ← C#)**: `page` ← `page`, `per_page` ← `perPage`, `filter` ← `filter`, `currency_prices` ← `currencyPrices`
- **Returns**: `IReadOnlyList<CouponResponse>`
- **Error**: `SdkException<RawError>` — **Case B**
- **Pagination**: manual `page`+`perPage`

### ListCouponsForProductFamily
- **Signature**: `ListCouponsForProductFamily(int productFamilyId, ListCouponsFilter? filter, bool? currencyPrices, int? page = 1, int? perPage = 30, CancellationToken ct = default)`
  - `filter` — nullable, no default → **must pass explicitly**
  - `currencyPrices` — nullable, no default → **must pass explicitly**
  - defaults: `page` = 1, `perPage` = 30
- **Query params (wire ← C#)**: `page` ← `page`, `per_page` ← `perPage`, `filter` ← `filter`, `currency_prices` ← `currencyPrices`
- **Returns**: `IReadOnlyList<CouponResponse>`
- **Error**: `SdkException<RawError>` — **Case B**
- **Pagination**: manual `page`+`perPage`

### ReadCoupon
- **Signature**: `ReadCoupon(int productFamilyId, int couponId, bool? currencyPrices, CancellationToken ct = default)`
  - `currencyPrices` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `currency_prices` ← `currencyPrices`
- **Returns**: `CouponResponse`
- **Error**: `SdkException<RawError>` — **Case B**

### ReadCouponUsage
- **Signature**: `ReadCouponUsage(int productFamilyId, int couponId, CancellationToken ct = default)`
- **Returns**: `IReadOnlyList<CouponUsage>`
- **Error**: `SdkException<RawError>` — **Case B**

### UpdateCoupon
- **Signature**: `UpdateCoupon(int productFamilyId, int couponId, CouponRequest? body, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `CouponResponse`
- **Error**: `SdkException<UpdateCouponError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

### UpdateCouponSubcodes
- **Signature**: `UpdateCouponSubcodes(int couponId, CouponSubcodes? body, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `CouponSubcodesResponse`
- **Error**: `SdkException<RawError>` — **Case B**

### ValidateCoupon
- **Signature**: `ValidateCoupon(string code, int? productFamilyId, CancellationToken ct = default)`
  - `productFamilyId` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `code` ← `code`, `product_family_id` ← `productFamilyId`
- **Returns**: `CouponResponse`
- **Error**: `SdkException<ValidateCouponError>` — **Case A (typed)**
- **Error accessors**: `TryGetSingleStringErrorResponse1(out SingleStringErrorResponse1)` [404] · `TryGetRawError(out RawError)` [fallback]
