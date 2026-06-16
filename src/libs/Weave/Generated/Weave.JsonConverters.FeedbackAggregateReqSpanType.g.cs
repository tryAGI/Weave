#nullable enable

namespace Weave.JsonConverters
{
    /// <inheritdoc />
    public sealed class FeedbackAggregateReqSpanTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Weave.FeedbackAggregateReqSpanType>
    {
        /// <inheritdoc />
        public override global::Weave.FeedbackAggregateReqSpanType Read(
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
                        return global::Weave.FeedbackAggregateReqSpanTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Weave.FeedbackAggregateReqSpanType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Weave.FeedbackAggregateReqSpanType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Weave.FeedbackAggregateReqSpanType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Weave.FeedbackAggregateReqSpanTypeExtensions.ToValueString(value));
        }
    }
}
