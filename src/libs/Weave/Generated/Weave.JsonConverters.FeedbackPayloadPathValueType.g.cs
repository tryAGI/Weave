#nullable enable

namespace Weave.JsonConverters
{
    /// <inheritdoc />
    public sealed class FeedbackPayloadPathValueTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Weave.FeedbackPayloadPathValueType>
    {
        /// <inheritdoc />
        public override global::Weave.FeedbackPayloadPathValueType Read(
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
                        return global::Weave.FeedbackPayloadPathValueTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Weave.FeedbackPayloadPathValueType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Weave.FeedbackPayloadPathValueType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Weave.FeedbackPayloadPathValueType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Weave.FeedbackPayloadPathValueTypeExtensions.ToValueString(value));
        }
    }
}
