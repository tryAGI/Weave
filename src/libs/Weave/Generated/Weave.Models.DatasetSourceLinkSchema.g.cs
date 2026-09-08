
#nullable enable

namespace Weave
{
    /// <summary>
    /// Schema for a single dataset source link row.
    /// </summary>
    public sealed partial class DatasetSourceLinkSchema
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("row_digest")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RowDigest { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("source_started_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime SourceStartedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_display_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourceDisplayName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("link_metadata")]
        public object? LinkMetadata { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("added_by")]
        public string? AddedBy { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted_at")]
        public global::System.DateTime? DeletedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetSourceLinkSchema" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="rowDigest"></param>
        /// <param name="sourceKind"></param>
        /// <param name="sourceId"></param>
        /// <param name="sourceTraceId"></param>
        /// <param name="sourceStartedAt"></param>
        /// <param name="sourceDisplayName"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="linkMetadata"></param>
        /// <param name="addedBy"></param>
        /// <param name="deletedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DatasetSourceLinkSchema(
            string id,
            string rowDigest,
            global::Weave.SourceKind sourceKind,
            string sourceId,
            string sourceTraceId,
            global::System.DateTime sourceStartedAt,
            string sourceDisplayName,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            object? linkMetadata,
            string? addedBy,
            global::System.DateTime? deletedAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.RowDigest = rowDigest ?? throw new global::System.ArgumentNullException(nameof(rowDigest));
            this.SourceKind = sourceKind;
            this.SourceId = sourceId ?? throw new global::System.ArgumentNullException(nameof(sourceId));
            this.SourceTraceId = sourceTraceId ?? throw new global::System.ArgumentNullException(nameof(sourceTraceId));
            this.SourceStartedAt = sourceStartedAt;
            this.SourceDisplayName = sourceDisplayName ?? throw new global::System.ArgumentNullException(nameof(sourceDisplayName));
            this.LinkMetadata = linkMetadata;
            this.AddedBy = addedBy;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.DeletedAt = deletedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetSourceLinkSchema" /> class.
        /// </summary>
        public DatasetSourceLinkSchema()
        {
        }

    }
}