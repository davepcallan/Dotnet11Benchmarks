# BenchmarkDotNet Results

## <a href="Dotnet11Benchmarks/CollectionBenchmarks.cs" target="_blank" rel="noopener noreferrer">CollectionBenchmarks.cs</a>

Source: `Dotnet11Benchmarks\Dotnet11Benchmarks\bin\Release\net10.0\BenchmarkDotNet.Artifacts\results\DotnetBenchmarks.CollectionBenchmarks-report-github.md`

BenchmarkDotNet v0.16.0-preview.2, Windows 10 (10.0.17763.9376/1809/October2018Update/Redstone5) (Hyper-V)  
AMD EPYC 7763 2.44GHz, 1 CPU, 4 logical and 2 physical cores  
Memory: 15.99 GB Total, 7.19 GB Available  
.NET SDK 11.0.100-rc.3.26522.148

- Host: .NET 10.0.14 (10.0.14, 10.0.1426.52326), X64 RyuJIT x86-64-v3
- .NET 10 job: .NET 10.0.14 (10.0.14, 10.0.1426.52326), X64 RyuJIT x86-64-v3
- .NET 11 job: .NET 11.0.0 (11.0.0-rc.3.26522.148, 11.0.26.52348), X64 RyuJIT x86-64-v3

| Method                    | Runtime   | Mean         | Ratio | Allocated | Alloc Ratio |
|-------------------------- |---------- |-------------:|------:|----------:|------------:|
| HashSetContains           | .NET 10.0 | 12,404.98 ns |  1.00 |         - |          NA |
| HashSetContains           | .NET 11.0 | 12,200.66 ns |  0.98 |         - |          NA |
|                           |           |              |       |           |             |
| HashSetUnionWithIntoEmpty | .NET 10.0 | 77,932.47 ns |  1.00 |  258323 B |        1.00 |
| HashSetUnionWithIntoEmpty | .NET 11.0 |  3,173.21 ns |  0.04 |   77896 B |        0.30 |
|                           |           |              |       |           |             |
| ArrayFindAllSmallResult   | .NET 10.0 |     24.97 ns |  1.00 |     112 B |        1.00 |
| ArrayFindAllSmallResult   | .NET 11.0 |     11.26 ns |  0.45 |      40 B |        0.36 |

<br>

## <a href="Dotnet11Benchmarks/DateTimeBenchmarks.cs" target="_blank" rel="noopener noreferrer">DateTimeBenchmarks.cs</a>

Source: `Dotnet11Benchmarks\Dotnet11Benchmarks\bin\Release\net10.0\BenchmarkDotNet.Artifacts\results\DotnetBenchmarks.DateTimeBenchmarks-report-github.md`

BenchmarkDotNet v0.16.0-preview.2, Windows 10 (10.0.17763.9376/1809/October2018Update/Redstone5) (Hyper-V)  
AMD EPYC 7763 2.44GHz, 1 CPU, 4 logical and 2 physical cores  
Memory: 15.99 GB Total, 7.19 GB Available  
.NET SDK 11.0.100-rc.3.26522.148

- Host: .NET 10.0.14 (10.0.14, 10.0.1426.52326), X64 RyuJIT x86-64-v3
- .NET 10 job: .NET 10.0.14 (10.0.14, 10.0.1426.52326), X64 RyuJIT x86-64-v3
- .NET 11 job: .NET 11.0.0 (11.0.0-rc.3.26522.148, 11.0.26.52348), X64 RyuJIT x86-64-v3

