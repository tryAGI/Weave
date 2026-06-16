#nullable enable

namespace Weave.JsonConverters
{
    /// <inheritdoc />
    public sealed class AgentSearchReqRolesVariant1ItemNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Weave.AgentSearchReqRolesVariant1Item?>
    {
        /// <inheritdoc />
        public override global::Weave.AgentSearchReqRolesVariant1Item? Read(
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
                        return global::Weave.AgentSearchReqRolesVariant1ItemExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Weave.AgentSearchReqRolesVariant1Item)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Weave.AgentSearchReqRolesVariant1Item?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Weave.AgentSearchReqRolesVariant1Item? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Weave.AgentSearchReqRolesVariant1ItemExtensions.ToValueString(value.Value));
            }
        }
    }
}
