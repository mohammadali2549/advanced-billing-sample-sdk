# SubscriptionGroupStatus — operations

Accessor: `client.SubscriptionGroupStatus` · Source: `Api/SubscriptionGroupStatus.cs` · 4 operations


### CancelDelayedCancellationForGroup
- **Signature**: `CancelDelayedCancellationForGroup(string uid, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<CancelDelayedCancellationForGroupError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

### CancelSubscriptionsInGroup
- **Signature**: `CancelSubscriptionsInGroup(string uid, CancelGroupedSubscriptionsRequest? body, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `void` (Task)
- **Error**: `SdkException<CancelSubscriptionsInGroupError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

### InitiateDelayedCancellationForGroup
- **Signature**: `InitiateDelayedCancellationForGroup(string uid, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<InitiateDelayedCancellationForGroupError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

### ReactivateSubscriptionGroup
- **Signature**: `ReactivateSubscriptionGroup(string uid, ReactivateSubscriptionGroupRequest? body, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `ReactivateSubscriptionGroupResponse`
- **Error**: `SdkException<ReactivateSubscriptionGroupError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]
