#nullable enable

namespace Weave
{
    public partial interface IScoresClient
    {
        /// <summary>
        /// Score Read<br/>
        /// Read a score.
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="project"></param>
        /// <param name="scoreId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weave.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.ScoreReadRes> ScoreReadV2EntityProjectScoresScoreIdGetAsync(
            string entity,
            string project,
            string scoreId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}