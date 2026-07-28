# BillingPortal — operations

Accessor: `client.BillingPortal` · Source: `Api/BillingPortal.cs` · 4 operations


### EnableBillingPortalForCustomer
- **Signature**: `EnableBillingPortalForCustomer(int customerId, AutoInvite? autoInvite, CancellationToken ct = default)`
  - `autoInvite` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `auto_invite` ← `autoInvite`
- **Returns**: `CustomerResponse`
- **Error**: `SdkException<EnableBillingPortalForCustomerError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

### ReadBillingPortalLink
- **Signature**: `ReadBillingPortalLink(int customerId, CancellationToken ct = default)`
- **Returns**: `PortalManagementLink`
- **Error**: `SdkException<ReadBillingPortalLinkError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetTooManyManagementLinkRequestsError1(out TooManyManagementLinkRequestsError1)` [429] · `TryGetRawError(out RawError)` [fallback]

### ResendBillingPortalInvitation
- **Signature**: `ResendBillingPortalInvitation(int customerId, CancellationToken ct = default)`
- **Returns**: `ResentInvitation`
- **Error**: `SdkException<ResendBillingPortalInvitationError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

### RevokeBillingPortalAccess
- **Signature**: `RevokeBillingPortalAccess(int customerId, CancellationToken ct = default)`
- **Returns**: `RevokedInvitation`
- **Error**: `SdkException<RawError>` — **Case B**
