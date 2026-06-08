
#nullable enable

namespace Weave
{
    /// <summary>
    /// A normalized agent span returned by query APIs.
    /// </summary>
    public sealed partial class AgentSpanSchema
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
        [global::System.Text.Json.Serialization.JsonPropertyName("trace_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TraceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("span_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SpanId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_span_id")]
        public string? ParentSpanId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("span_name")]
        public string? SpanName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("span_kind")]
        public global::Weave.AgentSpanSchemaSpanKind2? SpanKind { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_at")]
        public global::System.DateTime? StartedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ended_at")]
        public global::System.DateTime? EndedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status_code")]
        public global::Weave.AgentSpanSchemaStatusCode2? StatusCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status_message")]
        public string? StatusMessage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operation_name")]
        public string? OperationName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_name")]
        public string? ProviderName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_name")]
        public string? AgentName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        public string? AgentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_description")]
        public string? AgentDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_version")]
        public string? AgentVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_model")]
        public string? RequestModel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_model")]
        public string? ResponseModel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_id")]
        public string? ResponseId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_tokens")]
        public int? InputTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_tokens")]
        public int? OutputTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning_tokens")]
        public int? ReasoningTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_creation_input_tokens")]
        public int? CacheCreationInputTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_read_input_tokens")]
        public int? CacheReadInputTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning_content")]
        public string? ReasoningContent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_id")]
        public string? ConversationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_name")]
        public string? ConversationName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_name")]
        public string? ToolName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_type")]
        public string? ToolType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_call_id")]
        public string? ToolCallId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_description")]
        public string? ToolDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_definitions")]
        public string? ToolDefinitions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finish_reasons")]
        public global::System.Collections.Generic.IList<string>? FinishReasons { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_type")]
        public string? ErrorType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_temperature")]
        public double? RequestTemperature { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_max_tokens")]
        public int? RequestMaxTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_top_p")]
        public double? RequestTopP { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_frequency_penalty")]
        public double? RequestFrequencyPenalty { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_presence_penalty")]
        public double? RequestPresencePenalty { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_seed")]
        public int? RequestSeed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_stop_sequences")]
        public global::System.Collections.Generic.IList<string>? RequestStopSequences { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_choice_count")]
        public int? RequestChoiceCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_type")]
        public string? OutputType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_messages")]
        public global::System.Collections.Generic.IList<global::Weave.NormalizedMessage>? InputMessages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_messages")]
        public global::System.Collections.Generic.IList<global::Weave.NormalizedMessage>? OutputMessages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system_instructions")]
        public global::System.Collections.Generic.IList<string>? SystemInstructions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_call_arguments")]
        public string? ToolCallArguments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_call_result")]
        public string? ToolCallResult { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compaction_summary")]
        public string? CompactionSummary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compaction_items_before")]
        public int? CompactionItemsBefore { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compaction_items_after")]
        public int? CompactionItemsAfter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_refs")]
        public global::System.Collections.Generic.IList<string>? ContentRefs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("artifact_refs")]
        public global::System.Collections.Generic.IList<string>? ArtifactRefs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object_refs")]
        public global::System.Collections.Generic.IList<string>? ObjectRefs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_attrs_string")]
        public global::System.Collections.Generic.Dictionary<string, string>? CustomAttrsString { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_attrs_int")]
        public global::System.Collections.Generic.Dictionary<string, int>? CustomAttrsInt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_attrs_float")]
        public global::System.Collections.Generic.Dictionary<string, double>? CustomAttrsFloat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_attrs_bool")]
        public global::System.Collections.Generic.Dictionary<string, bool>? CustomAttrsBool { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_address")]
        public string? ServerAddress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_port")]
        public int? ServerPort { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wb_user_id")]
        public string? WbUserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wb_run_id")]
        public string? WbRunId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wb_run_step")]
        public int? WbRunStep { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wb_run_step_end")]
        public int? WbRunStepEnd { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("raw_span_dump")]
        public string? RawSpanDump { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSpanSchema" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="traceId"></param>
        /// <param name="spanId"></param>
        /// <param name="parentSpanId"></param>
        /// <param name="spanName"></param>
        /// <param name="spanKind"></param>
        /// <param name="startedAt"></param>
        /// <param name="endedAt"></param>
        /// <param name="statusCode"></param>
        /// <param name="statusMessage"></param>
        /// <param name="operationName"></param>
        /// <param name="providerName"></param>
        /// <param name="agentName"></param>
        /// <param name="agentId"></param>
        /// <param name="agentDescription"></param>
        /// <param name="agentVersion"></param>
        /// <param name="requestModel"></param>
        /// <param name="responseModel"></param>
        /// <param name="responseId"></param>
        /// <param name="inputTokens"></param>
        /// <param name="outputTokens"></param>
        /// <param name="reasoningTokens"></param>
        /// <param name="cacheCreationInputTokens"></param>
        /// <param name="cacheReadInputTokens"></param>
        /// <param name="reasoningContent"></param>
        /// <param name="conversationId"></param>
        /// <param name="conversationName"></param>
        /// <param name="toolName"></param>
        /// <param name="toolType"></param>
        /// <param name="toolCallId"></param>
        /// <param name="toolDescription"></param>
        /// <param name="toolDefinitions"></param>
        /// <param name="finishReasons"></param>
        /// <param name="errorType"></param>
        /// <param name="requestTemperature"></param>
        /// <param name="requestMaxTokens"></param>
        /// <param name="requestTopP"></param>
        /// <param name="requestFrequencyPenalty"></param>
        /// <param name="requestPresencePenalty"></param>
        /// <param name="requestSeed"></param>
        /// <param name="requestStopSequences"></param>
        /// <param name="requestChoiceCount"></param>
        /// <param name="outputType"></param>
        /// <param name="inputMessages"></param>
        /// <param name="outputMessages"></param>
        /// <param name="systemInstructions"></param>
        /// <param name="toolCallArguments"></param>
        /// <param name="toolCallResult"></param>
        /// <param name="compactionSummary"></param>
        /// <param name="compactionItemsBefore"></param>
        /// <param name="compactionItemsAfter"></param>
        /// <param name="contentRefs"></param>
        /// <param name="artifactRefs"></param>
        /// <param name="objectRefs"></param>
        /// <param name="customAttrsString"></param>
        /// <param name="customAttrsInt"></param>
        /// <param name="customAttrsFloat"></param>
        /// <param name="customAttrsBool"></param>
        /// <param name="serverAddress"></param>
        /// <param name="serverPort"></param>
        /// <param name="wbUserId"></param>
        /// <param name="wbRunId"></param>
        /// <param name="wbRunStep"></param>
        /// <param name="wbRunStepEnd"></param>
        /// <param name="rawSpanDump"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentSpanSchema(
            string projectId,
            string traceId,
            string spanId,
            string? parentSpanId,
            string? spanName,
            global::Weave.AgentSpanSchemaSpanKind2? spanKind,
            global::System.DateTime? startedAt,
            global::System.DateTime? endedAt,
            global::Weave.AgentSpanSchemaStatusCode2? statusCode,
            string? statusMessage,
            string? operationName,
            string? providerName,
            string? agentName,
            string? agentId,
            string? agentDescription,
            string? agentVersion,
            string? requestModel,
            string? responseModel,
            string? responseId,
            int? inputTokens,
            int? outputTokens,
            int? reasoningTokens,
            int? cacheCreationInputTokens,
            int? cacheReadInputTokens,
            string? reasoningContent,
            string? conversationId,
            string? conversationName,
            string? toolName,
            string? toolType,
            string? toolCallId,
            string? toolDescription,
            string? toolDefinitions,
            global::System.Collections.Generic.IList<string>? finishReasons,
            string? errorType,
            double? requestTemperature,
            int? requestMaxTokens,
            double? requestTopP,
            double? requestFrequencyPenalty,
            double? requestPresencePenalty,
            int? requestSeed,
            global::System.Collections.Generic.IList<string>? requestStopSequences,
            int? requestChoiceCount,
            string? outputType,
            global::System.Collections.Generic.IList<global::Weave.NormalizedMessage>? inputMessages,
            global::System.Collections.Generic.IList<global::Weave.NormalizedMessage>? outputMessages,
            global::System.Collections.Generic.IList<string>? systemInstructions,
            string? toolCallArguments,
            string? toolCallResult,
            string? compactionSummary,
            int? compactionItemsBefore,
            int? compactionItemsAfter,
            global::System.Collections.Generic.IList<string>? contentRefs,
            global::System.Collections.Generic.IList<string>? artifactRefs,
            global::System.Collections.Generic.IList<string>? objectRefs,
            global::System.Collections.Generic.Dictionary<string, string>? customAttrsString,
            global::System.Collections.Generic.Dictionary<string, int>? customAttrsInt,
            global::System.Collections.Generic.Dictionary<string, double>? customAttrsFloat,
            global::System.Collections.Generic.Dictionary<string, bool>? customAttrsBool,
            string? serverAddress,
            int? serverPort,
            string? wbUserId,
            string? wbRunId,
            int? wbRunStep,
            int? wbRunStepEnd,
            string? rawSpanDump)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.TraceId = traceId ?? throw new global::System.ArgumentNullException(nameof(traceId));
            this.SpanId = spanId ?? throw new global::System.ArgumentNullException(nameof(spanId));
            this.ParentSpanId = parentSpanId;
            this.SpanName = spanName;
            this.SpanKind = spanKind;
            this.StartedAt = startedAt;
            this.EndedAt = endedAt;
            this.StatusCode = statusCode;
            this.StatusMessage = statusMessage;
            this.OperationName = operationName;
            this.ProviderName = providerName;
            this.AgentName = agentName;
            this.AgentId = agentId;
            this.AgentDescription = agentDescription;
            this.AgentVersion = agentVersion;
            this.RequestModel = requestModel;
            this.ResponseModel = responseModel;
            this.ResponseId = responseId;
            this.InputTokens = inputTokens;
            this.OutputTokens = outputTokens;
            this.ReasoningTokens = reasoningTokens;
            this.CacheCreationInputTokens = cacheCreationInputTokens;
            this.CacheReadInputTokens = cacheReadInputTokens;
            this.ReasoningContent = reasoningContent;
            this.ConversationId = conversationId;
            this.ConversationName = conversationName;
            this.ToolName = toolName;
            this.ToolType = toolType;
            this.ToolCallId = toolCallId;
            this.ToolDescription = toolDescription;
            this.ToolDefinitions = toolDefinitions;
            this.FinishReasons = finishReasons;
            this.ErrorType = errorType;
            this.RequestTemperature = requestTemperature;
            this.RequestMaxTokens = requestMaxTokens;
            this.RequestTopP = requestTopP;
            this.RequestFrequencyPenalty = requestFrequencyPenalty;
            this.RequestPresencePenalty = requestPresencePenalty;
            this.RequestSeed = requestSeed;
            this.RequestStopSequences = requestStopSequences;
            this.RequestChoiceCount = requestChoiceCount;
            this.OutputType = outputType;
            this.InputMessages = inputMessages;
            this.OutputMessages = outputMessages;
            this.SystemInstructions = systemInstructions;
            this.ToolCallArguments = toolCallArguments;
            this.ToolCallResult = toolCallResult;
            this.CompactionSummary = compactionSummary;
            this.CompactionItemsBefore = compactionItemsBefore;
            this.CompactionItemsAfter = compactionItemsAfter;
            this.ContentRefs = contentRefs;
            this.ArtifactRefs = artifactRefs;
            this.ObjectRefs = objectRefs;
            this.CustomAttrsString = customAttrsString;
            this.CustomAttrsInt = customAttrsInt;
            this.CustomAttrsFloat = customAttrsFloat;
            this.CustomAttrsBool = customAttrsBool;
            this.ServerAddress = serverAddress;
            this.ServerPort = serverPort;
            this.WbUserId = wbUserId;
            this.WbRunId = wbRunId;
            this.WbRunStep = wbRunStep;
            this.WbRunStepEnd = wbRunStepEnd;
            this.RawSpanDump = rawSpanDump;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSpanSchema" /> class.
        /// </summary>
        public AgentSpanSchema()
        {
        }

    }
}