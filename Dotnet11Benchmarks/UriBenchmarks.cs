using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace DotnetBenchmarks;

[MemoryDiagnoser]
[HideColumns("Error", "StdDev", "Gen0", "Gen1", "Gen2")]
[SimpleJob(RuntimeMoniker.Net10_0, baseline: true)]
[SimpleJob(RuntimeMoniker.Net11_0)]
public class UriBenchmarks
{
    private const string ApiAddress = "https://example.com/api/items/42?view=summary#details";
    private const string UnicodeAddress = "https://dot.net/abc/defghijklmno/pqrstuv/wxyz?arch=x64&os=linux&type=release#hello\uD83C\uDF49";

    private readonly string _longHost = $"https://{new string('a', 64)}.example.com/path";
    private readonly string _escapedAscii = "https://example.com/" + string.Concat(Enumerable.Range('a', 26).Select(i => $"%{i:X2}"));

    [Benchmark]
    public Uri ParseApiAddress() => new(ApiAddress);

    [Benchmark]
    public Uri ParseLongHost() => new(_longHost);

    [Benchmark]
    public Uri ParseEscapedAscii() => new(_escapedAscii);

    [Benchmark]
    public Uri ParseWithUnicodeFragment() => new(UnicodeAddress);
}
