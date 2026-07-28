# Offers — operations

Accessor: `client.Offers` · Source: `Api/Offers.cs` · 5 operations


### ArchiveOffer
- **Signature**: `ArchiveOffer(int offerId, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<RawError>` — **Case B**

### CreateOffer
- **Signature**: `CreateOffer(CreateOfferRequest? body, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `OfferResponse`
- **Error**: `SdkException<CreateOfferError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorArrayMapResponse1(out ErrorArrayMapResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

### ListOffers
- **Signature**: `ListOffers(bool? includeArchived, int? page = 1, int? perPage = 20, CancellationToken ct = default)`
  - `includeArchived` — nullable, no default → **must pass explicitly**
  - defaults: `page` = 1, `perPage` = 20
- **Query params (wire ← C#)**: `page` ← `page`, `per_page` ← `perPage`, `include_archived` ← `includeArchived`
- **Returns**: `ListOffersResponse`
- **Error**: `SdkException<ListOffersError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]
- **Pagination**: manual `page`+`perPage`

### ReadOffer
- **Signature**: `ReadOffer(int offerId, CancellationToken ct = default)`
- **Returns**: `OfferResponse`
- **Error**: `SdkException<RawError>` — **Case B**

### UnarchiveOffer
- **Signature**: `UnarchiveOffer(int offerId, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<RawError>` — **Case B**
