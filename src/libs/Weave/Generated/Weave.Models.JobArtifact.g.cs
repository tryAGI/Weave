
#nullable enable

namespace Weave
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JobArtifact
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Target { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uri")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Uri { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expected_rows")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ExpectedRows { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("written_rows")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int WrittenRows { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JobArtifact" /> class.
        /// </summary>
        /// <param name="target"></param>
        /// <param name="uri"></param>
        /// <param name="expectedRows"></param>
        /// <param name="writtenRows"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public JobArtifact(
            string target,
            string uri,
            int expectedRows,
            int writtenRows)
        {
            this.Target = target ?? throw new global::System.ArgumentNullException(nameof(target));
            this.Uri = uri ?? throw new global::System.ArgumentNullException(nameof(uri));
            this.ExpectedRows = expectedRows;
            this.WrittenRows = writtenRows;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JobArtifact" /> class.
        /// </summary>
        public JobArtifact()
        {
        }

    }
}