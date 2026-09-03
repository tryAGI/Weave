
#nullable enable

namespace Weave
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CompletionsCreateRequestInputs
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        public global::System.Collections.Generic.IList<object>? Messages { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Weave.JsonConverters.AnyOfJsonConverter<double?, string, object>))]
        public global::Weave.AnyOf<double?, string, object>? Timeout { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_p")]
        public double? TopP { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("n")]
        public int? N { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Weave.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<object>, object>))]
        public global::Weave.AnyOf<string, global::System.Collections.Generic.IList<object>, object>? Stop { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_completion_tokens")]
        public int? MaxCompletionTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens")]
        public int? MaxTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modalities")]
        public global::System.Collections.Generic.IList<object>? Modalities { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presence_penalty")]
        public double? PresencePenalty { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frequency_penalty")]
        public double? FrequencyPenalty { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logit_bias")]
        public object? LogitBias { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public string? User { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_format")]
        public object? ResponseFormat { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<object>? Tools { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_choice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Weave.JsonConverters.AnyOfJsonConverter<string, object, object>))]
        public global::Weave.AnyOf<string, object, object>? ToolChoice { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logprobs")]
        public bool? Logprobs { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_logprobs")]
        public int? TopLogprobs { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parallel_tool_calls")]
        public bool? ParallelToolCalls { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning_effort")]
        public string? ReasoningEffort { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extra_headers")]
        public object? ExtraHeaders { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("functions")]
        public global::System.Collections.Generic.IList<object>? Functions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function_call")]
        public string? FunctionCall { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_version")]
        public string? ApiVersion { get; set; }

        /// <summary>
        /// Reference to a Weave Prompt object (e.g., 'weave:///entity/project/object/prompt_name:version'). If provided, the messages from this prompt will be prepended to the messages in this request. Template variables in the prompt messages can be substituted using the template_vars parameter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Dictionary of template variables to substitute in prompt messages. Variables in messages like '{variable_name}' will be replaced with the corresponding values. Applied to both prompt messages (if prompt is provided) and regular messages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template_vars")]
        public object? TemplateVars { get; set; }

        /// <summary>
        /// JSON string of Vertex AI service account credentials. When provided for vertex_ai models (e.g. vertex_ai/gemini-2.5-pro), used for authentication instead of api_key. Not persisted in trace storage.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vertex_credentials")]
        public string? VertexCredentials { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionsCreateRequestInputs" /> class.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="messages">
        /// Default Value: []
        /// </param>
        /// <param name="timeout"></param>
        /// <param name="temperature"></param>
        /// <param name="topP"></param>
        /// <param name="n"></param>
        /// <param name="stop"></param>
        /// <param name="maxCompletionTokens"></param>
        /// <param name="maxTokens"></param>
        /// <param name="modalities"></param>
        /// <param name="presencePenalty"></param>
        /// <param name="frequencyPenalty"></param>
        /// <param name="stream"></param>
        /// <param name="logitBias"></param>
        /// <param name="user"></param>
        /// <param name="responseFormat"></param>
        /// <param name="seed"></param>
        /// <param name="tools"></param>
        /// <param name="toolChoice"></param>
        /// <param name="logprobs"></param>
        /// <param name="topLogprobs"></param>
        /// <param name="parallelToolCalls"></param>
        /// <param name="reasoningEffort"></param>
        /// <param name="extraHeaders"></param>
        /// <param name="functions"></param>
        /// <param name="functionCall"></param>
        /// <param name="apiVersion"></param>
        /// <param name="prompt">
        /// Reference to a Weave Prompt object (e.g., 'weave:///entity/project/object/prompt_name:version'). If provided, the messages from this prompt will be prepended to the messages in this request. Template variables in the prompt messages can be substituted using the template_vars parameter.
        /// </param>
        /// <param name="templateVars">
        /// Dictionary of template variables to substitute in prompt messages. Variables in messages like '{variable_name}' will be replaced with the corresponding values. Applied to both prompt messages (if prompt is provided) and regular messages.
        /// </param>
        /// <param name="vertexCredentials">
        /// JSON string of Vertex AI service account credentials. When provided for vertex_ai models (e.g. vertex_ai/gemini-2.5-pro), used for authentication instead of api_key. Not persisted in trace storage.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CompletionsCreateRequestInputs(
            string model,
            global::System.Collections.Generic.IList<object>? messages,
            global::Weave.AnyOf<double?, string, object>? timeout,
            double? temperature,
            double? topP,
            int? n,
            global::Weave.AnyOf<string, global::System.Collections.Generic.IList<object>, object>? stop,
            int? maxCompletionTokens,
            int? maxTokens,
            global::System.Collections.Generic.IList<object>? modalities,
            double? presencePenalty,
            double? frequencyPenalty,
            bool? stream,
            object? logitBias,
            string? user,
            object? responseFormat,
            int? seed,
            global::System.Collections.Generic.IList<object>? tools,
            global::Weave.AnyOf<string, object, object>? toolChoice,
            bool? logprobs,
            int? topLogprobs,
            bool? parallelToolCalls,
            string? reasoningEffort,
            object? extraHeaders,
            global::System.Collections.Generic.IList<object>? functions,
            string? functionCall,
            string? apiVersion,
            string? prompt,
            object? templateVars,
            string? vertexCredentials)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Messages = messages;
            this.Timeout = timeout;
            this.Temperature = temperature;
            this.TopP = topP;
            this.N = n;
            this.Stop = stop;
            this.MaxCompletionTokens = maxCompletionTokens;
            this.MaxTokens = maxTokens;
            this.Modalities = modalities;
            this.PresencePenalty = presencePenalty;
            this.FrequencyPenalty = frequencyPenalty;
            this.Stream = stream;
            this.LogitBias = logitBias;
            this.User = user;
            this.ResponseFormat = responseFormat;
            this.Seed = seed;
            this.Tools = tools;
            this.ToolChoice = toolChoice;
            this.Logprobs = logprobs;
            this.TopLogprobs = topLogprobs;
            this.ParallelToolCalls = parallelToolCalls;
            this.ReasoningEffort = reasoningEffort;
            this.ExtraHeaders = extraHeaders;
            this.Functions = functions;
            this.FunctionCall = functionCall;
            this.ApiVersion = apiVersion;
            this.Prompt = prompt;
            this.TemplateVars = templateVars;
            this.VertexCredentials = vertexCredentials;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionsCreateRequestInputs" /> class.
        /// </summary>
        public CompletionsCreateRequestInputs()
        {
        }

    }
}