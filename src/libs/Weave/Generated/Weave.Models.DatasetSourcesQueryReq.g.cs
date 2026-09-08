
#nullable enable

namespace Weave
{
    /// <summary>
    /// Forward query: dataset -&gt; sources.
    /// </summary>
    public sealed partial class DatasetSourcesQueryReq
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

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
        public global::System.Collections.Generic.IList<string>? RowDigests { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_kinds")]
        public global::System.Collections.Generic.IList<global::Weave.SourceKind>? SourceKinds { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_deleted")]
        public bool? IncludeDeleted { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("offset")]
        public int? Offset { get; set; }

        /// <summary>
        /// Do not set directly. Server will automatically populate this field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wb_user_id")]
        public string? WbUserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetSourcesQueryReq" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="datasetObjectId"></param>
        /// <param name="rowDigests"></param>
        /// <param name="sourceKinds"></param>
        /// <param name="includeDeleted">
        /// Default Value: false
        /// </param>
        /// <param name="limit"></param>
        /// <param name="offset"></param>
        /// <param name="wbUserId">
        /// Do not set directly. Server will automatically populate this field.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DatasetSourcesQueryReq(
            string projectId,
            string datasetObjectId,
            global::System.Collections.Generic.IList<string>? rowDigests,
            global::System.Collections.Generic.IList<global::Weave.SourceKind>? sourceKinds,
            bool? includeDeleted,
            int? limit,
            int? offset,
            string? wbUserId)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.DatasetObjectId = datasetObjectId ?? throw new global::System.ArgumentNullException(nameof(datasetObjectId));
            this.RowDigests = rowDigests;
            this.SourceKinds = sourceKinds;
            this.IncludeDeleted = includeDeleted;
            this.Limit = limit;
            this.Offset = offset;
            this.WbUserId = wbUserId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetSourcesQueryReq" /> class.
        /// </summary>
        public DatasetSourcesQueryReq()
        {
        }

    }
}