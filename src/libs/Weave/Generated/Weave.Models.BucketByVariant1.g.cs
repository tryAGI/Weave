#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Weave
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct BucketByVariant1 : global::System.IEquatable<BucketByVariant1>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Weave.AgentSpanStatsReqBucketByVariant1DiscriminatorType? Type { get; }

        /// <summary>
        /// Bucket stats rows by started_at time intervals.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Weave.AgentSpanStatsTimeBucketSpec? Time { get; init; }
#else
        public global::Weave.AgentSpanStatsTimeBucketSpec? Time { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Time))]
#endif
        public bool IsTime => Time != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTime(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Weave.AgentSpanStatsTimeBucketSpec? value)
        {
            value = Time;
            return IsTime;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Weave.AgentSpanStatsTimeBucketSpec PickTime() => IsTime
            ? Time!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Time' but the value was {ToString()}.");

        /// <summary>
        /// Bucket stats rows by ranges of one numeric span or grouped value.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Weave.AgentSpanStatsNumericBucketSpec? Number { get; init; }
#else
        public global::Weave.AgentSpanStatsNumericBucketSpec? Number { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Number))]
#endif
        public bool IsNumber => Number != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickNumber(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Weave.AgentSpanStatsNumericBucketSpec? value)
        {
            value = Number;
            return IsNumber;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Weave.AgentSpanStatsNumericBucketSpec PickNumber() => IsNumber
            ? Number!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Number' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BucketByVariant1(global::Weave.AgentSpanStatsTimeBucketSpec value) => new BucketByVariant1((global::Weave.AgentSpanStatsTimeBucketSpec?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Weave.AgentSpanStatsTimeBucketSpec?(BucketByVariant1 @this) => @this.Time;

        /// <summary>
        /// 
        /// </summary>
        public BucketByVariant1(global::Weave.AgentSpanStatsTimeBucketSpec? value)
        {
            Time = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BucketByVariant1 FromTime(global::Weave.AgentSpanStatsTimeBucketSpec? value) => new BucketByVariant1(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BucketByVariant1(global::Weave.AgentSpanStatsNumericBucketSpec value) => new BucketByVariant1((global::Weave.AgentSpanStatsNumericBucketSpec?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Weave.AgentSpanStatsNumericBucketSpec?(BucketByVariant1 @this) => @this.Number;

        /// <summary>
        /// 
        /// </summary>
        public BucketByVariant1(global::Weave.AgentSpanStatsNumericBucketSpec? value)
        {
            Number = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BucketByVariant1 FromNumber(global::Weave.AgentSpanStatsNumericBucketSpec? value) => new BucketByVariant1(value);

        /// <summary>
        /// 
        /// </summary>
        public BucketByVariant1(
            global::Weave.AgentSpanStatsReqBucketByVariant1DiscriminatorType? type,
            global::Weave.AgentSpanStatsTimeBucketSpec? time,
            global::Weave.AgentSpanStatsNumericBucketSpec? number
            )
        {
            Type = type;

            Time = time;
            Number = number;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Number as object ??
            Time as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Time?.ToString() ??
            Number?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsTime && !IsNumber || !IsTime && IsNumber;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Weave.AgentSpanStatsTimeBucketSpec, TResult>? time = null,
            global::System.Func<global::Weave.AgentSpanStatsNumericBucketSpec, TResult>? number = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTime && time != null)
            {
                return time(Time!);
            }
            else if (IsNumber && number != null)
            {
                return number(Number!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Weave.AgentSpanStatsTimeBucketSpec>? time = null,

            global::System.Action<global::Weave.AgentSpanStatsNumericBucketSpec>? number = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTime)
            {
                time?.Invoke(Time!);
            }
            else if (IsNumber)
            {
                number?.Invoke(Number!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Weave.AgentSpanStatsTimeBucketSpec>? time = null,
            global::System.Action<global::Weave.AgentSpanStatsNumericBucketSpec>? number = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTime)
            {
                time?.Invoke(Time!);
            }
            else if (IsNumber)
            {
                number?.Invoke(Number!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Time,
                typeof(global::Weave.AgentSpanStatsTimeBucketSpec),
                Number,
                typeof(global::Weave.AgentSpanStatsNumericBucketSpec),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(BucketByVariant1 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Weave.AgentSpanStatsTimeBucketSpec?>.Default.Equals(Time, other.Time) &&
                global::System.Collections.Generic.EqualityComparer<global::Weave.AgentSpanStatsNumericBucketSpec?>.Default.Equals(Number, other.Number) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BucketByVariant1 obj1, BucketByVariant1 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BucketByVariant1>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BucketByVariant1 obj1, BucketByVariant1 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BucketByVariant1 o && Equals(o);
        }
    }
}
