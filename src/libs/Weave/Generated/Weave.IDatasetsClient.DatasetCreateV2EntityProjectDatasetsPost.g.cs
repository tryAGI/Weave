#nullable enable

namespace Weave
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Dataset Create<br/>
        /// Create a dataset object.
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="project"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weave.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.DatasetCreateRes> DatasetCreateV2EntityProjectDatasetsPostAsync(
            string entity,
            string project,

            global::Weave.DatasetCreateBody request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Dataset Create<br/>
        /// Create a dataset object.
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="project"></param>
        /// <param name="name">
        /// The name of this dataset.  Datasets with the same name will be versioned together.
        /// </param>
        /// <param name="description">
        /// A description of this dataset
        /// </param>
        /// <param name="rows">
        /// Dataset rows
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.DatasetCreateRes> DatasetCreateV2EntityProjectDatasetsPostAsync(
            string entity,
            string project,
            global::System.Collections.Generic.IList<object> rows,
            string? name = default,
            string? description = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}