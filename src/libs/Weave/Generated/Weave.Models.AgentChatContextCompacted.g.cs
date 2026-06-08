
#nullable enable

namespace Weave
{
    /// <summary>
    /// Payload for a context-window compaction event.
    /// </summary>
    public sealed partial class AgentChatContextCompacted
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compaction_summary")]
        public string? CompactionSummary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compaction_items_before")]
        public int? CompactionItemsBefore { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compaction_items_after")]
        public int? CompactionItemsAfter { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentChatContextCompacted" /> class.
        /// </summary>
        /// <param name="compactionSummary"></param>
        /// <param name="compactionItemsBefore"></param>
        /// <param name="compactionItemsAfter"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentChatContextCompacted(
            string? compactionSummary,
            int? compactionItemsBefore,
            int? compactionItemsAfter)
        {
            this.CompactionSummary = compactionSummary;
            this.CompactionItemsBefore = compactionItemsBefore;
            this.CompactionItemsAfter = compactionItemsAfter;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentChatContextCompacted" /> class.
        /// </summary>
        public AgentChatContextCompacted()
        {
        }

    }
}