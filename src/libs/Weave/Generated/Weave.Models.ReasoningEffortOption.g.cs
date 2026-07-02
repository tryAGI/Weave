
#nullable enable

namespace Weave
{
    /// <summary>
    /// Reasoning effort can be selected from a set of levels.
    /// </summary>
    public sealed partial class ReasoningEffortOption
    {
        /// <summary>
        /// Default Value: effort
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Accepted effort levels (null denotes an implicit default).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("values")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Weave.ReasoningEffortOptionValue2> Values { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReasoningEffortOption" /> class.
        /// </summary>
        /// <param name="values">
        /// Accepted effort levels (null denotes an implicit default).
        /// </param>
        /// <param name="type">
        /// Default Value: effort
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReasoningEffortOption(
            global::System.Collections.Generic.IList<global::Weave.ReasoningEffortOptionValue2> values,
            string? type)
        {
            this.Type = type;
            this.Values = values ?? throw new global::System.ArgumentNullException(nameof(values));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReasoningEffortOption" /> class.
        /// </summary>
        public ReasoningEffortOption()
        {
        }

    }
}