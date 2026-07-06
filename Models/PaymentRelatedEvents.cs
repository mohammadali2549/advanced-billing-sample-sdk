using System.Text.Json.Serialization;

namespace MaxioAdvancedBilling.Models;

public record PaymentRelatedEvents
{
    [JsonPropertyName("product_id")]
    public required int ProductId { get; init; }

    [JsonPropertyName("account_transaction_id")]
    public required int AccountTransactionId { get; init; }
}
