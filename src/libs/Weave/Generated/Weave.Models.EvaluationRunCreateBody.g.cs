
#nullable enable

namespace Weave
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EvaluationRunCreateBody
    {
        /// <summary>
        /// Reference to the evaluation (weave:// URI)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Evaluation { get; set; }

        /// <summary>
        /// Reference to the model (weave:// URI)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Source evaluation run ID if this run was created by rescoring — provenance link
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_evaluation_run_id")]
        public string? SourceEvaluationRunId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationRunCreateBody" /> class.
        /// </summary>
        /// <param name="evaluation">
        /// Reference to the evaluation (weave:// URI)
        /// </param>
        /// <param name="model">
        /// Reference to the model (weave:// URI)
        /// </param>
        /// <param name="sourceEvaluationRunId">
        /// Source evaluation run ID if this run was created by rescoring — provenance link
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvaluationRunCreateBody(
            string evaluation,
            string model,
            string? sourceEvaluationRunId)
        {
            this.Evaluation = evaluation ?? throw new global::System.ArgumentNullException(nameof(evaluation));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.SourceEvaluationRunId = sourceEvaluationRunId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationRunCreateBody" /> class.
        /// </summary>
        public EvaluationRunCreateBody()
        {
        }

    }
}