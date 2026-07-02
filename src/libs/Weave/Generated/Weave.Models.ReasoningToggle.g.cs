
#nullable enable

namespace Weave
{
    /// <summary>
    /// Reasoning can be turned on or off.
    /// </summary>
    public sealed partial class ReasoningToggle
    {
        /// <summary>
        /// Default Value: toggle
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReasoningToggle" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: toggle
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReasoningToggle(
            string? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReasoningToggle" /> class.
        /// </summary>
        public ReasoningToggle()
        {
        }

    }
}