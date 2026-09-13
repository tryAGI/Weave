
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Weave
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.CatalogModelsRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weave.LLMModelDetails>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.LLMModelDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.Cost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.Datacenter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.HTTPValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weave.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.ValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.Interleaved))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.InterleavedField), TypeInfoPropertyName = "InterleavedField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.LLMModelDetailsLifecycleStage), TypeInfoPropertyName = "LLMModelDetailsLifecycleStage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weave.LLMModelDetailsAvailableInItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.LLMModelDetailsAvailableInItem), TypeInfoPropertyName = "LLMModelDetailsAvailableInItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.LLMModelDetailsReasoningSupport), TypeInfoPropertyName = "LLMModelDetailsReasoningSupport2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weave.LLMModelDetailsReasoningEffort>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.LLMModelDetailsReasoningEffort), TypeInfoPropertyName = "LLMModelDetailsReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.LLMModelDetailsQuantization), TypeInfoPropertyName = "LLMModelDetailsQuantization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.Limit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.Modalities))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.ModelsDevModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weave.AnyOf<global::Weave.ReasoningToggle, global::Weave.ReasoningEffortOption, global::Weave.ReasoningBudgetTokens>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AnyOf<global::Weave.ReasoningToggle, global::Weave.ReasoningEffortOption, global::Weave.ReasoningBudgetTokens>), TypeInfoPropertyName = "AnyOfReasoningToggleReasoningEffortOptionReasoningBudgetTokens2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.ReasoningToggle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.ReasoningEffortOption))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.ReasoningBudgetTokens))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.ModelsDevModelStatus), TypeInfoPropertyName = "ModelsDevModelStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AnyOf<bool?, global::Weave.Interleaved, object>), TypeInfoPropertyName = "AnyOfBooleanInterleavedObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.ModelsDevProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Weave.ModelsDevModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.NvidiaHardwareOption))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.NvidiaServerlessPricing))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.NvidiaHardwareRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weave.NvidiaHardwareOption>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.Pricing))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weave.ReasoningEffortOptionValue?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.ReasoningEffortOptionValue), TypeInfoPropertyName = "ReasoningEffortOptionValue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.RouterOpenRouterModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.RouterOpenRouterModelQuantization), TypeInfoPropertyName = "RouterOpenRouterModelQuantization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weave.RouterOpenRouterModelSupportedSamplingParameter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.RouterOpenRouterModelSupportedSamplingParameter), TypeInfoPropertyName = "RouterOpenRouterModelSupportedSamplingParameter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weave.RouterOpenRouterModelSupportedFeature>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.RouterOpenRouterModelSupportedFeature), TypeInfoPropertyName = "RouterOpenRouterModelSupportedFeature2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weave.Datacenter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.RouterOpenRouterModelsRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weave.RouterOpenRouterModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weave.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AnyOf<string, int?>), TypeInfoPropertyName = "AnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Weave.ModelsDevProvider>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.InterleavedField?), TypeInfoPropertyName = "NullableInterleavedField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.LLMModelDetailsLifecycleStage?), TypeInfoPropertyName = "NullableLLMModelDetailsLifecycleStage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.LLMModelDetailsAvailableInItem?), TypeInfoPropertyName = "NullableLLMModelDetailsAvailableInItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.LLMModelDetailsReasoningSupport?), TypeInfoPropertyName = "NullableLLMModelDetailsReasoningSupport2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.LLMModelDetailsReasoningEffort?), TypeInfoPropertyName = "NullableLLMModelDetailsReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.LLMModelDetailsQuantization?), TypeInfoPropertyName = "NullableLLMModelDetailsQuantization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AnyOf<global::Weave.ReasoningToggle, global::Weave.ReasoningEffortOption, global::Weave.ReasoningBudgetTokens>?), TypeInfoPropertyName = "NullableAnyOfReasoningToggleReasoningEffortOptionReasoningBudgetTokens2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.ModelsDevModelStatus?), TypeInfoPropertyName = "NullableModelsDevModelStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AnyOf<bool?, global::Weave.Interleaved, object>?), TypeInfoPropertyName = "NullableAnyOfBooleanInterleavedObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.ReasoningEffortOptionValue?), TypeInfoPropertyName = "NullableReasoningEffortOptionValue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.RouterOpenRouterModelQuantization?), TypeInfoPropertyName = "NullableRouterOpenRouterModelQuantization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.RouterOpenRouterModelSupportedSamplingParameter?), TypeInfoPropertyName = "NullableRouterOpenRouterModelSupportedSamplingParameter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.RouterOpenRouterModelSupportedFeature?), TypeInfoPropertyName = "NullableRouterOpenRouterModelSupportedFeature2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AnyOf<string, int?>?), TypeInfoPropertyName = "NullableAnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weave.LLMModelDetails>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weave.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weave.LLMModelDetailsAvailableInItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weave.LLMModelDetailsReasoningEffort>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weave.AnyOf<global::Weave.ReasoningToggle, global::Weave.ReasoningEffortOption, global::Weave.ReasoningBudgetTokens>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weave.NvidiaHardwareOption>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weave.ReasoningEffortOptionValue?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weave.RouterOpenRouterModelSupportedSamplingParameter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weave.RouterOpenRouterModelSupportedFeature>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weave.Datacenter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weave.RouterOpenRouterModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weave.AnyOf<string, int?>>))]
    internal sealed partial class InferenceSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class InferenceSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static InferenceSourceGenerationContext Default { get; } = new(DefaultOptions);

        private InferenceSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::Weave.JsonConverters.AnyOfJsonConverter<double?, global::System.DateTime?, object>());
            options.Converters.Add(new global::Weave.JsonConverters.AnyOfJsonConverter<double?, global::System.DateTime?, object>());
            options.Converters.Add(new global::Weave.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?, object>());
            options.Converters.Add(new global::Weave.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string, int?, double?, bool?, object>());
            options.Converters.Add(new global::Weave.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string, int?, double?, bool?, object>());
            options.Converters.Add(new global::Weave.JsonConverters.AnyOfJsonConverter<double?, string, object>());
            options.Converters.Add(new global::Weave.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<object>, object>());
            options.Converters.Add(new global::Weave.JsonConverters.AnyOfJsonConverter<string, object, object>());
            options.Converters.Add(new global::Weave.JsonConverters.AnyOfJsonConverter<global::Weave.ReasoningToggle, global::Weave.ReasoningEffortOption, global::Weave.ReasoningBudgetTokens>());
            options.Converters.Add(new global::Weave.JsonConverters.AnyOfJsonConverter<bool?, global::Weave.Interleaved, object>());
            options.Converters.Add(new global::Weave.JsonConverters.AnyOfJsonConverter<string, int?>());
            options.Converters.Add(new global::Weave.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Weave.InterleavedField)

                    || typeToConvert == typeof(global::Weave.InterleavedField?)

                    || typeToConvert == typeof(global::Weave.LLMModelDetailsLifecycleStage)

                    || typeToConvert == typeof(global::Weave.LLMModelDetailsLifecycleStage?)

                    || typeToConvert == typeof(global::Weave.LLMModelDetailsAvailableInItem)

                    || typeToConvert == typeof(global::Weave.LLMModelDetailsAvailableInItem?)

                    || typeToConvert == typeof(global::Weave.LLMModelDetailsReasoningSupport)

                    || typeToConvert == typeof(global::Weave.LLMModelDetailsReasoningSupport?)

                    || typeToConvert == typeof(global::Weave.LLMModelDetailsReasoningEffort)

                    || typeToConvert == typeof(global::Weave.LLMModelDetailsReasoningEffort?)

                    || typeToConvert == typeof(global::Weave.LLMModelDetailsQuantization)

                    || typeToConvert == typeof(global::Weave.LLMModelDetailsQuantization?)

                    || typeToConvert == typeof(global::Weave.ModelsDevModelStatus)

                    || typeToConvert == typeof(global::Weave.ModelsDevModelStatus?)

                    || typeToConvert == typeof(global::Weave.ReasoningEffortOptionValue)

                    || typeToConvert == typeof(global::Weave.ReasoningEffortOptionValue?)

                    || typeToConvert == typeof(global::Weave.RouterOpenRouterModelQuantization)

                    || typeToConvert == typeof(global::Weave.RouterOpenRouterModelQuantization?)

                    || typeToConvert == typeof(global::Weave.RouterOpenRouterModelSupportedSamplingParameter)

                    || typeToConvert == typeof(global::Weave.RouterOpenRouterModelSupportedSamplingParameter?)

                    || typeToConvert == typeof(global::Weave.RouterOpenRouterModelSupportedFeature)

                    || typeToConvert == typeof(global::Weave.RouterOpenRouterModelSupportedFeature?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Weave.InterleavedField))
                {
                    return new global::Weave.JsonConverters.InterleavedFieldJsonConverter();
                }

                if (typeToConvert == typeof(global::Weave.InterleavedField?))
                {
                    return new global::Weave.JsonConverters.InterleavedFieldNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Weave.LLMModelDetailsLifecycleStage))
                {
                    return new global::Weave.JsonConverters.LLMModelDetailsLifecycleStageJsonConverter();
                }

                if (typeToConvert == typeof(global::Weave.LLMModelDetailsLifecycleStage?))
                {
                    return new global::Weave.JsonConverters.LLMModelDetailsLifecycleStageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Weave.LLMModelDetailsAvailableInItem))
                {
                    return new global::Weave.JsonConverters.LLMModelDetailsAvailableInItemJsonConverter();
                }

                if (typeToConvert == typeof(global::Weave.LLMModelDetailsAvailableInItem?))
                {
                    return new global::Weave.JsonConverters.LLMModelDetailsAvailableInItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Weave.LLMModelDetailsReasoningSupport))
                {
                    return new global::Weave.JsonConverters.LLMModelDetailsReasoningSupportJsonConverter();
                }

                if (typeToConvert == typeof(global::Weave.LLMModelDetailsReasoningSupport?))
                {
                    return new global::Weave.JsonConverters.LLMModelDetailsReasoningSupportNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Weave.LLMModelDetailsReasoningEffort))
                {
                    return new global::Weave.JsonConverters.LLMModelDetailsReasoningEffortJsonConverter();
                }

                if (typeToConvert == typeof(global::Weave.LLMModelDetailsReasoningEffort?))
                {
                    return new global::Weave.JsonConverters.LLMModelDetailsReasoningEffortNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Weave.LLMModelDetailsQuantization))
                {
                    return new global::Weave.JsonConverters.LLMModelDetailsQuantizationJsonConverter();
                }

                if (typeToConvert == typeof(global::Weave.LLMModelDetailsQuantization?))
                {
                    return new global::Weave.JsonConverters.LLMModelDetailsQuantizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Weave.ModelsDevModelStatus))
                {
                    return new global::Weave.JsonConverters.ModelsDevModelStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Weave.ModelsDevModelStatus?))
                {
                    return new global::Weave.JsonConverters.ModelsDevModelStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Weave.ReasoningEffortOptionValue))
                {
                    return new global::Weave.JsonConverters.ReasoningEffortOptionValueJsonConverter();
                }

                if (typeToConvert == typeof(global::Weave.ReasoningEffortOptionValue?))
                {
                    return new global::Weave.JsonConverters.ReasoningEffortOptionValueNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Weave.RouterOpenRouterModelQuantization))
                {
                    return new global::Weave.JsonConverters.RouterOpenRouterModelQuantizationJsonConverter();
                }

                if (typeToConvert == typeof(global::Weave.RouterOpenRouterModelQuantization?))
                {
                    return new global::Weave.JsonConverters.RouterOpenRouterModelQuantizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Weave.RouterOpenRouterModelSupportedSamplingParameter))
                {
                    return new global::Weave.JsonConverters.RouterOpenRouterModelSupportedSamplingParameterJsonConverter();
                }

                if (typeToConvert == typeof(global::Weave.RouterOpenRouterModelSupportedSamplingParameter?))
                {
                    return new global::Weave.JsonConverters.RouterOpenRouterModelSupportedSamplingParameterNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Weave.RouterOpenRouterModelSupportedFeature))
                {
                    return new global::Weave.JsonConverters.RouterOpenRouterModelSupportedFeatureJsonConverter();
                }

                if (typeToConvert == typeof(global::Weave.RouterOpenRouterModelSupportedFeature?))
                {
                    return new global::Weave.JsonConverters.RouterOpenRouterModelSupportedFeatureNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new InferenceSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}