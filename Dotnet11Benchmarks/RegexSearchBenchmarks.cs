using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using System.Text.RegularExpressions;

namespace DotnetBenchmarks;

[MemoryDiagnoser]
[HideColumns("Error", "StdDev", "Gen0", "Gen1", "Gen2")]
[SimpleJob(RuntimeMoniker.Net10_0, baseline: true)]
[SimpleJob(RuntimeMoniker.Net11_0)]
public partial class RegexSearchBenchmarks
{
    private readonly string _sharedPrefixInput = new('a', 4_096);
    private readonly string _literalAlternationInput = new string('a', 100_000) + "tttaccct";
    private readonly string _anchoredTooLong = new('a', 513);

    [Benchmark]
    public bool SharedPrefixAlternation() => SharedPrefix.IsMatch(_sharedPrefixInput);

    [Benchmark]
    public bool LiteralAlternation() => Literals.IsMatch(_literalAlternationInput);

    [Benchmark]
    public bool AnchoredLengthReject() => Anchored.IsMatch(_anchoredTooLong);

    [GeneratedRegex("[ab]+c[ab]+|[ab]+")]
    private static partial Regex SharedPrefix { get; }

    [GeneratedRegex("agggtaaa|tttaccct")]
    private static partial Regex Literals { get; }

    [GeneratedRegex(@"\A[a-z]{512}\z")]
    private static partial Regex Anchored { get; }
}
