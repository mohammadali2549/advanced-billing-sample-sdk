# ProformaInvoices — operations

Accessor: `client.ProformaInvoices` · Source: `Api/ProformaInvoices.cs` · 10 operations


### CreateConsolidatedProformaInvoice
- **Signature**: `CreateConsolidatedProformaInvoice(string uid, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<CreateConsolidatedProformaInvoiceError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

### CreateProformaInvoice
- **Signature**: `CreateProformaInvoice(int subscriptionId, CancellationToken ct = default)`
- **Returns**: `ProformaInvoice`
- **Error**: `SdkException<CreateProformaInvoiceError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

### CreateSignupProformaInvoice
- **Signature**: `CreateSignupProformaInvoice(CreateSubscriptionRequest? body, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `ProformaInvoice`
- **Error**: `SdkException<CreateSignupProformaInvoiceError>` — **Case A (typed)**
- **Error accessors**: `TryGetProformaBadRequestErrorResponse1(out ProformaBadRequestErrorResponse1)` [400] · `TryGetErrorArrayMapResponse1(out ErrorArrayMapResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

### DeliverProformaInvoice
- **Signature**: `DeliverProformaInvoice(string proformaInvoiceUid, DeliverProformaInvoiceRequest? body, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `ProformaInvoice`
- **Error**: `SdkException<DeliverProformaInvoiceError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

### ListProformaInvoices
- **Signature**: `ListProformaInvoices(int subscriptionId, string? startDate, string? endDate, ProformaInvoiceStatus? status, Direction? direction, int? page = 1, int? perPage = 20, bool? lineItems = false, bool? discounts = false, bool? taxes = false, bool? credits = false, bool? payments = false, bool? customFields = false, CancellationToken ct = default)`
  - 4 params (`startDate` … `direction`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
  - defaults: `page` = 1, `perPage` = 20, `lineItems` = false, `discounts` = false, `taxes` = false, `credits` = false, `payments` = false, `customFields` = false
- **Query params (wire ← C#)**: `start_date` ← `startDate`, `end_date` ← `endDate`, `status` ← `status`, `page` ← `page`, `per_page` ← `perPage`, `direction` ← `direction`, `line_items` ← `lineItems`, `discounts` ← `discounts`, `taxes` ← `taxes`, `credits` ← `credits`, `payments` ← `payments`, `custom_fields` ← `customFields`
- **Returns**: `ListProformaInvoicesResponse`
- **Error**: `SdkException<RawError>` — **Case B**
- **Pagination**: manual `page`+`perPage`

### ListSubscriptionGroupProformaInvoices
- **Signature**: `ListSubscriptionGroupProformaInvoices(string uid, bool? lineItems = false, bool? discounts = false, bool? taxes = false, bool? credits = false, bool? payments = false, bool? customFields = false, CancellationToken ct = default)`
  - defaults: `lineItems` = false, `discounts` = false, `taxes` = false, `credits` = false, `payments` = false, `customFields` = false
- **Query params (wire ← C#)**: `line_items` ← `lineItems`, `discounts` ← `discounts`, `taxes` ← `taxes`, `credits` ← `credits`, `payments` ← `payments`, `custom_fields` ← `customFields`
- **Returns**: `ListProformaInvoicesResponse`
- **Error**: `SdkException<ListSubscriptionGroupProformaInvoicesError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetRawError(out RawError)` [fallback]

### PreviewProformaInvoice
- **Signature**: `PreviewProformaInvoice(int subscriptionId, CancellationToken ct = default)`
- **Returns**: `ProformaInvoice`
- **Error**: `SdkException<PreviewProformaInvoiceError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

### PreviewSignupProformaInvoice
- **Signature**: `PreviewSignupProformaInvoice(CreateSignupProformaPreviewInclude? include, CreateSubscriptionRequest? body, CancellationToken ct = default)`
  - `include` — nullable, no default → **must pass explicitly**
  - `body` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `include` ← `include`
- **Returns**: `SignupProformaPreviewResponse`
- **Error**: `SdkException<PreviewSignupProformaInvoiceError>` — **Case A (typed)**
- **Error accessors**: `TryGetProformaBadRequestErrorResponse1(out ProformaBadRequestErrorResponse1)` [400] · `TryGetErrorArrayMapResponse1(out ErrorArrayMapResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

### ReadProformaInvoice
- **Signature**: `ReadProformaInvoice(string proformaInvoiceUid, CancellationToken ct = default)`
- **Returns**: `ProformaInvoice`
- **Error**: `SdkException<ReadProformaInvoiceError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetRawError(out RawError)` [fallback]

### VoidProformaInvoice
- **Signature**: `VoidProformaInvoice(string proformaInvoiceUid, VoidInvoiceRequest? body, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `ProformaInvoice`
- **Error**: `SdkException<VoidProformaInvoiceError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]
