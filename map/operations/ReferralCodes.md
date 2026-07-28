# ReferralCodes — operations

Accessor: `client.ReferralCodes` · Source: `Api/ReferralCodes.cs` · 1 operations


### ValidateReferralCode
- **Signature**: `ValidateReferralCode(string code, CancellationToken ct = default)`
- **Query params (wire ← C#)**: `code` ← `code`
- **Returns**: `ReferralValidationResponse`
- **Error**: `SdkException<ValidateReferralCodeError>` — **Case A (typed)**
- **Error accessors**: `TryGetSingleStringErrorResponse1(out SingleStringErrorResponse1)` [404] · `TryGetRawError(out RawError)` [fallback]
