
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Weave
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentChatAgentHandoff? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentChatAgentStart? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentChatAgentStartStatus? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentChatAssistantMessage? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentChatAssistantMessageStatus? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentChatContextCompacted? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentChatFeedback? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, double>? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentChatMessage? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentChatMessageType? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentChatMessageStatusCode? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentChatUserMessage? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentChatToolCall? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.AgentChatFeedback>? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentChatToolCallStatus? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentConversationChatReq? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentConversationChatRes? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.AgentTraceChatRes>? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentTraceChatRes? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentConversationMessagePreview? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentConversationMessagePreviewRole? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentConversationSpan? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentConversationSpanStatus? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentConversationSpanFeedback? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentConversationSpanFeedbackFeedbackType? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.AgentConversationSpanRating>? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentConversationSpanRating? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentConversationSpans? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.AgentConversationSpan>? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.AgentConversationSpanFeedback>? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentConversationSpansReq? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentConversationSpansRes? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.AgentConversationSpans>? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentCustomAttrSchemaItem? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentCustomAttrSchemaItemSource? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentCustomAttrSchemaItemValueType? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentCustomAttrsSchemaReq? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.Query? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentCustomAttrsSchemaRes? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.AgentCustomAttrSchemaItem>? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentGroupByRef? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentGroupByRefSource? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentInsightFilter? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentInsightFilterField? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSchema? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSearchConversationResult? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.AgentSearchMatchedMessage>? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSearchMatchedMessage? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnyOf<global::Weave.AgentSearchMatchedMessageRole?, string>? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSearchMatchedMessageRole? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSearchReq? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.AgentSearchReqRolesVariant1Item>? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSearchReqRolesVariant1Item? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSearchRes? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.AgentSearchConversationResult>? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSignalFilter? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.RatingCondition>? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.RatingCondition? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSortBy? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSortByDirection? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSpanGroupDistributionBin? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSpanGroupDistributionItem? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSpanGroupDistributionItemSource? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSpanGroupDistributionItemValueType? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.AgentSpanGroupDistributionBin>? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.AgentSpanGroupDistributionValue>? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSpanGroupDistributionValue? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSpanGroupDistributionSpec? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSpanValueRef? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSpanGroupFilter? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.AgentGroupByRef>? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSpanMeasureSpec? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnyOf<double?, global::System.DateTime?, object>? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSpanGroupRow? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnyOf<string, int?, double?, bool?, object>? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnyOf<global::System.DateTime?, string, int?, double?, bool?, object>? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Weave.AgentSpanGroupDistributionItem>? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSpanMeasureSpecAggregation? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSpanMeasureSpecValueType? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSpanSchema? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSpanSchemaSpanKind? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSpanSchemaStatusCode? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.NormalizedMessage>? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.NormalizedMessage? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, int>? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, bool>? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSpanStatsColumn? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSpanStatsColumnRole? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSpanStatsColumnValueType? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSpanStatsMetricSpec? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSpanStatsMetricSpecValueType? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.AgentSpanStatsMetricSpecAggregation>? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSpanStatsMetricSpecAggregation? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<double>? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSpanStatsNumericBucketSpec? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSpanStatsReq? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.AgentSpanStatsMetricSpec>? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.BucketByVariant1? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSpanStatsTimeBucketSpec? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSpanStatsReqBucketByVariant1Discriminator? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSpanStatsReqBucketByVariant1DiscriminatorType? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.AgentSpanGroupFilter>? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.AgentInsightFilter>? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSpanStatsRes? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSpanStatsResBucketType? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.AgentSpanStatsColumn>? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSpanValueRefSource? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSpansQueryReq? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.AgentSpanMeasureSpec>? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.AgentSpanGroupDistributionSpec>? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.AgentSpanValueRef>? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.AgentSortBy>? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSpansQueryRes? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.AgentSpanSchema>? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.AgentSpanGroupRow>? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentTraceChatReq? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentTraceChatResStatusCode? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.AgentChatMessage>? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentVersionSchema? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentVersionsQueryReq? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentVersionsQueryRes? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.AgentVersionSchema>? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentsQueryFilters? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentsQueryReq? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentsQueryRes? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.AgentSchema>? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AggregationType? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AliasesListRes? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AndOperation? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.LiteralOperation? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.GetFieldOperator? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ConvertOperation? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.SizeOperation? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.OrOperation? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.NotOperation? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EqOperation? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.GtOperation? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.LtOperation? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.GteOperation? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.LteOperation? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.InOperation? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ContainsOperation? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnnotationQueueAddCallsBody? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnnotationQueueAddCallsRes? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnnotationQueueCreateReq? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnnotationQueueCreateRes? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnnotationQueueDeleteRes? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnnotationQueueSchema? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnnotationQueueItemProgressUpdateBody? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnnotationQueueItemSchema? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnnotationQueueItemSchemaAnnotationState? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnnotationQueueItemsFilter? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.AnnotationQueueItemsFilterAnnotationStatesVariant1Item>? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnnotationQueueItemsFilterAnnotationStatesVariant1Item? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnnotationQueueItemsQueryBody? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.SortBy>? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.SortBy? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnnotationQueueItemsQueryRes? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.AnnotationQueueItemSchema>? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnnotationQueueReadRes? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnnotationQueueStatsSchema? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnnotationQueueUpdateBody? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnnotationQueueUpdateRes? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnnotationQueuesQueryReq? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnnotationQueuesStatsReq? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnnotationQueuesStatsRes? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.AnnotationQueueStatsSchema>? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnnotatorQueueItemsProgressUpdateRes? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.BaseModel? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.BodyFileCreateFileCreatePost? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallBatchEndMode? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallEndReq? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallBatchStartMode? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallStartReq? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallCreateBatchReq? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.AnyOf<global::Weave.CallBatchStartMode, global::Weave.CallBatchEndMode>>? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnyOf<global::Weave.CallBatchStartMode, global::Weave.CallBatchEndMode>? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallCreateBatchRes? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.AnyOf<global::Weave.CallStartRes, global::Weave.CallEndRes>>? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnyOf<global::Weave.CallStartRes, global::Weave.CallEndRes>? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallStartRes? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallEndRes? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EndedCallSchemaForInsert? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallMetricSpec? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallMetricSpecMetric? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.AggregationType>? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallReadReq? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallReadRes? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallSchema? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.StartedCallSchemaForInsert? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallStatsReq? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.UsageMetricSpec>? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.UsageMetricSpec? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.CallMetricSpec>? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallsFilter? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallStatsRes? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallUpdateReq? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallUpdateRes? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallsDeleteReq? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallsDeleteRes? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallsQueryReq? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallsQueryStatsReq? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallsQueryStatsRes? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallsScoreReq? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallsScoreRes? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallsUpsertCompleteReq? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.CompletedCallSchemaForInsert>? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CompletedCallSchemaForInsert? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallsUpsertCompleteRes? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallsUsageReq? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallsUsageRes? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, global::Weave.LLMAggregatedUsage>>? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Weave.LLMAggregatedUsage>? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.LLMAggregatedUsage? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CatalogModelsRes? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.LLMModelDetails>? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.LLMModelDetails? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.SummaryInsertMap? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CompletionsCreateReq? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CompletionsCreateRequestInputs? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnyOf<double?, string, object>? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnyOf<string, global::System.Collections.Generic.IList<object>, object>? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnyOf<string, object, object>? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CompletionsCreateRes? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CompletionsCreateStreamChunk? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CompletionsCreateStreamMeta? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ContainsSpec? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ConvertSpec? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ConvertSpecTo? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.Cost? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CostCreateInput? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CostCreateReq? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Weave.CostCreateInput>? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CostCreateRes? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CostPurgeReq? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CostPurgeRes? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CostQueryOutput? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CostQueryReq? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CostQueryRes? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.CostQueryOutput>? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CreateAndLinkPayload? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CreateAndLinkTarget? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CreateAndLinkWeaveAssetRes? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CustomRuntimeApplyBody? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.CustomRuntimeID>? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CustomRuntimeID? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CustomRuntimeApplyRes? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.CustomRuntimeIDRes>? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CustomRuntimeIDRes? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.Datacenter? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.DatasetCreateBody? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.DatasetCreateRes? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.DatasetDeleteRes? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.DatasetReadRes? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.DatasetSourceLinkPayload? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.SourceRef>? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.SourceRef? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.DatasetSourceLinkSchema? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.SourceKind? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.DatasetSourcesLinkReq? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.DatasetSourceLinkPayload>? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.DatasetSourcesLinkRes? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.DatasetSourcesLinkResEntry>? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.DatasetSourcesLinkResEntry? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.DatasetSourcesQueryReq? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.SourceKind>? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.DatasetSourcesQueryRes? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.DatasetSourceLinkSchema>? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.DeletedObjVersion? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvalResultsEvaluationSummary? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.EvalResultsScorerStats>? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvalResultsScorerStats? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvalResultsFilter? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvalResultsQueryBody? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.EvalResultsSortBy>? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvalResultsSortBy? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.EvalResultsFilter>? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvalResultsQueryBodyFilterLogicOperator? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvalResultsQueryRes? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.EvalResultsRow>? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvalResultsRow? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvalResultsSummaryRes? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.EvalResultsRowEvaluation>? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvalResultsRowEvaluation? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.EvalResultsTrial>? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvalResultsTrial? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvalResultsScorerStatsValueType? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvalResultsSortByDirection? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvalResultsSortByMode? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.EvalResultsEvaluationSummary>? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.GenAISpanRef>? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.GenAISpanRef? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvaluateModelReq? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvaluateModelRes? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvaluationCreateBody? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvaluationCreateRes? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvaluationDeleteRes? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvaluationReadRes? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvaluationRunCreateBody? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvaluationRunCreateRes? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvaluationRunDeleteRes? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvaluationRunFinishBody? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvaluationRunFinishRes? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvaluationRunReadRes? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvaluationStatusComplete? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvaluationStatusFailed? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvaluationStatusNotFound? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvaluationStatusReq? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvaluationStatusRes? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnyOf<global::Weave.EvaluationStatusNotFound, global::Weave.EvaluationStatusRunning, global::Weave.EvaluationStatusFailed, global::Weave.EvaluationStatusComplete>? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvaluationStatusRunning? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FeedbackAggregateBucket? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FeedbackAggregateReq? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.FeedbackAggregateReqSpanType>? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FeedbackAggregateReqSpanType? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.FeedbackAggregateReqGroupByItem>? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FeedbackAggregateReqGroupByItem? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FeedbackAggregateRes? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.FeedbackAggregateBucket>? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FeedbackCreateBatchReq? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.FeedbackCreateReq>? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FeedbackCreateReq? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FeedbackCreateBatchRes? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.FeedbackCreateRes>? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FeedbackCreateRes? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FeedbackMetricSpec? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FeedbackMetricSpecValueType? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FeedbackPayloadPath? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FeedbackPayloadPathValueType? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FeedbackPayloadSchemaReq? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FeedbackPayloadSchemaRes? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.FeedbackPayloadPath>? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FeedbackPurgeReq? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FeedbackPurgeRes? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FeedbackQueryReq? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FeedbackQueryRes? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FeedbackReplaceReq? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FeedbackReplaceRes? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FeedbackStatsReq? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.FeedbackMetricSpec>? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FeedbackStatsRes? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FileContentReadReq? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FileCreateRes? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FilesResolveUrlReq? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FilesStatsReq? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FilesStatsRes? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.Geolocation? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.GeolocationRes? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.HTTPValidationError? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.ValidationError>? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ValidationError? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ImageGenerationCreateReq? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ImageGenerationRequestInputs? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ImageGenerationCreateRes? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.Interleaved? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.InterleavedField? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.LLMModelDetailsLifecycleStage? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.LLMModelDetailsAvailableInItem>? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.LLMModelDetailsAvailableInItem? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.LLMModelDetailsReasoningSupport? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.LLMModelDetailsReasoningEffort>? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.LLMModelDetailsReasoningEffort? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.LLMModelDetailsQuantization? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.LLMUsageSchema? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.Limit? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnyOf<string, int?, double?, bool?, global::System.Collections.Generic.Dictionary<string, global::Weave.LiteralOperation>, global::System.Collections.Generic.IList<global::Weave.LiteralOperation>, object>? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Weave.LiteralOperation>? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.LiteralOperation>? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.Modalities? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ModelCreateBody? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ModelCreateRes? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ModelDeleteRes? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ModelReadRes? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ModelsDevModel? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.AnyOf<global::Weave.ReasoningToggle, global::Weave.ReasoningEffortOption, global::Weave.ReasoningBudgetTokens>>? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnyOf<global::Weave.ReasoningToggle, global::Weave.ReasoningEffortOption, global::Weave.ReasoningBudgetTokens>? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ReasoningToggle? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ReasoningEffortOption? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ReasoningBudgetTokens? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ModelsDevModelStatus? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnyOf<bool?, global::Weave.Interleaved, object>? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ModelsDevProvider? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Weave.ModelsDevModel>? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.NvidiaHardwareOption? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.NvidiaServerlessPricing? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.NvidiaHardwareRes? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.NvidiaHardwareOption>? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ObjAddTagsRes? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ObjCreateReq? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ObjSchemaForInsert? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ObjCreateRes? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ObjDeleteReq? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ObjDeleteRes? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.DeletedObjVersion>? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ObjQueryReq? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ObjectVersionFilter? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ObjQueryRes? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.ObjSchema>? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ObjSchema? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ObjReadReq? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ObjReadRes? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ObjRemoveAliasesBody? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ObjRemoveAliasesRes? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ObjRemoveTagsRes? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ObjSetAliasesBody? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ObjSetAliasesRes? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ObjTagsBody? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.OpCreateBody? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.OpCreateRes? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.OpDeleteRes? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.OpReadRes? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.PredictionCreateBody? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.PredictionCreateRes? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.PredictionDeleteRes? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.PredictionFinishRes? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.PredictionReadRes? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.Pricing? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ProjectIngestSamplingSettingsReadReq? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ProjectIngestSamplingSettingsReadRes? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ProjectSensitiveDataSettingsReadRes? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.SensitiveDataPolicy? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ProjectStatsReq? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ProjectStatsRes? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ProjectTTLSettingsReadReq? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ProjectTTLSettingsReadRes? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ProjectTTLSettingsUpdateReq? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ProjectTTLSettingsUpdateRes? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ProjectsInfoReq? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ProjectsInfoRes? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.RatingConditionOp? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.ReasoningEffortOptionValue?>? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ReasoningEffortOptionValue? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ReferenceResolveRes? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.RefsReadBatchReq? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.RefsReadBatchRes? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.RescoreReq? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.RescoreRes? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.RouterOpenRouterModel? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.RouterOpenRouterModelQuantization? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.RouterOpenRouterModelSupportedSamplingParameter>? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.RouterOpenRouterModelSupportedSamplingParameter? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.RouterOpenRouterModelSupportedFeature>? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.RouterOpenRouterModelSupportedFeature? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.Datacenter>? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.RouterOpenRouterModelsRes? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.RouterOpenRouterModel>? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ScoreCreateBody? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ScoreCreateRes? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ScoreDeleteRes? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ScoreReadRes? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ScorerCreateBody? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ScorerCreateRes? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ScorerDeleteRes? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ScorerReadRes? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ServerInfoRes? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.SortByDirection? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.SourceDatasetMembership? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.SourceDatasetsQueryReq? Type470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.SourceDatasetsQueryRes? Type471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.SourceDatasetMembership>? Type472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Weave.LLMUsageSchema>? Type473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.TableAppendSpec? Type474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.TableAppendSpecPayload? Type475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.TableCreateFromDigestsReq? Type476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.TableCreateFromDigestsRes? Type477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.TableCreateReq? Type478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.TableSchemaForInsert? Type479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.TableCreateRes? Type480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.TableInsertSpec? Type481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.TableInsertSpecPayload? Type482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.TablePopSpec? Type483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.TablePopSpecPayload? Type484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.TableQueryReq? Type485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.TableRowFilter? Type486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.TableQueryRes? Type487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.TableRowSchema>? Type488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.TableRowSchema? Type489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.TableQueryStatsBatchReq? Type490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.TableQueryStatsBatchRes? Type491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.TableStatsRow>? Type492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.TableStatsRow? Type493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.TableQueryStatsReq? Type494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.TableQueryStatsRes? Type495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.TableUpdateReq? Type496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.AnyOf<global::Weave.TableAppendSpec, global::Weave.TablePopSpec, global::Weave.TableInsertSpec>>? Type497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnyOf<global::Weave.TableAppendSpec, global::Weave.TablePopSpec, global::Weave.TableInsertSpec>? Type498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.TableUpdateRes? Type499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.TagsListRes? Type500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ThreadSchema? Type501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ThreadsQueryFilter? Type502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ThreadsQueryReq? Type503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.TraceStatus? Type504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.TraceUsageReq? Type505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.TraceUsageRes? Type506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.UsageMetricSpecMetric? Type507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.AnyOf<string, int?>>? Type508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnyOf<string, int?>? Type509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Weave.ModelsDevProvider>? Type510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.ProjectsInfoRes>? Type511 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.AgentChatFeedback>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.AgentTraceChatRes>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.AgentConversationSpanRating>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.AgentConversationSpan>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.AgentConversationSpanFeedback>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.AgentConversationSpans>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.AgentCustomAttrSchemaItem>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.AgentSearchMatchedMessage>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.AgentSearchReqRolesVariant1Item>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.AgentSearchConversationResult>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.RatingCondition>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.AgentSpanGroupDistributionBin>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.AgentSpanGroupDistributionValue>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.AgentGroupByRef>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.NormalizedMessage>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.AgentSpanStatsMetricSpecAggregation>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<double>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.AgentSpanStatsMetricSpec>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.AgentSpanGroupFilter>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.AgentInsightFilter>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.AgentSpanStatsColumn>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<object>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.AgentSpanMeasureSpec>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.AgentSpanGroupDistributionSpec>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.AgentSpanValueRef>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.AgentSortBy>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.AgentSpanSchema>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.AgentSpanGroupRow>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.AgentChatMessage>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.AgentVersionSchema>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.AgentSchema>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.AnnotationQueueItemsFilterAnnotationStatesVariant1Item>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.SortBy>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.AnnotationQueueItemSchema>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.AnnotationQueueStatsSchema>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.AnyOf<global::Weave.CallBatchStartMode, global::Weave.CallBatchEndMode>>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.AnyOf<global::Weave.CallStartRes, global::Weave.CallEndRes>>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.AggregationType>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.UsageMetricSpec>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.CallMetricSpec>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.CompletedCallSchemaForInsert>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.LLMModelDetails>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnyOf<string, global::System.Collections.Generic.List<object>, object>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<string>>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.CostQueryOutput>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.CustomRuntimeID>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.CustomRuntimeIDRes>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.SourceRef>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.DatasetSourceLinkPayload>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.DatasetSourcesLinkResEntry>? ListType50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.SourceKind>? ListType51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.DatasetSourceLinkSchema>? ListType52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.EvalResultsScorerStats>? ListType53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.EvalResultsSortBy>? ListType54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.EvalResultsFilter>? ListType55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.EvalResultsRow>? ListType56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.EvalResultsRowEvaluation>? ListType57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.EvalResultsTrial>? ListType58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.EvalResultsEvaluationSummary>? ListType59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.GenAISpanRef>? ListType60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.FeedbackAggregateReqSpanType>? ListType61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.FeedbackAggregateReqGroupByItem>? ListType62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.FeedbackAggregateBucket>? ListType63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.FeedbackCreateReq>? ListType64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.FeedbackCreateRes>? ListType65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.FeedbackPayloadPath>? ListType66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.FeedbackMetricSpec>? ListType67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.ValidationError>? ListType68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.LLMModelDetailsAvailableInItem>? ListType69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.LLMModelDetailsReasoningEffort>? ListType70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnyOf<string, int?, double?, bool?, global::System.Collections.Generic.Dictionary<string, global::Weave.LiteralOperation>, global::System.Collections.Generic.List<global::Weave.LiteralOperation>, object>? ListType71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.LiteralOperation>? ListType72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.AnyOf<global::Weave.ReasoningToggle, global::Weave.ReasoningEffortOption, global::Weave.ReasoningBudgetTokens>>? ListType73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.NvidiaHardwareOption>? ListType74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.DeletedObjVersion>? ListType75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.ObjSchema>? ListType76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.ReasoningEffortOptionValue?>? ListType77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.RouterOpenRouterModelSupportedSamplingParameter>? ListType78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.RouterOpenRouterModelSupportedFeature>? ListType79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.Datacenter>? ListType80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.RouterOpenRouterModel>? ListType81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.SourceDatasetMembership>? ListType82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.TableRowSchema>? ListType83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.TableStatsRow>? ListType84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.AnyOf<global::Weave.TableAppendSpec, global::Weave.TablePopSpec, global::Weave.TableInsertSpec>>? ListType85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.AnyOf<string, int?>>? ListType86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.ProjectsInfoRes>? ListType87 { get; set; }
    }
}