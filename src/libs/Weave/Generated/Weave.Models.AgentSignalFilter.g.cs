
#nullable enable

namespace Weave
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentSignalFilter
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ratings")]
        public global::System.Collections.Generic.IList<global::Weave.RatingCondition>? Ratings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSignalFilter" /> class.
        /// </summary>
        /// <param name="tags"></param>
        /// <param name="ratings"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentSignalFilter(
            global::System.Collections.Generic.IList<string>? tags,
            global::System.Collections.Generic.IList<global::Weave.RatingCondition>? ratings)
        {
            this.Tags = tags;
            this.Ratings = ratings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSignalFilter" /> class.
        /// </summary>
        public AgentSignalFilter()
        {
        }

    }
}