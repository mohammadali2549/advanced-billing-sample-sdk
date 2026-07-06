using System.Collections.Generic;
using MaxioAdvancedBilling.Core.Models;

namespace MaxioAdvancedBilling.Core.Authentication.OAuth2;

internal delegate IReadOnlyList<T> CredentialParamsFactory<out T>(string clientId, string? clientSecret);
