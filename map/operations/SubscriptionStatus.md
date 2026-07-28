# SubscriptionStatus — operations

Accessor: `client.SubscriptionStatus` · Source: `Api/SubscriptionStatus.cs` · 10 operations


### CancelDelayedCancellation
- **Signature**: `CancelDelayedCancellation(int subscriptionId, CancellationToken ct = default)`
- **Returns**: `DelayedCancellationResponse`
- **Error**: `SdkException<CancelDelayedCancellationError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetRawError(out RawError)` [fallback]

### CancelDunning
- **Signature**: `CancelDunning(int subscriptionId, CancellationToken ct = default)`
- **Returns**: `SubscriptionResponse`
- **Error**: `SdkException<CancelDunningError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

### CancelSubscription
- **Signature**: `CancelSubscription(int subscriptionId, CancellationRequest? body, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `SubscriptionResponse`
- **Error**: `SdkException<CancelSubscriptionApiError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetCancelSubscriptionErrorResponse(out CancelSubscriptionErrorResponse)` [422] · `TryGetRawError(out RawError)` [fallback]

### InitiateDelayedCancellation
- **Signature**: `InitiateDelayedCancellation(int subscriptionId, CancellationRequest? body, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `DelayedCancellationResponse`
- **Error**: `SdkException<InitiateDelayedCancellationError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

### PauseSubscription
- **Signature**: `PauseSubscription(int subscriptionId, PauseRequest? body, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `SubscriptionResponse`
- **Error**: `SdkException<PauseSubscriptionError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

### PreviewRenewal
- **Signature**: `PreviewRenewal(int subscriptionId, RenewalPreviewRequest? body, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `RenewalPreviewResponse`
- **Error**: `SdkException<PreviewRenewalError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

### ReactivateSubscription
- **Signature**: `ReactivateSubscription(int subscriptionId, ReactivateSubscriptionRequest? body, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `SubscriptionResponse`
- **Error**: `SdkException<ReactivateSubscriptionError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

### ResumeSubscription
- **Signature**: `ResumeSubscription(int subscriptionId, ResumptionCharge? calendarBillingResumptionCharge, CancellationToken ct = default)`
  - `calendarBillingResumptionCharge` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `calendar_billing['resumption_charge']` ← `calendarBillingResumptionCharge`
- **Returns**: `SubscriptionResponse`
- **Error**: `SdkException<ResumeSubscriptionError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

### RetrySubscription
- **Signature**: `RetrySubscription(int subscriptionId, CancellationToken ct = default)`
- **Returns**: `SubscriptionResponse`
- **Error**: `SdkException<RetrySubscriptionError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

### UpdateAutomaticSubscriptionResumption
- **Signature**: `UpdateAutomaticSubscriptionResumption(int subscriptionId, PauseRequest? body, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `SubscriptionResponse`
- **Error**: `SdkException<UpdateAutomaticSubscriptionResumptionError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]
