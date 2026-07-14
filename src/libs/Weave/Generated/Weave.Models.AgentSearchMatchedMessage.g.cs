
#nullable enable

namespace Weave
{
    /// <summary>
    /// A single message that matched the search query.
    /// </summary>
    public sealed partial class AgentSearchMatchedMessage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("span_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SpanId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TraceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Weave.JsonConverters.AnyOfJsonConverter<global::Weave.AgentSearchMatchedMessageRole?, string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Weave.AnyOf<global::Weave.AgentSearchMatchedMessageRole?, string> Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_preview")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContentPreview { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_digest")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContentDigest { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StartedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSearchMatchedMessage" /> class.
        /// </summary>
        /// <param name="spanId"></param>
        /// <param name="traceId"></param>
        /// <param name="role"></param>
        /// <param name="contentPreview"></param>
        /// <param name="contentDigest"></param>
        /// <param name="startedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentSearchMatchedMessage(
            string spanId,
            string traceId,
            global::Weave.AnyOf<global::Weave.AgentSearchMatchedMessageRole?, string> role,
            string contentPreview,
            string contentDigest,
            global::System.DateTime startedAt)
        {
            this.SpanId = spanId ?? throw new global::System.ArgumentNullException(nameof(spanId));
            this.TraceId = traceId ?? throw new global::System.ArgumentNullException(nameof(traceId));
            this.Role = role;
            this.ContentPreview = contentPreview ?? throw new global::System.ArgumentNullException(nameof(contentPreview));
            this.ContentDigest = contentDigest ?? throw new global::System.ArgumentNullException(nameof(contentDigest));
            this.StartedAt = startedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSearchMatchedMessage" /> class.
        /// </summary>
        public AgentSearchMatchedMessage()
        {
        }

    }
}