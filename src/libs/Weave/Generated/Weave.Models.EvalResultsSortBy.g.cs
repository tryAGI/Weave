
#nullable enable

namespace Weave
{
    /// <summary>
    /// Sort specification for evaluation results, extending SortBy
    /// </summary>
    public sealed partial class EvalResultsSortBy
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("field")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Field { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("direction")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Weave.JsonConverters.EvalResultsSortByDirectionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Weave.EvalResultsSortByDirection Direction { get; set; }

        /// <summary>
        /// Scope the sort to a specific evaluation's scores.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluation_call_id")]
        public string? EvaluationCallId { get; set; }

        /// <summary>
        /// When 'value', sort by the field value for the specified evaluation. When 'difference', sort by max-min spread of the field across all evaluations (evaluation_call_id is ignored).<br/>
        /// Default Value: value
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Weave.JsonConverters.EvalResultsSortByModeJsonConverter))]
        public global::Weave.EvalResultsSortByMode? Mode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalResultsSortBy" /> class.
        /// </summary>
        /// <param name="field"></param>
        /// <param name="direction"></param>
        /// <param name="evaluationCallId">
        /// Scope the sort to a specific evaluation's scores.
        /// </param>
        /// <param name="mode">
        /// When 'value', sort by the field value for the specified evaluation. When 'difference', sort by max-min spread of the field across all evaluations (evaluation_call_id is ignored).<br/>
        /// Default Value: value
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvalResultsSortBy(
            string field,
            global::Weave.EvalResultsSortByDirection direction,
            string? evaluationCallId,
            global::Weave.EvalResultsSortByMode? mode)
        {
            this.Field = field ?? throw new global::System.ArgumentNullException(nameof(field));
            this.Direction = direction;
            this.EvaluationCallId = evaluationCallId;
            this.Mode = mode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalResultsSortBy" /> class.
        /// </summary>
        public EvalResultsSortBy()
        {
        }
    }
}