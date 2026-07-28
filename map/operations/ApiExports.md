# ApiExports — operations

Accessor: `client.ApiExports` · Source: `Api/ApiExports.cs` · 9 operations


### ExportInvoices
- **Signature**: `ExportInvoices(CancellationToken ct = default)`
- **Returns**: `BatchJobResponse`
- **Error**: `SdkException<ExportInvoicesError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetSingleErrorResponse1(out SingleErrorResponse1)` [409] · `TryGetRawError(out RawError)` [fallback]

### ExportProformaInvoices
- **Signature**: `ExportProformaInvoices(CancellationToken ct = default)`
- **Returns**: `BatchJobResponse`
- **Error**: `SdkException<ExportProformaInvoicesError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetSingleErrorResponse1(out SingleErrorResponse1)` [409] · `TryGetRawError(out RawError)` [fallback]

### ExportSubscriptions
- **Signature**: `ExportSubscriptions(CancellationToken ct = default)`
- **Returns**: `BatchJobResponse`
- **Error**: `SdkException<ExportSubscriptionsError>` — **Case A (typed)**
- **Error accessors**: `TryGetSingleErrorResponse1(out SingleErrorResponse1)` [409] · `TryGetRawError(out RawError)` [fallback]

### ListExportedInvoices
- **Signature**: `ListExportedInvoices(string batchId, int? perPage = 100, int? page = 1, CancellationToken ct = default)`
  - defaults: `perPage` = 100, `page` = 1
- **Query params (wire ← C#)**: `per_page` ← `perPage`, `page` ← `page`
- **Returns**: `IReadOnlyList<Invoice>`
- **Error**: `SdkException<ListExportedInvoicesError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetRawError(out RawError)` [fallback]
- **Pagination**: manual `page`+`perPage`

### ListExportedProformaInvoices
- **Signature**: `ListExportedProformaInvoices(string batchId, int? perPage = 100, int? page = 1, CancellationToken ct = default)`
  - defaults: `perPage` = 100, `page` = 1
- **Query params (wire ← C#)**: `per_page` ← `perPage`, `page` ← `page`
- **Returns**: `IReadOnlyList<ProformaInvoice>`
- **Error**: `SdkException<ListExportedProformaInvoicesError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetRawError(out RawError)` [fallback]
- **Pagination**: manual `page`+`perPage`

### ListExportedSubscriptions
- **Signature**: `ListExportedSubscriptions(string batchId, int? perPage = 100, int? page = 1, CancellationToken ct = default)`
  - defaults: `perPage` = 100, `page` = 1
- **Query params (wire ← C#)**: `per_page` ← `perPage`, `page` ← `page`
- **Returns**: `IReadOnlyList<Subscription>`
- **Error**: `SdkException<ListExportedSubscriptionsError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetRawError(out RawError)` [fallback]
- **Pagination**: manual `page`+`perPage`

### ReadInvoicesExport
- **Signature**: `ReadInvoicesExport(string batchId, CancellationToken ct = default)`
- **Returns**: `BatchJobResponse`
- **Error**: `SdkException<ReadInvoicesExportError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetRawError(out RawError)` [fallback]

### ReadProformaInvoicesExport
- **Signature**: `ReadProformaInvoicesExport(string batchId, CancellationToken ct = default)`
- **Returns**: `BatchJobResponse`
- **Error**: `SdkException<ReadProformaInvoicesExportError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetRawError(out RawError)` [fallback]

### ReadSubscriptionsExport
- **Signature**: `ReadSubscriptionsExport(string batchId, CancellationToken ct = default)`
- **Returns**: `BatchJobResponse`
- **Error**: `SdkException<ReadSubscriptionsExportError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetRawError(out RawError)` [fallback]
