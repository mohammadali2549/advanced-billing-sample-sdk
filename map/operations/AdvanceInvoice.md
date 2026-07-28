# AdvanceInvoice — operations

Accessor: `client.AdvanceInvoice` · Source: `Api/AdvanceInvoice.cs` · 3 operations


### IssueAdvanceInvoice
- **Signature**: `IssueAdvanceInvoice(int subscriptionId, IssueAdvanceInvoiceRequest? body, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `Invoice`
- **Error**: `SdkException<IssueAdvanceInvoiceError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

### ReadAdvanceInvoice
- **Signature**: `ReadAdvanceInvoice(int subscriptionId, CancellationToken ct = default)`
- **Returns**: `Invoice`
- **Error**: `SdkException<ReadAdvanceInvoiceError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetRawError(out RawError)` [fallback]

### VoidAdvanceInvoice
- **Signature**: `VoidAdvanceInvoice(int subscriptionId, VoidInvoiceRequest? body, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `Invoice`
- **Error**: `SdkException<VoidAdvanceInvoiceError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetRawError(out RawError)` [fallback]
