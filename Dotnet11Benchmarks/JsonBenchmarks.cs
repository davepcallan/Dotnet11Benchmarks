using System.Text.Json;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace DotnetBenchmarks;

[MemoryDiagnoser]
[HideColumns("Error", "StdDev", "Gen0", "Gen1", "Gen2")]
[SimpleJob(RuntimeMoniker.Net10_0, baseline: true)]
[SimpleJob(RuntimeMoniker.Net11_0)]
public class JsonBenchmarks
{
    private static readonly string s_fullyEscaped = new('"', 2_048);

    private static readonly string s_html = string.Concat(Enumerable.Repeat("<p class=\"note\">Tom & Jerry's \"best\" bits</p>", 40));

    [Benchmark]
    public byte[] SerializeEscapedString() => JsonSerializer.SerializeToUtf8Bytes(s_fullyEscaped);

    [Benchmark]
    public byte[] SerializeHtmlString() => JsonSerializer.SerializeToUtf8Bytes(s_html);
}
