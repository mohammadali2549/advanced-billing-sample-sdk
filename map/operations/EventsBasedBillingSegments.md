# EventsBasedBillingSegments — operations

Accessor: `client.EventsBasedBillingSegments` · Source: `Api/EventsBasedBillingSegments.cs` · 6 operations


### BulkCreateSegments
- **Signature**: `BulkCreateSegments(string componentId, string pricePointId, BulkCreateSegments? body, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `ListSegmentsResponse`
- **Error**: `SdkException<BulkCreateSegmentsError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetEventBasedBillingSegment1(out EventBasedBillingSegment1)` [422] · `TryGetRawError(out RawError)` [fallback]

### BulkUpdateSegments
- **Signature**: `BulkUpdateSegments(string componentId, string pricePointId, BulkUpdateSegments? body, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `ListSegmentsResponse`
- **Error**: `SdkException<BulkUpdateSegmentsError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetEventBasedBillingSegment1(out EventBasedBillingSegment1)` [422] · `TryGetRawError(out RawError)` [fallback]

### CreateSegment
- **Signature**: `CreateSegment(string componentId, string pricePointId, CreateSegmentRequest? body, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `SegmentResponse`
- **Error**: `SdkException<CreateSegmentError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetEventBasedBillingSegmentErrors1(out EventBasedBillingSegmentErrors1)` [422] · `TryGetRawError(out RawError)` [fallback]

### DeleteSegment
- **Signature**: `DeleteSegment(string componentId, string pricePointId, double id, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<DeleteSegmentError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404, 422] · `TryGetRawError(out RawError)` [fallback]

### ListSegmentsForPricePoint
- **Signature**: `ListSegmentsForPricePoint(string componentId, string pricePointId, ListSegmentsFilter? filter, int? page = 1, int? perPage = 30, CancellationToken ct = default)`
  - `filter` — nullable, no default → **must pass explicitly**
  - defaults: `page` = 1, `perPage` = 30
- **Query params (wire ← C#)**: `page` ← `page`, `per_page` ← `perPage`, `filter` ← `filter`
- **Returns**: `ListSegmentsResponse`
- **Error**: `SdkException<ListSegmentsForPricePointError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetEventBasedBillingListSegmentsErrors1(out EventBasedBillingListSegmentsErrors1)` [422] · `TryGetRawError(out RawError)` [fallback]
- **Pagination**: manual `page`+`perPage`

### UpdateSegment
- **Signature**: `UpdateSegment(string componentId, string pricePointId, double id, UpdateSegmentRequest? body, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `SegmentResponse`
- **Error**: `SdkException<UpdateSegmentError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetEventBasedBillingSegmentErrors1(out EventBasedBillingSegmentErrors1)` [422] · `TryGetRawError(out RawError)` [fallback]
