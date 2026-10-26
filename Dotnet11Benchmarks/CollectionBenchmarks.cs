using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace DotnetBenchmarks;

[MemoryDiagnoser]
[HideColumns("Error", "StdDev", "Gen0", "Gen1", "Gen2")]
[SimpleJob(RuntimeMoniker.Net10_0, baseline: true)]
[SimpleJob(RuntimeMoniker.Net11_0)]
public class CollectionBenchmarks
{
    private readonly HashSet<int> _set = Enumerable.Range(0, 4_096).ToHashSet();
    private readonly int[] _probes = Enumerable.Range(0, 4_096).ToArray();

    private readonly HashSet<int> _unionSource = new(Enumerable.Range(0, 4_096));

    private readonly int[] _findAllData = Enumerable.Range(0, 4).ToArray();

    [Benchmark]
    public int HashSetContains()
    {
        int count = 0;
        foreach (int value in _probes)
        {
            count += _set.Contains(value) ? 1 : 0;
        }

        return count;
    }

    [Benchmark]
    public HashSet<int> HashSetUnionWithIntoEmpty()
    {
        HashSet<int> destination = [];
        destination.UnionWith(_unionSource);
        return destination;
    }

    [Benchmark]
    public int[] ArrayFindAllSmallResult() => Array.FindAll(_findAllData, static _ => true);
}
