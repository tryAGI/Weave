
#nullable enable

namespace Weave
{
    /// <summary>
    /// Reverse query: sources -&gt; datasets.
    /// </summary>
    public sealed partial class SourceDatasetsQueryReq
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
        [global::System.Text.Json.Serialization.JsonPropertyName("sources")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Weave.SourceRef> Sources { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_deleted")]
        public bool? IncludeDeleted { get; set; }

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
        /// Initializes a new instance of the <see cref="SourceDatasetsQueryReq" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="sources"></param>
        /// <param name="includeDeleted">
        /// Default Value: false
        /// </param>
        /// <param name="wbUserId">
        /// Do not set directly. Server will automatically populate this field.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SourceDatasetsQueryReq(
            string projectId,
            global::System.Collections.Generic.IList<global::Weave.SourceRef> sources,
            bool? includeDeleted,
            string? wbUserId)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.Sources = sources ?? throw new global::System.ArgumentNullException(nameof(sources));
            this.IncludeDeleted = includeDeleted;
            this.WbUserId = wbUserId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SourceDatasetsQueryReq" /> class.
        /// </summary>
        public SourceDatasetsQueryReq()
        {
        }

    }
}