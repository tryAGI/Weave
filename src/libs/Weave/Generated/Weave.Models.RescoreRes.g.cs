
#nullable enable

namespace Weave
{
    /// <summary>
    /// Response for a rescore request.
    /// </summary>
    public sealed partial class RescoreRes
    {
        /// <summary>
        /// Call ID for /evaluations/status polling
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CallId { get; set; }

        /// <summary>
        /// The newly created EvaluationRun ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluation_run_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EvaluationRunId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RescoreRes" /> class.
        /// </summary>
        /// <param name="callId">
        /// Call ID for /evaluations/status polling
        /// </param>
        /// <param name="evaluationRunId">
        /// The newly created EvaluationRun ID
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RescoreRes(
            string callId,
            string evaluationRunId)
        {
            this.CallId = callId ?? throw new global::System.ArgumentNullException(nameof(callId));
            this.EvaluationRunId = evaluationRunId ?? throw new global::System.ArgumentNullException(nameof(evaluationRunId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RescoreRes" /> class.
        /// </summary>
        public RescoreRes()
        {
        }

    }
}