| Method             | Runtime   | Mean     | Ratio | Allocated | Alloc Ratio |
|------------------- |---------- |---------:|------:|----------:|------------:|
| Now                | .NET 10.0 | 88.59 ns |  1.00 |         - |          NA |
| Now                | .NET 11.0 | 40.44 ns |  0.46 |         - |          NA |
|                    |           |          |       |           |             |
| ConvertTimeFromUtc | .NET 10.0 | 64.73 ns |  1.00 |         - |          NA |
| ConvertTimeFromUtc | .NET 11.0 | 21.70 ns |  0.34 |         - |          NA |
|                    |           |          |       |           |             |
| ConvertTimeToUtc   | .NET 10.0 | 67.53 ns |  1.00 |         - |          NA |
| ConvertTimeToUtc   | .NET 11.0 | 26.92 ns |  0.40 |         - |          NA |
|                    |           |          |       |           |             |
| ToStringInvariantG | .NET 10.0 | 79.52 ns |  1.00 |      64 B |        1.00 |
| ToStringInvariantG | .NET 11.0 | 18.51 ns |  0.23 |      64 B |        1.00 |

<br>

## <a href="Dotnet11Benchmarks/FrozenCollectionBenchmark.cs" target="_blank" rel="noopener noreferrer">FrozenCollectionBenchmark.cs</a>

Source: `Dotnet11Benchmarks\Dotnet11Benchmarks\bin\Release\net10.0\BenchmarkDotNet.Artifacts\results\DotnetBenchmarks.FrozenCollectionBenchmark-report-github.md`

BenchmarkDotNet v0.16.0-preview.2, Windows 10 (10.0.17763.9376/1809/October2018Update/Redstone5) (Hyper-V)  
AMD EPYC 7763 2.44GHz, 1 CPU, 4 logical and 2 physical cores  
Memory: 15.99 GB Total, 7.19 GB Available  
.NET SDK 11.0.100-rc.3.26522.148

- Host: .NET 10.0.14 (10.0.14, 10.0.1426.52326), X64 RyuJIT x86-64-v3
- .NET 10 job: .NET 10.0.14 (10.0.14, 10.0.1426.52326), X64 RyuJIT x86-64-v3
- .NET 11 job: .NET 11.0.0 (11.0.0-rc.3.26522.148, 11.0.26.52348), X64 RyuJIT x86-64-v3

| Method             | Runtime   | Mean     | Ratio | Allocated | Alloc Ratio |
|------------------- |---------- |---------:|------:|----------:|------------:|
| ToFrozenDictionary | .NET 10.0 | 89.45 μs |  1.00 | 347.18 KB |        1.00 |
| ToFrozenDictionary | .NET 11.0 | 31.79 μs |  0.36 | 127.16 KB |        0.37 |

<br>

## <a href="Dotnet11Benchmarks/JitBenchmarks.cs" target="_blank" rel="noopener noreferrer">JitBenchmarks.cs</a>

Source: `Dotnet11Benchmarks\Dotnet11Benchmarks\bin\Release\net10.0\BenchmarkDotNet.Artifacts\results\DotnetBenchmarks.JitBenchmarks-report-github.md`

BenchmarkDotNet v0.16.0-preview.2, Windows 10 (10.0.17763.9376/1809/October2018Update/Redstone5) (Hyper-V)  
AMD EPYC 7763 2.44GHz, 1 CPU, 4 logical and 2 physical cores  
Memory: 15.99 GB Total, 5.66 GB Available  
.NET SDK 11.0.100-rc.3.26522.148

- Host: .NET 10.0.14 (10.0.14, 10.0.1426.52326), X64 RyuJIT x86-64-v3
- .NET 10 job: .NET 10.0.14 (10.0.14, 10.0.1426.52326), X64 RyuJIT x86-64-v3
- .NET 11 job: .NET 11.0.0 (11.0.0-rc.3.26522.148, 11.0.26.52348), X64 RyuJIT x86-64-v3

