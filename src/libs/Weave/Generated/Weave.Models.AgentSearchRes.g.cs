
#nullable enable

namespace Weave
{
    /// <summary>
    /// Response from a full-text search across agent messages.
    /// </summary>
    public sealed partial class AgentSearchRes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Weave.AgentSearchConversationResult> Results { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_conversations")]
        public int? TotalConversations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSearchRes" /> class.
        /// </summary>
        /// <param name="results"></param>
        /// <param name="totalConversations">
        /// Default Value: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentSearchRes(
            global::System.Collections.Generic.IList<global::Weave.AgentSearchConversationResult> results,
            int? totalConversations)
        {
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
            this.TotalConversations = totalConversations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSearchRes" /> class.
        /// </summary>
        public AgentSearchRes()
        {
        }

    }
}