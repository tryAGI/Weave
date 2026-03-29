
#nullable enable

namespace Weave
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TableUpdateReq
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
        [global::System.Text.Json.Serialization.JsonPropertyName("base_digest")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BaseDigest { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updates")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Weave.AnyOf<global::Weave.TableAppendSpec, global::Weave.TablePopSpec, global::Weave.TableInsertSpec>> Updates { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TableUpdateReq" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="baseDigest"></param>
        /// <param name="updates"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TableUpdateReq(
            string projectId,
            string baseDigest,
            global::System.Collections.Generic.IList<global::Weave.AnyOf<global::Weave.TableAppendSpec, global::Weave.TablePopSpec, global::Weave.TableInsertSpec>> updates)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.BaseDigest = baseDigest ?? throw new global::System.ArgumentNullException(nameof(baseDigest));
            this.Updates = updates ?? throw new global::System.ArgumentNullException(nameof(updates));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TableUpdateReq" /> class.
        /// </summary>
        public TableUpdateReq()
        {
        }
    }
}