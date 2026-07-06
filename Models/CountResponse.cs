using System.Text.Json.Serialization;

namespace MaxioAdvancedBilling.Models;

public record CountResponse
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("count")]
    public int? Count { get; init; }
}