| Method                        | Runtime   | Mean      | Ratio | Allocated | Alloc Ratio |
|------------------------------ |---------- |----------:|------:|----------:|------------:|
| BoxNullableNull               | .NET 10.0 |  4.165 ns |  1.00 |         - |          NA |
| BoxNullableNull               | .NET 11.0 |  2.421 ns |  0.58 |         - |          NA |
|                               |           |           |       |           |             |
| BoxNullableValue              | .NET 10.0 | 19.644 ns |  1.00 |      24 B |        1.00 |
| BoxNullableValue              | .NET 11.0 |  6.843 ns |  0.35 |      24 B |        1.00 |
|                               |           |           |       |           |             |
| FormatNullableInt             | .NET 10.0 | 21.620 ns |  1.00 |      24 B |        1.00 |
| FormatNullableInt             | .NET 11.0 |  4.045 ns |  0.19 |         - |        0.00 |
|                               |           |           |       |           |             |
| EqualityComparerDefaultEquals | .NET 10.0 |  6.560 ns |  1.00 |      24 B |        1.00 |
| EqualityComparerDefaultEquals | .NET 11.0 |  2.817 ns |  0.43 |         - |        0.00 |
|                               |           |           |       |           |             |
| DelegateEquals                | .NET 10.0 |  8.906 ns |  1.00 |         - |          NA |
| DelegateEquals                | .NET 11.0 |  6.662 ns |  0.75 |         - |          NA |
|                               |           |           |       |           |             |
| DelegateGetHashCode           | .NET 10.0 | 12.915 ns |  1.00 |         - |          NA |
| DelegateGetHashCode           | .NET 11.0 | 10.696 ns |  0.83 |         - |          NA |

<br>

## <a href="Dotnet11Benchmarks/JsonBenchmarks.cs" target="_blank" rel="noopener noreferrer">JsonBenchmarks.cs</a>

Source: `Dotnet11Benchmarks\Dotnet11Benchmarks\bin\Release\net10.0\BenchmarkDotNet.Artifacts\results\DotnetBenchmarks.JsonBenchmarks-report-github.md`

BenchmarkDotNet v0.16.0-preview.2, Windows 10 (10.0.17763.9376/1809/October2018Update/Redstone5) (Hyper-V)  
AMD EPYC 7763 2.44GHz, 1 CPU, 4 logical and 2 physical cores  
Memory: 15.99 GB Total, 6.94 GB Available  
.NET SDK 11.0.100-rc.3.26522.148

- Host: .NET 10.0.14 (10.0.14, 10.0.1426.52326), X64 RyuJIT x86-64-v3
- .NET 10 job: .NET 10.0.14 (10.0.14, 10.0.1426.52326), X64 RyuJIT x86-64-v3
- .NET 11 job: .NET 11.0.0 (11.0.0-rc.3.26522.148, 11.0.26.52348), X64 RyuJIT x86-64-v3

| Method                 | Runtime   | Mean      | Ratio | Allocated | Alloc Ratio |
|----------------------- |---------- |----------:|------:|----------:|------------:|
| SerializeEscapedString | .NET 10.0 | 18.323 μs |  1.00 |  12.03 KB |        1.00 |
| SerializeEscapedString | .NET 11.0 |  8.499 μs |  0.46 |  12.03 KB |        1.00 |
|                        |           |           |       |           |             |
| SerializeHtmlString    | .NET 10.0 | 10.179 μs |  1.00 |   3.74 KB |        1.00 |
| SerializeHtmlString    | .NET 11.0 |  6.478 μs |  0.64 |   3.74 KB |        1.00 |

<br>

## <a href="Dotnet11Benchmarks/NumericsBenchmarks.cs" target="_blank" rel="noopener noreferrer">NumericsBenchmarks.cs</a>

Source: `Dotnet11Benchmarks\Dotnet11Benchmarks\bin\Release\net10.0\BenchmarkDotNet.Artifacts\results\DotnetBenchmarks.NumericsBenchmarks-report-github.md`

BenchmarkDotNet v0.16.0-preview.2, Windows 10 (10.0.17763.9376/1809/October2018Update/Redstone5) (Hyper-V)  
AMD EPYC 7763 2.44GHz, 1 CPU, 4 logical and 2 physical cores  
Memory: 15.99 GB Total, 5.66 GB Available  
.NET SDK 11.0.100-rc.3.26522.148

