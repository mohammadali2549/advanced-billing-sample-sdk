using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using MaxioAdvancedBilling.Core.Extensions;
using MaxioAdvancedBilling.Core.Models;

namespace MaxioAdvancedBilling.Models.AnyOf;

/// <summary>
/// (Optional)
/// </summary>
[JsonConverter(typeof(TrialIntervalConverter))]
public record TrialInterval
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<int> _intValue;

    private TrialInterval(Optional<string> stringValue, Optional<int> intValue)
    {
        _stringValue = stringValue;
        _intValue = intValue;
    }

    public static TrialInterval String(string value) => new(Optional<string>.Some(value), default);

    public static TrialInterval Int(int value) => new(default, Optional<int>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetInt(out int value) => _intValue.TryGetValue(out value);

    public static implicit operator TrialInterval(string value) => String(value);

    public static implicit operator TrialInterval(int value) => Int(value);
}

file sealed class TrialIntervalConverter : JsonConverter<TrialInterval>
{
    public override TrialInterval Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<string>(root, options, out var stringValue))
        {
            return TrialInterval.String(stringValue);
        }
        if (JsonSerializer.TryDeserialize<int>(root, options, out var intValue))
        {
            return TrialInterval.Int(intValue);
        }
        throw new JsonException($"JSON does not match string or int schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, TrialInterval value, JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else if (value.TryGetInt(out var intValue))
        {
            JsonSerializer.Serialize(writer, intValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(TrialInterval)} contains no valid value to serialize.");
        }
    }
}
