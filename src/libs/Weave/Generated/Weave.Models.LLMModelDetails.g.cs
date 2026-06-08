
#nullable enable

namespace Weave
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LLMModelDetails
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Provider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("idPlayground")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IdPlayground { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("idHuggingFace")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IdHuggingFace { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labelOpenRouter")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LabelOpenRouter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lifecycleStage")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Weave.JsonConverters.LLMModelDetailsLifecycleStageJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Weave.LLMModelDetailsLifecycleStage LifecycleStage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("availableIn")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Weave.LLMModelDetailsAvailableInItem> AvailableIn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("launchedQuarter")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LaunchedQuarter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("descriptionShort")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DescriptionShort { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("descriptionMedium")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DescriptionMedium { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("launchDate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LaunchDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("featureReasoning")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool FeatureReasoning { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("featureJsonMode")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool FeatureJsonMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("featureStructuredOutput")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool FeatureStructuredOutput { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("featureToolCalling")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool FeatureToolCalling { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("featureLoRA")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool FeatureLoRA { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("featureTrainableServerlessRL")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool FeatureTrainableServerlessRL { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameterCountTotal")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ParameterCountTotal { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameterCountActive")]
        public int? ParameterCountActive { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contextWindow")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ContextWindow { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quantization")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Weave.JsonConverters.LLMModelDetailsQuantizationJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Weave.LLMModelDetailsQuantization Quantization { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("priceCentsPerBillionTokensInput")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PriceCentsPerBillionTokensInput { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("priceCentsPerBillionTokensCached")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PriceCentsPerBillionTokensCached { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("priceCentsPerBillionTokensOutput")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PriceCentsPerBillionTokensOutput { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isAvailableOpenRouter")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsAvailableOpenRouter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiStyle")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ApiStyle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modalities")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Modalities { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modalitiesInput")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> ModalitiesInput { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modalitiesOutput")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> ModalitiesOutput { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("likesHuggingFace")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int LikesHuggingFace { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("downloadsHuggingFace")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DownloadsHuggingFace { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("license")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string License { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMModelDetails" /> class.
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="id"></param>
        /// <param name="idPlayground"></param>
        /// <param name="idHuggingFace"></param>
        /// <param name="label"></param>
        /// <param name="labelOpenRouter"></param>
        /// <param name="status"></param>
        /// <param name="lifecycleStage"></param>
        /// <param name="availableIn"></param>
        /// <param name="launchedQuarter"></param>
        /// <param name="descriptionShort"></param>
        /// <param name="descriptionMedium"></param>
        /// <param name="launchDate"></param>
        /// <param name="featureReasoning"></param>
        /// <param name="featureJsonMode"></param>
        /// <param name="featureStructuredOutput"></param>
        /// <param name="featureToolCalling"></param>
        /// <param name="featureLoRA"></param>
        /// <param name="featureTrainableServerlessRL"></param>
        /// <param name="parameterCountTotal"></param>
        /// <param name="contextWindow"></param>
        /// <param name="quantization"></param>
        /// <param name="priceCentsPerBillionTokensInput"></param>
        /// <param name="priceCentsPerBillionTokensCached"></param>
        /// <param name="priceCentsPerBillionTokensOutput"></param>
        /// <param name="isAvailableOpenRouter"></param>
        /// <param name="apiStyle"></param>
        /// <param name="modalities"></param>
        /// <param name="modalitiesInput"></param>
        /// <param name="modalitiesOutput"></param>
        /// <param name="tags"></param>
        /// <param name="likesHuggingFace"></param>
        /// <param name="downloadsHuggingFace"></param>
        /// <param name="license"></param>
        /// <param name="parameterCountActive"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LLMModelDetails(
            string provider,
            string id,
            string idPlayground,
            string idHuggingFace,
            string label,
            string labelOpenRouter,
            string status,
            global::Weave.LLMModelDetailsLifecycleStage lifecycleStage,
            global::System.Collections.Generic.IList<global::Weave.LLMModelDetailsAvailableInItem> availableIn,
            string launchedQuarter,
            string descriptionShort,
            string descriptionMedium,
            string launchDate,
            bool featureReasoning,
            bool featureJsonMode,
            bool featureStructuredOutput,
            bool featureToolCalling,
            bool featureLoRA,
            bool featureTrainableServerlessRL,
            int parameterCountTotal,
            int contextWindow,
            global::Weave.LLMModelDetailsQuantization quantization,
            int priceCentsPerBillionTokensInput,
            int priceCentsPerBillionTokensCached,
            int priceCentsPerBillionTokensOutput,
            bool isAvailableOpenRouter,
            string apiStyle,
            global::System.Collections.Generic.IList<string> modalities,
            global::System.Collections.Generic.IList<string> modalitiesInput,
            global::System.Collections.Generic.IList<string> modalitiesOutput,
            global::System.Collections.Generic.IList<string> tags,
            int likesHuggingFace,
            int downloadsHuggingFace,
            string license,
            int? parameterCountActive)
        {
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.IdPlayground = idPlayground ?? throw new global::System.ArgumentNullException(nameof(idPlayground));
            this.IdHuggingFace = idHuggingFace ?? throw new global::System.ArgumentNullException(nameof(idHuggingFace));
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.LabelOpenRouter = labelOpenRouter ?? throw new global::System.ArgumentNullException(nameof(labelOpenRouter));
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.LifecycleStage = lifecycleStage;
            this.AvailableIn = availableIn ?? throw new global::System.ArgumentNullException(nameof(availableIn));
            this.LaunchedQuarter = launchedQuarter ?? throw new global::System.ArgumentNullException(nameof(launchedQuarter));
            this.DescriptionShort = descriptionShort ?? throw new global::System.ArgumentNullException(nameof(descriptionShort));
            this.DescriptionMedium = descriptionMedium ?? throw new global::System.ArgumentNullException(nameof(descriptionMedium));
            this.LaunchDate = launchDate ?? throw new global::System.ArgumentNullException(nameof(launchDate));
            this.FeatureReasoning = featureReasoning;
            this.FeatureJsonMode = featureJsonMode;
            this.FeatureStructuredOutput = featureStructuredOutput;
            this.FeatureToolCalling = featureToolCalling;
            this.FeatureLoRA = featureLoRA;
            this.FeatureTrainableServerlessRL = featureTrainableServerlessRL;
            this.ParameterCountTotal = parameterCountTotal;
            this.ParameterCountActive = parameterCountActive;
            this.ContextWindow = contextWindow;
            this.Quantization = quantization;
            this.PriceCentsPerBillionTokensInput = priceCentsPerBillionTokensInput;
            this.PriceCentsPerBillionTokensCached = priceCentsPerBillionTokensCached;
            this.PriceCentsPerBillionTokensOutput = priceCentsPerBillionTokensOutput;
            this.IsAvailableOpenRouter = isAvailableOpenRouter;
            this.ApiStyle = apiStyle ?? throw new global::System.ArgumentNullException(nameof(apiStyle));
            this.Modalities = modalities ?? throw new global::System.ArgumentNullException(nameof(modalities));
            this.ModalitiesInput = modalitiesInput ?? throw new global::System.ArgumentNullException(nameof(modalitiesInput));
            this.ModalitiesOutput = modalitiesOutput ?? throw new global::System.ArgumentNullException(nameof(modalitiesOutput));
            this.Tags = tags ?? throw new global::System.ArgumentNullException(nameof(tags));
            this.LikesHuggingFace = likesHuggingFace;
            this.DownloadsHuggingFace = downloadsHuggingFace;
            this.License = license ?? throw new global::System.ArgumentNullException(nameof(license));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMModelDetails" /> class.
        /// </summary>
        public LLMModelDetails()
        {
        }

    }
}