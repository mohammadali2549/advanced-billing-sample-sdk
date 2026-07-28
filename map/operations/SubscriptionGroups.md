# SubscriptionGroups — operations

Accessor: `client.SubscriptionGroups` · Source: `Api/SubscriptionGroups.cs` · 9 operations


### AddSubscriptionToGroup
- **Signature**: `AddSubscriptionToGroup(int subscriptionId, AddSubscriptionToAGroup? body, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `SubscriptionGroupResponse`
- **Error**: `SdkException<RawError>` — **Case B**

### CreateSubscriptionGroup
- **Signature**: `CreateSubscriptionGroup(CreateSubscriptionGroupRequest? body, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `SubscriptionGroupResponse`
- **Error**: `SdkException<CreateSubscriptionGroupError>` — **Case A (typed)**
- **Error accessors**: `TryGetSubscriptionGroupCreateErrorResponse1(out SubscriptionGroupCreateErrorResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

### DeleteSubscriptionGroup
- **Signature**: `DeleteSubscriptionGroup(string uid, CancellationToken ct = default)`
- **Returns**: `DeleteSubscriptionGroupResponse`
- **Error**: `SdkException<DeleteSubscriptionGroupError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetRawError(out RawError)` [fallback]

### FindSubscriptionGroup
- **Signature**: `FindSubscriptionGroup(string subscriptionId, CancellationToken ct = default)`
- **Query params (wire ← C#)**: `subscription_id` ← `subscriptionId`
- **Returns**: `FullSubscriptionGroupResponse`
- **Error**: `SdkException<FindSubscriptionGroupError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetRawError(out RawError)` [fallback]

### ListSubscriptionGroups
- **Signature**: `ListSubscriptionGroups(IReadOnlyList<SubscriptionGroupsListInclude>? include, int? page = 1, int? perPage = 20, CancellationToken ct = default)`
  - `include` — nullable, no default → **must pass explicitly**
  - defaults: `page` = 1, `perPage` = 20
- **Query params (wire ← C#)**: `page` ← `page`, `per_page` ← `perPage`, `include` ← `include`
- **Returns**: `ListSubscriptionGroupsResponse`
- **Error**: `SdkException<RawError>` — **Case B**
- **Pagination**: manual `page`+`perPage`

### ReadSubscriptionGroup
- **Signature**: `ReadSubscriptionGroup(string uid, IReadOnlyList<SubscriptionGroupInclude>? include, CancellationToken ct = default)`
  - `include` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `include` ← `include`
- **Returns**: `FullSubscriptionGroupResponse`
- **Error**: `SdkException<RawError>` — **Case B**

### RemoveSubscriptionFromGroup
- **Signature**: `RemoveSubscriptionFromGroup(int subscriptionId, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<RemoveSubscriptionFromGroupError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

### SignupWithSubscriptionGroup
- **Signature**: `SignupWithSubscriptionGroup(SubscriptionGroupSignupRequest? body, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `SubscriptionGroupSignupResponse`
- **Error**: `SdkException<SignupWithSubscriptionGroupError>` — **Case A (typed)**
- **Error accessors**: `TryGetSubscriptionGroupSignupErrorResponse1(out SubscriptionGroupSignupErrorResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

### UpdateSubscriptionGroupMembers
- **Signature**: `UpdateSubscriptionGroupMembers(string uid, UpdateSubscriptionGroupRequest? body, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `SubscriptionGroupResponse`
- **Error**: `SdkException<UpdateSubscriptionGroupMembersError>` — **Case A (typed)**
- **Error accessors**: `TryGetSubscriptionGroupUpdateErrorResponse1(out SubscriptionGroupUpdateErrorResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]
