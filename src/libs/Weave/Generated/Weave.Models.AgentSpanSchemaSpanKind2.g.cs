
#nullable enable

namespace Weave
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentSpanSchemaSpanKind2
    {
        /// <summary>
        /// 
        /// </summary>
        Client,
        /// <summary>
        /// 
        /// </summary>
        Consumer,
        /// <summary>
        /// 
        /// </summary>
        Internal,
        /// <summary>
        /// 
        /// </summary>
        Producer,
        /// <summary>
        /// 
        /// </summary>
        Server,
        /// <summary>
        /// 
        /// </summary>
        Unspecified,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentSpanSchemaSpanKind2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentSpanSchemaSpanKind2 value)
        {
            return value switch
            {
                AgentSpanSchemaSpanKind2.Client => "CLIENT",
                AgentSpanSchemaSpanKind2.Consumer => "CONSUMER",
                AgentSpanSchemaSpanKind2.Internal => "INTERNAL",
                AgentSpanSchemaSpanKind2.Producer => "PRODUCER",
                AgentSpanSchemaSpanKind2.Server => "SERVER",
                AgentSpanSchemaSpanKind2.Unspecified => "UNSPECIFIED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentSpanSchemaSpanKind2? ToEnum(string value)
        {
            return value switch
            {
                "CLIENT" => AgentSpanSchemaSpanKind2.Client,
                "CONSUMER" => AgentSpanSchemaSpanKind2.Consumer,
                "INTERNAL" => AgentSpanSchemaSpanKind2.Internal,
                "PRODUCER" => AgentSpanSchemaSpanKind2.Producer,
                "SERVER" => AgentSpanSchemaSpanKind2.Server,
                "UNSPECIFIED" => AgentSpanSchemaSpanKind2.Unspecified,
                _ => null,
            };
        }
    }
}