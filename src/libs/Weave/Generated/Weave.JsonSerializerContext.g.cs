
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Weave
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Weave.JsonConverters.AgentChatAgentStartStatus2JsonConverter),

            typeof(global::Weave.JsonConverters.AgentChatAgentStartStatus2NullableJsonConverter),

            typeof(global::Weave.JsonConverters.AgentChatAssistantMessageStatus2JsonConverter),

            typeof(global::Weave.JsonConverters.AgentChatAssistantMessageStatus2NullableJsonConverter),

            typeof(global::Weave.JsonConverters.AgentChatMessageTypeJsonConverter),

            typeof(global::Weave.JsonConverters.AgentChatMessageTypeNullableJsonConverter),

            typeof(global::Weave.JsonConverters.AgentChatToolCallStatus2JsonConverter),

            typeof(global::Weave.JsonConverters.AgentChatToolCallStatus2NullableJsonConverter),

            typeof(global::Weave.JsonConverters.AgentCustomAttrSchemaItemSourceJsonConverter),

            typeof(global::Weave.JsonConverters.AgentCustomAttrSchemaItemSourceNullableJsonConverter),

            typeof(global::Weave.JsonConverters.AgentCustomAttrSchemaItemValueTypeJsonConverter),

            typeof(global::Weave.JsonConverters.AgentCustomAttrSchemaItemValueTypeNullableJsonConverter),

            typeof(global::Weave.JsonConverters.AgentGroupByRefSourceJsonConverter),

            typeof(global::Weave.JsonConverters.AgentGroupByRefSourceNullableJsonConverter),

            typeof(global::Weave.JsonConverters.AgentSearchMatchedMessageRoleJsonConverter),

            typeof(global::Weave.JsonConverters.AgentSearchMatchedMessageRoleNullableJsonConverter),

            typeof(global::Weave.JsonConverters.AgentSearchReqRolesVariant1ItemJsonConverter),

            typeof(global::Weave.JsonConverters.AgentSearchReqRolesVariant1ItemNullableJsonConverter),

            typeof(global::Weave.JsonConverters.AgentSortByDirectionJsonConverter),

            typeof(global::Weave.JsonConverters.AgentSortByDirectionNullableJsonConverter),

            typeof(global::Weave.JsonConverters.AgentSpanGroupDistributionItemSourceJsonConverter),

            typeof(global::Weave.JsonConverters.AgentSpanGroupDistributionItemSourceNullableJsonConverter),

            typeof(global::Weave.JsonConverters.AgentSpanGroupDistributionItemValueTypeJsonConverter),

            typeof(global::Weave.JsonConverters.AgentSpanGroupDistributionItemValueTypeNullableJsonConverter),

            typeof(global::Weave.JsonConverters.AgentSpanMeasureSpecAggregationJsonConverter),

            typeof(global::Weave.JsonConverters.AgentSpanMeasureSpecAggregationNullableJsonConverter),

            typeof(global::Weave.JsonConverters.AgentSpanMeasureSpecValueType2JsonConverter),

            typeof(global::Weave.JsonConverters.AgentSpanMeasureSpecValueType2NullableJsonConverter),

            typeof(global::Weave.JsonConverters.AgentSpanSchemaSpanKind2JsonConverter),

            typeof(global::Weave.JsonConverters.AgentSpanSchemaSpanKind2NullableJsonConverter),

            typeof(global::Weave.JsonConverters.AgentSpanSchemaStatusCode2JsonConverter),

            typeof(global::Weave.JsonConverters.AgentSpanSchemaStatusCode2NullableJsonConverter),

            typeof(global::Weave.JsonConverters.AgentSpanStatsColumnRoleJsonConverter),

            typeof(global::Weave.JsonConverters.AgentSpanStatsColumnRoleNullableJsonConverter),

            typeof(global::Weave.JsonConverters.AgentSpanStatsColumnValueTypeJsonConverter),

            typeof(global::Weave.JsonConverters.AgentSpanStatsColumnValueTypeNullableJsonConverter),

            typeof(global::Weave.JsonConverters.AgentSpanStatsMetricSpecValueTypeJsonConverter),

            typeof(global::Weave.JsonConverters.AgentSpanStatsMetricSpecValueTypeNullableJsonConverter),

            typeof(global::Weave.JsonConverters.AgentSpanStatsMetricSpecAggregationJsonConverter),

            typeof(global::Weave.JsonConverters.AgentSpanStatsMetricSpecAggregationNullableJsonConverter),

            typeof(global::Weave.JsonConverters.AgentSpanStatsReqBucketByVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Weave.JsonConverters.AgentSpanStatsReqBucketByVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Weave.JsonConverters.AgentSpanStatsResBucketTypeJsonConverter),

            typeof(global::Weave.JsonConverters.AgentSpanStatsResBucketTypeNullableJsonConverter),

            typeof(global::Weave.JsonConverters.AgentSpanValueRefSourceJsonConverter),

            typeof(global::Weave.JsonConverters.AgentSpanValueRefSourceNullableJsonConverter),

            typeof(global::Weave.JsonConverters.AggregationTypeJsonConverter),

            typeof(global::Weave.JsonConverters.AggregationTypeNullableJsonConverter),

            typeof(global::Weave.JsonConverters.AnnotationQueueItemSchemaAnnotationStateJsonConverter),

            typeof(global::Weave.JsonConverters.AnnotationQueueItemSchemaAnnotationStateNullableJsonConverter),

            typeof(global::Weave.JsonConverters.AnnotationQueueItemsFilterAnnotationStatesVariant1ItemJsonConverter),

            typeof(global::Weave.JsonConverters.AnnotationQueueItemsFilterAnnotationStatesVariant1ItemNullableJsonConverter),

            typeof(global::Weave.JsonConverters.CallMetricSpecMetricJsonConverter),

            typeof(global::Weave.JsonConverters.CallMetricSpecMetricNullableJsonConverter),

            typeof(global::Weave.JsonConverters.ConvertSpecToJsonConverter),

            typeof(global::Weave.JsonConverters.ConvertSpecToNullableJsonConverter),

            typeof(global::Weave.JsonConverters.EvalResultsScorerStatsValueType2JsonConverter),

            typeof(global::Weave.JsonConverters.EvalResultsScorerStatsValueType2NullableJsonConverter),

            typeof(global::Weave.JsonConverters.EvalResultsSortByDirectionJsonConverter),

            typeof(global::Weave.JsonConverters.EvalResultsSortByDirectionNullableJsonConverter),

            typeof(global::Weave.JsonConverters.EvalResultsSortByModeJsonConverter),

            typeof(global::Weave.JsonConverters.EvalResultsSortByModeNullableJsonConverter),

            typeof(global::Weave.JsonConverters.FeedbackMetricSpecValueTypeJsonConverter),

            typeof(global::Weave.JsonConverters.FeedbackMetricSpecValueTypeNullableJsonConverter),

            typeof(global::Weave.JsonConverters.FeedbackPayloadPathValueTypeJsonConverter),

            typeof(global::Weave.JsonConverters.FeedbackPayloadPathValueTypeNullableJsonConverter),

            typeof(global::Weave.JsonConverters.LLMModelDetailsLifecycleStageJsonConverter),

            typeof(global::Weave.JsonConverters.LLMModelDetailsLifecycleStageNullableJsonConverter),

            typeof(global::Weave.JsonConverters.LLMModelDetailsAvailableInItemJsonConverter),

            typeof(global::Weave.JsonConverters.LLMModelDetailsAvailableInItemNullableJsonConverter),

            typeof(global::Weave.JsonConverters.LLMModelDetailsQuantizationJsonConverter),

            typeof(global::Weave.JsonConverters.LLMModelDetailsQuantizationNullableJsonConverter),

            typeof(global::Weave.JsonConverters.RouterOpenRouterModelQuantizationJsonConverter),

            typeof(global::Weave.JsonConverters.RouterOpenRouterModelQuantizationNullableJsonConverter),

            typeof(global::Weave.JsonConverters.RouterOpenRouterModelSupportedSamplingParameterJsonConverter),

            typeof(global::Weave.JsonConverters.RouterOpenRouterModelSupportedSamplingParameterNullableJsonConverter),

            typeof(global::Weave.JsonConverters.RouterOpenRouterModelSupportedFeatureJsonConverter),

            typeof(global::Weave.JsonConverters.RouterOpenRouterModelSupportedFeatureNullableJsonConverter),

            typeof(global::Weave.JsonConverters.SortByDirectionJsonConverter),

            typeof(global::Weave.JsonConverters.SortByDirectionNullableJsonConverter),

            typeof(global::Weave.JsonConverters.TraceStatusJsonConverter),

            typeof(global::Weave.JsonConverters.TraceStatusNullableJsonConverter),

            typeof(global::Weave.JsonConverters.UsageMetricSpecMetricJsonConverter),

            typeof(global::Weave.JsonConverters.UsageMetricSpecMetricNullableJsonConverter),

            typeof(global::Weave.JsonConverters.BucketByVariant1JsonConverter),

            typeof(global::Weave.JsonConverters.AnyOfJsonConverter<double?, global::System.DateTime?, object>),

            typeof(global::Weave.JsonConverters.AnyOfJsonConverter<double?, global::System.DateTime?, object>),

            typeof(global::Weave.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?, object>),

            typeof(global::Weave.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string, int?, double?, bool?, object>),

            typeof(global::Weave.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string, int?, double?, bool?, object>),

            typeof(global::Weave.JsonConverters.AnyOfJsonConverter<global::Weave.LiteralOperation, global::Weave.GetFieldOperator, global::Weave.ConvertOperation, global::Weave.AndOperation, global::Weave.OrOperation, global::Weave.NotOperation, global::Weave.EqOperation, global::Weave.GtOperation, global::Weave.LtOperation, global::Weave.GteOperation, global::Weave.LteOperation, global::Weave.InOperation, global::Weave.ContainsOperation>),

            typeof(global::Weave.JsonConverters.AnyOfJsonConverter<global::Weave.CallBatchStartMode, global::Weave.CallBatchEndMode>),

            typeof(global::Weave.JsonConverters.AnyOfJsonConverter<global::Weave.CallStartRes, global::Weave.CallEndRes>),

            typeof(global::Weave.JsonConverters.AnyOfJsonConverter<global::Weave.LiteralOperation, global::Weave.GetFieldOperator, global::Weave.ConvertOperation, global::Weave.AndOperation, global::Weave.OrOperation, global::Weave.NotOperation, global::Weave.EqOperation, global::Weave.GtOperation, global::Weave.LtOperation, global::Weave.GteOperation, global::Weave.LteOperation, global::Weave.InOperation, global::Weave.ContainsOperation>),

            typeof(global::Weave.JsonConverters.AnyOfJsonConverter<global::Weave.LiteralOperation, global::Weave.GetFieldOperator, global::Weave.ConvertOperation, global::Weave.AndOperation, global::Weave.OrOperation, global::Weave.NotOperation, global::Weave.EqOperation, global::Weave.GtOperation, global::Weave.LtOperation, global::Weave.GteOperation, global::Weave.LteOperation, global::Weave.InOperation, global::Weave.ContainsOperation>),

            typeof(global::Weave.JsonConverters.AnyOfJsonConverter<global::Weave.LiteralOperation, global::Weave.GetFieldOperator, global::Weave.ConvertOperation, global::Weave.AndOperation, global::Weave.OrOperation, global::Weave.NotOperation, global::Weave.EqOperation, global::Weave.GtOperation, global::Weave.LtOperation, global::Weave.GteOperation, global::Weave.LteOperation, global::Weave.InOperation, global::Weave.ContainsOperation>),

            typeof(global::Weave.JsonConverters.AnyOfJsonConverter<global::Weave.LiteralOperation, global::Weave.GetFieldOperator, global::Weave.ConvertOperation, global::Weave.AndOperation, global::Weave.OrOperation, global::Weave.NotOperation, global::Weave.EqOperation, global::Weave.GtOperation, global::Weave.LtOperation, global::Weave.GteOperation, global::Weave.LteOperation, global::Weave.InOperation, global::Weave.ContainsOperation>),

            typeof(global::Weave.JsonConverters.AnyOfJsonConverter<global::Weave.LiteralOperation, global::Weave.GetFieldOperator, global::Weave.ConvertOperation, global::Weave.AndOperation, global::Weave.OrOperation, global::Weave.NotOperation, global::Weave.EqOperation, global::Weave.GtOperation, global::Weave.LtOperation, global::Weave.GteOperation, global::Weave.LteOperation, global::Weave.InOperation, global::Weave.ContainsOperation>),

            typeof(global::Weave.JsonConverters.AnyOfJsonConverter<global::Weave.EvaluationStatusNotFound, global::Weave.EvaluationStatusRunning, global::Weave.EvaluationStatusFailed, global::Weave.EvaluationStatusComplete>),

            typeof(global::Weave.JsonConverters.AnyOfJsonConverter<global::Weave.LiteralOperation, global::Weave.GetFieldOperator, global::Weave.ConvertOperation, global::Weave.AndOperation, global::Weave.OrOperation, global::Weave.NotOperation, global::Weave.EqOperation, global::Weave.GtOperation, global::Weave.LtOperation, global::Weave.GteOperation, global::Weave.LteOperation, global::Weave.InOperation, global::Weave.ContainsOperation>),

            typeof(global::Weave.JsonConverters.AnyOfJsonConverter<global::Weave.LiteralOperation, global::Weave.GetFieldOperator, global::Weave.ConvertOperation, global::Weave.AndOperation, global::Weave.OrOperation, global::Weave.NotOperation, global::Weave.EqOperation, global::Weave.GtOperation, global::Weave.LtOperation, global::Weave.GteOperation, global::Weave.LteOperation, global::Weave.InOperation, global::Weave.ContainsOperation>),

            typeof(global::Weave.JsonConverters.AnyOfJsonConverter<global::Weave.LiteralOperation, global::Weave.GetFieldOperator, global::Weave.ConvertOperation, global::Weave.AndOperation, global::Weave.OrOperation, global::Weave.NotOperation, global::Weave.EqOperation, global::Weave.GtOperation, global::Weave.LtOperation, global::Weave.GteOperation, global::Weave.LteOperation, global::Weave.InOperation, global::Weave.ContainsOperation>),

            typeof(global::Weave.JsonConverters.AnyOfJsonConverter<global::Weave.LiteralOperation, global::Weave.GetFieldOperator, global::Weave.ConvertOperation, global::Weave.AndOperation, global::Weave.OrOperation, global::Weave.NotOperation, global::Weave.EqOperation, global::Weave.GtOperation, global::Weave.LtOperation, global::Weave.GteOperation, global::Weave.LteOperation, global::Weave.InOperation, global::Weave.ContainsOperation>),

            typeof(global::Weave.JsonConverters.AnyOfJsonConverter<global::Weave.AnyOf<global::Weave.LiteralOperation, global::Weave.GetFieldOperator, global::Weave.ConvertOperation, global::Weave.AndOperation, global::Weave.OrOperation, global::Weave.NotOperation, global::Weave.EqOperation, global::Weave.GtOperation, global::Weave.LtOperation, global::Weave.GteOperation, global::Weave.LteOperation, global::Weave.InOperation, global::Weave.ContainsOperation>?, global::System.Collections.Generic.IList<global::Weave.AnyOf<global::Weave.LiteralOperation, global::Weave.GetFieldOperator, global::Weave.ConvertOperation, global::Weave.AndOperation, global::Weave.OrOperation, global::Weave.NotOperation, global::Weave.EqOperation, global::Weave.GtOperation, global::Weave.LtOperation, global::Weave.GteOperation, global::Weave.LteOperation, global::Weave.InOperation, global::Weave.ContainsOperation>>>),

            typeof(global::Weave.JsonConverters.AnyOfJsonConverter<global::Weave.LiteralOperation, global::Weave.GetFieldOperator, global::Weave.ConvertOperation, global::Weave.AndOperation, global::Weave.OrOperation, global::Weave.NotOperation, global::Weave.EqOperation, global::Weave.GtOperation, global::Weave.LtOperation, global::Weave.GteOperation, global::Weave.LteOperation, global::Weave.InOperation, global::Weave.ContainsOperation>),

            typeof(global::Weave.JsonConverters.AnyOfJsonConverter<global::Weave.LiteralOperation, global::Weave.GetFieldOperator, global::Weave.ConvertOperation, global::Weave.AndOperation, global::Weave.OrOperation, global::Weave.NotOperation, global::Weave.EqOperation, global::Weave.GtOperation, global::Weave.LtOperation, global::Weave.GteOperation, global::Weave.LteOperation, global::Weave.InOperation, global::Weave.ContainsOperation>),

            typeof(global::Weave.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?, global::System.Collections.Generic.Dictionary<string, global::Weave.LiteralOperation>, global::System.Collections.Generic.IList<global::Weave.LiteralOperation>, object>),

            typeof(global::Weave.JsonConverters.AnyOfJsonConverter<global::Weave.LiteralOperation, global::Weave.GetFieldOperator, global::Weave.ConvertOperation, global::Weave.AndOperation, global::Weave.OrOperation, global::Weave.NotOperation, global::Weave.EqOperation, global::Weave.GtOperation, global::Weave.LtOperation, global::Weave.GteOperation, global::Weave.LteOperation, global::Weave.InOperation, global::Weave.ContainsOperation>),

            typeof(global::Weave.JsonConverters.AnyOfJsonConverter<global::Weave.LiteralOperation, global::Weave.GetFieldOperator, global::Weave.ConvertOperation, global::Weave.AndOperation, global::Weave.OrOperation, global::Weave.NotOperation, global::Weave.EqOperation, global::Weave.GtOperation, global::Weave.LtOperation, global::Weave.GteOperation, global::Weave.LteOperation, global::Weave.InOperation, global::Weave.ContainsOperation>),

            typeof(global::Weave.JsonConverters.AnyOfJsonConverter<global::Weave.LiteralOperation, global::Weave.GetFieldOperator, global::Weave.ConvertOperation, global::Weave.AndOperation, global::Weave.OrOperation, global::Weave.NotOperation, global::Weave.EqOperation, global::Weave.GtOperation, global::Weave.LtOperation, global::Weave.GteOperation, global::Weave.LteOperation, global::Weave.InOperation, global::Weave.ContainsOperation>),

            typeof(global::Weave.JsonConverters.AnyOfJsonConverter<global::Weave.LiteralOperation, global::Weave.GetFieldOperator, global::Weave.ConvertOperation, global::Weave.AndOperation, global::Weave.OrOperation, global::Weave.NotOperation, global::Weave.EqOperation, global::Weave.GtOperation, global::Weave.LtOperation, global::Weave.GteOperation, global::Weave.LteOperation, global::Weave.InOperation, global::Weave.ContainsOperation>),

            typeof(global::Weave.JsonConverters.AnyOfJsonConverter<global::Weave.LiteralOperation, global::Weave.GetFieldOperator, global::Weave.ConvertOperation, global::Weave.AndOperation, global::Weave.OrOperation, global::Weave.NotOperation, global::Weave.EqOperation, global::Weave.GtOperation, global::Weave.LtOperation, global::Weave.GteOperation, global::Weave.LteOperation, global::Weave.InOperation, global::Weave.ContainsOperation>),

            typeof(global::Weave.JsonConverters.AnyOfJsonConverter<global::Weave.LiteralOperation, global::Weave.GetFieldOperator, global::Weave.ConvertOperation, global::Weave.AndOperation, global::Weave.OrOperation, global::Weave.NotOperation, global::Weave.EqOperation, global::Weave.GtOperation, global::Weave.LtOperation, global::Weave.GteOperation, global::Weave.LteOperation, global::Weave.InOperation, global::Weave.ContainsOperation>),

            typeof(global::Weave.JsonConverters.AnyOfJsonConverter<global::Weave.AndOperation, global::Weave.OrOperation, global::Weave.NotOperation, global::Weave.EqOperation, global::Weave.GtOperation, global::Weave.LtOperation, global::Weave.GteOperation, global::Weave.LteOperation, global::Weave.InOperation, global::Weave.ContainsOperation>),

            typeof(global::Weave.JsonConverters.AnyOfJsonConverter<global::Weave.TableAppendSpec, global::Weave.TablePopSpec, global::Weave.TableInsertSpec>),

            typeof(global::Weave.JsonConverters.AnyOfJsonConverter<string, int?>),

            typeof(global::Weave.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AgentChatAgentHandoff))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AgentChatAgentStart))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AgentChatAgentStartStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AgentChatAssistantMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AgentChatAssistantMessageStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AgentChatContextCompacted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AgentChatMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AgentChatMessageType), TypeInfoPropertyName = "AgentChatMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AgentChatUserMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AgentChatToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AgentChatToolCallStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AgentConversationChatReq))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AgentConversationChatRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weave.AgentTraceChatRes>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AgentTraceChatRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AgentConversationMessagePreview))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AgentCustomAttrSchemaItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AgentCustomAttrSchemaItemSource), TypeInfoPropertyName = "AgentCustomAttrSchemaItemSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AgentCustomAttrSchemaItemValueType), TypeInfoPropertyName = "AgentCustomAttrSchemaItemValueType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AgentCustomAttrsSchemaReq))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.Query))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AgentCustomAttrsSchemaRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weave.AgentCustomAttrSchemaItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AgentGroupByRef))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AgentGroupByRefSource), TypeInfoPropertyName = "AgentGroupByRefSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AgentSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AgentSearchConversationResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weave.AgentSearchMatchedMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AgentSearchMatchedMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AgentSearchMatchedMessageRole), TypeInfoPropertyName = "AgentSearchMatchedMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AgentSearchReq))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weave.AgentSearchReqRolesVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AgentSearchReqRolesVariant1Item), TypeInfoPropertyName = "AgentSearchReqRolesVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AgentSearchRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weave.AgentSearchConversationResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AgentSortBy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AgentSortByDirection), TypeInfoPropertyName = "AgentSortByDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AgentSpanGroupDistributionBin))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AgentSpanGroupDistributionItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AgentSpanGroupDistributionItemSource), TypeInfoPropertyName = "AgentSpanGroupDistributionItemSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AgentSpanGroupDistributionItemValueType), TypeInfoPropertyName = "AgentSpanGroupDistributionItemValueType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weave.AgentSpanGroupDistributionBin>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weave.AgentSpanGroupDistributionValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AgentSpanGroupDistributionValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AgentSpanGroupDistributionSpec))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AgentSpanValueRef))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AgentSpanGroupFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weave.AgentGroupByRef>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AgentSpanMeasureSpec))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AnyOf<double?, global::System.DateTime?, object>), TypeInfoPropertyName = "AnyOfDoubleDateTimeObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AgentSpanGroupRow))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AnyOf<string, int?, double?, bool?, object>), TypeInfoPropertyName = "AnyOfStringInt32DoubleBooleanObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AnyOf<global::System.DateTime?, string, int?, double?, bool?, object>), TypeInfoPropertyName = "AnyOfDateTimeStringInt32DoubleBooleanObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Weave.AgentSpanGroupDistributionItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AgentSpanMeasureSpecAggregation), TypeInfoPropertyName = "AgentSpanMeasureSpecAggregation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AgentSpanMeasureSpecValueType2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AgentSpanSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AgentSpanSchemaSpanKind2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AgentSpanSchemaStatusCode2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weave.NormalizedMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.NormalizedMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, bool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AgentSpanStatsColumn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AgentSpanStatsColumnRole), TypeInfoPropertyName = "AgentSpanStatsColumnRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AgentSpanStatsColumnValueType), TypeInfoPropertyName = "AgentSpanStatsColumnValueType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AgentSpanStatsMetricSpec))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AgentSpanStatsMetricSpecValueType), TypeInfoPropertyName = "AgentSpanStatsMetricSpecValueType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weave.AgentSpanStatsMetricSpecAggregation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AgentSpanStatsMetricSpecAggregation), TypeInfoPropertyName = "AgentSpanStatsMetricSpecAggregation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AgentSpanStatsNumericBucketSpec))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AgentSpanStatsReq))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weave.AgentSpanStatsMetricSpec>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.BucketByVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AgentSpanStatsTimeBucketSpec))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AgentSpanStatsReqBucketByVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AgentSpanStatsReqBucketByVariant1DiscriminatorType), TypeInfoPropertyName = "AgentSpanStatsReqBucketByVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weave.AgentSpanGroupFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AgentSpanStatsRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AgentSpanStatsResBucketType), TypeInfoPropertyName = "AgentSpanStatsResBucketType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weave.AgentSpanStatsColumn>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AgentSpanValueRefSource), TypeInfoPropertyName = "AgentSpanValueRefSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AgentSpansQueryReq))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weave.AgentSpanMeasureSpec>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weave.AgentSpanGroupDistributionSpec>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weave.AgentSpanValueRef>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weave.AgentSortBy>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AgentSpansQueryRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weave.AgentSpanSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weave.AgentSpanGroupRow>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AgentTraceChatReq))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weave.AgentChatMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AgentVersionSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AgentVersionsQueryReq))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AgentVersionsQueryRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weave.AgentVersionSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AgentsQueryFilters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AgentsQueryReq))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AgentsQueryRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weave.AgentSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AggregationType), TypeInfoPropertyName = "AggregationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AliasesListRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AndOperation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weave.AnyOf<global::Weave.LiteralOperation, global::Weave.GetFieldOperator, global::Weave.ConvertOperation, global::Weave.AndOperation, global::Weave.OrOperation, global::Weave.NotOperation, global::Weave.EqOperation, global::Weave.GtOperation, global::Weave.LtOperation, global::Weave.GteOperation, global::Weave.LteOperation, global::Weave.InOperation, global::Weave.ContainsOperation>>), TypeInfoPropertyName = "ContainsOperation_179074160b8e7669")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AnyOf<global::Weave.LiteralOperation, global::Weave.GetFieldOperator, global::Weave.ConvertOperation, global::Weave.AndOperation, global::Weave.OrOperation, global::Weave.NotOperation, global::Weave.EqOperation, global::Weave.GtOperation, global::Weave.LtOperation, global::Weave.GteOperation, global::Weave.LteOperation, global::Weave.InOperation, global::Weave.ContainsOperation>), TypeInfoPropertyName = "ContainsOperation_e36a77c4746492b2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.LiteralOperation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.GetFieldOperator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.ConvertOperation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.OrOperation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.NotOperation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.EqOperation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.GtOperation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.LtOperation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.GteOperation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.LteOperation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.InOperation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.ContainsOperation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AnnotationQueueAddCallsBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AnnotationQueueAddCallsRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AnnotationQueueCreateReq))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AnnotationQueueCreateRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AnnotationQueueDeleteRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AnnotationQueueSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AnnotationQueueItemProgressUpdateBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AnnotationQueueItemSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AnnotationQueueItemSchemaAnnotationState), TypeInfoPropertyName = "AnnotationQueueItemSchemaAnnotationState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AnnotationQueueItemsFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weave.AnnotationQueueItemsFilterAnnotationStatesVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AnnotationQueueItemsFilterAnnotationStatesVariant1Item), TypeInfoPropertyName = "AnnotationQueueItemsFilterAnnotationStatesVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AnnotationQueueItemsQueryBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weave.SortBy>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.SortBy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AnnotationQueueItemsQueryRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weave.AnnotationQueueItemSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AnnotationQueueReadRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AnnotationQueueStatsSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AnnotationQueueUpdateBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AnnotationQueueUpdateRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AnnotationQueuesQueryReq))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AnnotationQueuesStatsReq))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AnnotationQueuesStatsRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weave.AnnotationQueueStatsSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AnnotatorQueueItemsProgressUpdateRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.BodyFileCreateFileCreatePost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.CallBatchEndMode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.CallEndReq))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.CallBatchStartMode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.CallStartReq))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.CallCreateBatchReq))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weave.AnyOf<global::Weave.CallBatchStartMode, global::Weave.CallBatchEndMode>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AnyOf<global::Weave.CallBatchStartMode, global::Weave.CallBatchEndMode>), TypeInfoPropertyName = "AnyOfCallBatchStartModeCallBatchEndMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.CallCreateBatchRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weave.AnyOf<global::Weave.CallStartRes, global::Weave.CallEndRes>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AnyOf<global::Weave.CallStartRes, global::Weave.CallEndRes>), TypeInfoPropertyName = "AnyOfCallStartResCallEndRes2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.CallStartRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.CallEndRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.EndedCallSchemaForInsert))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.CallMetricSpec))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.CallMetricSpecMetric), TypeInfoPropertyName = "CallMetricSpecMetric2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weave.AggregationType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.CallReadReq))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.CallReadRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.CallSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.StartedCallSchemaForInsert))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.CallStatsReq))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weave.UsageMetricSpec>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.UsageMetricSpec))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weave.CallMetricSpec>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.CallsFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.CallStatsRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.CallUpdateReq))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.CallUpdateRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.CallsDeleteReq))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.CallsDeleteRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.CallsQueryReq))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.CallsQueryStatsReq))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.CallsQueryStatsRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.CallsScoreReq))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.CallsScoreRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.CallsUsageReq))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.CallsUsageRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, global::Weave.LLMAggregatedUsage>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Weave.LLMAggregatedUsage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.LLMAggregatedUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.CatalogModelsRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weave.LLMModelDetails>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.LLMModelDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.ContainsSpec))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.ConvertSpec))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.ConvertSpecTo), TypeInfoPropertyName = "ConvertSpecTo2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.CostCreateInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.CostCreateReq))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Weave.CostCreateInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.CostCreateRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.CostPurgeReq))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.CostPurgeRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.CostQueryOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.CostQueryReq))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.CostQueryRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weave.CostQueryOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.CreateAndLinkPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.CreateAndLinkTarget))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.CreateAndLinkWeaveAssetRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.Datacenter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.DatasetCreateBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.DatasetCreateRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.DatasetDeleteRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.DatasetReadRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.SummaryInsertMap))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.EvalResultsEvaluationSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weave.EvalResultsScorerStats>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.EvalResultsScorerStats))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.EvalResultsFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.EvalResultsQueryBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weave.EvalResultsSortBy>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.EvalResultsSortBy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weave.EvalResultsFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.EvalResultsQueryRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weave.EvalResultsRow>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.EvalResultsRow))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.EvalResultsSummaryRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weave.EvalResultsRowEvaluation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.EvalResultsRowEvaluation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weave.EvalResultsTrial>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.EvalResultsTrial))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.EvalResultsScorerStatsValueType2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.EvalResultsSortByDirection), TypeInfoPropertyName = "EvalResultsSortByDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.EvalResultsSortByMode), TypeInfoPropertyName = "EvalResultsSortByMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weave.EvalResultsEvaluationSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weave.GenAISpanRef>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.GenAISpanRef))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.EvaluateModelReq))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.EvaluateModelRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.EvaluationCreateBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.EvaluationCreateRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.EvaluationDeleteRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.EvaluationReadRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.EvaluationRunCreateBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.EvaluationRunCreateRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.EvaluationRunDeleteRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.EvaluationRunFinishBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.EvaluationRunFinishRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.EvaluationRunReadRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.EvaluationStatusComplete))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.EvaluationStatusFailed))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.EvaluationStatusNotFound))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.EvaluationStatusReq))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.EvaluationStatusRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AnyOf<global::Weave.EvaluationStatusNotFound, global::Weave.EvaluationStatusRunning, global::Weave.EvaluationStatusFailed, global::Weave.EvaluationStatusComplete>), TypeInfoPropertyName = "AnyOfEvaluationStatusNotFoundEvaluationStatusRunningEvaluationStatusFailedEvaluationStatusComplete2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.EvaluationStatusRunning))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.FeedbackCreateBatchReq))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weave.FeedbackCreateReq>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.FeedbackCreateReq))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.FeedbackCreateBatchRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weave.FeedbackCreateRes>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.FeedbackCreateRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.FeedbackMetricSpec))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.FeedbackMetricSpecValueType), TypeInfoPropertyName = "FeedbackMetricSpecValueType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.FeedbackPayloadPath))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.FeedbackPayloadPathValueType), TypeInfoPropertyName = "FeedbackPayloadPathValueType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.FeedbackPayloadSchemaReq))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.FeedbackPayloadSchemaRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weave.FeedbackPayloadPath>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.FeedbackPurgeReq))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.FeedbackPurgeRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.FeedbackQueryReq))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.FeedbackQueryRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.FeedbackReplaceReq))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.FeedbackReplaceRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.FeedbackStatsReq))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weave.FeedbackMetricSpec>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.FeedbackStatsRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.FileContentReadReq))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.FileCreateRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.FilesStatsReq))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.FilesStatsRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.Geolocation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.GeolocationRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.HTTPValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weave.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.ValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.ImageGenerationCreateReq))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.ImageGenerationRequestInputs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.ImageGenerationCreateRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weave.AnyOf<global::Weave.AnyOf<global::Weave.LiteralOperation, global::Weave.GetFieldOperator, global::Weave.ConvertOperation, global::Weave.AndOperation, global::Weave.OrOperation, global::Weave.NotOperation, global::Weave.EqOperation, global::Weave.GtOperation, global::Weave.LtOperation, global::Weave.GteOperation, global::Weave.LteOperation, global::Weave.InOperation, global::Weave.ContainsOperation>?, global::System.Collections.Generic.IList<global::Weave.AnyOf<global::Weave.LiteralOperation, global::Weave.GetFieldOperator, global::Weave.ConvertOperation, global::Weave.AndOperation, global::Weave.OrOperation, global::Weave.NotOperation, global::Weave.EqOperation, global::Weave.GtOperation, global::Weave.LtOperation, global::Weave.GteOperation, global::Weave.LteOperation, global::Weave.InOperation, global::Weave.ContainsOperation>>>>), TypeInfoPropertyName = "ContainsOperation_d224c796101edc12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AnyOf<global::Weave.AnyOf<global::Weave.LiteralOperation, global::Weave.GetFieldOperator, global::Weave.ConvertOperation, global::Weave.AndOperation, global::Weave.OrOperation, global::Weave.NotOperation, global::Weave.EqOperation, global::Weave.GtOperation, global::Weave.LtOperation, global::Weave.GteOperation, global::Weave.LteOperation, global::Weave.InOperation, global::Weave.ContainsOperation>?, global::System.Collections.Generic.IList<global::Weave.AnyOf<global::Weave.LiteralOperation, global::Weave.GetFieldOperator, global::Weave.ConvertOperation, global::Weave.AndOperation, global::Weave.OrOperation, global::Weave.NotOperation, global::Weave.EqOperation, global::Weave.GtOperation, global::Weave.LtOperation, global::Weave.GteOperation, global::Weave.LteOperation, global::Weave.InOperation, global::Weave.ContainsOperation>>>), TypeInfoPropertyName = "ContainsOperation_9f2e53bde2b7df10")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.LLMModelDetailsLifecycleStage), TypeInfoPropertyName = "LLMModelDetailsLifecycleStage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weave.LLMModelDetailsAvailableInItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.LLMModelDetailsAvailableInItem), TypeInfoPropertyName = "LLMModelDetailsAvailableInItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.LLMModelDetailsQuantization), TypeInfoPropertyName = "LLMModelDetailsQuantization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.LLMUsageSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AnyOf<string, int?, double?, bool?, global::System.Collections.Generic.Dictionary<string, global::Weave.LiteralOperation>, global::System.Collections.Generic.IList<global::Weave.LiteralOperation>, object>), TypeInfoPropertyName = "AnyOfStringInt32DoubleBooleanDictionaryStringLiteralOperationIListLiteralOperationObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Weave.LiteralOperation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weave.LiteralOperation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.ModelCreateBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.ModelCreateRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.ModelDeleteRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.ModelReadRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.NvidiaHardwareOption))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.NvidiaServerlessPricing))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.NvidiaHardwareRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weave.NvidiaHardwareOption>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.ObjAddTagsRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.ObjCreateReq))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.ObjSchemaForInsert))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.ObjCreateRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.ObjDeleteReq))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.ObjDeleteRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.ObjQueryReq))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.ObjectVersionFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.ObjQueryRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weave.ObjSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.ObjSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.ObjReadReq))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.ObjReadRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.ObjRemoveAliasesBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.ObjRemoveAliasesRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.ObjRemoveTagsRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.ObjSetAliasesBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.ObjSetAliasesRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.ObjTagsBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.OpCreateBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.OpCreateRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.OpDeleteRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.OpReadRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.PredictionCreateBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.PredictionCreateRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.PredictionDeleteRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.PredictionFinishRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.PredictionReadRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.Pricing))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.ProjectsInfoReq))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.ProjectsInfoRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AnyOf<global::Weave.AndOperation, global::Weave.OrOperation, global::Weave.NotOperation, global::Weave.EqOperation, global::Weave.GtOperation, global::Weave.LtOperation, global::Weave.GteOperation, global::Weave.LteOperation, global::Weave.InOperation, global::Weave.ContainsOperation>), TypeInfoPropertyName = "ContainsOperation_b519b0000bd0c5bf")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.RefsReadBatchReq))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.RefsReadBatchRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.RescoreReq))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.RescoreRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.RouterOpenRouterModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.RouterOpenRouterModelQuantization), TypeInfoPropertyName = "RouterOpenRouterModelQuantization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weave.RouterOpenRouterModelSupportedSamplingParameter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.RouterOpenRouterModelSupportedSamplingParameter), TypeInfoPropertyName = "RouterOpenRouterModelSupportedSamplingParameter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weave.RouterOpenRouterModelSupportedFeature>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.RouterOpenRouterModelSupportedFeature), TypeInfoPropertyName = "RouterOpenRouterModelSupportedFeature2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weave.Datacenter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.RouterOpenRouterModelsRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weave.RouterOpenRouterModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.ScoreCreateBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.ScoreCreateRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.ScoreDeleteRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.ScoreReadRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.ScorerCreateBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.ScorerCreateRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.ScorerDeleteRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.ScorerReadRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.ServerInfoRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.SortByDirection), TypeInfoPropertyName = "SortByDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Weave.LLMUsageSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.TableAppendSpec))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.TableAppendSpecPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.TableCreateFromDigestsReq))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.TableCreateFromDigestsRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.TableCreateReq))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.TableSchemaForInsert))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.TableCreateRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.TableInsertSpec))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.TableInsertSpecPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.TablePopSpec))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.TablePopSpecPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.TableQueryReq))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.TableRowFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.TableQueryRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weave.TableRowSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.TableRowSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.TableQueryStatsBatchReq))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.TableQueryStatsBatchRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weave.TableStatsRow>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.TableStatsRow))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.TableQueryStatsReq))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.TableQueryStatsRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.TableUpdateReq))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weave.AnyOf<global::Weave.TableAppendSpec, global::Weave.TablePopSpec, global::Weave.TableInsertSpec>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AnyOf<global::Weave.TableAppendSpec, global::Weave.TablePopSpec, global::Weave.TableInsertSpec>), TypeInfoPropertyName = "AnyOfTableAppendSpecTablePopSpecTableInsertSpec2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.TableUpdateRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.TagsListRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.ThreadsQueryFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.ThreadsQueryReq))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.TraceStatus), TypeInfoPropertyName = "TraceStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.TraceUsageReq))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.TraceUsageRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.UsageMetricSpecMetric), TypeInfoPropertyName = "UsageMetricSpecMetric2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weave.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AnyOf<string, int?>), TypeInfoPropertyName = "AnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weave.ProjectsInfoRes>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weave.EvaluationRunReadRes>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weave.PredictionReadRes>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weave.ScoreReadRes>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AnyOf<global::Weave.LiteralOperation, global::Weave.GetFieldOperator, global::Weave.ConvertOperation, global::Weave.AndOperation, global::Weave.OrOperation, global::Weave.NotOperation, global::Weave.EqOperation, global::Weave.GtOperation, global::Weave.LtOperation, global::Weave.GteOperation, global::Weave.LteOperation, global::Weave.InOperation, global::Weave.ContainsOperation>?), TypeInfoPropertyName = "ContainsOperation_cacc07f640474c92")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AnyOf<global::Weave.AnyOf<global::Weave.LiteralOperation, global::Weave.GetFieldOperator, global::Weave.ConvertOperation, global::Weave.AndOperation, global::Weave.OrOperation, global::Weave.NotOperation, global::Weave.EqOperation, global::Weave.GtOperation, global::Weave.LtOperation, global::Weave.GteOperation, global::Weave.LteOperation, global::Weave.InOperation, global::Weave.ContainsOperation>?, global::System.Collections.Generic.IList<global::Weave.AnyOf<global::Weave.LiteralOperation, global::Weave.GetFieldOperator, global::Weave.ConvertOperation, global::Weave.AndOperation, global::Weave.OrOperation, global::Weave.NotOperation, global::Weave.EqOperation, global::Weave.GtOperation, global::Weave.LtOperation, global::Weave.GteOperation, global::Weave.LteOperation, global::Weave.InOperation, global::Weave.ContainsOperation>>>?), TypeInfoPropertyName = "ContainsOperation_41ee95c2de4ff4d2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AnyOf<global::Weave.AndOperation, global::Weave.OrOperation, global::Weave.NotOperation, global::Weave.EqOperation, global::Weave.GtOperation, global::Weave.LtOperation, global::Weave.GteOperation, global::Weave.LteOperation, global::Weave.InOperation, global::Weave.ContainsOperation>?), TypeInfoPropertyName = "ContainsOperation_c0feb72d6a19828a")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weave.AgentTraceChatRes>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weave.AgentCustomAttrSchemaItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weave.AgentSearchMatchedMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weave.AgentSearchReqRolesVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weave.AgentSearchConversationResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weave.AgentSpanGroupDistributionBin>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weave.AgentSpanGroupDistributionValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weave.AgentGroupByRef>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weave.NormalizedMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weave.AgentSpanStatsMetricSpecAggregation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weave.AgentSpanStatsMetricSpec>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weave.AgentSpanGroupFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weave.AgentSpanStatsColumn>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weave.AgentSpanMeasureSpec>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weave.AgentSpanGroupDistributionSpec>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weave.AgentSpanValueRef>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weave.AgentSortBy>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weave.AgentSpanSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weave.AgentSpanGroupRow>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weave.AgentChatMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weave.AgentVersionSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weave.AgentSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weave.AnyOf<global::Weave.LiteralOperation, global::Weave.GetFieldOperator, global::Weave.ConvertOperation, global::Weave.AndOperation, global::Weave.OrOperation, global::Weave.NotOperation, global::Weave.EqOperation, global::Weave.GtOperation, global::Weave.LtOperation, global::Weave.GteOperation, global::Weave.LteOperation, global::Weave.InOperation, global::Weave.ContainsOperation>>), TypeInfoPropertyName = "ContainsOperation_f91d53025cea92a6")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weave.AnnotationQueueItemsFilterAnnotationStatesVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weave.SortBy>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weave.AnnotationQueueItemSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weave.AnnotationQueueStatsSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weave.AnyOf<global::Weave.CallBatchStartMode, global::Weave.CallBatchEndMode>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weave.AnyOf<global::Weave.CallStartRes, global::Weave.CallEndRes>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weave.AggregationType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weave.UsageMetricSpec>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weave.CallMetricSpec>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weave.LLMModelDetails>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weave.CostQueryOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weave.EvalResultsScorerStats>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weave.EvalResultsSortBy>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weave.EvalResultsFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weave.EvalResultsRow>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weave.EvalResultsRowEvaluation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weave.EvalResultsTrial>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weave.EvalResultsEvaluationSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weave.GenAISpanRef>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weave.FeedbackCreateReq>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weave.FeedbackCreateRes>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weave.FeedbackPayloadPath>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weave.FeedbackMetricSpec>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weave.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weave.AnyOf<global::Weave.AnyOf<global::Weave.LiteralOperation, global::Weave.GetFieldOperator, global::Weave.ConvertOperation, global::Weave.AndOperation, global::Weave.OrOperation, global::Weave.NotOperation, global::Weave.EqOperation, global::Weave.GtOperation, global::Weave.LtOperation, global::Weave.GteOperation, global::Weave.LteOperation, global::Weave.InOperation, global::Weave.ContainsOperation>?, global::System.Collections.Generic.List<global::Weave.AnyOf<global::Weave.LiteralOperation, global::Weave.GetFieldOperator, global::Weave.ConvertOperation, global::Weave.AndOperation, global::Weave.OrOperation, global::Weave.NotOperation, global::Weave.EqOperation, global::Weave.GtOperation, global::Weave.LtOperation, global::Weave.GteOperation, global::Weave.LteOperation, global::Weave.InOperation, global::Weave.ContainsOperation>>>>), TypeInfoPropertyName = "ContainsOperation_29ccdc77e8195b38")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AnyOf<global::Weave.AnyOf<global::Weave.LiteralOperation, global::Weave.GetFieldOperator, global::Weave.ConvertOperation, global::Weave.AndOperation, global::Weave.OrOperation, global::Weave.NotOperation, global::Weave.EqOperation, global::Weave.GtOperation, global::Weave.LtOperation, global::Weave.GteOperation, global::Weave.LteOperation, global::Weave.InOperation, global::Weave.ContainsOperation>?, global::System.Collections.Generic.List<global::Weave.AnyOf<global::Weave.LiteralOperation, global::Weave.GetFieldOperator, global::Weave.ConvertOperation, global::Weave.AndOperation, global::Weave.OrOperation, global::Weave.NotOperation, global::Weave.EqOperation, global::Weave.GtOperation, global::Weave.LtOperation, global::Weave.GteOperation, global::Weave.LteOperation, global::Weave.InOperation, global::Weave.ContainsOperation>>>), TypeInfoPropertyName = "ContainsOperation_e672610a6ad136fe")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weave.LLMModelDetailsAvailableInItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AnyOf<string, int?, double?, bool?, global::System.Collections.Generic.Dictionary<string, global::Weave.LiteralOperation>, global::System.Collections.Generic.List<global::Weave.LiteralOperation>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weave.LiteralOperation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weave.NvidiaHardwareOption>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weave.ObjSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weave.RouterOpenRouterModelSupportedSamplingParameter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weave.RouterOpenRouterModelSupportedFeature>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weave.Datacenter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weave.RouterOpenRouterModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weave.TableRowSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weave.TableStatsRow>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weave.AnyOf<global::Weave.TableAppendSpec, global::Weave.TablePopSpec, global::Weave.TableInsertSpec>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weave.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weave.ProjectsInfoRes>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weave.EvaluationRunReadRes>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weave.PredictionReadRes>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weave.ScoreReadRes>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}