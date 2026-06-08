
#nullable enable

namespace Weave
{
    /// <summary>
    /// Reference to a field or map-key that spans should be grouped by.<br/>
    /// `source="field"` targets a semantic span field (`agent.name`) or direct<br/>
    /// span column (`agent_name`), allowlisted server-side. `source="column"` is<br/>
    /// accepted for existing callers.<br/>
    /// The other sources target keys inside the typed custom attribute Map columns,<br/>
    /// which accept arbitrary user-defined keys.
    /// </summary>
    public sealed partial class AgentGroupByRef
    {
        /// <summary>
        /// Default Value: field
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Weave.JsonConverters.AgentGroupByRefSourceJsonConverter))]
        public global::Weave.AgentGroupByRefSource? Source { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alias")]
        public string? Alias { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentGroupByRef" /> class.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="source">
        /// Default Value: field
        /// </param>
        /// <param name="alias"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentGroupByRef(
            string key,
            global::Weave.AgentGroupByRefSource? source,
            string? alias)
        {
            this.Source = source;
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Alias = alias;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentGroupByRef" /> class.
        /// </summary>
        public AgentGroupByRef()
        {
        }

    }
}