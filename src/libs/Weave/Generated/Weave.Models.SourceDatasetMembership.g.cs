
#nullable enable

namespace Weave
{
    /// <summary>
    /// Membership of a single (source, dataset) pair in the reverse query.
    /// </summary>
    public sealed partial class SourceDatasetMembership
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Weave.JsonConverters.SourceKindJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Weave.SourceKind SourceKind { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourceId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_trace_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourceTraceId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_object_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DatasetObjectId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("row_digests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> RowDigests { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("row_digests_truncated")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool RowDigestsTruncated { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("row_digests_total_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RowDigestsTotalCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_seen_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime FirstSeenAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SourceDatasetMembership" /> class.
        /// </summary>
        /// <param name="sourceKind"></param>
        /// <param name="sourceId"></param>
        /// <param name="sourceTraceId"></param>
        /// <param name="datasetObjectId"></param>
        /// <param name="rowDigests"></param>
        /// <param name="rowDigestsTruncated"></param>
        /// <param name="rowDigestsTotalCount"></param>
        /// <param name="firstSeenAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SourceDatasetMembership(
            global::Weave.SourceKind sourceKind,
            string sourceId,
            string sourceTraceId,
            string datasetObjectId,
            global::System.Collections.Generic.IList<string> rowDigests,
            bool rowDigestsTruncated,
            int rowDigestsTotalCount,
            global::System.DateTime firstSeenAt)
        {
            this.SourceKind = sourceKind;
            this.SourceId = sourceId ?? throw new global::System.ArgumentNullException(nameof(sourceId));
            this.SourceTraceId = sourceTraceId ?? throw new global::System.ArgumentNullException(nameof(sourceTraceId));
            this.DatasetObjectId = datasetObjectId ?? throw new global::System.ArgumentNullException(nameof(datasetObjectId));
            this.RowDigests = rowDigests ?? throw new global::System.ArgumentNullException(nameof(rowDigests));
            this.RowDigestsTruncated = rowDigestsTruncated;
            this.RowDigestsTotalCount = rowDigestsTotalCount;
            this.FirstSeenAt = firstSeenAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SourceDatasetMembership" /> class.
        /// </summary>
        public SourceDatasetMembership()
        {
        }

    }
}