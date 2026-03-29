#nullable enable

namespace Weave
{
    public partial interface IFilesClient
    {
        /// <summary>
        /// Files Stats
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weave.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.FilesStatsRes> FilesStatsFilesQueryStatsPostAsync(

            global::Weave.FilesStatsReq request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Files Stats
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.FilesStatsRes> FilesStatsFilesQueryStatsPostAsync(
            string projectId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}