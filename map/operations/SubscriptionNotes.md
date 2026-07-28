# SubscriptionNotes — operations

Accessor: `client.SubscriptionNotes` · Source: `Api/SubscriptionNotes.cs` · 5 operations


### CreateSubscriptionNote
- **Signature**: `CreateSubscriptionNote(int subscriptionId, UpdateSubscriptionNoteRequest? body, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `SubscriptionNoteResponse`
- **Error**: `SdkException<CreateSubscriptionNoteError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

### DeleteSubscriptionNote
- **Signature**: `DeleteSubscriptionNote(int subscriptionId, int noteId, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<RawError>` — **Case B**

### ListSubscriptionNotes
- **Signature**: `ListSubscriptionNotes(int subscriptionId, int? page = 1, int? perPage = 20, CancellationToken ct = default)`
  - defaults: `page` = 1, `perPage` = 20
- **Query params (wire ← C#)**: `page` ← `page`, `per_page` ← `perPage`
- **Returns**: `IReadOnlyList<SubscriptionNoteResponse>`
- **Error**: `SdkException<ListSubscriptionNotesError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]
- **Pagination**: manual `page`+`perPage`

### ReadSubscriptionNote
- **Signature**: `ReadSubscriptionNote(int subscriptionId, int noteId, CancellationToken ct = default)`
- **Returns**: `SubscriptionNoteResponse`
- **Error**: `SdkException<RawError>` — **Case B**

### UpdateSubscriptionNote
- **Signature**: `UpdateSubscriptionNote(int subscriptionId, int noteId, UpdateSubscriptionNoteRequest? body, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `SubscriptionNoteResponse`
- **Error**: `SdkException<UpdateSubscriptionNoteError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]
