#nullable enable

namespace Weave.JsonConverters
{
    /// <inheritdoc />
    public sealed class ReasoningEffortOptionValueNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Weave.ReasoningEffortOptionValue?>
    {
        /// <inheritdoc />
        public override global::Weave.ReasoningEffortOptionValue? Read(
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
                        return global::Weave.ReasoningEffortOptionValueExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Weave.ReasoningEffortOptionValue)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Weave.ReasoningEffortOptionValue?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Weave.ReasoningEffortOptionValue? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Weave.ReasoningEffortOptionValueExtensions.ToValueString(value.Value));
            }
        }
    }
}
