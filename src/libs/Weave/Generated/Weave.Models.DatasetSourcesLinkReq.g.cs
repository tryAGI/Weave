
#nullable enable

namespace Weave
{
    /// <summary>
    /// Request to link dataset rows to their provenance sources.
    /// </summary>
    public sealed partial class DatasetSourcesLinkReq
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
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_digest")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DatasetDigest { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("links")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Weave.DatasetSourceLinkPayload> Links { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_created_status")]
        public bool? IncludeCreatedStatus { get; set; }

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
        /// Initializes a new instance of the <see cref="DatasetSourcesLinkReq" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="datasetObjectId"></param>
        /// <param name="datasetDigest"></param>
        /// <param name="links"></param>
        /// <param name="includeCreatedStatus">
        /// Default Value: false
        /// </param>
        /// <param name="wbUserId">
        /// Do not set directly. Server will automatically populate this field.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DatasetSourcesLinkReq(
            string projectId,
            string datasetObjectId,
            string datasetDigest,
            global::System.Collections.Generic.IList<global::Weave.DatasetSourceLinkPayload> links,
            bool? includeCreatedStatus,
            string? wbUserId)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.DatasetObjectId = datasetObjectId ?? throw new global::System.ArgumentNullException(nameof(datasetObjectId));
            this.DatasetDigest = datasetDigest ?? throw new global::System.ArgumentNullException(nameof(datasetDigest));
            this.Links = links ?? throw new global::System.ArgumentNullException(nameof(links));
            this.IncludeCreatedStatus = includeCreatedStatus;
            this.WbUserId = wbUserId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetSourcesLinkReq" /> class.
        /// </summary>
        public DatasetSourcesLinkReq()
        {
        }

    }
}