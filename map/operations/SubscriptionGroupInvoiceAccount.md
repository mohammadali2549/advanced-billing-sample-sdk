# SubscriptionGroupInvoiceAccount — operations

Accessor: `client.SubscriptionGroupInvoiceAccount` · Source: `Api/SubscriptionGroupInvoiceAccount.cs` · 4 operations


### CreateSubscriptionGroupPrepayment
- **Signature**: `CreateSubscriptionGroupPrepayment(string uid, SubscriptionGroupPrepaymentRequest? body, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `SubscriptionGroupPrepaymentResponse`
- **Error**: `SdkException<CreateSubscriptionGroupPrepaymentError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

### DeductSubscriptionGroupServiceCredit
- **Signature**: `DeductSubscriptionGroupServiceCredit(string uid, DeductServiceCreditRequest? body, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `ServiceCredit`
- **Error**: `SdkException<DeductSubscriptionGroupServiceCreditError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

### IssueSubscriptionGroupServiceCredit
- **Signature**: `IssueSubscriptionGroupServiceCredit(string uid, IssueServiceCreditRequest? body, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `ServiceCreditResponse`
- **Error**: `SdkException<IssueSubscriptionGroupServiceCreditError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

### ListPrepaymentsForSubscriptionGroup
- **Signature**: `ListPrepaymentsForSubscriptionGroup(string uid, ListPrepaymentsFilter? filter, int? page = 1, int? perPage = 20, CancellationToken ct = default)`
  - `filter` — nullable, no default → **must pass explicitly**
  - defaults: `page` = 1, `perPage` = 20
- **Query params (wire ← C#)**: `page` ← `page`, `per_page` ← `perPage`, `filter` ← `filter`
- **Returns**: `ListSubscriptionGroupPrepaymentResponse`
- **Error**: `SdkException<ListPrepaymentsForSubscriptionGroupError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetRawError(out RawError)` [fallback]
- **Pagination**: manual `page`+`perPage`
