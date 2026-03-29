#nullable enable

namespace Weave
{
    public partial interface IOpsClient
    {
        /// <summary>
        /// Op Read<br/>
        /// Get an op object.
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="project"></param>
        /// <param name="objectId"></param>
        /// <param name="digest"></param>
        /// <param name="eager">
        /// Whether to eagerly load the op code<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weave.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.OpReadRes> OpReadV2EntityProjectOpsObjectIdVersionsDigestGetAsync(
            string entity,
            string project,
            string objectId,
            string digest,
            bool? eager = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}