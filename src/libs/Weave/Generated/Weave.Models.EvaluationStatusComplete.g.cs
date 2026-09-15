
#nullable enable

namespace Weave
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EvaluationStatusComplete
    {
        /// <summary>
        /// Default Value: complete
        /// </summary>
        /// <default>"complete"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public string Code { get; set; } = "complete";

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Output { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationStatusComplete" /> class.
        /// </summary>
        /// <param name="output"></param>
        /// <param name="code">
        /// Default Value: complete
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvaluationStatusComplete(
            object output,
            string code = "complete")
        {
            this.Code = code;
            this.Output = output ?? throw new global::System.ArgumentNullException(nameof(output));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationStatusComplete" /> class.
        /// </summary>
        public EvaluationStatusComplete()
        {
        }

        /// <summary>
        /// Creates a new <see cref="EvaluationStatusComplete"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static EvaluationStatusComplete FromOutput(object output)
        {
            return new EvaluationStatusComplete
            {
                Output = output,
            };
        }

    }
}