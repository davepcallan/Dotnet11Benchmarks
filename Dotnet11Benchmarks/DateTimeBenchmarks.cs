using System.Globalization;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace DotnetBenchmarks;

[MemoryDiagnoser]
[HideColumns("Error", "StdDev", "Gen0", "Gen1", "Gen2")]
[SimpleJob(RuntimeMoniker.Net10_0, baseline: true)]
[SimpleJob(RuntimeMoniker.Net11_0)]
public class DateTimeBenchmarks
{
    private readonly DateTime _utc = new(2026, 7, 15, 12, 0, 0, DateTimeKind.Utc);
    private readonly DateTime _local = new(2026, 7, 15, 5, 0, 0, DateTimeKind.Unspecified);
    private readonly TimeZoneInfo _zone = TimeZoneInfo.FindSystemTimeZoneById(
        OperatingSystem.IsWindows() ? "Pacific Standard Time" : "America/Los_Angeles");

    [Benchmark]
    public DateTime Now() => DateTime.Now;

    [Benchmark]
    public DateTime ConvertTimeFromUtc() => TimeZoneInfo.ConvertTimeFromUtc(_utc, _zone);

    [Benchmark]
    public DateTime ConvertTimeToUtc() => TimeZoneInfo.ConvertTimeToUtc(_local, _zone);

    [Benchmark]
    public string ToStringInvariantG() => _utc.ToString("G", CultureInfo.InvariantCulture);
}
