using System.Text.Json.Serialization;

namespace MaxioAdvancedBilling.Models;

public record MeteredUsage
{
    [JsonPropertyName("previous_unit_balance")]
    public required string PreviousUnitBalance { get; init; }

    [JsonPropertyName("new_unit_balance")]
    public required int NewUnitBalance { get; init; }

    [JsonPropertyName("usage_quantity")]
    public required int UsageQuantity { get; init; }

    [JsonPropertyName("component_id")]
    public required int ComponentId { get; init; }

    [JsonPropertyName("component_handle")]
    public required string ComponentHandle { get; init; }

    [JsonPropertyName("memo")]
    public required string Memo { get; init; }
}
