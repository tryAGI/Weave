#nullable enable

namespace Weave.JsonConverters
{
    /// <inheritdoc />
    public sealed class ConvertSpecToNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Weave.ConvertSpecTo?>
    {
        /// <inheritdoc />
        public override global::Weave.ConvertSpecTo? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Weave.ConvertSpecToExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Weave.ConvertSpecTo)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Weave.ConvertSpecTo?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Weave.ConvertSpecTo? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Weave.ConvertSpecToExtensions.ToValueString(value.Value));
            }
        }
    }
}
