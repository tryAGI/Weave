
#nullable enable

namespace Weave
{
    /// <summary>
    /// Supported input and output modalities.
    /// </summary>
    public sealed partial class Modalities
    {
        /// <summary>
        /// Supported input types (e.g. text, image, audio, video, pdf).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Input { get; set; }

        /// <summary>
        /// Supported output types.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Output { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Modalities" /> class.
        /// </summary>
        /// <param name="input">
        /// Supported input types (e.g. text, image, audio, video, pdf).
        /// </param>
        /// <param name="output">
        /// Supported output types.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Modalities(
            global::System.Collections.Generic.IList<string> input,
            global::System.Collections.Generic.IList<string> output)
        {
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
            this.Output = output ?? throw new global::System.ArgumentNullException(nameof(output));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Modalities" /> class.
        /// </summary>
        public Modalities()
        {
        }

    }
}