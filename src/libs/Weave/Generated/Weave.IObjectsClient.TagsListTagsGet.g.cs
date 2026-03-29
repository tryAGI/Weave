#nullable enable

namespace Weave
{
    public partial interface IObjectsClient
    {
        /// <summary>
        /// Tags List<br/>
        /// List all tags in a project.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weave.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.TagsListRes> TagsListTagsGetAsync(
            string projectId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}