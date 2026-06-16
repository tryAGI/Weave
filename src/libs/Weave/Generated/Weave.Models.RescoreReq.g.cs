
#nullable enable

namespace Weave
{
    /// <summary>
    /// Full rescore request including server-set fields.
    /// </summary>
    public sealed partial class RescoreReq
    {
        /// <summary>
        /// The evaluation run whose predictions will be rescored
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_evaluation_run_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourceEvaluationRunId { get; set; }

        /// <summary>
        /// Scorer references (weave:// URIs) to apply; must be non-empty
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scorer_refs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> ScorerRefs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// Do not set directly. Server will automatically populate this field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wb_user_id")]
        public string? WbUserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RescoreReq" /> class.
        /// </summary>
        /// <param name="sourceEvaluationRunId">
        /// The evaluation run whose predictions will be rescored
        /// </param>
        /// <param name="scorerRefs">
        /// Scorer references (weave:// URIs) to apply; must be non-empty
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="wbUserId">
        /// Do not set directly. Server will automatically populate this field.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RescoreReq(
            string sourceEvaluationRunId,
            global::System.Collections.Generic.IList<string> scorerRefs,
            string projectId,
            string? wbUserId)
        {
            this.SourceEvaluationRunId = sourceEvaluationRunId ?? throw new global::System.ArgumentNullException(nameof(sourceEvaluationRunId));
            this.ScorerRefs = scorerRefs ?? throw new global::System.ArgumentNullException(nameof(scorerRefs));
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.WbUserId = wbUserId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RescoreReq" /> class.
        /// </summary>
        public RescoreReq()
        {
        }

    }
}