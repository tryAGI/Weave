
#nullable enable

namespace Weave
{
    /// <summary>
    /// Sort specification for agent query endpoints.
    /// </summary>
    public sealed partial class AgentSortBy
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("field")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Field { get; set; }

        /// <summary>
        /// Default Value: desc
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("direction")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Weave.JsonConverters.AgentSortByDirectionJsonConverter))]
        public global::Weave.AgentSortByDirection? Direction { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSortBy" /> class.
        /// </summary>
        /// <param name="field"></param>
        /// <param name="direction">
        /// Default Value: desc
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentSortBy(
            string field,
            global::Weave.AgentSortByDirection? direction)
        {
            this.Field = field ?? throw new global::System.ArgumentNullException(nameof(field));
            this.Direction = direction;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSortBy" /> class.
        /// </summary>
        public AgentSortBy()
        {
        }

    }
}