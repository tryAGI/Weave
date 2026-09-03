
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
        public global::Weave.AgentChatAgentStartStatus2? Type4 { get; set; }
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
        public global::Weave.AgentChatAssistantMessageStatus2? Type8 { get; set; }
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
        public global::Weave.AgentChatMessageStatusCode2? Type17 { get; set; }
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
        public global::Weave.AgentChatToolCallStatus2? Type21 { get; set; }
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
        public global::Weave.AgentSchema? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSearchConversationResult? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.AgentSearchMatchedMessage>? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSearchMatchedMessage? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnyOf<global::Weave.AgentSearchMatchedMessageRole?, string>? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSearchMatchedMessageRole? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSearchReq? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.AgentSearchReqRolesVariant1Item>? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSearchReqRolesVariant1Item? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSearchRes? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.AgentSearchConversationResult>? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSignalFilter? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.RatingCondition>? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.RatingCondition? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSortBy? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSortByDirection? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSpanGroupDistributionBin? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSpanGroupDistributionItem? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSpanGroupDistributionItemSource? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSpanGroupDistributionItemValueType? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.AgentSpanGroupDistributionBin>? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.AgentSpanGroupDistributionValue>? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSpanGroupDistributionValue? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSpanGroupDistributionSpec? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSpanValueRef? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSpanGroupFilter? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.AgentGroupByRef>? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSpanMeasureSpec? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnyOf<double?, global::System.DateTime?, object>? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSpanGroupRow? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnyOf<string, int?, double?, bool?, object>? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnyOf<global::System.DateTime?, string, int?, double?, bool?, object>? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Weave.AgentSpanGroupDistributionItem>? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSpanMeasureSpecAggregation? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSpanMeasureSpecValueType2? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSpanSchema? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSpanSchemaSpanKind2? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSpanSchemaStatusCode2? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.NormalizedMessage>? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.NormalizedMessage? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, int>? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, bool>? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSpanStatsColumn? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSpanStatsColumnRole? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSpanStatsColumnValueType? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSpanStatsMetricSpec? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSpanStatsMetricSpecValueType? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.AgentSpanStatsMetricSpecAggregation>? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSpanStatsMetricSpecAggregation? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<double>? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSpanStatsNumericBucketSpec? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSpanStatsReq? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.AgentSpanStatsMetricSpec>? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.BucketByVariant1? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSpanStatsTimeBucketSpec? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSpanStatsReqBucketByVariant1Discriminator? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSpanStatsReqBucketByVariant1DiscriminatorType? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.AgentSpanGroupFilter>? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSpanStatsRes? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSpanStatsResBucketType? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.AgentSpanStatsColumn>? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSpanValueRefSource? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSpansQueryReq? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.AgentSpanMeasureSpec>? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.AgentSpanGroupDistributionSpec>? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.AgentSpanValueRef>? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.AgentSortBy>? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSpansQueryRes? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.AgentSpanSchema>? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.AgentSpanGroupRow>? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentTraceChatReq? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentTraceChatResStatusCode2? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.AgentChatMessage>? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentVersionSchema? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentVersionsQueryReq? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentVersionsQueryRes? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.AgentVersionSchema>? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentsQueryFilters? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentsQueryReq? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentsQueryRes? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.AgentSchema>? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AggregationType? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AliasesListRes? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AndOperation? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.LiteralOperation? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.GetFieldOperator? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ConvertOperation? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.SizeOperation? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.OrOperation? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.NotOperation? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EqOperation? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.GtOperation? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.LtOperation? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.GteOperation? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.LteOperation? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.InOperation? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ContainsOperation? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnnotationQueueAddCallsBody? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnnotationQueueAddCallsRes? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnnotationQueueCreateReq? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnnotationQueueCreateRes? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnnotationQueueDeleteRes? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnnotationQueueSchema? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnnotationQueueItemProgressUpdateBody? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnnotationQueueItemSchema? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnnotationQueueItemSchemaAnnotationState? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnnotationQueueItemsFilter? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.AnnotationQueueItemsFilterAnnotationStatesVariant1Item>? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnnotationQueueItemsFilterAnnotationStatesVariant1Item? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnnotationQueueItemsQueryBody? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.SortBy>? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.SortBy? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnnotationQueueItemsQueryRes? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.AnnotationQueueItemSchema>? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnnotationQueueReadRes? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnnotationQueueStatsSchema? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnnotationQueueUpdateBody? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnnotationQueueUpdateRes? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnnotationQueuesQueryReq? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnnotationQueuesStatsReq? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnnotationQueuesStatsRes? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.AnnotationQueueStatsSchema>? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnnotatorQueueItemsProgressUpdateRes? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.BaseModel? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.BodyFileCreateFileCreatePost? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallBatchEndMode? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallEndReq? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallBatchStartMode? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallStartReq? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallCreateBatchReq? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.AnyOf<global::Weave.CallBatchStartMode, global::Weave.CallBatchEndMode>>? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnyOf<global::Weave.CallBatchStartMode, global::Weave.CallBatchEndMode>? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallCreateBatchRes? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.AnyOf<global::Weave.CallStartRes, global::Weave.CallEndRes>>? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnyOf<global::Weave.CallStartRes, global::Weave.CallEndRes>? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallStartRes? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallEndRes? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EndedCallSchemaForInsert? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallMetricSpec? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallMetricSpecMetric? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.AggregationType>? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallReadReq? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallReadRes? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallSchema? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.StartedCallSchemaForInsert? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallStatsReq? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.UsageMetricSpec>? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.UsageMetricSpec? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.CallMetricSpec>? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallsFilter? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallStatsRes? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallUpdateReq? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallUpdateRes? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallsDeleteReq? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallsDeleteRes? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallsQueryReq? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallsQueryStatsReq? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallsQueryStatsRes? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallsScoreReq? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallsScoreRes? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallsUpsertCompleteReq? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.CompletedCallSchemaForInsert>? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CompletedCallSchemaForInsert? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallsUpsertCompleteRes? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallsUsageReq? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallsUsageRes? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, global::Weave.LLMAggregatedUsage>>? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Weave.LLMAggregatedUsage>? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.LLMAggregatedUsage? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CatalogModelsRes? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.LLMModelDetails>? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.LLMModelDetails? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.SummaryInsertMap? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CompletionsCreateReq? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CompletionsCreateRequestInputs? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnyOf<double?, string, object>? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnyOf<string, global::System.Collections.Generic.IList<object>, object>? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnyOf<string, object, object>? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CompletionsCreateRes? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ContainsSpec? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ConvertSpec? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ConvertSpecTo? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.Cost? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CostCreateInput? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CostCreateReq? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Weave.CostCreateInput>? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CostCreateRes? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CostPurgeReq? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CostPurgeRes? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CostQueryOutput? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CostQueryReq? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CostQueryRes? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.CostQueryOutput>? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CreateAndLinkPayload? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CreateAndLinkTarget? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CreateAndLinkWeaveAssetRes? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CustomRuntimeApplyBody? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.CustomRuntimeID>? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CustomRuntimeID? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CustomRuntimeApplyRes? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.CustomRuntimeIDRes>? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CustomRuntimeIDRes? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.Datacenter? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.DatasetCreateBody? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.DatasetCreateRes? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.DatasetDeleteRes? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.DatasetReadRes? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.DeletedObjVersion? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvalResultsEvaluationSummary? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.EvalResultsScorerStats>? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvalResultsScorerStats? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvalResultsFilter? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvalResultsQueryBody? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.EvalResultsSortBy>? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvalResultsSortBy? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.EvalResultsFilter>? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvalResultsQueryBodyFilterLogicOperator? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvalResultsQueryRes? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.EvalResultsRow>? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvalResultsRow? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvalResultsSummaryRes? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.EvalResultsRowEvaluation>? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvalResultsRowEvaluation? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.EvalResultsTrial>? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvalResultsTrial? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvalResultsScorerStatsValueType2? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvalResultsSortByDirection? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvalResultsSortByMode? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.EvalResultsEvaluationSummary>? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.GenAISpanRef>? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.GenAISpanRef? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvaluateModelReq? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvaluateModelRes? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvaluationCreateBody? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvaluationCreateRes? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvaluationDeleteRes? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvaluationReadRes? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvaluationRunCreateBody? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvaluationRunCreateRes? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvaluationRunDeleteRes? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvaluationRunFinishBody? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvaluationRunFinishRes? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvaluationRunReadRes? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvaluationStatusComplete? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvaluationStatusFailed? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvaluationStatusNotFound? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvaluationStatusReq? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvaluationStatusRes? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnyOf<global::Weave.EvaluationStatusNotFound, global::Weave.EvaluationStatusRunning, global::Weave.EvaluationStatusFailed, global::Weave.EvaluationStatusComplete>? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvaluationStatusRunning? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FeedbackAggregateBucket? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FeedbackAggregateReq? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.FeedbackAggregateReqSpanType>? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FeedbackAggregateReqSpanType? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.FeedbackAggregateReqGroupByItem>? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FeedbackAggregateReqGroupByItem? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FeedbackAggregateRes? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.FeedbackAggregateBucket>? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FeedbackCreateBatchReq? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.FeedbackCreateReq>? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FeedbackCreateReq? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FeedbackCreateBatchRes? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.FeedbackCreateRes>? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FeedbackCreateRes? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FeedbackMetricSpec? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FeedbackMetricSpecValueType? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FeedbackPayloadPath? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FeedbackPayloadPathValueType? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FeedbackPayloadSchemaReq? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FeedbackPayloadSchemaRes? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.FeedbackPayloadPath>? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FeedbackPurgeReq? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FeedbackPurgeRes? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FeedbackQueryReq? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FeedbackQueryRes? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FeedbackReplaceReq? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FeedbackReplaceRes? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FeedbackStatsReq? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.FeedbackMetricSpec>? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FeedbackStatsRes? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FileContentReadReq? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FileCreateRes? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FilesStatsReq? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FilesStatsRes? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.Geolocation? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.GeolocationRes? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.HTTPValidationError? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.ValidationError>? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ValidationError? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ImageGenerationCreateReq? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ImageGenerationRequestInputs? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ImageGenerationCreateRes? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.Interleaved? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.InterleavedField? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.LLMModelDetailsLifecycleStage? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.LLMModelDetailsAvailableInItem>? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.LLMModelDetailsAvailableInItem? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.LLMModelDetailsReasoningSupport? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.LLMModelDetailsReasoningEffort>? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.LLMModelDetailsReasoningEffort? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.LLMModelDetailsQuantization? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.LLMUsageSchema? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.Limit? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnyOf<string, int?, double?, bool?, global::System.Collections.Generic.Dictionary<string, global::Weave.LiteralOperation>, global::System.Collections.Generic.IList<global::Weave.LiteralOperation>, object>? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Weave.LiteralOperation>? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.LiteralOperation>? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.Modalities? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ModelCreateBody? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ModelCreateRes? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ModelDeleteRes? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ModelReadRes? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ModelsDevModel? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.AnyOf<global::Weave.ReasoningToggle, global::Weave.ReasoningEffortOption, global::Weave.ReasoningBudgetTokens>>? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnyOf<global::Weave.ReasoningToggle, global::Weave.ReasoningEffortOption, global::Weave.ReasoningBudgetTokens>? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ReasoningToggle? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ReasoningEffortOption? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ReasoningBudgetTokens? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ModelsDevModelStatus2? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnyOf<bool?, global::Weave.Interleaved, object>? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ModelsDevProvider? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Weave.ModelsDevModel>? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.NvidiaHardwareOption? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.NvidiaServerlessPricing? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.NvidiaHardwareRes? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.NvidiaHardwareOption>? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ObjAddTagsRes? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ObjCreateReq? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ObjSchemaForInsert? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ObjCreateRes? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ObjDeleteReq? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ObjDeleteRes? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.DeletedObjVersion>? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ObjQueryReq? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ObjectVersionFilter? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ObjQueryRes? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.ObjSchema>? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ObjSchema? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ObjReadReq? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ObjReadRes? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ObjRemoveAliasesBody? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ObjRemoveAliasesRes? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ObjRemoveTagsRes? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ObjSetAliasesBody? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ObjSetAliasesRes? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ObjTagsBody? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.OpCreateBody? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.OpCreateRes? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.OpDeleteRes? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.OpReadRes? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.PredictionCreateBody? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.PredictionCreateRes? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.PredictionDeleteRes? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.PredictionFinishRes? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.PredictionReadRes? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.Pricing? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ProjectsInfoReq? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ProjectsInfoRes? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.RatingConditionOp? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.ReasoningEffortOptionValue2>? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ReasoningEffortOptionValue2? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.RefsReadBatchReq? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.RefsReadBatchRes? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.RescoreReq? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.RescoreRes? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.RouterOpenRouterModel? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.RouterOpenRouterModelQuantization? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.RouterOpenRouterModelSupportedSamplingParameter>? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.RouterOpenRouterModelSupportedSamplingParameter? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.RouterOpenRouterModelSupportedFeature>? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.RouterOpenRouterModelSupportedFeature? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.Datacenter>? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.RouterOpenRouterModelsRes? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.RouterOpenRouterModel>? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ScoreCreateBody? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ScoreCreateRes? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ScoreDeleteRes? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ScoreReadRes? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ScorerCreateBody? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ScorerCreateRes? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ScorerDeleteRes? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ScorerReadRes? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ServerInfoRes? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.SortByDirection? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Weave.LLMUsageSchema>? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.TableAppendSpec? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.TableAppendSpecPayload? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.TableCreateFromDigestsReq? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.TableCreateFromDigestsRes? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.TableCreateReq? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.TableSchemaForInsert? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.TableCreateRes? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.TableInsertSpec? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.TableInsertSpecPayload? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.TablePopSpec? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.TablePopSpecPayload? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.TableQueryReq? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.TableRowFilter? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.TableQueryRes? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.TableRowSchema>? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.TableRowSchema? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.TableQueryStatsBatchReq? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.TableQueryStatsBatchRes? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.TableStatsRow>? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.TableStatsRow? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.TableQueryStatsReq? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.TableQueryStatsRes? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.TableUpdateReq? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.AnyOf<global::Weave.TableAppendSpec, global::Weave.TablePopSpec, global::Weave.TableInsertSpec>>? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnyOf<global::Weave.TableAppendSpec, global::Weave.TablePopSpec, global::Weave.TableInsertSpec>? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.TableUpdateRes? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.TagsListRes? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ThreadSchema? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ThreadsQueryFilter? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ThreadsQueryReq? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.TraceStatus? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.TraceUsageReq? Type470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.TraceUsageRes? Type471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.UsageMetricSpecMetric? Type472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.AnyOf<string, int?>>? Type473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnyOf<string, int?>? Type474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Weave.ModelsDevProvider>? Type475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.ProjectsInfoRes>? Type476 { get; set; }

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
        public global::System.Collections.Generic.List<global::Weave.AgentSpanStatsColumn>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<object>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.AgentSpanMeasureSpec>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.AgentSpanGroupDistributionSpec>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.AgentSpanValueRef>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.AgentSortBy>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.AgentSpanSchema>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.AgentSpanGroupRow>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.AgentChatMessage>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.AgentVersionSchema>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.AgentSchema>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.AnnotationQueueItemsFilterAnnotationStatesVariant1Item>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.SortBy>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.AnnotationQueueItemSchema>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.AnnotationQueueStatsSchema>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.AnyOf<global::Weave.CallBatchStartMode, global::Weave.CallBatchEndMode>>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.AnyOf<global::Weave.CallStartRes, global::Weave.CallEndRes>>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.AggregationType>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.UsageMetricSpec>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.CallMetricSpec>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.CompletedCallSchemaForInsert>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.LLMModelDetails>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnyOf<string, global::System.Collections.Generic.List<object>, object>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<string>>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.CostQueryOutput>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.CustomRuntimeID>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.CustomRuntimeIDRes>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.EvalResultsScorerStats>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.EvalResultsSortBy>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.EvalResultsFilter>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.EvalResultsRow>? ListType50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.EvalResultsRowEvaluation>? ListType51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.EvalResultsTrial>? ListType52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.EvalResultsEvaluationSummary>? ListType53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.GenAISpanRef>? ListType54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.FeedbackAggregateReqSpanType>? ListType55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.FeedbackAggregateReqGroupByItem>? ListType56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.FeedbackAggregateBucket>? ListType57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.FeedbackCreateReq>? ListType58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.FeedbackCreateRes>? ListType59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.FeedbackPayloadPath>? ListType60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.FeedbackMetricSpec>? ListType61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.ValidationError>? ListType62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.LLMModelDetailsAvailableInItem>? ListType63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.LLMModelDetailsReasoningEffort>? ListType64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnyOf<string, int?, double?, bool?, global::System.Collections.Generic.Dictionary<string, global::Weave.LiteralOperation>, global::System.Collections.Generic.List<global::Weave.LiteralOperation>, object>? ListType65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.LiteralOperation>? ListType66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.AnyOf<global::Weave.ReasoningToggle, global::Weave.ReasoningEffortOption, global::Weave.ReasoningBudgetTokens>>? ListType67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.NvidiaHardwareOption>? ListType68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.DeletedObjVersion>? ListType69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.ObjSchema>? ListType70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.ReasoningEffortOptionValue2>? ListType71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.RouterOpenRouterModelSupportedSamplingParameter>? ListType72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.RouterOpenRouterModelSupportedFeature>? ListType73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.Datacenter>? ListType74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.RouterOpenRouterModel>? ListType75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.TableRowSchema>? ListType76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.TableStatsRow>? ListType77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.AnyOf<global::Weave.TableAppendSpec, global::Weave.TablePopSpec, global::Weave.TableInsertSpec>>? ListType78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.AnyOf<string, int?>>? ListType79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.ProjectsInfoRes>? ListType80 { get; set; }
    }
}