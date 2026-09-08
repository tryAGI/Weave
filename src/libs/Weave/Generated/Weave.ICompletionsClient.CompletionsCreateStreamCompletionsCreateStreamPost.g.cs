#nullable enable

namespace Weave
{
    public partial interface ICompletionsClient
    {
        /// <summary>
        /// Completions Create Stream
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weave.ApiException"></exception>
        global::System.Collections.Generic.IAsyncEnumerable<global::Weave.CompletionsCreateStreamChunk> CompletionsCreateStreamCompletionsCreateStreamPostAsync(

            global::Weave.CompletionsCreateReq request,
            global::Weave.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Completions Create Stream
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="inputs"></param>
        /// <param name="wbUserId">
        /// Do not set directly. Server will automatically populate this field.
        /// </param>
        /// <param name="trackLlmCall">
        /// Whether to track this LLM call in the trace server<br/>
        /// Default Value: true
        /// </param>
        /// <param name="traceId">
        /// Trace ID to use for the LLM call (for nesting under a parent)
        /// </param>
        /// <param name="parentId">
        /// Parent call ID to nest this LLM call under
        /// </param>
        /// <param name="conversationId">
        /// Conversation ID to group related completions into a multi-turn conversation
        /// </param>
        /// <param name="conversationName">
        /// Human-readable conversation name
        /// </param>
        /// <param name="source">
        /// Source of the completion request (e.g. 'playground', 'signals')
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Collections.Generic.IAsyncEnumerable<global::Weave.CompletionsCreateStreamChunk> CompletionsCreateStreamCompletionsCreateStreamPostAsync(
            string projectId,
            global::Weave.CompletionsCreateRequestInputs inputs,
            string? wbUserId = default,
            bool? trackLlmCall = default,
            string? traceId = default,
            string? parentId = default,
            string? conversationId = default,
            string? conversationName = default,
            string? source = default,
            global::Weave.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}