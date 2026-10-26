using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace DotnetBenchmarks;

[MemoryDiagnoser]
[HideColumns("Error", "StdDev", "Gen0", "Gen1", "Gen2")]
[SimpleJob(RuntimeMoniker.Net10_0, baseline: true)]
[SimpleJob(RuntimeMoniker.Net11_0)]
public class StringAndSpanBenchmarks
{
    private readonly string _splitInput = new('a', 16_384);

    private readonly Guid[] _guids1 = new Guid[2];
    private readonly Guid[] _guids2 = new Guid[2];

    private readonly int[] _unsorted = Enumerable.Range(0, 512).Select(i => (i * 257) % 512).ToArray();
    private readonly int[] _sortBuffer = new int[512];

    [Benchmark]
    public int SplitNoSeparators() => _splitInput.Split(',').Length;

    [Benchmark]
    public bool GuidSequenceEqual() => _guids1.AsSpan().SequenceEqual(_guids2);

    [Benchmark]
    public int SpanSortStructComparer()
    {
        // Sorting is in-place, so restore the unsorted input each invocation.
        _unsorted.CopyTo(_sortBuffer);
        _sortBuffer.AsSpan().Sort(new DescendingComparer());
        return _sortBuffer[0];
    }

    private readonly struct DescendingComparer : IComparer<int>
    {
        public int Compare(int x, int y) => y.CompareTo(x);
    }
}
