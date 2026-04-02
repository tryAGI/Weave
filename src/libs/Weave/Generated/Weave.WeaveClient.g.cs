
#nullable enable

namespace Weave
{
    /// <summary>
    /// W&amp;B Weave API for LLM observability, tracing, evaluations, and datasets<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class WeaveClient : global::Weave.IWeaveClient, global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        public const string DefaultBaseUrl = "https://trace.wandb.ai";

        private bool _disposeHttpClient = true;

        /// <inheritdoc/>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <inheritdoc/>
        public System.Uri? BaseUri => HttpClient.BaseAddress;

        /// <inheritdoc/>
        public global::System.Collections.Generic.List<global::Weave.EndPointAuthorization> Authorizations { get; }

        /// <inheritdoc/>
        public bool ReadResponseAsString { get; set; }
#if DEBUG
            = true;
#endif
        /// <summary>
        /// 
        /// </summary>
        #pragma warning disable CS0618 // Type or member is obsolete
        public global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; } = new global::System.Text.Json.JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                Converters =
                {
                    new global::Weave.JsonConverters.AggregationTypeJsonConverter(),
                    new global::Weave.JsonConverters.AggregationTypeNullableJsonConverter(),
                    new global::Weave.JsonConverters.AnnotationQueueItemSchemaAnnotationStateJsonConverter(),
                    new global::Weave.JsonConverters.AnnotationQueueItemSchemaAnnotationStateNullableJsonConverter(),
                    new global::Weave.JsonConverters.AnnotationQueueItemsFilterAnnotationStatesVariant1ItemJsonConverter(),
                    new global::Weave.JsonConverters.AnnotationQueueItemsFilterAnnotationStatesVariant1ItemNullableJsonConverter(),
                    new global::Weave.JsonConverters.CallMetricSpecMetricJsonConverter(),
                    new global::Weave.JsonConverters.CallMetricSpecMetricNullableJsonConverter(),
                    new global::Weave.JsonConverters.ConvertSpecToJsonConverter(),
                    new global::Weave.JsonConverters.ConvertSpecToNullableJsonConverter(),
                    new global::Weave.JsonConverters.EvalResultsScorerStatsValueType2JsonConverter(),
                    new global::Weave.JsonConverters.EvalResultsScorerStatsValueType2NullableJsonConverter(),
                    new global::Weave.JsonConverters.FeedbackMetricSpecValueTypeJsonConverter(),
                    new global::Weave.JsonConverters.FeedbackMetricSpecValueTypeNullableJsonConverter(),
                    new global::Weave.JsonConverters.FeedbackPayloadPathValueTypeJsonConverter(),
                    new global::Weave.JsonConverters.FeedbackPayloadPathValueTypeNullableJsonConverter(),
                    new global::Weave.JsonConverters.RouterOpenRouterModelQuantizationJsonConverter(),
                    new global::Weave.JsonConverters.RouterOpenRouterModelQuantizationNullableJsonConverter(),
                    new global::Weave.JsonConverters.RouterOpenRouterModelSupportedSamplingParameterJsonConverter(),
                    new global::Weave.JsonConverters.RouterOpenRouterModelSupportedSamplingParameterNullableJsonConverter(),
                    new global::Weave.JsonConverters.RouterOpenRouterModelSupportedFeatureJsonConverter(),
                    new global::Weave.JsonConverters.RouterOpenRouterModelSupportedFeatureNullableJsonConverter(),
                    new global::Weave.JsonConverters.SortByDirectionJsonConverter(),
                    new global::Weave.JsonConverters.SortByDirectionNullableJsonConverter(),
                    new global::Weave.JsonConverters.TraceStatusJsonConverter(),
                    new global::Weave.JsonConverters.TraceStatusNullableJsonConverter(),
                    new global::Weave.JsonConverters.UsageMetricSpecMetricJsonConverter(),
                    new global::Weave.JsonConverters.UsageMetricSpecMetricNullableJsonConverter(),
                    new global::Weave.JsonConverters.AnyOfJsonConverter<global::Weave.LiteralOperation, global::Weave.GetFieldOperator, global::Weave.ConvertOperation, global::Weave.AndOperation, global::Weave.OrOperation, global::Weave.NotOperation, global::Weave.EqOperation, global::Weave.GtOperation, global::Weave.LtOperation, global::Weave.GteOperation, global::Weave.LteOperation, global::Weave.InOperation, global::Weave.ContainsOperation>(),
                    new global::Weave.JsonConverters.AnyOfJsonConverter<global::Weave.CallBatchStartMode, global::Weave.CallBatchEndMode>(),
                    new global::Weave.JsonConverters.AnyOfJsonConverter<global::Weave.CallStartRes, global::Weave.CallEndRes>(),
                    new global::Weave.JsonConverters.AnyOfJsonConverter<global::Weave.LiteralOperation, global::Weave.GetFieldOperator, global::Weave.ConvertOperation, global::Weave.AndOperation, global::Weave.OrOperation, global::Weave.NotOperation, global::Weave.EqOperation, global::Weave.GtOperation, global::Weave.LtOperation, global::Weave.GteOperation, global::Weave.LteOperation, global::Weave.InOperation, global::Weave.ContainsOperation>(),
                    new global::Weave.JsonConverters.AnyOfJsonConverter<global::Weave.LiteralOperation, global::Weave.GetFieldOperator, global::Weave.ConvertOperation, global::Weave.AndOperation, global::Weave.OrOperation, global::Weave.NotOperation, global::Weave.EqOperation, global::Weave.GtOperation, global::Weave.LtOperation, global::Weave.GteOperation, global::Weave.LteOperation, global::Weave.InOperation, global::Weave.ContainsOperation>(),
                    new global::Weave.JsonConverters.AnyOfJsonConverter<global::Weave.LiteralOperation, global::Weave.GetFieldOperator, global::Weave.ConvertOperation, global::Weave.AndOperation, global::Weave.OrOperation, global::Weave.NotOperation, global::Weave.EqOperation, global::Weave.GtOperation, global::Weave.LtOperation, global::Weave.GteOperation, global::Weave.LteOperation, global::Weave.InOperation, global::Weave.ContainsOperation>(),
                    new global::Weave.JsonConverters.AnyOfJsonConverter<global::Weave.EvaluationStatusNotFound, global::Weave.EvaluationStatusRunning, global::Weave.EvaluationStatusFailed, global::Weave.EvaluationStatusComplete>(),
                    new global::Weave.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?, global::System.Collections.Generic.Dictionary<string, global::Weave.LiteralOperation>, global::System.Collections.Generic.IList<global::Weave.LiteralOperation>, object>(),
                    new global::Weave.JsonConverters.AnyOfJsonConverter<global::Weave.LiteralOperation, global::Weave.GetFieldOperator, global::Weave.ConvertOperation, global::Weave.AndOperation, global::Weave.OrOperation, global::Weave.NotOperation, global::Weave.EqOperation, global::Weave.GtOperation, global::Weave.LtOperation, global::Weave.GteOperation, global::Weave.LteOperation, global::Weave.InOperation, global::Weave.ContainsOperation>(),
                    new global::Weave.JsonConverters.AnyOfJsonConverter<global::Weave.AndOperation, global::Weave.OrOperation, global::Weave.NotOperation, global::Weave.EqOperation, global::Weave.GtOperation, global::Weave.LtOperation, global::Weave.GteOperation, global::Weave.LteOperation, global::Weave.InOperation, global::Weave.ContainsOperation>(),
                    new global::Weave.JsonConverters.AnyOfJsonConverter<global::Weave.TableAppendSpec, global::Weave.TablePopSpec, global::Weave.TableInsertSpec>(),
                    new global::Weave.JsonConverters.AnyOfJsonConverter<string, int?>(),
                    new global::Weave.JsonConverters.UnixTimestampJsonConverter(),
                }
            };
        #pragma warning restore CS0618 // Type or member is obsolete


        /// <summary>
        /// 
        /// </summary>
        public AnnotationQueuesClient AnnotationQueues => new AnnotationQueuesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public CallsClient Calls => new CallsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public CostsClient Costs => new CostsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public DatasetsClient Datasets => new DatasetsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public EvalResultsClient EvalResults => new EvalResultsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public EvaluationRunsClient EvaluationRuns => new EvaluationRunsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public EvaluationsClient Evaluations => new EvaluationsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public FeedbackClient Feedback => new FeedbackClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public FilesClient Files => new FilesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ImagesClient Images => new ImagesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public InferenceClient Inference => new InferenceClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ModelsClient Models => new ModelsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ObjectsClient Objects => new ObjectsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public OpenTelemetryClient OpenTelemetry => new OpenTelemetryClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public OpsClient Ops => new OpsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public PredictionsClient Predictions => new PredictionsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public RefsClient Refs => new RefsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ScorersClient Scorers => new ScorersClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ScoresClient Scores => new ScoresClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ServiceClient Service => new ServiceClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public TablesClient Tables => new TablesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ThreadsClient Threads => new ThreadsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Creates a new instance of the WeaveClient.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public WeaveClient(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::Weave.EndPointAuthorization>? authorizations = null,
            bool disposeHttpClient = true)
        {
            HttpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            HttpClient.BaseAddress ??= baseUri ?? new global::System.Uri(DefaultBaseUrl);
            Authorizations = authorizations ?? new global::System.Collections.Generic.List<global::Weave.EndPointAuthorization>();
            _disposeHttpClient = disposeHttpClient;

            Initialized(HttpClient);
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            if (_disposeHttpClient)
            {
                HttpClient.Dispose();
            }
        }

        partial void Initialized(
            global::System.Net.Http.HttpClient client);
        partial void PrepareArguments(
            global::System.Net.Http.HttpClient client);
        partial void PrepareRequest(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpRequestMessage request);
        partial void ProcessResponse(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response);
        partial void ProcessResponseContent(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response,
            ref string content);
    }
}