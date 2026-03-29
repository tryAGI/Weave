#nullable enable

namespace Weave
{
    public partial interface IServiceClient
    {
        /// <summary>
        /// Projects Info
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weave.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Weave.ProjectsInfoRes>> ProjectsInfoServiceProjectsInfoPostAsync(

            global::Weave.ProjectsInfoReq request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Projects Info
        /// </summary>
        /// <param name="projectIds">
        /// External project IDs in 'entity/project' format.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Weave.ProjectsInfoRes>> ProjectsInfoServiceProjectsInfoPostAsync(
            global::System.Collections.Generic.IList<string> projectIds,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}