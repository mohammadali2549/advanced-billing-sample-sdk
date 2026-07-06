using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using MaxioAdvancedBilling.Core.Extensions;
using MaxioAdvancedBilling.Core.Models;

namespace MaxioAdvancedBilling.Models.AnyOf;

[JsonConverter(typeof(StartingQuantityConverter))]
public record StartingQuantity
{
    private readonly Optional<int> _intValue;

    private readonly Optional<string> _stringValue;

    private StartingQuantity(Optional<int> intValue, Optional<string> stringValue)
    {
        _intValue = intValue;
        _stringValue = stringValue;
    }

    public static StartingQuantity Int(int value) => new(Optional<int>.Some(value), default);

    public static StartingQuantity String(string value) => new(default, Optional<string>.Some(value));

    public bool TryGetInt(out int value) => _intValue.TryGetValue(out value);

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public static implicit operator StartingQuantity(int value) => Int(value);

    public static implicit operator StartingQuantity(string value) => String(value);
}

file sealed class StartingQuantityConverter : JsonConverter<StartingQuantity>
{
    public override StartingQuantity Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<int>(root, options, out var intValue))
        {
            return StartingQuantity.Int(intValue);
        }
        if (JsonSerializer.TryDeserialize<string>(root, options, out var stringValue))
        {
            return StartingQuantity.String(stringValue);
        }
        throw new JsonException($"JSON does not match int or string schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, StartingQuantity value, JsonSerializerOptions options)
    {
        if (value.TryGetInt(out var intValue))
        {
            JsonSerializer.Serialize(writer, intValue, options);
        }
        else if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(StartingQuantity)} contains no valid value to serialize.");
        }
    }
}
