
#nullable enable

namespace Weave
{
    /// <summary>
    /// Conversation filter backed by extracted Insights data in ClickHouse.<br/>
    /// Values within one filter are ORed, while multiple filters are ANDed. Topic<br/>
    /// filters use stable topic IDs that span successful clustering runs.
    /// </summary>
    public sealed partial class AgentInsightFilter
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("field")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Weave.JsonConverters.AgentInsightFilterFieldJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Weave.AgentInsightFilterField Field { get; set; }

        /// <summary>
        /// Values to match. intent_sentiment accepts only frustrated, dissatisfied, neutral, satisfied, delighted; failure_severity accepts only info, major, or minor.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("values")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Values { get; set; }

        /// <summary>
        /// Exclude conversations matching any value in this filter.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclude")]
        public bool? Exclude { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentInsightFilter" /> class.
        /// </summary>
        /// <param name="field"></param>
        /// <param name="values">
        /// Values to match. intent_sentiment accepts only frustrated, dissatisfied, neutral, satisfied, delighted; failure_severity accepts only info, major, or minor.
        /// </param>
        /// <param name="exclude">
        /// Exclude conversations matching any value in this filter.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentInsightFilter(
            global::Weave.AgentInsightFilterField field,
            global::System.Collections.Generic.IList<string> values,
            bool? exclude)
        {
            this.Field = field;
            this.Values = values ?? throw new global::System.ArgumentNullException(nameof(values));
            this.Exclude = exclude;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentInsightFilter" /> class.
        /// </summary>
        public AgentInsightFilter()
        {
        }

    }
}