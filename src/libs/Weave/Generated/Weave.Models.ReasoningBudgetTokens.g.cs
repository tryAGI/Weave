
#nullable enable

namespace Weave
{
    /// <summary>
    /// Reasoning is controlled via a token budget.
    /// </summary>
    public sealed partial class ReasoningBudgetTokens
    {
        /// <summary>
        /// Default Value: budget_tokens
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Minimum reasoning budget.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min")]
        public int? Min { get; set; }

        /// <summary>
        /// Maximum reasoning budget.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max")]
        public int? Max { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReasoningBudgetTokens" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: budget_tokens
        /// </param>
        /// <param name="min">
        /// Minimum reasoning budget.
        /// </param>
        /// <param name="max">
        /// Maximum reasoning budget.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReasoningBudgetTokens(
            string? type,
            int? min,
            int? max)
        {
            this.Type = type;
            this.Min = min;
            this.Max = max;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReasoningBudgetTokens" /> class.
        /// </summary>
        public ReasoningBudgetTokens()
        {
        }

    }
}