using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using System.Collections.Frozen;

namespace DotnetBenchmarks;

[MemoryDiagnoser]
[HideColumns("Error", "StdDev", "Gen0", "Gen1", "Gen2")]
[SimpleJob(RuntimeMoniker.Net10_0, baseline: true)]
[SimpleJob(RuntimeMoniker.Net11_0)]
public class FrozenCollectionBenchmark
{
    private readonly KeyValuePair<int, int>[] _pairs =
        Enumerable.Range(0, 4_096).Select(i => new KeyValuePair<int, int>(i, i)).ToArray();

    [Benchmark]
    public FrozenDictionary<int, int> ToFrozenDictionary() => _pairs.ToFrozenDictionary();
}