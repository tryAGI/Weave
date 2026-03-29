#nullable enable

namespace Weave.JsonConverters
{
    /// <inheritdoc />
    public sealed class CallMetricSpecMetricNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Weave.CallMetricSpecMetric?>
    {
        /// <inheritdoc />
        public override global::Weave.CallMetricSpecMetric? Read(
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
                        return global::Weave.CallMetricSpecMetricExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Weave.CallMetricSpecMetric)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Weave.CallMetricSpecMetric?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Weave.CallMetricSpecMetric? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Weave.CallMetricSpecMetricExtensions.ToValueString(value.Value));
            }
        }
    }
}
