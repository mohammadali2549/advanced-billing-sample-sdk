using System.Text.Json.Serialization;

namespace MaxioAdvancedBilling.Models;

public record PrepaidUsageAllocationDetail
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("allocation_id")]
    public int? AllocationId { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("charge_id")]
    public int? ChargeId { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("usage_quantity")]
    public int? UsageQuantity { get; init; }
}
