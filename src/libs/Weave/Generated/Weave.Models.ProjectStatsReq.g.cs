
#nullable enable

namespace Weave
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ProjectStatsReq
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_trace_storage_size")]
        public bool? IncludeTraceStorageSize { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_object_storage_size")]
        public bool? IncludeObjectStorageSize { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_table_storage_size")]
        public bool? IncludeTableStorageSize { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_file_storage_size")]
        public bool? IncludeFileStorageSize { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectStatsReq" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="includeTraceStorageSize">
        /// Default Value: true
        /// </param>
        /// <param name="includeObjectStorageSize">
        /// Default Value: true
        /// </param>
        /// <param name="includeTableStorageSize">
        /// Default Value: true
        /// </param>
        /// <param name="includeFileStorageSize">
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectStatsReq(
            string projectId,
            bool? includeTraceStorageSize,
            bool? includeObjectStorageSize,
            bool? includeTableStorageSize,
            bool? includeFileStorageSize)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.IncludeTraceStorageSize = includeTraceStorageSize;
            this.IncludeObjectStorageSize = includeObjectStorageSize;
            this.IncludeTableStorageSize = includeTableStorageSize;
            this.IncludeFileStorageSize = includeFileStorageSize;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectStatsReq" /> class.
        /// </summary>
        public ProjectStatsReq()
        {
        }

    }
}