#nullable enable

namespace Weave.JsonConverters
{
    /// <inheritdoc />
    public sealed class AgentSpanStatsColumnValueTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Weave.AgentSpanStatsColumnValueType>
    {
        /// <inheritdoc />
        public override global::Weave.AgentSpanStatsColumnValueType Read(
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
                        return global::Weave.AgentSpanStatsColumnValueTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Weave.AgentSpanStatsColumnValueType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Weave.AgentSpanStatsColumnValueType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Weave.AgentSpanStatsColumnValueType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Weave.AgentSpanStatsColumnValueTypeExtensions.ToValueString(value));
        }
    }
}
