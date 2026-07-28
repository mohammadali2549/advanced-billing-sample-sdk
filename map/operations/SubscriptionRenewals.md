# SubscriptionRenewals — operations

Accessor: `client.SubscriptionRenewals` · Source: `Api/SubscriptionRenewals.cs` · 11 operations


### CancelScheduledRenewalConfiguration
- **Signature**: `CancelScheduledRenewalConfiguration(int subscriptionId, int id, CancellationToken ct = default)`
- **Returns**: `ScheduledRenewalConfigurationResponse`
- **Error**: `SdkException<CancelScheduledRenewalConfigurationError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

### CreateScheduledRenewalConfiguration
- **Signature**: `CreateScheduledRenewalConfiguration(int subscriptionId, ScheduledRenewalConfigurationRequest? body, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `ScheduledRenewalConfigurationResponse`
- **Error**: `SdkException<CreateScheduledRenewalConfigurationError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

### CreateScheduledRenewalConfigurationItem
- **Signature**: `CreateScheduledRenewalConfigurationItem(int subscriptionId, int scheduledRenewalsConfigurationId, ScheduledRenewalConfigurationItemRequest? body, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `ScheduledRenewalConfigurationItemResponse`
- **Error**: `SdkException<CreateScheduledRenewalConfigurationItemError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

### DeleteScheduledRenewalConfigurationItem
- **Signature**: `DeleteScheduledRenewalConfigurationItem(int subscriptionId, int scheduledRenewalsConfigurationId, int id, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<DeleteScheduledRenewalConfigurationItemError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

### ListScheduledRenewalConfigurations
- **Signature**: `ListScheduledRenewalConfigurations(int subscriptionId, Status? status, CancellationToken ct = default)`
  - `status` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `status` ← `status`
- **Returns**: `ScheduledRenewalConfigurationsResponse`
- **Error**: `SdkException<RawError>` — **Case B**

### LockInScheduledRenewalImmediately
- **Signature**: `LockInScheduledRenewalImmediately(int subscriptionId, int id, CancellationToken ct = default)`
- **Returns**: `ScheduledRenewalConfigurationResponse`
- **Error**: `SdkException<LockInScheduledRenewalImmediatelyError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

### ReadScheduledRenewalConfiguration
- **Signature**: `ReadScheduledRenewalConfiguration(int subscriptionId, int id, CancellationToken ct = default)`
- **Returns**: `ScheduledRenewalConfigurationResponse`
- **Error**: `SdkException<RawError>` — **Case B**

### ScheduleScheduledRenewalLockIn
- **Signature**: `ScheduleScheduledRenewalLockIn(int subscriptionId, int id, ScheduledRenewalLockInRequest? body, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `ScheduledRenewalConfigurationResponse`
- **Error**: `SdkException<ScheduleScheduledRenewalLockInError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

### UnpublishScheduledRenewalConfiguration
- **Signature**: `UnpublishScheduledRenewalConfiguration(int subscriptionId, int id, CancellationToken ct = default)`
- **Returns**: `ScheduledRenewalConfigurationResponse`
- **Error**: `SdkException<UnpublishScheduledRenewalConfigurationError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

### UpdateScheduledRenewalConfiguration
- **Signature**: `UpdateScheduledRenewalConfiguration(int subscriptionId, int id, ScheduledRenewalConfigurationRequest? body, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `ScheduledRenewalConfigurationResponse`
- **Error**: `SdkException<UpdateScheduledRenewalConfigurationError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

### UpdateScheduledRenewalConfigurationItem
- **Signature**: `UpdateScheduledRenewalConfigurationItem(int subscriptionId, int scheduledRenewalsConfigurationId, int id, ScheduledRenewalUpdateRequest? body, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `ScheduledRenewalConfigurationItemResponse`
- **Error**: `SdkException<UpdateScheduledRenewalConfigurationItemError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]
