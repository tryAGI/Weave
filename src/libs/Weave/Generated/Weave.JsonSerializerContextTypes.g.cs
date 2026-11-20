
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
        /// String arrays used by dynamic JSON option values.
        /// </summary>
        public string[]? StringArray { get; set; }

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
        public global::System.Collections.Generic.IList<global::Weave.AgentSortBy>? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSortBy? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentConversationChatRes? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.AgentTraceChatRes>? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentTraceChatRes? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentConversationMessagePreview? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentConversationMessagePreviewRole? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentConversationSpan? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentConversationSpanStatus? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentConversationSpanFeedback? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentConversationSpanFeedbackFeedbackType? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.AgentConversationSpanRating>? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentConversationSpanRating? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentConversationSpans? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.AgentConversationSpan>? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.AgentConversationSpanFeedback>? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentConversationSpansReq? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentConversationSpansRes? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.AgentConversationSpans>? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentConversationTagFilter? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Guid>? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Guid? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentCustomAttrSchemaItem? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentCustomAttrSchemaItemSource? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentCustomAttrSchemaItemValueType? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentCustomAttrsSchemaReq? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.Query? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentCustomAttrsSchemaRes? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.AgentCustomAttrSchemaItem>? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentGroupByRef? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentGroupByRefSource? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentInsightFilter? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentInsightFilterField? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSchema? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSearchConversationResult? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.AgentSearchMatchedMessage>? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSearchMatchedMessage? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnyOf<global::Weave.AgentSearchMatchedMessageRole?, string>? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSearchMatchedMessageRole? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSearchReq? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.AgentSearchReqRolesVariant1Item>? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSearchReqRolesVariant1Item? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSearchRes? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.AgentSearchConversationResult>? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSignalFilter? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.RatingCondition>? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.RatingCondition? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSortByDirection? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSpanGroupDistributionBin? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSpanGroupDistributionItem? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSpanGroupDistributionItemSource? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSpanGroupDistributionItemValueType? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.AgentSpanGroupDistributionBin>? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.AgentSpanGroupDistributionValue>? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSpanGroupDistributionValue? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSpanGroupDistributionSpec? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSpanValueRef? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSpanGroupFilter? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.AgentGroupByRef>? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSpanMeasureSpec? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnyOf<double?, global::System.DateTime?>? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSpanGroupRow? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnyOf<string, int?, double?, bool?>? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnyOf<global::System.DateTime?, string, int?, double?, bool?>? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Weave.AgentSpanGroupDistributionItem>? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSpanMeasureSpecAggregation? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSpanMeasureSpecValueType? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSpanSchema? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSpanSchemaSpanKind? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSpanSchemaStatusCode? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.NormalizedMessage>? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.NormalizedMessage? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, int>? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, bool>? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSpanStatsColumn? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSpanStatsColumnRole? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSpanStatsColumnValueType? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSpanStatsMetricSpec? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSpanStatsMetricSpecValueType? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.AgentSpanStatsMetricSpecAggregation>? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSpanStatsMetricSpecAggregation? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<double>? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSpanStatsNumericBucketSpec? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSpanStatsReq? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.AgentSpanStatsMetricSpec>? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.BucketByVariant1? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSpanStatsTimeBucketSpec? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSpanStatsReqBucketByVariant1Discriminator? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSpanStatsReqBucketByVariant1DiscriminatorType? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.AgentSpanGroupFilter>? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.AgentInsightFilter>? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSpanStatsRes? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSpanStatsResBucketType? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.AgentSpanStatsColumn>? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSpanValueRefSource? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSpansExistsReq? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSpansExistsRes? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSpansQueryReq? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.AgentSpanMeasureSpec>? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.AgentSpanGroupDistributionSpec>? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.AgentSpanValueRef>? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentSpansQueryRes? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.AgentSpanSchema>? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.AgentSpanGroupRow>? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentTraceChatReq? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentTraceChatResStatusCode? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.AgentChatMessage>? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentVersionSchema? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentVersionsQueryReq? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentVersionsQueryRes? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.AgentVersionSchema>? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentsQueryFilters? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentsQueryReq? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AgentsQueryRes? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.AgentSchema>? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AggregationType? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AliasesListRes? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AndOperation? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.LiteralOperation? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.GetFieldOperator? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ConvertOperation? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.SizeOperation? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.OrOperation? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.NotOperation? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EqOperation? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.GtOperation? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.LtOperation? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.GteOperation? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.LteOperation? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.InOperation? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ContainsOperation? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnnotationQueueAddCallsBody? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnnotationQueueAddCallsRes? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnnotationQueueCreateReq? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnnotationQueueCreateRes? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnnotationQueueDeleteRes? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnnotationQueueSchema? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnnotationQueueItemProgressUpdateBody? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnnotationQueueItemSchema? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnnotationQueueItemSchemaAnnotationState? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnnotationQueueItemsFilter? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.AnnotationQueueItemsFilterAnnotationStatesVariant1Item>? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnnotationQueueItemsFilterAnnotationStatesVariant1Item? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnnotationQueueItemsQueryBody? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.SortBy>? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.SortBy? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnnotationQueueItemsQueryRes? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.AnnotationQueueItemSchema>? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnnotationQueueReadRes? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnnotationQueueStatsSchema? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnnotationQueueUpdateBody? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnnotationQueueUpdateRes? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnnotationQueuesQueryReq? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnnotationQueuesStatsReq? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnnotationQueuesStatsRes? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.AnnotationQueueStatsSchema>? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnnotatorQueueItemsProgressUpdateRes? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.BaseModel? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.BodyFileCreateFileCreatePost? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallBatchEndMode? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallEndReq? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallBatchStartMode? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallStartReq? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallCreateBatchReq? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.AnyOf<global::Weave.CallBatchStartMode, global::Weave.CallBatchEndMode>>? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnyOf<global::Weave.CallBatchStartMode, global::Weave.CallBatchEndMode>? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallCreateBatchRes? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.AnyOf<global::Weave.CallStartRes, global::Weave.CallEndRes>>? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnyOf<global::Weave.CallStartRes, global::Weave.CallEndRes>? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallStartRes? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallEndRes? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EndedCallSchemaForInsert? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallMetricSpec? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallMetricSpecMetric? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.AggregationType>? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallReadReq? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallReadRes? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallSchema? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.StartedCallSchemaForInsert? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallStatsReq? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.UsageMetricSpec>? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.UsageMetricSpec? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.CallMetricSpec>? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallsFilter? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallStatsRes? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallUpdateReq? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallUpdateRes? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallsDeleteReq? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallsDeleteRes? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallsQueryReq? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallsQueryStatsReq? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallsQueryStatsRes? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallsScoreReq? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallsScoreRes? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallsUpsertCompleteReq? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.CompletedCallSchemaForInsert>? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CompletedCallSchemaForInsert? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallsUpsertCompleteRes? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallsUsageReq? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CallsUsageRes? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, global::Weave.LLMAggregatedUsage>>? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Weave.LLMAggregatedUsage>? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.LLMAggregatedUsage? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CatalogModelsRes? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.LLMModelDetails>? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.LLMModelDetails? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.SummaryInsertMap? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CompletionsCreateReq? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CompletionsCreateRequestInputs? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.DedicatedInferenceRoute? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnyOf<double?, string>? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnyOf<string, global::System.Collections.Generic.IList<object>>? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnyOf<string, object>? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CompletionsCreateRes? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CompletionsCreateStreamChunk? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CompletionsCreateStreamMeta? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ContainsSpec? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ConvertSpec? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ConvertSpecTo? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.Cost? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CostCreateInput? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CostCreateReq? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Weave.CostCreateInput>? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CostCreateRes? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CostPurgeReq? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CostPurgeRes? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CostQueryOutput? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CostQueryReq? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CostQueryRes? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.CostQueryOutput>? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CreateAndLinkPayload? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CreateAndLinkTarget? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CreateAndLinkWeaveAssetRes? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CustomRuntimeApplyBody? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.CustomRuntimeID>? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CustomRuntimeID? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CustomRuntimeApplyRes? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.CustomRuntimeIDRes>? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.CustomRuntimeIDRes? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.Datacenter? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.DatasetCreateBody? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.DatasetCreateRes? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.DatasetDeleteRes? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.DatasetReadRes? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.DatasetSourceLinkPayload? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.SourceRef>? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.SourceRef? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.DatasetSourceLinkSchema? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.SourceKind? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.DatasetSourcesLinkReq? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.DatasetSourceLinkPayload>? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.DatasetSourcesLinkRes? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.DatasetSourcesLinkResEntry>? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.DatasetSourcesLinkResEntry? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.DatasetSourcesQueryReq? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.SourceKind>? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.DatasetSourcesQueryRes? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.DatasetSourceLinkSchema>? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.DeletedObjVersion? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvalResultsEvaluationSummary? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.EvalResultsScorerStats>? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvalResultsScorerStats? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvalResultsFilter? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvalResultsQueryBody? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.EvalResultsSortBy>? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvalResultsSortBy? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.EvalResultsFilter>? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvalResultsQueryBodyFilterLogicOperator? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvalResultsQueryRes? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.EvalResultsRow>? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvalResultsRow? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvalResultsSummaryRes? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.EvalResultsRowEvaluation>? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvalResultsRowEvaluation? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.EvalResultsTrial>? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvalResultsTrial? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvalResultsScorerStatsValueType? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvalResultsSortByDirection? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvalResultsSortByMode? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.EvalResultsEvaluationSummary>? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.GenAISpanRef>? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.GenAISpanRef? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvaluateModelReq? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvaluateModelRes? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvaluationCreateBody? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvaluationCreateRes? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvaluationDeleteRes? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvaluationReadRes? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvaluationRunCreateBody? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvaluationRunCreateRes? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvaluationRunDeleteRes? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvaluationRunFinishBody? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvaluationRunFinishRes? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvaluationRunReadRes? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvaluationStatusComplete? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvaluationStatusFailed? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvaluationStatusNotFound? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvaluationStatusReq? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvaluationStatusRes? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnyOf<global::Weave.EvaluationStatusNotFound, global::Weave.EvaluationStatusRunning, global::Weave.EvaluationStatusFailed, global::Weave.EvaluationStatusComplete>? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.EvaluationStatusRunning? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ExportAuthorizationErrorResponse? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ExportBody? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.ExportBodyTarget>? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ExportBodyTarget? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ExportErrorResponse? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.JobFailure? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ExportStartedResponse? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ExportStatusResponse? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ExportStatusResponseState? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.JobArtifact>? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.JobArtifact? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FeedbackAggregateBucket? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FeedbackAggregateReq? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.FeedbackAggregateReqSpanType>? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FeedbackAggregateReqSpanType? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.FeedbackAggregateReqGroupByItem>? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FeedbackAggregateReqGroupByItem? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FeedbackAggregateRes? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.FeedbackAggregateBucket>? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FeedbackCreateBatchReq? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.FeedbackCreateReq>? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FeedbackCreateReq? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FeedbackCreateBatchRes? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.FeedbackCreateRes>? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FeedbackCreateRes? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FeedbackMetricSpec? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FeedbackMetricSpecValueType? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FeedbackPayloadPath? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FeedbackPayloadPathValueType? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FeedbackPayloadSchemaReq? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FeedbackPayloadSchemaRes? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.FeedbackPayloadPath>? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FeedbackPurgeReq? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FeedbackPurgeRes? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FeedbackQueryReq? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FeedbackQueryRes? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FeedbackReplaceReq? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FeedbackReplaceRes? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FeedbackStatsReq? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.FeedbackMetricSpec>? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FeedbackStatsRes? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FileContentReadReq? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FileCreateRes? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FilesResolveUrlReq? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FilesStatsReq? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.FilesStatsRes? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.Geolocation? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.GeolocationRes? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.HTTPValidationError? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.ValidationError>? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ValidationError? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ImageGenerationCreateReq? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ImageGenerationRequestInputs? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ImageGenerationCreateRes? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.Interleaved? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.InterleavedField? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.LLMModelDetailsLifecycleStage? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.LLMModelDetailsAvailableInItem>? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.LLMModelDetailsAvailableInItem? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.LLMModelDetailsReasoningSupport? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.LLMModelDetailsReasoningEffort>? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.LLMModelDetailsReasoningEffort? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.LLMModelDetailsQuantization? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.LLMUsageSchema? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.Limit? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnyOf<string, int?, double?, bool?, global::System.Collections.Generic.Dictionary<string, global::Weave.LiteralOperation>, global::System.Collections.Generic.IList<global::Weave.LiteralOperation>>? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Weave.LiteralOperation>? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.LiteralOperation>? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.Modalities? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ModelCreateBody? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ModelCreateRes? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ModelDeleteRes? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ModelReadRes? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ModelsDevModel? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.AnyOf<global::Weave.ReasoningToggle, global::Weave.ReasoningEffortOption, global::Weave.ReasoningBudgetTokens>>? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnyOf<global::Weave.ReasoningToggle, global::Weave.ReasoningEffortOption, global::Weave.ReasoningBudgetTokens>? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ReasoningToggle? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ReasoningEffortOption? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ReasoningBudgetTokens? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ModelsDevModelStatus? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnyOf<bool?, global::Weave.Interleaved>? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ModelsDevProvider? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Weave.ModelsDevModel>? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.NvidiaHardwareOption? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.NvidiaServerlessPricing? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.NvidiaHardwareRes? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.NvidiaHardwareOption>? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ObjAddTagsRes? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ObjCreateReq? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ObjSchemaForInsert? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ObjCreateRes? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ObjDeleteReq? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ObjDeleteRes? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.DeletedObjVersion>? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ObjQueryReq? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ObjectVersionFilter? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ObjQueryRes? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.ObjSchema>? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ObjSchema? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ObjReadReq? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ObjReadRes? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ObjRemoveAliasesBody? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ObjRemoveAliasesRes? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ObjRemoveTagsRes? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ObjSetAliasesBody? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ObjSetAliasesRes? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ObjTagsBody? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.OpCreateBody? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.OpCreateRes? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.OpDeleteRes? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.OpReadRes? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.PredictionCreateBody? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.PredictionCreateRes? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.PredictionDeleteRes? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.PredictionFinishRes? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.PredictionReadRes? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.Pricing? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ProjectIngestSamplingSettingsReadReq? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ProjectIngestSamplingSettingsReadRes? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ProjectSensitiveDataSettingsReadRes? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.SensitiveDataPolicy? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ProjectStatsReq? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ProjectStatsRes? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ProjectTTLSettingsReadReq? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ProjectTTLSettingsReadRes? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ProjectTTLSettingsUpdateReq? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ProjectTTLSettingsUpdateRes? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ProjectsInfoReq? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ProjectsInfoRes? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.RatingConditionOp? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.ReasoningEffortOptionValue?>? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ReasoningEffortOptionValue? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ReferenceResolveRes? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.RefsReadBatchReq? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.RefsReadBatchRes? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.RescoreReq? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.RescoreRes? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.RouterOpenRouterModel? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.RouterOpenRouterModelQuantization? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.RouterOpenRouterModelSupportedSamplingParameter>? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.RouterOpenRouterModelSupportedSamplingParameter? Type470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.RouterOpenRouterModelSupportedFeature>? Type471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.RouterOpenRouterModelSupportedFeature? Type472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.Datacenter>? Type473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.RouterOpenRouterModelsRes? Type474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.RouterOpenRouterModel>? Type475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ScoreCreateBody? Type476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ScoreCreateRes? Type477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ScoreDeleteRes? Type478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ScoreReadRes? Type479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ScorerCreateBody? Type480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ScorerCreateRes? Type481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ScorerDeleteRes? Type482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ScorerReadRes? Type483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ServerInfoRes? Type484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.SortByDirection? Type485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.SourceDatasetMembership? Type486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.SourceDatasetsQueryReq? Type487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.SourceDatasetsQueryRes? Type488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.SourceDatasetMembership>? Type489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Weave.LLMUsageSchema>? Type490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.TableAppendSpec? Type491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.TableAppendSpecPayload? Type492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.TableCreateFromDigestsReq? Type493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.TableCreateFromDigestsRes? Type494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.TableCreateReq? Type495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.TableSchemaForInsert? Type496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.TableCreateRes? Type497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.TableInsertSpec? Type498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.TableInsertSpecPayload? Type499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.TablePopSpec? Type500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.TablePopSpecPayload? Type501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.TableQueryReq? Type502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.TableRowFilter? Type503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.TableQueryRes? Type504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.TableRowSchema>? Type505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.TableRowSchema? Type506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.TableQueryStatsBatchReq? Type507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.TableQueryStatsBatchRes? Type508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.TableStatsRow>? Type509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.TableStatsRow? Type510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.TableQueryStatsReq? Type511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.TableQueryStatsRes? Type512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.TableUpdateReq? Type513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.AnyOf<global::Weave.TableAppendSpec, global::Weave.TablePopSpec, global::Weave.TableInsertSpec>>? Type514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnyOf<global::Weave.TableAppendSpec, global::Weave.TablePopSpec, global::Weave.TableInsertSpec>? Type515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.TableUpdateRes? Type516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.TagsListRes? Type517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ThreadSchema? Type518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ThreadsQueryFilter? Type519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.ThreadsQueryReq? Type520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.TraceStatus? Type521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.TraceUsageReq? Type522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.TraceUsageRes? Type523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.UsageMetricSpecMetric? Type524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.AnyOf<string, int?>>? Type525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnyOf<string, int?>? Type526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Weave.ModelsDevProvider>? Type527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weave.ProjectsInfoRes>? Type528 { get; set; }

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
        public global::System.Collections.Generic.List<global::Weave.AgentSortBy>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.AgentTraceChatRes>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.AgentConversationSpanRating>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.AgentConversationSpan>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.AgentConversationSpanFeedback>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.AgentConversationSpans>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Guid>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.AgentCustomAttrSchemaItem>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.AgentSearchMatchedMessage>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.AgentSearchReqRolesVariant1Item>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.AgentSearchConversationResult>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.RatingCondition>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.AgentSpanGroupDistributionBin>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.AgentSpanGroupDistributionValue>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.AgentGroupByRef>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.NormalizedMessage>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.AgentSpanStatsMetricSpecAggregation>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<double>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.AgentSpanStatsMetricSpec>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.AgentSpanGroupFilter>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.AgentInsightFilter>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.AgentSpanStatsColumn>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<object>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.AgentSpanMeasureSpec>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.AgentSpanGroupDistributionSpec>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.AgentSpanValueRef>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.AgentSpanSchema>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.AgentSpanGroupRow>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.AgentChatMessage>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.AgentVersionSchema>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.AgentSchema>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.AnnotationQueueItemsFilterAnnotationStatesVariant1Item>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.SortBy>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.AnnotationQueueItemSchema>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.AnnotationQueueStatsSchema>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.AnyOf<global::Weave.CallBatchStartMode, global::Weave.CallBatchEndMode>>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.AnyOf<global::Weave.CallStartRes, global::Weave.CallEndRes>>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.AggregationType>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.UsageMetricSpec>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.CallMetricSpec>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.CompletedCallSchemaForInsert>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.LLMModelDetails>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnyOf<string, global::System.Collections.Generic.List<object>>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<string>>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.CostQueryOutput>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.CustomRuntimeID>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.CustomRuntimeIDRes>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.SourceRef>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.DatasetSourceLinkPayload>? ListType50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.DatasetSourcesLinkResEntry>? ListType51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.SourceKind>? ListType52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.DatasetSourceLinkSchema>? ListType53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.EvalResultsScorerStats>? ListType54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.EvalResultsSortBy>? ListType55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.EvalResultsFilter>? ListType56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.EvalResultsRow>? ListType57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.EvalResultsRowEvaluation>? ListType58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.EvalResultsTrial>? ListType59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.EvalResultsEvaluationSummary>? ListType60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.GenAISpanRef>? ListType61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.ExportBodyTarget>? ListType62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.JobArtifact>? ListType63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.FeedbackAggregateReqSpanType>? ListType64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.FeedbackAggregateReqGroupByItem>? ListType65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.FeedbackAggregateBucket>? ListType66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.FeedbackCreateReq>? ListType67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.FeedbackCreateRes>? ListType68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.FeedbackPayloadPath>? ListType69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.FeedbackMetricSpec>? ListType70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.ValidationError>? ListType71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.LLMModelDetailsAvailableInItem>? ListType72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.LLMModelDetailsReasoningEffort>? ListType73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weave.AnyOf<string, int?, double?, bool?, global::System.Collections.Generic.Dictionary<string, global::Weave.LiteralOperation>, global::System.Collections.Generic.List<global::Weave.LiteralOperation>>? ListType74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.LiteralOperation>? ListType75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.AnyOf<global::Weave.ReasoningToggle, global::Weave.ReasoningEffortOption, global::Weave.ReasoningBudgetTokens>>? ListType76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.NvidiaHardwareOption>? ListType77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.DeletedObjVersion>? ListType78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.ObjSchema>? ListType79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.ReasoningEffortOptionValue?>? ListType80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.RouterOpenRouterModelSupportedSamplingParameter>? ListType81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.RouterOpenRouterModelSupportedFeature>? ListType82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.Datacenter>? ListType83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.RouterOpenRouterModel>? ListType84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.SourceDatasetMembership>? ListType85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.TableRowSchema>? ListType86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.TableStatsRow>? ListType87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.AnyOf<global::Weave.TableAppendSpec, global::Weave.TablePopSpec, global::Weave.TableInsertSpec>>? ListType88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.AnyOf<string, int?>>? ListType89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weave.ProjectsInfoRes>? ListType90 { get; set; }
    }
}