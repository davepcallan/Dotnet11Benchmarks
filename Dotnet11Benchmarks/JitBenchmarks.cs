using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace DotnetBenchmarks;

[MemoryDiagnoser]
[HideColumns("Error", "StdDev", "Gen0", "Gen1", "Gen2")]
[SimpleJob(RuntimeMoniker.Net10_0, baseline: true)]
[SimpleJob(RuntimeMoniker.Net11_0)]
public class JitBenchmarks
{
    private static readonly Value s_other = new(42);

    private static readonly Target s_target = new();
    private static readonly Func<int> s_first = s_target.GetValue;
    private static readonly Func<int> s_second = s_target.GetValue;

    private int? _nullableNull = null;
    private int? _nullableValue = 42;

    [Benchmark]
    public object? BoxNullableNull() => (object?)_nullableNull;

    [Benchmark]
    public object? BoxNullableValue() => (object?)_nullableValue;

    [Benchmark]
    public string? FormatNullableInt() => Format(_nullableValue);

    [Benchmark]
    public bool EqualityComparerDefaultEquals() => EqualityComparer<Value>.Default.Equals(new Value(42), s_other);

    [Benchmark]
    public bool DelegateEquals() => s_first.Equals(s_second);

    [Benchmark]
    public int DelegateGetHashCode() => s_first.GetHashCode();

    private static string? Format<T>(T value)
    {
        if (value is IFormattable formattable)
        {
            return formattable.ToString(null, null);
        }

        return null;
    }

    private sealed class Value(int value)
    {
        private readonly int _value = value;

        public override bool Equals(object? obj) => obj is Value other && _value == other._value;

        public override int GetHashCode() => _value;
    }

    private sealed class Target
    {
        public int GetValue() => 42;
    }
}
