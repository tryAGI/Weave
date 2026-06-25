
#nullable enable

namespace Weave
{
    /// <summary>
    /// Schema for inserting a completed call directly.<br/>
    /// This represents a call that is already finished at insertion time, with both<br/>
    /// start and end information provided together. Used by the calls_complete endpoint.
    /// </summary>
    public sealed partial class CompletedCallSchemaForInsert
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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TraceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("op_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OpName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StartedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ended_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime EndedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_id")]
        public string? ParentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thread_id")]
        public string? ThreadId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turn_id")]
        public string? TurnId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Attributes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Inputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public object? Output { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Weave.SummaryInsertMap Summary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("otel_dump")]
        public object? OtelDump { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exception")]
        public string? Exception { get; set; }

        /// <summary>
        /// Do not set directly. Server will automatically populate this field.
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletedCallSchemaForInsert" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="id"></param>
        /// <param name="traceId"></param>
        /// <param name="opName"></param>
        /// <param name="startedAt"></param>
        /// <param name="endedAt"></param>
        /// <param name="attributes"></param>
        /// <param name="inputs"></param>
        /// <param name="summary"></param>
        /// <param name="displayName"></param>
        /// <param name="parentId"></param>
        /// <param name="threadId"></param>
        /// <param name="turnId"></param>
        /// <param name="output"></param>
        /// <param name="otelDump"></param>
        /// <param name="exception"></param>
        /// <param name="wbUserId">
        /// Do not set directly. Server will automatically populate this field.
        /// </param>
        /// <param name="wbRunId"></param>
        /// <param name="wbRunStep"></param>
        /// <param name="wbRunStepEnd"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CompletedCallSchemaForInsert(
            string projectId,
            string id,
            string traceId,
            string opName,
            global::System.DateTime startedAt,
            global::System.DateTime endedAt,
            object attributes,
            object inputs,
            global::Weave.SummaryInsertMap summary,
            string? displayName,
            string? parentId,
            string? threadId,
            string? turnId,
            object? output,
            object? otelDump,
            string? exception,
            string? wbUserId,
            string? wbRunId,
            int? wbRunStep,
            int? wbRunStepEnd)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.TraceId = traceId ?? throw new global::System.ArgumentNullException(nameof(traceId));
            this.OpName = opName ?? throw new global::System.ArgumentNullException(nameof(opName));
            this.StartedAt = startedAt;
            this.EndedAt = endedAt;
            this.DisplayName = displayName;
            this.ParentId = parentId;
            this.ThreadId = threadId;
            this.TurnId = turnId;
            this.Attributes = attributes ?? throw new global::System.ArgumentNullException(nameof(attributes));
            this.Inputs = inputs ?? throw new global::System.ArgumentNullException(nameof(inputs));
            this.Output = output;
            this.Summary = summary ?? throw new global::System.ArgumentNullException(nameof(summary));
            this.OtelDump = otelDump;
            this.Exception = exception;
            this.WbUserId = wbUserId;
            this.WbRunId = wbRunId;
            this.WbRunStep = wbRunStep;
            this.WbRunStepEnd = wbRunStepEnd;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletedCallSchemaForInsert" /> class.
        /// </summary>
        public CompletedCallSchemaForInsert()
        {
        }

    }
}