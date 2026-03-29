#nullable enable

namespace Weave
{
    public partial interface IFilesClient
    {
        /// <summary>
        /// File Create
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weave.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.FileCreateRes> FileCreateFileCreatePostAsync(

            global::Weave.BodyFileCreateFileCreatePost request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// File Create
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="file"></param>
        /// <param name="filename"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.FileCreateRes> FileCreateFileCreatePostAsync(
            string projectId,
            byte[] file,
            string filename,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}