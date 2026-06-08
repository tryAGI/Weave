
#nullable enable

namespace Weave
{
    /// <summary>
    /// Range filter over one grouped span measure.
    /// </summary>
    public sealed partial class AgentSpanGroupFilter
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_by")]
        public global::System.Collections.Generic.IList<global::Weave.AgentGroupByRef>? GroupBy { get; set; }

        /// <summary>
        /// One aggregate measure computed over spans in a group or bucket.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("measure")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Weave.AgentSpanMeasureSpec Measure { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Weave.JsonConverters.AnyOfJsonConverter<double?, global::System.DateTime?, object>))]
        public global::Weave.AnyOf<double?, global::System.DateTime?, object>? Min { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Weave.JsonConverters.AnyOfJsonConverter<double?, global::System.DateTime?, object>))]
        public global::Weave.AnyOf<double?, global::System.DateTime?, object>? Max { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSpanGroupFilter" /> class.
        /// </summary>
        /// <param name="measure">
        /// One aggregate measure computed over spans in a group or bucket.
        /// </param>
        /// <param name="groupBy"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentSpanGroupFilter(
            global::Weave.AgentSpanMeasureSpec measure,
            global::System.Collections.Generic.IList<global::Weave.AgentGroupByRef>? groupBy,
            global::Weave.AnyOf<double?, global::System.DateTime?, object>? min,
            global::Weave.AnyOf<double?, global::System.DateTime?, object>? max)
        {
            this.GroupBy = groupBy;
            this.Measure = measure ?? throw new global::System.ArgumentNullException(nameof(measure));
            this.Min = min;
            this.Max = max;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSpanGroupFilter" /> class.
        /// </summary>
        public AgentSpanGroupFilter()
        {
        }

    }
}