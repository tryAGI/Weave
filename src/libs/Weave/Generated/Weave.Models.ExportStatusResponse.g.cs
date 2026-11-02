
#nullable enable

namespace Weave
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ExportStatusResponse
    {
        /// <summary>
        /// Project-scoped export resource name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid JobId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Weave.JsonConverters.ExportStatusResponseStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Weave.ExportStatusResponseState State { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("artifacts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Weave.JobArtifact> Artifacts { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failure")]
        public global::Weave.JobFailure? Failure { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExportStatusResponse" /> class.
        /// </summary>
        /// <param name="name">
        /// Project-scoped export resource name.
        /// </param>
        /// <param name="jobId"></param>
        /// <param name="createdAt"></param>
        /// <param name="state"></param>
        /// <param name="updatedAt"></param>
        /// <param name="artifacts"></param>
        /// <param name="failure"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExportStatusResponse(
            string name,
            global::System.Guid jobId,
            global::System.DateTime createdAt,
            global::Weave.ExportStatusResponseState state,
            global::System.DateTime updatedAt,
            global::System.Collections.Generic.IList<global::Weave.JobArtifact> artifacts,
            global::Weave.JobFailure? failure)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.JobId = jobId;
            this.CreatedAt = createdAt;
            this.State = state;
            this.UpdatedAt = updatedAt;
            this.Artifacts = artifacts ?? throw new global::System.ArgumentNullException(nameof(artifacts));
            this.Failure = failure;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExportStatusResponse" /> class.
        /// </summary>
        public ExportStatusResponse()
        {
        }

    }
}