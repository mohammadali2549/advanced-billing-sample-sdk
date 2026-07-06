using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using MaxioAdvancedBilling.Core.Extensions;
using MaxioAdvancedBilling.Core.Models;

namespace MaxioAdvancedBilling.Models.AnyOf;

/// <summary>
/// Either the component price point's Chargify id or its handle prefixed with <c>handle:</c>
/// </summary>
[JsonConverter(typeof(PricePointId3Converter))]
public record PricePointId3
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<int> _intValue;

    private PricePointId3(Optional<string> stringValue, Optional<int> intValue)
    {
        _stringValue = stringValue;
        _intValue = intValue;
    }

    public static PricePointId3 String(string value) => new(Optional<string>.Some(value), default);

    public static PricePointId3 Int(int value) => new(default, Optional<int>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetInt(out int value) => _intValue.TryGetValue(out value);

    public static implicit operator PricePointId3(string value) => String(value);

    public static implicit operator PricePointId3(int value) => Int(value);
}

file sealed class PricePointId3Converter : JsonConverter<PricePointId3>
{
    public override PricePointId3 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<string>(root, options, out var stringValue))
        {
            return PricePointId3.String(stringValue);
        }
        if (JsonSerializer.TryDeserialize<int>(root, options, out var intValue))
        {
            return PricePointId3.Int(intValue);
        }
        throw new JsonException($"JSON does not match string or int schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, PricePointId3 value, JsonSerializerOptions options)
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
            throw new JsonException($"{nameof(PricePointId3)} contains no valid value to serialize.");
        }
    }
}
