#pragma warning disable CS3002 // Return type is not CLS-compliant
using System.Text.Json;
using Microsoft.Extensions.AI;

namespace Weave;

/// <summary>
/// Extensions for using WeaveClient operations as MEAI tools with any IChatClient.
/// </summary>
public static class WeaveToolExtensions
{
    /// <summary>
    /// Creates an <see cref="AIFunction"/> that lists traced calls/spans for a project.
    /// Useful for agents that need to inspect LLM call history, latencies, and errors.
    /// </summary>
    /// <param name="client">The Weave client.</param>
    /// <param name="limit">Maximum number of calls to return (default: 20).</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsListCallsTool(
        this WeaveClient client,
        int limit = 20)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string projectId, string? opName, CancellationToken cancellationToken) =>
            {
                var filter = opName is { Length: > 0 }
                    ? new CallsFilter
                    {
                        OpNames = [opName],
                    }
                    : null;

                var response = await client.Calls.CallsQueryStreamCallsStreamQueryPostAsync(
                    projectId: projectId,
                    filter: filter,
                    limit: limit,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return response;
            },
            name: "ListCalls",
            description: "Lists traced LLM calls/spans for a W&B Weave project. Provide a projectId (entity/project format). Optionally filter by opName. Returns call IDs, operation names, timestamps, and status.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that reads a specific call by ID.
    /// Useful for agents that need to inspect inputs, outputs, and metadata of a traced call.
    /// </summary>
    /// <param name="client">The Weave client.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsGetCallTool(this WeaveClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string projectId, string callId, CancellationToken cancellationToken) =>
            {
                var response = await client.Calls.CallReadCallReadPostAsync(
                    projectId: projectId,
                    id: callId,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                var call = response.Call;
                if (call is null)
                {
                    return "Call not found.";
                }

                return JsonSerializer.Serialize(new
                {
                    id = call.Id,
                    op_name = call.OpName,
                    display_name = call.DisplayName,
                    trace_id = call.TraceId,
                    parent_id = call.ParentId,
                    started_at = call.StartedAt,
                    ended_at = call.EndedAt,
                    exception = call.Exception,
                    summary = call.Summary,
                });
            },
            name: "GetCall",
            description: "Reads a specific traced call/span by ID from W&B Weave. Returns the call's operation name, timestamps, trace ID, parent ID, and summary. Provide projectId (entity/project format) and callId.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that lists tracked objects (models, datasets, evaluations, etc.) in a project.
    /// Useful for agents that need to discover what assets are available in a Weave project.
    /// </summary>
    /// <param name="client">The Weave client.</param>
    /// <param name="limit">Maximum number of objects to return (default: 20).</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsListObjectsTool(
        this WeaveClient client,
        int limit = 20)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string projectId, string? baseObjectClass, CancellationToken cancellationToken) =>
            {
                var filter = baseObjectClass is { Length: > 0 }
                    ? new ObjectVersionFilter
                    {
                        BaseObjectClasses = [baseObjectClass],
                        LatestOnly = true,
                    }
                    : new ObjectVersionFilter
                    {
                        LatestOnly = true,
                    };

                var response = await client.Objects.ObjsQueryObjsQueryPostAsync(
                    projectId: projectId,
                    filter: filter,
                    limit: limit,
                    metadataOnly: true,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return JsonSerializer.Serialize(response.Objs.Select(o => new
                {
                    object_id = o.ObjectId,
                    kind = o.Kind,
                    base_object_class = o.BaseObjectClass,
                    created_at = o.CreatedAt,
                    version_index = o.VersionIndex,
                    digest = o.Digest,
                }));
            },
            name: "ListObjects",
            description: "Lists tracked objects (models, datasets, evaluations, scorers, etc.) in a W&B Weave project. Optionally filter by baseObjectClass (e.g., 'Model', 'Dataset', 'Evaluation'). Returns object IDs, kinds, versions, and digests.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that queries rows from a Weave table.
    /// Useful for agents that need to read dataset contents or evaluation results.
    /// </summary>
    /// <param name="client">The Weave client.</param>
    /// <param name="limit">Maximum number of rows to return (default: 50).</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsQueryTableTool(
        this WeaveClient client,
        int limit = 50)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string projectId, string digest, CancellationToken cancellationToken) =>
            {
                var response = await client.Tables.TableQueryTableQueryPostAsync(
                    projectId: projectId,
                    digest: digest,
                    limit: limit,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return JsonSerializer.Serialize(response.Rows.Select(r => new
                {
                    digest = r.Digest,
                    val = r.Val,
                }));
            },
            name: "QueryTable",
            description: "Queries rows from a W&B Weave table by its digest. Tables store dataset rows and evaluation results. Provide projectId (entity/project format) and the table digest hash. Returns row digests and values.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that adds feedback/scores to a traced call.
    /// Useful for agents that need to annotate calls with quality scores or labels.
    /// </summary>
    /// <param name="client">The Weave client.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsAddFeedbackTool(this WeaveClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string projectId, string weaveRef, string feedbackType, string payload, CancellationToken cancellationToken) =>
            {
                var payloadObj = JsonSerializer.Deserialize<Dictionary<string, object>>(payload) ?? new();

                var response = await client.Feedback.FeedbackCreateFeedbackCreatePostAsync(
                    request: new FeedbackCreateReq
                    {
                        ProjectId = projectId,
                        WeaveRef = weaveRef,
                        FeedbackType = feedbackType,
                        Payload = payloadObj,
                    },
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return JsonSerializer.Serialize(new
                {
                    id = response.Id,
                    created_at = response.CreatedAt,
                    wb_user_id = response.WbUserId,
                });
            },
            name: "AddFeedback",
            description: "Adds feedback or a score to a traced call in W&B Weave. Provide projectId, weaveRef (the call reference), feedbackType (e.g., 'thumbs_up', 'score'), and payload as a JSON string with the feedback data.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that retrieves call statistics for a project.
    /// Useful for agents that need to understand usage patterns, latencies, and error rates.
    /// </summary>
    /// <param name="client">The Weave client.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsGetCallStatsTool(this WeaveClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string projectId, string? opName, CancellationToken cancellationToken) =>
            {
                var filter = opName is { Length: > 0 }
                    ? new CallsFilter
                    {
                        OpNames = [opName],
                    }
                    : null;

                var response = await client.Calls.CallsQueryStatsCallsQueryStatsPostAsync(
                    request: new CallsQueryStatsReq
                    {
                        ProjectId = projectId,
                        Filter = filter,
                    },
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return JsonSerializer.Serialize(new
                {
                    count = response.Count,
                });
            },
            name: "GetCallStats",
            description: "Gets call statistics (count, storage) for a W&B Weave project. Optionally filter by opName. Useful for understanding usage volume and patterns.");
    }
}
