
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
        public global::Weave.BodyFileCreateFileCreatePost? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallBatchEndMode? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallEndReq? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallBatchStartMode? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallStartReq? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallCreateBatchReq? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.AnyOf<global::Weave.CallBatchStartMode, global::Weave.CallBatchEndMode>>? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnyOf<global::Weave.CallBatchStartMode, global::Weave.CallBatchEndMode>? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallCreateBatchRes? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.AnyOf<global::Weave.CallStartRes, global::Weave.CallEndRes>>? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnyOf<global::Weave.CallStartRes, global::Weave.CallEndRes>? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallStartRes? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallEndRes? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EndedCallSchemaForInsert? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallMetricSpec? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallMetricSpecMetric? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.AggregationType>? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallReadReq? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallReadRes? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallSchema? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.StartedCallSchemaForInsert? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallStatsReq? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.UsageMetricSpec>? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.UsageMetricSpec? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.CallMetricSpec>? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallsFilter? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallStatsRes? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallUpdateReq? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallUpdateRes? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallsDeleteReq? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallsDeleteRes? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallsQueryReq? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallsQueryStatsReq? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallsQueryStatsRes? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallsScoreReq? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallsScoreRes? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallsUpsertCompleteReq? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.CompletedCallSchemaForInsert>? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CompletedCallSchemaForInsert? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallsUpsertCompleteRes? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallsUsageReq? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallsUsageRes? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, global::Weave.LLMAggregatedUsage>>? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Weave.LLMAggregatedUsage>? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.LLMAggregatedUsage? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CatalogModelsRes? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.LLMModelDetails>? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.LLMModelDetails? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.SummaryInsertMap? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ContainsSpec? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ConvertSpec? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ConvertSpecTo? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.Cost? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CostCreateInput? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CostCreateReq? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Weave.CostCreateInput>? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CostCreateRes? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CostPurgeReq? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CostPurgeRes? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CostQueryOutput? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CostQueryReq? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CostQueryRes? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.CostQueryOutput>? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CreateAndLinkPayload? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CreateAndLinkTarget? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CreateAndLinkWeaveAssetRes? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CustomRuntimeApplyBody? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.CustomRuntimeID>? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CustomRuntimeID? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CustomRuntimeApplyRes? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.CustomRuntimeIDRes>? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CustomRuntimeIDRes? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.Datacenter? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.DatasetCreateBody? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.DatasetCreateRes? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.DatasetDeleteRes? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.DatasetReadRes? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.DeletedObjVersion? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvalResultsEvaluationSummary? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.EvalResultsScorerStats>? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvalResultsScorerStats? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvalResultsFilter? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvalResultsQueryBody? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.EvalResultsSortBy>? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvalResultsSortBy? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.EvalResultsFilter>? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvalResultsQueryBodyFilterLogicOperator? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvalResultsQueryRes? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.EvalResultsRow>? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvalResultsRow? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvalResultsSummaryRes? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.EvalResultsRowEvaluation>? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvalResultsRowEvaluation? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.EvalResultsTrial>? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvalResultsTrial? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvalResultsScorerStatsValueType2? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvalResultsSortByDirection? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvalResultsSortByMode? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.EvalResultsEvaluationSummary>? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.GenAISpanRef>? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.GenAISpanRef? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvaluateModelReq? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvaluateModelRes? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvaluationCreateBody? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvaluationCreateRes? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvaluationDeleteRes? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvaluationReadRes? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvaluationRunCreateBody? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvaluationRunCreateRes? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvaluationRunDeleteRes? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvaluationRunFinishBody? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvaluationRunFinishRes? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvaluationRunReadRes? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvaluationStatusComplete? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvaluationStatusFailed? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvaluationStatusNotFound? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvaluationStatusReq? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvaluationStatusRes? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnyOf<global::Weave.EvaluationStatusNotFound, global::Weave.EvaluationStatusRunning, global::Weave.EvaluationStatusFailed, global::Weave.EvaluationStatusComplete>? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvaluationStatusRunning? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FeedbackAggregateBucket? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FeedbackAggregateReq? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.FeedbackAggregateReqSpanType>? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FeedbackAggregateReqSpanType? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.FeedbackAggregateReqGroupByItem>? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FeedbackAggregateReqGroupByItem? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FeedbackAggregateRes? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.FeedbackAggregateBucket>? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FeedbackCreateBatchReq? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.FeedbackCreateReq>? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FeedbackCreateReq? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FeedbackCreateBatchRes? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.FeedbackCreateRes>? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FeedbackCreateRes? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FeedbackMetricSpec? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FeedbackMetricSpecValueType? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FeedbackPayloadPath? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FeedbackPayloadPathValueType? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FeedbackPayloadSchemaReq? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FeedbackPayloadSchemaRes? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.FeedbackPayloadPath>? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FeedbackPurgeReq? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FeedbackPurgeRes? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FeedbackQueryReq? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FeedbackQueryRes? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FeedbackReplaceReq? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FeedbackReplaceRes? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FeedbackStatsReq? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.FeedbackMetricSpec>? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FeedbackStatsRes? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FileContentReadReq? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FileCreateRes? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FilesStatsReq? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FilesStatsRes? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.Geolocation? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.GeolocationRes? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.HTTPValidationError? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.ValidationError>? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ValidationError? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ImageGenerationCreateReq? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ImageGenerationRequestInputs? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ImageGenerationCreateRes? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.Interleaved? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.InterleavedField? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.LLMModelDetailsLifecycleStage? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.LLMModelDetailsAvailableInItem>? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.LLMModelDetailsAvailableInItem? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.LLMModelDetailsReasoningSupport? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.LLMModelDetailsReasoningEffort>? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.LLMModelDetailsReasoningEffort? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.LLMModelDetailsQuantization? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.LLMUsageSchema? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.Limit? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnyOf<string, int?, double?, bool?, global::System.Collections.Generic.Dictionary<string, global::Weave.LiteralOperation>, global::System.Collections.Generic.IList<global::Weave.LiteralOperation>, object>? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Weave.LiteralOperation>? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.LiteralOperation>? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.Modalities? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ModelCreateBody? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ModelCreateRes? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ModelDeleteRes? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ModelReadRes? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ModelsDevModel? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.AnyOf<global::Weave.ReasoningToggle, global::Weave.ReasoningEffortOption, global::Weave.ReasoningBudgetTokens>>? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnyOf<global::Weave.ReasoningToggle, global::Weave.ReasoningEffortOption, global::Weave.ReasoningBudgetTokens>? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ReasoningToggle? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ReasoningEffortOption? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ReasoningBudgetTokens? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ModelsDevModelStatus2? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnyOf<bool?, global::Weave.Interleaved, object>? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ModelsDevProvider? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Weave.ModelsDevModel>? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.NvidiaHardwareOption? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.NvidiaServerlessPricing? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.NvidiaHardwareRes? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.NvidiaHardwareOption>? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ObjAddTagsRes? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ObjCreateReq? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ObjSchemaForInsert? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ObjCreateRes? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ObjDeleteReq? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ObjDeleteRes? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.DeletedObjVersion>? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ObjQueryReq? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ObjectVersionFilter? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ObjQueryRes? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.ObjSchema>? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ObjSchema? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ObjReadReq? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ObjReadRes? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ObjRemoveAliasesBody? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ObjRemoveAliasesRes? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ObjRemoveTagsRes? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ObjSetAliasesBody? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ObjSetAliasesRes? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ObjTagsBody? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.OpCreateBody? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.OpCreateRes? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.OpDeleteRes? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.OpReadRes? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.PredictionCreateBody? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.PredictionCreateRes? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.PredictionDeleteRes? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.PredictionFinishRes? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.PredictionReadRes? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.Pricing? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ProjectsInfoReq? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ProjectsInfoRes? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.RatingConditionOp? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.ReasoningEffortOptionValue2>? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ReasoningEffortOptionValue2? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.RefsReadBatchReq? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.RefsReadBatchRes? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.RescoreReq? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.RescoreRes? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.RouterOpenRouterModel? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.RouterOpenRouterModelQuantization? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.RouterOpenRouterModelSupportedSamplingParameter>? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.RouterOpenRouterModelSupportedSamplingParameter? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.RouterOpenRouterModelSupportedFeature>? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.RouterOpenRouterModelSupportedFeature? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.Datacenter>? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.RouterOpenRouterModelsRes? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.RouterOpenRouterModel>? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ScoreCreateBody? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ScoreCreateRes? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ScoreDeleteRes? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ScoreReadRes? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ScorerCreateBody? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ScorerCreateRes? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ScorerDeleteRes? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ScorerReadRes? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ServerInfoRes? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.SortByDirection? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Weave.LLMUsageSchema>? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.TableAppendSpec? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.TableAppendSpecPayload? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.TableCreateFromDigestsReq? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.TableCreateFromDigestsRes? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.TableCreateReq? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.TableSchemaForInsert? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.TableCreateRes? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.TableInsertSpec? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.TableInsertSpecPayload? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.TablePopSpec? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.TablePopSpecPayload? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.TableQueryReq? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.TableRowFilter? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.TableQueryRes? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.TableRowSchema>? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.TableRowSchema? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.TableQueryStatsBatchReq? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.TableQueryStatsBatchRes? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.TableStatsRow>? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.TableStatsRow? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.TableQueryStatsReq? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.TableQueryStatsRes? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.TableUpdateReq? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.AnyOf<global::Weave.TableAppendSpec, global::Weave.TablePopSpec, global::Weave.TableInsertSpec>>? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnyOf<global::Weave.TableAppendSpec, global::Weave.TablePopSpec, global::Weave.TableInsertSpec>? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.TableUpdateRes? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.TagsListRes? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ThreadSchema? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ThreadsQueryFilter? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ThreadsQueryReq? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.TraceStatus? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.TraceUsageReq? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.TraceUsageRes? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.UsageMetricSpecMetric? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.AnyOf<string, int?>>? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnyOf<string, int?>? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Weave.ModelsDevProvider>? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.ProjectsInfoRes>? Type469 { get; set; }

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
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<string>>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.CostQueryOutput>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.CustomRuntimeID>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.CustomRuntimeIDRes>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.EvalResultsScorerStats>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.EvalResultsSortBy>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.EvalResultsFilter>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.EvalResultsRow>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.EvalResultsRowEvaluation>? ListType50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.EvalResultsTrial>? ListType51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.EvalResultsEvaluationSummary>? ListType52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.GenAISpanRef>? ListType53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.FeedbackAggregateReqSpanType>? ListType54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.FeedbackAggregateReqGroupByItem>? ListType55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.FeedbackAggregateBucket>? ListType56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.FeedbackCreateReq>? ListType57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.FeedbackCreateRes>? ListType58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.FeedbackPayloadPath>? ListType59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.FeedbackMetricSpec>? ListType60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.ValidationError>? ListType61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.LLMModelDetailsAvailableInItem>? ListType62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.LLMModelDetailsReasoningEffort>? ListType63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnyOf<string, int?, double?, bool?, global::System.Collections.Generic.Dictionary<string, global::Weave.LiteralOperation>, global::System.Collections.Generic.List<global::Weave.LiteralOperation>, object>? ListType64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.LiteralOperation>? ListType65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.AnyOf<global::Weave.ReasoningToggle, global::Weave.ReasoningEffortOption, global::Weave.ReasoningBudgetTokens>>? ListType66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.NvidiaHardwareOption>? ListType67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.DeletedObjVersion>? ListType68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.ObjSchema>? ListType69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.ReasoningEffortOptionValue2>? ListType70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.RouterOpenRouterModelSupportedSamplingParameter>? ListType71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.RouterOpenRouterModelSupportedFeature>? ListType72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.Datacenter>? ListType73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.RouterOpenRouterModel>? ListType74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.TableRowSchema>? ListType75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.TableStatsRow>? ListType76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.AnyOf<global::Weave.TableAppendSpec, global::Weave.TablePopSpec, global::Weave.TableInsertSpec>>? ListType77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.AnyOf<string, int?>>? ListType78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.ProjectsInfoRes>? ListType79 { get; set; }
    }
}