
#nullable enable

namespace Weave
{
    /// <summary>
    ///
    /// </summary>
    public enum AgentSpanSchemaSpanKind
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
    public static class AgentSpanSchemaSpanKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentSpanSchemaSpanKind value)
        {
            return value switch
            {
                AgentSpanSchemaSpanKind.Client => "CLIENT",
                AgentSpanSchemaSpanKind.Consumer => "CONSUMER",
                AgentSpanSchemaSpanKind.Internal => "INTERNAL",
                AgentSpanSchemaSpanKind.Producer => "PRODUCER",
                AgentSpanSchemaSpanKind.Server => "SERVER",
                AgentSpanSchemaSpanKind.Unspecified => "UNSPECIFIED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentSpanSchemaSpanKind? ToEnum(string value)
        {
            return value switch
            {
                "CLIENT" => AgentSpanSchemaSpanKind.Client,
                "CONSUMER" => AgentSpanSchemaSpanKind.Consumer,
                "INTERNAL" => AgentSpanSchemaSpanKind.Internal,
                "PRODUCER" => AgentSpanSchemaSpanKind.Producer,
                "SERVER" => AgentSpanSchemaSpanKind.Server,
                "UNSPECIFIED" => AgentSpanSchemaSpanKind.Unspecified,
                _ => null,
            };
        }
    }
}