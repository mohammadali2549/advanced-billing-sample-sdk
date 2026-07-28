# SubscriptionInvoiceAccount — operations

Accessor: `client.SubscriptionInvoiceAccount` · Source: `Api/SubscriptionInvoiceAccount.cs` · 7 operations


### CreatePrepayment
- **Signature**: `CreatePrepayment(int subscriptionId, CreatePrepaymentRequest? body, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `CreatePrepaymentResponse`
- **Error**: `SdkException<CreatePrepaymentApiError>` — **Case A (typed)**
- **Error accessors**: `TryGetCreatePrepaymentErrorResponse(out CreatePrepaymentErrorResponse)` [422] · `TryGetRawError(out RawError)` [fallback]

### DeductServiceCredit
- **Signature**: `DeductServiceCredit(int subscriptionId, DeductServiceCreditRequest? body, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `void` (Task)
- **Error**: `SdkException<DeductServiceCreditApiError>` — **Case A (typed)**
- **Error accessors**: `TryGetDeductServiceCreditErrorResponse(out DeductServiceCreditErrorResponse)` [422] · `TryGetRawError(out RawError)` [fallback]

### IssueServiceCredit
- **Signature**: `IssueServiceCredit(int subscriptionId, IssueServiceCreditRequest? body, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `ServiceCredit`
- **Error**: `SdkException<IssueServiceCreditApiError>` — **Case A (typed)**
- **Error accessors**: `TryGetIssueServiceCreditErrorResponse(out IssueServiceCreditErrorResponse)` [422] · `TryGetRawError(out RawError)` [fallback]

### ListPrepayments
- **Signature**: `ListPrepayments(int subscriptionId, ListPrepaymentsFilter? filter, int? page = 1, int? perPage = 20, CancellationToken ct = default)`
  - `filter` — nullable, no default → **must pass explicitly**
  - defaults: `page` = 1, `perPage` = 20
- **Query params (wire ← C#)**: `page` ← `page`, `per_page` ← `perPage`, `filter` ← `filter`
- **Returns**: `PrepaymentsResponse`
- **Error**: `SdkException<ListPrepaymentsError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetRawError(out RawError)` [fallback]
- **Pagination**: manual `page`+`perPage`

### ListServiceCredits
- **Signature**: `ListServiceCredits(int subscriptionId, SortingDirection? direction, int? page = 1, int? perPage = 20, CancellationToken ct = default)`
  - `direction` — nullable, no default → **must pass explicitly**
  - defaults: `page` = 1, `perPage` = 20
- **Query params (wire ← C#)**: `page` ← `page`, `per_page` ← `perPage`, `direction` ← `direction`
- **Returns**: `ListServiceCreditsResponse`
- **Error**: `SdkException<ListServiceCreditsError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]
- **Pagination**: manual `page`+`perPage`

### ReadAccountBalances
- **Signature**: `ReadAccountBalances(int subscriptionId, CancellationToken ct = default)`
- **Returns**: `AccountBalances`
- **Error**: `SdkException<RawError>` — **Case B**

### RefundPrepayment
- **Signature**: `RefundPrepayment(int subscriptionId, long prepaymentId, RefundPrepaymentRequest? body, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `PrepaymentResponse`
- **Error**: `SdkException<RefundPrepaymentApiError>` — **Case A (typed)**
- **Error accessors**: `TryGetRefundPrepaymentBaseErrorsResponse1(out RefundPrepaymentBaseErrorsResponse1)` [400] · `TryGetString(out string)` [404] · `TryGetRefundPrepaymentErrorResponse(out RefundPrepaymentErrorResponse)` [422] · `TryGetRawError(out RawError)` [fallback]
