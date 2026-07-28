# Sites — operations

Accessor: `client.Sites` · Source: `Api/Sites.cs` · 3 operations


### ClearSite
- **Signature**: `ClearSite(CleanupScope? cleanupScope, CancellationToken ct = default)`
  - `cleanupScope` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `cleanup_scope` ← `cleanupScope`
- **Returns**: `void` (Task)
- **Error**: `SdkException<RawError>` — **Case B**

### ListChargifyJsPublicKeys
- **Signature**: `ListChargifyJsPublicKeys(int? page = 1, int? perPage = 20, CancellationToken ct = default)`
  - defaults: `page` = 1, `perPage` = 20
- **Query params (wire ← C#)**: `page` ← `page`, `per_page` ← `perPage`
- **Returns**: `ListPublicKeysResponse`
- **Error**: `SdkException<RawError>` — **Case B**
- **Pagination**: manual `page`+`perPage`

### ReadSite
- **Signature**: `ReadSite(CancellationToken ct = default)`
- **Returns**: `SiteResponse`
- **Error**: `SdkException<RawError>` — **Case B**
