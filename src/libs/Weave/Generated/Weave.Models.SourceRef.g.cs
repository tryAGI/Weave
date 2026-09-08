
#nullable enable

namespace Weave
{
    /// <summary>
    /// Reference to a provenance source (a call, an agent span, or a<br/>
    /// conversation).
    /// </summary>
    public sealed partial class SourceRef
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Weave.JsonConverters.SourceKindJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Weave.SourceKind SourceKind { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourceId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_trace_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourceTraceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SourceRef" /> class.
        /// </summary>
        /// <param name="sourceKind"></param>
        /// <param name="sourceId"></param>
        /// <param name="sourceTraceId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SourceRef(
            global::Weave.SourceKind sourceKind,
            string sourceId,
            string sourceTraceId)
        {
            this.SourceKind = sourceKind;
            this.SourceId = sourceId ?? throw new global::System.ArgumentNullException(nameof(sourceId));
            this.SourceTraceId = sourceTraceId ?? throw new global::System.ArgumentNullException(nameof(sourceTraceId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SourceRef" /> class.
        /// </summary>
        public SourceRef()
        {
        }

    }
}