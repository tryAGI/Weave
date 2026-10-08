
#nullable enable

namespace Weave
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ProjectStatsRes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace_storage_size_bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long TraceStorageSizeBytes { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spans_storage_size_bytes")]
        public long? SpansStorageSizeBytes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("objects_storage_size_bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long ObjectsStorageSizeBytes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tables_storage_size_bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long TablesStorageSizeBytes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files_storage_size_bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long FilesStorageSizeBytes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectStatsRes" /> class.
        /// </summary>
        /// <param name="traceStorageSizeBytes"></param>
        /// <param name="objectsStorageSizeBytes"></param>
        /// <param name="tablesStorageSizeBytes"></param>
        /// <param name="filesStorageSizeBytes"></param>
        /// <param name="spansStorageSizeBytes">
        /// Default Value: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectStatsRes(
            long traceStorageSizeBytes,
            long objectsStorageSizeBytes,
            long tablesStorageSizeBytes,
            long filesStorageSizeBytes,
            long? spansStorageSizeBytes)
        {
            this.TraceStorageSizeBytes = traceStorageSizeBytes;
            this.SpansStorageSizeBytes = spansStorageSizeBytes;
            this.ObjectsStorageSizeBytes = objectsStorageSizeBytes;
            this.TablesStorageSizeBytes = tablesStorageSizeBytes;
            this.FilesStorageSizeBytes = filesStorageSizeBytes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectStatsRes" /> class.
        /// </summary>
        public ProjectStatsRes()
        {
        }

    }
}