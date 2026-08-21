
#nullable enable

namespace Weave
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ThreadSchema
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thread_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ThreadId { get; set; }

        /// <summary>
        /// Number of turn calls in this thread
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turn_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TurnCount { get; set; }

        /// <summary>
        /// Earliest start time of turn calls in this thread
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StartTime { get; set; }

        /// <summary>
        /// Latest end time of turn calls in this thread
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_updated")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime LastUpdated { get; set; }

        /// <summary>
        /// Turn ID of the first turn in this thread (earliest start_time)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_turn_id")]
        public string? FirstTurnId { get; set; }

        /// <summary>
        /// Turn ID of the latest turn in this thread (latest end_time)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_turn_id")]
        public string? LastTurnId { get; set; }

        /// <summary>
        /// 50th percentile (median) of turn durations in milliseconds within this thread
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("p50_turn_duration_ms")]
        public double? P50TurnDurationMs { get; set; }

        /// <summary>
        /// 99th percentile of turn durations in milliseconds within this thread
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("p99_turn_duration_ms")]
        public double? P99TurnDurationMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreadSchema" /> class.
        /// </summary>
        /// <param name="threadId"></param>
        /// <param name="turnCount">
        /// Number of turn calls in this thread
        /// </param>
        /// <param name="startTime">
        /// Earliest start time of turn calls in this thread
        /// </param>
        /// <param name="lastUpdated">
        /// Latest end time of turn calls in this thread
        /// </param>
        /// <param name="firstTurnId">
        /// Turn ID of the first turn in this thread (earliest start_time)
        /// </param>
        /// <param name="lastTurnId">
        /// Turn ID of the latest turn in this thread (latest end_time)
        /// </param>
        /// <param name="p50TurnDurationMs">
        /// 50th percentile (median) of turn durations in milliseconds within this thread
        /// </param>
        /// <param name="p99TurnDurationMs">
        /// 99th percentile of turn durations in milliseconds within this thread
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ThreadSchema(
            string threadId,
            int turnCount,
            global::System.DateTime startTime,
            global::System.DateTime lastUpdated,
            string? firstTurnId,
            string? lastTurnId,
            double? p50TurnDurationMs,
            double? p99TurnDurationMs)
        {
            this.ThreadId = threadId ?? throw new global::System.ArgumentNullException(nameof(threadId));
            this.TurnCount = turnCount;
            this.StartTime = startTime;
            this.LastUpdated = lastUpdated;
            this.FirstTurnId = firstTurnId;
            this.LastTurnId = lastTurnId;
            this.P50TurnDurationMs = p50TurnDurationMs;
            this.P99TurnDurationMs = p99TurnDurationMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreadSchema" /> class.
        /// </summary>
        public ThreadSchema()
        {
        }

    }
}