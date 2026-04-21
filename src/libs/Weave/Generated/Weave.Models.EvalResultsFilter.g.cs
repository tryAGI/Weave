
#nullable enable

namespace Weave
{
    /// <summary>
    /// A filter scoped to an optional evaluation.
    /// </summary>
    public sealed partial class EvalResultsFilter
    {
        /// <summary>
        /// When set, filter fields are scoped to this evaluation's data.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluation_call_id")]
        public string? EvaluationCallId { get; set; }

        /// <summary>
        /// Filter expression. Supported field prefixes: scores.&lt;name&gt;, inputs.&lt;path&gt;, outputs.&lt;path&gt;.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Weave.Query Query { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalResultsFilter" /> class.
        /// </summary>
        /// <param name="query">
        /// Filter expression. Supported field prefixes: scores.&lt;name&gt;, inputs.&lt;path&gt;, outputs.&lt;path&gt;.
        /// </param>
        /// <param name="evaluationCallId">
        /// When set, filter fields are scoped to this evaluation's data.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvalResultsFilter(
            global::Weave.Query query,
            string? evaluationCallId)
        {
            this.EvaluationCallId = evaluationCallId;
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalResultsFilter" /> class.
        /// </summary>
        public EvalResultsFilter()
        {
        }
    }
}