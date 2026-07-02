
#nullable enable

namespace Weave
{
    /// <summary>
    /// A single model entry in the models.dev schema.
    /// </summary>
    public sealed partial class ModelsDevModel
    {
        /// <summary>
        /// Model identifier used by the AI SDK.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Display name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Human-readable description of the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// File attachment support.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attachment")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Attachment { get; set; }

        /// <summary>
        /// Chain-of-thought reasoning support.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Reasoning { get; set; }

        /// <summary>
        /// Tool calling support.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_call")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ToolCall { get; set; }

        /// <summary>
        /// Dedicated structured output feature.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("structured_output")]
        public bool? StructuredOutput { get; set; }

        /// <summary>
        /// Temperature control support.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public bool? Temperature { get; set; }

        /// <summary>
        /// Knowledge cutoff in YYYY-MM or YYYY-MM-DD format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("knowledge")]
        public string? Knowledge { get; set; }

        /// <summary>
        /// First public release date (YYYY-MM-DD).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("release_date")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ReleaseDate { get; set; }

        /// <summary>
        /// Most recent update date (YYYY-MM-DD).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_updated")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LastUpdated { get; set; }

        /// <summary>
        /// Public weights availability.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("open_weights")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool OpenWeights { get; set; }

        /// <summary>
        /// Lifecycle status of the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public global::Weave.ModelsDevModelStatus2? Status { get; set; }

        /// <summary>
        /// Reasoning interleaving support.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interleaved")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Weave.JsonConverters.AnyOfJsonConverter<bool?, global::Weave.Interleaved, object>))]
        public global::Weave.AnyOf<bool?, global::Weave.Interleaved, object>? Interleaved { get; set; }

        /// <summary>
        /// Pricing information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost")]
        public global::Weave.Cost? Cost { get; set; }

        /// <summary>
        /// Token limits.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public global::Weave.Limit? Limit { get; set; }

        /// <summary>
        /// Supported input and output modalities.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modalities")]
        public global::Weave.Modalities? Modalities { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelsDevModel" /> class.
        /// </summary>
        /// <param name="id">
        /// Model identifier used by the AI SDK.
        /// </param>
        /// <param name="name">
        /// Display name.
        /// </param>
        /// <param name="attachment">
        /// File attachment support.
        /// </param>
        /// <param name="reasoning">
        /// Chain-of-thought reasoning support.
        /// </param>
        /// <param name="toolCall">
        /// Tool calling support.
        /// </param>
        /// <param name="releaseDate">
        /// First public release date (YYYY-MM-DD).
        /// </param>
        /// <param name="lastUpdated">
        /// Most recent update date (YYYY-MM-DD).
        /// </param>
        /// <param name="openWeights">
        /// Public weights availability.
        /// </param>
        /// <param name="description">
        /// Human-readable description of the model.
        /// </param>
        /// <param name="structuredOutput">
        /// Dedicated structured output feature.
        /// </param>
        /// <param name="temperature">
        /// Temperature control support.
        /// </param>
        /// <param name="knowledge">
        /// Knowledge cutoff in YYYY-MM or YYYY-MM-DD format.
        /// </param>
        /// <param name="status">
        /// Lifecycle status of the model.
        /// </param>
        /// <param name="interleaved">
        /// Reasoning interleaving support.
        /// </param>
        /// <param name="cost">
        /// Pricing information.
        /// </param>
        /// <param name="limit">
        /// Token limits.
        /// </param>
        /// <param name="modalities">
        /// Supported input and output modalities.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelsDevModel(
            string id,
            string name,
            bool attachment,
            bool reasoning,
            bool toolCall,
            string releaseDate,
            string lastUpdated,
            bool openWeights,
            string? description,
            bool? structuredOutput,
            bool? temperature,
            string? knowledge,
            global::Weave.ModelsDevModelStatus2? status,
            global::Weave.AnyOf<bool?, global::Weave.Interleaved, object>? interleaved,
            global::Weave.Cost? cost,
            global::Weave.Limit? limit,
            global::Weave.Modalities? modalities)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Attachment = attachment;
            this.Reasoning = reasoning;
            this.ToolCall = toolCall;
            this.StructuredOutput = structuredOutput;
            this.Temperature = temperature;
            this.Knowledge = knowledge;
            this.ReleaseDate = releaseDate ?? throw new global::System.ArgumentNullException(nameof(releaseDate));
            this.LastUpdated = lastUpdated ?? throw new global::System.ArgumentNullException(nameof(lastUpdated));
            this.OpenWeights = openWeights;
            this.Status = status;
            this.Interleaved = interleaved;
            this.Cost = cost;
            this.Limit = limit;
            this.Modalities = modalities;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelsDevModel" /> class.
        /// </summary>
        public ModelsDevModel()
        {
        }

    }
}