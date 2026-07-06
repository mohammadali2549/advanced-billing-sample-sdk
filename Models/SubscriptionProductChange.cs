using System.Text.Json.Serialization;

namespace MaxioAdvancedBilling.Models;

public record SubscriptionProductChange
{
    [JsonPropertyName("previous_product_id")]
    public required int PreviousProductId { get; init; }

    [JsonPropertyName("new_product_id")]
    public required int NewProductId { get; init; }
}
