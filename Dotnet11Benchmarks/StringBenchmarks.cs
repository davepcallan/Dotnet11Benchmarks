using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace DotnetBenchmarks;

[MemoryDiagnoser]
[HideColumns("Error", "StdDev", "Gen0", "Gen1", "Gen2")]
[SimpleJob(RuntimeMoniker.Net10_0, baseline: true)]
[SimpleJob(RuntimeMoniker.Net11_0)]
public class StringBenchmarks
{
    private readonly IEnumerable<string?> _array = Enumerable.Range(0, 1_000).Select(i => i.ToString()).ToArray();
    private readonly IEnumerable<string?> _list = Enumerable.Range(0, 1_000).Select(i => i.ToString()).ToList();

    [Benchmark]
    public string ConcatArray() => string.Concat(_array);

    [Benchmark]
    public string ConcatList() => string.Concat(_list);
}