- Host: .NET 10.0.14 (10.0.14, 10.0.1426.52326), X64 RyuJIT x86-64-v3
- .NET 10 job: .NET 10.0.14 (10.0.14, 10.0.1426.52326), X64 RyuJIT x86-64-v3
- .NET 11 job: .NET 11.0.0 (11.0.0-rc.3.26522.148, 11.0.26.52348), X64 RyuJIT x86-64-v3

| Method                  | Runtime   | Mean      | Ratio | Allocated | Alloc Ratio |
|------------------------ |---------- |----------:|------:|----------:|------------:|
| DoubleParseLongFraction | .NET 10.0 | 12.423 μs |  1.00 |         - |          NA |
| DoubleParseLongFraction | .NET 11.0 |  7.042 μs |  0.57 |         - |          NA |
|                         |           |           |       |           |             |
| RandomNext              | .NET 10.0 |  9.050 μs |  1.00 |         - |          NA |
| RandomNext              | .NET 11.0 |  5.513 μs |  0.61 |         - |          NA |

<br>

## <a href="Dotnet11Benchmarks/RegexBenchmarks.cs" target="_blank" rel="noopener noreferrer">RegexBenchmarks.cs</a>

Source: `Dotnet11Benchmarks\Dotnet11Benchmarks\bin\Release\net10.0\BenchmarkDotNet.Artifacts\results\DotnetBenchmarks.RegexBenchmarks-report-github.md`

BenchmarkDotNet v0.16.0-preview.2, Windows 10 (10.0.17763.9376/1809/October2018Update/Redstone5) (Hyper-V)  
AMD EPYC 7763 2.44GHz, 1 CPU, 4 logical and 2 physical cores  
Memory: 15.99 GB Total, 7.19 GB Available  
.NET SDK 11.0.100-rc.3.26522.148

- Host: .NET 10.0.14 (10.0.14, 10.0.1426.52326), X64 RyuJIT x86-64-v3
- .NET 10 job: .NET 10.0.14 (10.0.14, 10.0.1426.52326), X64 RyuJIT x86-64-v3
- .NET 11 job: .NET 11.0.0 (11.0.0-rc.3.26522.148, 11.0.26.52348), X64 RyuJIT x86-64-v3

| Method                | Runtime   | Mean       | Ratio | Allocated | Alloc Ratio |
|---------------------- |---------- |-----------:|------:|----------:|------------:|
| IgnoreCaseAlternation | .NET 10.0 | 297.296 μs |  1.00 |         - |          NA |
| IgnoreCaseAlternation | .NET 11.0 |   4.056 μs |  0.01 |         - |          NA |
|                       |           |            |       |           |             |
| IgnoreCaseWholeWord   | .NET 10.0 | 303.575 μs |  1.00 |         - |          NA |
| IgnoreCaseWholeWord   | .NET 11.0 |   4.968 μs |  0.02 |         - |          NA |
|                       |           |            |       |           |             |
| CompiledAlternation   | .NET 10.0 | 454.811 μs |  1.00 |         - |          NA |
| CompiledAlternation   | .NET 11.0 | 372.352 μs |  0.82 |         - |          NA |

<br>

## <a href="Dotnet11Benchmarks/RegexSearchBenchmarks.cs" target="_blank" rel="noopener noreferrer">RegexSearchBenchmarks.cs</a>

Source: `Dotnet11Benchmarks\Dotnet11Benchmarks\bin\Release\net10.0\BenchmarkDotNet.Artifacts\results\DotnetBenchmarks.RegexSearchBenchmarks-report-github.md`

BenchmarkDotNet v0.16.0-preview.2, Windows 10 (10.0.17763.9376/1809/October2018Update/Redstone5) (Hyper-V)  
AMD EPYC 7763 2.44GHz, 1 CPU, 4 logical and 2 physical cores  
Memory: 15.99 GB Total, 7.19 GB Available  
.NET SDK 11.0.100-rc.3.26522.148

