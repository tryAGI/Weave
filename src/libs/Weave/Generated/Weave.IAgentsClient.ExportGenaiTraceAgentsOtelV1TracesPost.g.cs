#nullable enable

namespace Weave
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Export Genai Trace<br/>
        /// Ingest OTel spans into the GenAI observability system.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weave.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> ExportGenaiTraceAgentsOtelV1TracesPostAsync(
            global::Weave.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Export Genai Trace<br/>
        /// Ingest OTel spans into the GenAI observability system.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weave.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> ExportGenaiTraceAgentsOtelV1TracesPostAsStreamAsync(
            global::Weave.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Export Genai Trace<br/>
        /// Ingest OTel spans into the GenAI observability system.
        /// </summary>
        /// <returns>The response metadata and an unbuffered body stream. The caller must dispose Body to release the HTTP response.</returns>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weave.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.AutoSDKHttpResponse<global::System.IO.Stream>> ExportGenaiTraceAgentsOtelV1TracesPostAsStreamAsResponseAsync(
            global::Weave.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Export Genai Trace<br/>
        /// Ingest OTel spans into the GenAI observability system.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weave.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.AutoSDKHttpResponse<byte[]>> ExportGenaiTraceAgentsOtelV1TracesPostAsResponseAsync(
            global::Weave.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}