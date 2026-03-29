
#nullable enable

namespace Weave
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RouterOpenRouterModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Created { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_modalities")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> InputModalities { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_modalities")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> OutputModalities { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quantization")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Weave.JsonConverters.RouterOpenRouterModelQuantizationJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Weave.RouterOpenRouterModelQuantization Quantization { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context_length")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ContextLength { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_output_length")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxOutputLength { get; set; }

        /// <summary>
        /// All pricing values are in USD per 1 token.<br/>
        /// Pricing fields are in string format to avoid floating point precision issues.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pricing")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Weave.Pricing Pricing { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supported_sampling_parameters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Weave.RouterOpenRouterModelSupportedSamplingParameter> SupportedSamplingParameters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supported_features")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Weave.RouterOpenRouterModelSupportedFeature> SupportedFeatures { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datacenters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Weave.Datacenter> Datacenters { get; set; }

        /// <summary>
        /// Date when the model is deprecated (YYYY-MM-DD). Omitted from output if not set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deprecation_date")]
        public string? DeprecationDate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RouterOpenRouterModel" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="created"></param>
        /// <param name="inputModalities"></param>
        /// <param name="outputModalities"></param>
        /// <param name="quantization"></param>
        /// <param name="contextLength"></param>
        /// <param name="maxOutputLength"></param>
        /// <param name="pricing">
        /// All pricing values are in USD per 1 token.<br/>
        /// Pricing fields are in string format to avoid floating point precision issues.
        /// </param>
        /// <param name="supportedSamplingParameters"></param>
        /// <param name="supportedFeatures"></param>
        /// <param name="datacenters"></param>
        /// <param name="deprecationDate">
        /// Date when the model is deprecated (YYYY-MM-DD). Omitted from output if not set.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RouterOpenRouterModel(
            string id,
            string name,
            int created,
            global::System.Collections.Generic.IList<string> inputModalities,
            global::System.Collections.Generic.IList<string> outputModalities,
            global::Weave.RouterOpenRouterModelQuantization quantization,
            int contextLength,
            int maxOutputLength,
            global::Weave.Pricing pricing,
            global::System.Collections.Generic.IList<global::Weave.RouterOpenRouterModelSupportedSamplingParameter> supportedSamplingParameters,
            global::System.Collections.Generic.IList<global::Weave.RouterOpenRouterModelSupportedFeature> supportedFeatures,
            global::System.Collections.Generic.IList<global::Weave.Datacenter> datacenters,
            string? deprecationDate)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Created = created;
            this.InputModalities = inputModalities ?? throw new global::System.ArgumentNullException(nameof(inputModalities));
            this.OutputModalities = outputModalities ?? throw new global::System.ArgumentNullException(nameof(outputModalities));
            this.Quantization = quantization;
            this.ContextLength = contextLength;
            this.MaxOutputLength = maxOutputLength;
            this.Pricing = pricing ?? throw new global::System.ArgumentNullException(nameof(pricing));
            this.SupportedSamplingParameters = supportedSamplingParameters ?? throw new global::System.ArgumentNullException(nameof(supportedSamplingParameters));
            this.SupportedFeatures = supportedFeatures ?? throw new global::System.ArgumentNullException(nameof(supportedFeatures));
            this.Datacenters = datacenters ?? throw new global::System.ArgumentNullException(nameof(datacenters));
            this.DeprecationDate = deprecationDate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RouterOpenRouterModel" /> class.
        /// </summary>
        public RouterOpenRouterModel()
        {
        }
    }
}