- Host: .NET 10.0.14 (10.0.14, 10.0.1426.52326), X64 RyuJIT x86-64-v3
- .NET 10 job: .NET 10.0.14 (10.0.14, 10.0.1426.52326), X64 RyuJIT x86-64-v3
- .NET 11 job: .NET 11.0.0 (11.0.0-rc.3.26522.148, 11.0.26.52348), X64 RyuJIT x86-64-v3

| Method                  | Runtime   | Mean          | Ratio | Allocated | Alloc Ratio |
|------------------------ |---------- |--------------:|------:|----------:|------------:|
| SharedPrefixAlternation | .NET 10.0 |     223.71 ns |  1.00 |         - |          NA |
| SharedPrefixAlternation | .NET 11.0 |     129.28 ns |  0.58 |         - |          NA |
|                         |           |               |       |           |             |
| LiteralAlternation      | .NET 10.0 | 943,493.86 ns | 1.000 |         - |          NA |
| LiteralAlternation      | .NET 11.0 |   8,525.34 ns | 0.009 |         - |          NA |
|                         |           |               |       |           |             |
| AnchoredLengthReject    | .NET 10.0 |      28.66 ns |  1.00 |         - |          NA |
| AnchoredLengthReject    | .NET 11.0 |      17.50 ns |  0.61 |         - |          NA |

<br>

## <a href="Dotnet11Benchmarks/StringAndSpanBenchmarks.cs" target="_blank" rel="noopener noreferrer">StringAndSpanBenchmarks.cs</a>

Source: `Dotnet11Benchmarks\Dotnet11Benchmarks\bin\Release\net10.0\BenchmarkDotNet.Artifacts\results\DotnetBenchmarks.StringAndSpanBenchmarks-report-github.md`

BenchmarkDotNet v0.16.0-preview.2, Windows 10 (10.0.17763.9376/1809/October2018Update/Redstone5) (Hyper-V)  
AMD EPYC 7763 2.44GHz, 1 CPU, 4 logical and 2 physical cores  
Memory: 15.99 GB Total, 7.19 GB Available  
.NET SDK 11.0.100-rc.3.26522.148

- Host: .NET 10.0.14 (10.0.14, 10.0.1426.52326), X64 RyuJIT x86-64-v3
- .NET 10 job: .NET 10.0.14 (10.0.14, 10.0.1426.52326), X64 RyuJIT x86-64-v3
- .NET 11 job: .NET 11.0.0 (11.0.0-rc.3.26522.148, 11.0.26.52348), X64 RyuJIT x86-64-v3

| Method                 | Runtime   | Mean          | Ratio | Allocated | Alloc Ratio |
|----------------------- |---------- |--------------:|------:|----------:|------------:|
| SplitNoSeparators      | .NET 10.0 |    676.096 ns |  1.00 |      32 B |        1.00 |
| SplitNoSeparators      | .NET 11.0 |    509.700 ns |  0.75 |      32 B |        1.00 |
|                        |           |               |       |           |             |
| GuidSequenceEqual      | .NET 10.0 |      4.167 ns |  1.00 |         - |          NA |
| GuidSequenceEqual      | .NET 11.0 |      2.194 ns |  0.53 |         - |          NA |
|                        |           |               |       |           |             |
| SpanSortStructComparer | .NET 10.0 | 15,196.708 ns |  1.00 |      88 B |        1.00 |
| SpanSortStructComparer | .NET 11.0 |  2,751.157 ns |  0.18 |         - |        0.00 |

<br>

## <a href="Dotnet11Benchmarks/StringBenchmarks.cs" target="_blank" rel="noopener noreferrer">StringBenchmarks.cs</a>

Source: `Dotnet11Benchmarks\Dotnet11Benchmarks\bin\Release\net10.0\BenchmarkDotNet.Artifacts\results\DotnetBenchmarks.StringBenchmarks-report-github.md`

