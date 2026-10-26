using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using System.Text.RegularExpressions;

namespace DotnetBenchmarks;

[MemoryDiagnoser]
[HideColumns("Error", "StdDev", "Gen0", "Gen1", "Gen2")]
[SimpleJob(RuntimeMoniker.Net10_0, baseline: true)]
[SimpleJob(RuntimeMoniker.Net11_0)]
public partial class RegexBenchmarks
{
    private readonly string _httpInput = string.Concat(Enumerable.Repeat("httx", 25_000)) + "https";
    private readonly string _wordInput = string.Concat(Enumerable.Repeat("xn ", 33_333)) + "in";
    private readonly string _alternationInput = string.Concat(Enumerable.Repeat("p15", 10_000));
    private readonly Regex _compiledAlternation = new(@"(?>a0|b1|c2|d3|e4|f5|g6|h7|i8|j9|k10|l11|m12|n13|o14|p15)", RegexOptions.Compiled);

    [Benchmark]
    public bool IgnoreCaseAlternation() => Http.IsMatch(_httpInput);

    [Benchmark]
    public bool IgnoreCaseWholeWord() => WholeWord.IsMatch(_wordInput);

    [Benchmark]
    public int CompiledAlternation() => _compiledAlternation.Count(_alternationInput);

    [GeneratedRegex("(http|https)", RegexOptions.IgnoreCase)]
    private static partial Regex Http { get; }

    [GeneratedRegex(@"\b(in)\b", RegexOptions.IgnoreCase)]
    private static partial Regex WholeWord { get; }
}
