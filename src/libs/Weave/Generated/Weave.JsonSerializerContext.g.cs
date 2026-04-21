
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AggregationType), TypeInfoPropertyName = "AggregationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AliasesListRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AnnotationQueueCreateReq))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AnnotationQueueCreateRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AnnotationQueueDeleteRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AnnotationQueueSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AnnotationQueueItemProgressUpdateBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AnnotationQueueItemSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AnnotationQueueItemSchemaAnnotationState), TypeInfoPropertyName = "AnnotationQueueItemSchemaAnnotationState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AnnotationQueueItemsFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weave.AnnotationQueueItemsFilterAnnotationStatesVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AnnotationQueueItemsFilterAnnotationStatesVariant1Item), TypeInfoPropertyName = "AnnotationQueueItemsFilterAnnotationStatesVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AnnotationQueueItemsQueryBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weave.SortBy>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.SortBy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.CallUpdateReq))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.CallUpdateRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.CallsDeleteReq))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.CallsDeleteRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.CallsQueryReq))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.Query))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.CallsQueryStatsReq))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.CallsQueryStatsRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.CallsScoreReq))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.CallsScoreRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.CallsUsageReq))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.CallsUsageRes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, global::Weave.LLMAggregatedUsage>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Weave.LLMAggregatedUsage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.LLMAggregatedUsage))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, int>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weave.AnyOf<global::Weave.LiteralOperation, global::Weave.GetFieldOperator, global::Weave.ConvertOperation, global::Weave.AndOperation, global::Weave.OrOperation, global::Weave.NotOperation, global::Weave.EqOperation, global::Weave.GtOperation, global::Weave.LtOperation, global::Weave.GteOperation, global::Weave.LteOperation, global::Weave.InOperation, global::Weave.ContainsOperation>>), TypeInfoPropertyName = "ContainsOperation_f91d53025cea92a6")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weave.AnnotationQueueItemsFilterAnnotationStatesVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weave.SortBy>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weave.AnnotationQueueItemSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weave.AnnotationQueueStatsSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weave.AnyOf<global::Weave.CallBatchStartMode, global::Weave.CallBatchEndMode>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weave.AnyOf<global::Weave.CallStartRes, global::Weave.CallEndRes>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weave.AggregationType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weave.UsageMetricSpec>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weave.CallMetricSpec>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weave.CostQueryOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weave.EvalResultsScorerStats>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weave.EvalResultsSortBy>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weave.EvalResultsFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weave.EvalResultsRow>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weave.EvalResultsRowEvaluation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weave.EvalResultsTrial>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weave.EvalResultsEvaluationSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weave.FeedbackCreateReq>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weave.FeedbackCreateRes>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weave.FeedbackPayloadPath>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weave.FeedbackMetricSpec>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weave.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weave.AnyOf<global::Weave.AnyOf<global::Weave.LiteralOperation, global::Weave.GetFieldOperator, global::Weave.ConvertOperation, global::Weave.AndOperation, global::Weave.OrOperation, global::Weave.NotOperation, global::Weave.EqOperation, global::Weave.GtOperation, global::Weave.LtOperation, global::Weave.GteOperation, global::Weave.LteOperation, global::Weave.InOperation, global::Weave.ContainsOperation>?, global::System.Collections.Generic.List<global::Weave.AnyOf<global::Weave.LiteralOperation, global::Weave.GetFieldOperator, global::Weave.ConvertOperation, global::Weave.AndOperation, global::Weave.OrOperation, global::Weave.NotOperation, global::Weave.EqOperation, global::Weave.GtOperation, global::Weave.LtOperation, global::Weave.GteOperation, global::Weave.LteOperation, global::Weave.InOperation, global::Weave.ContainsOperation>>>>), TypeInfoPropertyName = "ContainsOperation_29ccdc77e8195b38")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weave.AnyOf<global::Weave.AnyOf<global::Weave.LiteralOperation, global::Weave.GetFieldOperator, global::Weave.ConvertOperation, global::Weave.AndOperation, global::Weave.OrOperation, global::Weave.NotOperation, global::Weave.EqOperation, global::Weave.GtOperation, global::Weave.LtOperation, global::Weave.GteOperation, global::Weave.LteOperation, global::Weave.InOperation, global::Weave.ContainsOperation>?, global::System.Collections.Generic.List<global::Weave.AnyOf<global::Weave.LiteralOperation, global::Weave.GetFieldOperator, global::Weave.ConvertOperation, global::Weave.AndOperation, global::Weave.OrOperation, global::Weave.NotOperation, global::Weave.EqOperation, global::Weave.GtOperation, global::Weave.LtOperation, global::Weave.GteOperation, global::Weave.LteOperation, global::Weave.InOperation, global::Weave.ContainsOperation>>>), TypeInfoPropertyName = "ContainsOperation_e672610a6ad136fe")]
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