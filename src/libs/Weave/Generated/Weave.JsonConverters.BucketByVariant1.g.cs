#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Weave.JsonConverters
{
    /// <inheritdoc />
    public class BucketByVariant1JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Weave.BucketByVariant1>
    {
        /// <inheritdoc />
        public override global::Weave.BucketByVariant1 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Weave.AgentSpanStatsReqBucketByVariant1Discriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Weave.AgentSpanStatsReqBucketByVariant1Discriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Weave.AgentSpanStatsReqBucketByVariant1Discriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Weave.AgentSpanStatsTimeBucketSpec? time = default;
            if (discriminator?.Type == global::Weave.AgentSpanStatsReqBucketByVariant1DiscriminatorType.Time)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Weave.AgentSpanStatsTimeBucketSpec), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Weave.AgentSpanStatsTimeBucketSpec> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Weave.AgentSpanStatsTimeBucketSpec)}");
                time = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Weave.AgentSpanStatsNumericBucketSpec? number = default;
            if (discriminator?.Type == global::Weave.AgentSpanStatsReqBucketByVariant1DiscriminatorType.Number)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Weave.AgentSpanStatsNumericBucketSpec), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Weave.AgentSpanStatsNumericBucketSpec> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Weave.AgentSpanStatsNumericBucketSpec)}");
                number = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Weave.BucketByVariant1(
                discriminator?.Type,
                time,

                number
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Weave.BucketByVariant1 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsTime)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Weave.AgentSpanStatsTimeBucketSpec), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Weave.AgentSpanStatsTimeBucketSpec?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Weave.AgentSpanStatsTimeBucketSpec).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Time!, typeInfo);
            }
            else if (value.IsNumber)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Weave.AgentSpanStatsNumericBucketSpec), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Weave.AgentSpanStatsNumericBucketSpec?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Weave.AgentSpanStatsNumericBucketSpec).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Number!, typeInfo);
            }
        }
    }
}