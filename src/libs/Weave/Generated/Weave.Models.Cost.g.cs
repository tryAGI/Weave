
#nullable enable

namespace Weave
{
    /// <summary>
    /// Costs are expressed in USD per million tokens.
    /// </summary>
    public sealed partial class Cost
    {
        /// <summary>
        /// Cost per million input tokens (USD).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Input { get; set; }

        /// <summary>
        /// Cost per million output tokens (USD).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Output { get; set; }

        /// <summary>
        /// Cost per million reasoning tokens (USD).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning")]
        public double? Reasoning { get; set; }

        /// <summary>
        /// Cost per million cached read tokens (USD).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_read")]
        public double? CacheRead { get; set; }

        /// <summary>
        /// Cost per million cached write tokens (USD).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_write")]
        public double? CacheWrite { get; set; }

        /// <summary>
        /// Cost per million audio input tokens (USD).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_audio")]
        public double? InputAudio { get; set; }

        /// <summary>
        /// Cost per million audio output tokens (USD).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_audio")]
        public double? OutputAudio { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Cost" /> class.
        /// </summary>
        /// <param name="input">
        /// Cost per million input tokens (USD).
        /// </param>
        /// <param name="output">
        /// Cost per million output tokens (USD).
        /// </param>
        /// <param name="reasoning">
        /// Cost per million reasoning tokens (USD).
        /// </param>
        /// <param name="cacheRead">
        /// Cost per million cached read tokens (USD).
        /// </param>
        /// <param name="cacheWrite">
        /// Cost per million cached write tokens (USD).
        /// </param>
        /// <param name="inputAudio">
        /// Cost per million audio input tokens (USD).
        /// </param>
        /// <param name="outputAudio">
        /// Cost per million audio output tokens (USD).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Cost(
            double input,
            double output,
            double? reasoning,
            double? cacheRead,
            double? cacheWrite,
            double? inputAudio,
            double? outputAudio)
        {
            this.Input = input;
            this.Output = output;
            this.Reasoning = reasoning;
            this.CacheRead = cacheRead;
            this.CacheWrite = cacheWrite;
            this.InputAudio = inputAudio;
            this.OutputAudio = outputAudio;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Cost" /> class.
        /// </summary>
        public Cost()
        {
        }

    }
}