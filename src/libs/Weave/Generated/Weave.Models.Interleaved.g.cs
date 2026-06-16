
#nullable enable

namespace Weave
{
    /// <summary>
    /// Reasoning interleaving support details.
    /// </summary>
    public sealed partial class Interleaved
    {
        /// <summary>
        /// Format identifier for interleaved reasoning.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("field")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Weave.JsonConverters.InterleavedFieldJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Weave.InterleavedField Field { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Interleaved" /> class.
        /// </summary>
        /// <param name="field">
        /// Format identifier for interleaved reasoning.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Interleaved(
            global::Weave.InterleavedField field)
        {
            this.Field = field;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Interleaved" /> class.
        /// </summary>
        public Interleaved()
        {
        }

    }
}