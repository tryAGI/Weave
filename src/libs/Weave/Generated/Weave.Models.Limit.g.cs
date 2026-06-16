
#nullable enable

namespace Weave
{
    /// <summary>
    /// Token limits for a model.
    /// </summary>
    public sealed partial class Limit
    {
        /// <summary>
        /// Maximum context window in tokens.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Context { get; set; }

        /// <summary>
        /// Maximum input tokens.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Input { get; set; }

        /// <summary>
        /// Maximum output tokens.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Output { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Limit" /> class.
        /// </summary>
        /// <param name="context">
        /// Maximum context window in tokens.
        /// </param>
        /// <param name="input">
        /// Maximum input tokens.
        /// </param>
        /// <param name="output">
        /// Maximum output tokens.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Limit(
            int context,
            int input,
            int output)
        {
            this.Context = context;
            this.Input = input;
            this.Output = output;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Limit" /> class.
        /// </summary>
        public Limit()
        {
        }

    }
}