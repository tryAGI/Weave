
#nullable enable

namespace Weave
{
    /// <summary>
    /// Result for a single flattened (row_digest, source) link.
    /// </summary>
    public sealed partial class DatasetSourcesLinkResEntry
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("link_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LinkId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        public bool? Created { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetSourcesLinkResEntry" /> class.
        /// </summary>
        /// <param name="linkId"></param>
        /// <param name="created"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DatasetSourcesLinkResEntry(
            string linkId,
            bool? created)
        {
            this.LinkId = linkId ?? throw new global::System.ArgumentNullException(nameof(linkId));
            this.Created = created;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetSourcesLinkResEntry" /> class.
        /// </summary>
        public DatasetSourcesLinkResEntry()
        {
        }

    }
}