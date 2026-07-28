# ReasonCodes — operations

Accessor: `client.ReasonCodes` · Source: `Api/ReasonCodes.cs` · 5 operations


### CreateReasonCode
- **Signature**: `CreateReasonCode(CreateReasonCodeRequest? body, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `ReasonCodeResponse`
- **Error**: `SdkException<CreateReasonCodeError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

### DeleteReasonCode
- **Signature**: `DeleteReasonCode(int reasonCodeId, CancellationToken ct = default)`
- **Returns**: `OkResponse`
- **Error**: `SdkException<DeleteReasonCodeError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetRawError(out RawError)` [fallback]

### ListReasonCodes
- **Signature**: `ListReasonCodes(int? page = 1, int? perPage = 20, CancellationToken ct = default)`
  - defaults: `page` = 1, `perPage` = 20
- **Query params (wire ← C#)**: `page` ← `page`, `per_page` ← `perPage`
- **Returns**: `IReadOnlyList<ReasonCodeResponse>`
- **Error**: `SdkException<ListReasonCodesError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]
- **Pagination**: manual `page`+`perPage`

### ReadReasonCode
- **Signature**: `ReadReasonCode(int reasonCodeId, CancellationToken ct = default)`
- **Returns**: `ReasonCodeResponse`
- **Error**: `SdkException<ReadReasonCodeError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetRawError(out RawError)` [fallback]

### UpdateReasonCode
- **Signature**: `UpdateReasonCode(int reasonCodeId, UpdateReasonCodeRequest? body, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `ReasonCodeResponse`
- **Error**: `SdkException<UpdateReasonCodeError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]
