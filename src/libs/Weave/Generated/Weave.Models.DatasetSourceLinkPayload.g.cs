
#nullable enable

namespace Weave
{
    /// <summary>
    /// A single dataset row and the sources to link to it.
    /// </summary>
    public sealed partial class DatasetSourceLinkPayload
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("row_digest")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RowDigest { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sources")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Weave.SourceRef> Sources { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("link_metadata")]
        public object? LinkMetadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetSourceLinkPayload" /> class.
        /// </summary>
        /// <param name="rowDigest"></param>
        /// <param name="sources"></param>
        /// <param name="linkMetadata"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DatasetSourceLinkPayload(
            string rowDigest,
            global::System.Collections.Generic.IList<global::Weave.SourceRef> sources,
            object? linkMetadata)
        {
            this.RowDigest = rowDigest ?? throw new global::System.ArgumentNullException(nameof(rowDigest));
            this.Sources = sources ?? throw new global::System.ArgumentNullException(nameof(sources));
            this.LinkMetadata = linkMetadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetSourceLinkPayload" /> class.
        /// </summary>
        public DatasetSourceLinkPayload()
        {
        }

    }
}