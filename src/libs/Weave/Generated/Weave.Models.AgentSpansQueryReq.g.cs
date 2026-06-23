
#nullable enable

namespace Weave
{
    /// <summary>
    /// Request to query agent spans for a project.<br/>
    /// When `group_by` is empty (or omitted), returns raw span rows in the<br/>
    /// response's `spans` field. When `group_by` is non-empty, returns<br/>
    /// aggregate group rows in the response's `groups` field.
    /// </summary>
    public sealed partial class AgentSpansQueryReq
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
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        public global::Weave.Query? Query { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_by")]
        public global::System.Collections.Generic.IList<global::Weave.AgentGroupByRef>? GroupBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("measures")]
        public global::System.Collections.Generic.IList<global::Weave.AgentSpanMeasureSpec>? Measures { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_filters")]
        public global::System.Collections.Generic.IList<global::Weave.AgentSpanGroupFilter>? GroupFilters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_distributions")]
        public global::System.Collections.Generic.IList<global::Weave.AgentSpanGroupDistributionSpec>? GroupDistributions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_attr_columns")]
        public global::System.Collections.Generic.IList<global::Weave.AgentSpanValueRef>? CustomAttrColumns { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_details")]
        public bool? IncludeDetails { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_costs")]
        public bool? IncludeCosts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sort_by")]
        public global::System.Collections.Generic.IList<global::Weave.AgentSortBy>? SortBy { get; set; }

        /// <summary>
        /// Default Value: 100
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("offset")]
        public int? Offset { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_after")]
        public global::System.DateTime? StartedAfter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_before")]
        public global::System.DateTime? StartedBefore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSpansQueryReq" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="query"></param>
        /// <param name="groupBy"></param>
        /// <param name="measures"></param>
        /// <param name="groupFilters"></param>
        /// <param name="groupDistributions"></param>
        /// <param name="customAttrColumns"></param>
        /// <param name="includeDetails">
        /// Default Value: false
        /// </param>
        /// <param name="includeCosts">
        /// Default Value: false
        /// </param>
        /// <param name="sortBy"></param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="startedAfter"></param>
        /// <param name="startedBefore"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentSpansQueryReq(
            string projectId,
            global::Weave.Query? query,
            global::System.Collections.Generic.IList<global::Weave.AgentGroupByRef>? groupBy,
            global::System.Collections.Generic.IList<global::Weave.AgentSpanMeasureSpec>? measures,
            global::System.Collections.Generic.IList<global::Weave.AgentSpanGroupFilter>? groupFilters,
            global::System.Collections.Generic.IList<global::Weave.AgentSpanGroupDistributionSpec>? groupDistributions,
            global::System.Collections.Generic.IList<global::Weave.AgentSpanValueRef>? customAttrColumns,
            bool? includeDetails,
            bool? includeCosts,
            global::System.Collections.Generic.IList<global::Weave.AgentSortBy>? sortBy,
            int? limit,
            int? offset,
            global::System.DateTime? startedAfter,
            global::System.DateTime? startedBefore)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.Query = query;
            this.GroupBy = groupBy;
            this.Measures = measures;
            this.GroupFilters = groupFilters;
            this.GroupDistributions = groupDistributions;
            this.CustomAttrColumns = customAttrColumns;
            this.IncludeDetails = includeDetails;
            this.IncludeCosts = includeCosts;
            this.SortBy = sortBy;
            this.Limit = limit;
            this.Offset = offset;
            this.StartedAfter = startedAfter;
            this.StartedBefore = startedBefore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSpansQueryReq" /> class.
        /// </summary>
        public AgentSpansQueryReq()
        {
        }

    }
}