BenchmarkDotNet v0.16.0-preview.2, Windows 10 (10.0.17763.9376/1809/October2018Update/Redstone5) (Hyper-V)  
AMD EPYC 7763 2.44GHz, 1 CPU, 4 logical and 2 physical cores  
Memory: 15.99 GB Total, 5.66 GB Available  
.NET SDK 11.0.100-rc.3.26522.148

- Host: .NET 10.0.14 (10.0.14, 10.0.1426.52326), X64 RyuJIT x86-64-v3
- .NET 10 job: .NET 10.0.14 (10.0.14, 10.0.1426.52326), X64 RyuJIT x86-64-v3
- .NET 11 job: .NET 11.0.0 (11.0.0-rc.3.26522.148, 11.0.26.52348), X64 RyuJIT x86-64-v3

| Method      | Runtime   | Mean      | Ratio | Allocated | Alloc Ratio |
|------------ |---------- |----------:|------:|----------:|------------:|
| ConcatArray | .NET 10.0 |  9.643 μs |  1.00 |    5.7 KB |        1.00 |
| ConcatArray | .NET 11.0 |  9.222 μs |  0.96 |   5.67 KB |        0.99 |
|             |           |           |       |           |             |
| ConcatList  | .NET 10.0 | 10.928 μs |  1.00 |   5.71 KB |        1.00 |
| ConcatList  | .NET 11.0 |  8.546 μs |  0.78 |   5.67 KB |        0.99 |

<br>

## <a href="Dotnet11Benchmarks/UriBenchmarks.cs" target="_blank" rel="noopener noreferrer">UriBenchmarks.cs</a>

Source: `Dotnet11Benchmarks\Dotnet11Benchmarks\bin\Release\net10.0\BenchmarkDotNet.Artifacts\results\DotnetBenchmarks.UriBenchmarks-report-github.md`

BenchmarkDotNet v0.16.0-preview.2, Windows 10 (10.0.17763.9376/1809/October2018Update/Redstone5) (Hyper-V)  
AMD EPYC 7763 2.44GHz, 1 CPU, 4 logical and 2 physical cores  
Memory: 15.99 GB Total, 6.56 GB Available  
.NET SDK 11.0.100-rc.3.26522.148

- Host: .NET 10.0.14 (10.0.14, 10.0.1426.52326), X64 RyuJIT x86-64-v3
- .NET 10 job: .NET 10.0.14 (10.0.14, 10.0.1426.52326), X64 RyuJIT x86-64-v3
- .NET 11 job: .NET 11.0.0 (11.0.0-rc.3.26522.148, 11.0.26.52348), X64 RyuJIT x86-64-v3

| Method                   | Runtime   | Mean        | Ratio | Allocated | Alloc Ratio |
|------------------------- |---------- |------------:|------:|----------:|------------:|
| ParseApiAddress          | .NET 10.0 |   117.45 ns |  1.00 |      56 B |        1.00 |
| ParseApiAddress          | .NET 11.0 |    96.85 ns |  0.82 |      56 B |        1.00 |
|                          |           |             |       |           |             |
| ParseLongHost            | .NET 10.0 |   545.28 ns |  1.00 |      56 B |        1.00 |
| ParseLongHost            | .NET 11.0 |   216.86 ns |  0.40 |      56 B |        1.00 |
|                          |           |             |       |           |             |
| ParseEscapedAscii        | .NET 10.0 |   889.71 ns |  1.00 |     448 B |        1.00 |
| ParseEscapedAscii        | .NET 11.0 |   539.72 ns |  0.61 |     368 B |        0.82 |
|                          |           |             |       |           |             |
| ParseWithUnicodeFragment | .NET 10.0 | 1,085.37 ns |  1.00 |     936 B |        1.00 |
| ParseWithUnicodeFragment | .NET 11.0 |   669.60 ns |  0.62 |     432 B |        0.46 |
