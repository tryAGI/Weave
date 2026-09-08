
#nullable enable

namespace Weave
{
    /// <summary>
    ///
    /// </summary>
    public enum SourceKind
    {
        /// <summary>
        ///
        /// </summary>
        Call,
        /// <summary>
        ///
        /// </summary>
        Conversation,
        /// <summary>
        ///
        /// </summary>
        Span,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SourceKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SourceKind value)
        {
            return value switch
            {
                SourceKind.Call => "call",
                SourceKind.Conversation => "conversation",
                SourceKind.Span => "span",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SourceKind? ToEnum(string value)
        {
            return value switch
            {
                "call" => SourceKind.Call,
                "conversation" => SourceKind.Conversation,
                "span" => SourceKind.Span,
                _ => null,
            };
        }
    }
}