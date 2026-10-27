using System.Globalization;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace DotnetBenchmarks;

[MemoryDiagnoser]
[HideColumns("Error", "StdDev", "Gen0", "Gen1", "Gen2")]
[SimpleJob(RuntimeMoniker.Net10_0, baseline: true)]
[SimpleJob(RuntimeMoniker.Net11_0)]
public class NumericsBenchmarks
{
    private readonly string _longFraction = "0." + new string('1', 768);

    private readonly Random _random = new(42);

    [Benchmark]
    public double DoubleParseLongFraction() => double.Parse(_longFraction, CultureInfo.InvariantCulture);

    [Benchmark]
    public int RandomNext()
    {
        int sum = 0;
        for (int i = 0; i < 1024; i++)
        {
            sum += _random.Next();
        }

        return sum;
    }
}
