#nullable enable

namespace Weave
{
    public partial interface IOpenTelemetryClient
    {
        /// <summary>
        /// Export Trace
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weave.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ExportTraceOtelV1TracesPostAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}