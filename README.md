# BenchmarkDotNet Results

## DateTimeBenchmarks.cs

Source: `Dotnet11Benchmarks\Dotnet11Benchmarks\bin\Release\net10.0\BenchmarkDotNet.Artifacts\results\DotnetBenchmarks.DateTimeBenchmarks-report-github.md`

BenchmarkDotNet v0.16.0-preview.2, Windows 10 (10.0.17763.9376/1809/October2018Update/Redstone5) (Hyper-V)  
AMD EPYC 7763 2.44GHz, 1 CPU, 4 logical and 2 physical cores  
Memory: 15.99 GB Total, 9.5 GB Available  
.NET SDK 11.0.100-rc.3.26522.148

- Host: .NET 10.0.14 (10.0.14, 10.0.1426.52326), X64 RyuJIT x86-64-v3
- .NET 10 job: .NET 10.0.14 (10.0.14, 10.0.1426.52326), X64 RyuJIT x86-64-v3
- .NET 11 job: .NET 11.0.0 (11.0.0-rc.3.26522.148, 11.0.26.52348), X64 RyuJIT x86-64-v3

| Method             | Runtime   | Mean     | Ratio | RatioSD | Allocated | Alloc Ratio |
|------------------- |---------- |---------:|------:|--------:|----------:|------------:|
| Now                | .NET 10.0 | 88.03 ns |  1.00 |    0.00 |         - |          NA |
| Now                | .NET 11.0 | 40.92 ns |  0.47 |    0.01 |         - |          NA |
|                    |           |          |       |         |           |             |
| ConvertTimeFromUtc | .NET 10.0 | 70.30 ns |  1.00 |    0.00 |         - |          NA |
| ConvertTimeFromUtc | .NET 11.0 | 24.37 ns |  0.35 |    0.02 |         - |          NA |
|                    |           |          |       |         |           |             |
| ConvertTimeToUtc   | .NET 10.0 | 71.58 ns |  1.00 |    0.00 |         - |          NA |
| ConvertTimeToUtc   | .NET 11.0 | 30.79 ns |  0.43 |    0.03 |         - |          NA |
|                    |           |          |       |         |           |             |
| ToStringInvariantG | .NET 10.0 | 90.30 ns |  1.00 |    0.00 |      64 B |        1.00 |
| ToStringInvariantG | .NET 11.0 | 20.69 ns |  0.23 |    0.02 |      64 B |        1.00 |

## FrozenCollectionBenchmark.cs

Source: `Dotnet11Benchmarks\Dotnet11Benchmarks\bin\Release\net10.0\BenchmarkDotNet.Artifacts\results\DotnetBenchmarks.FrozenCollectionBenchmark-report-github.md`

BenchmarkDotNet v0.16.0-preview.2, Windows 10 (10.0.17763.9376/1809/October2018Update/Redstone5) (Hyper-V)  
AMD EPYC 7763 2.44GHz, 1 CPU, 4 logical and 2 physical cores  
Memory: 15.99 GB Total, 7.52 GB Available  
.NET SDK 11.0.100-rc.3.26522.148

- Host: .NET 10.0.14 (10.0.14, 10.0.1426.52326), X64 RyuJIT x86-64-v3
- .NET 10 job: .NET 10.0.14 (10.0.14, 10.0.1426.52326), X64 RyuJIT x86-64-v3
- .NET 11 job: .NET 11.0.0 (11.0.0-rc.3.26522.148, 11.0.26.52348), X64 RyuJIT x86-64-v3

| Method             | Runtime   | Mean     | Ratio | Allocated | Alloc Ratio |
|------------------- |---------- |---------:|------:|----------:|------------:|
| ToFrozenDictionary | .NET 10.0 | 87.72 μs |  1.00 | 347.18 KB |        1.00 |
| ToFrozenDictionary | .NET 11.0 | 31.07 μs |  0.35 | 127.16 KB |        0.37 |

## RegexBenchmarks.cs

Source: `Dotnet11Benchmarks\Dotnet11Benchmarks\bin\Release\net10.0\BenchmarkDotNet.Artifacts\results\DotnetBenchmarks.RegexBenchmarks-report-github.md`

BenchmarkDotNet v0.16.0-preview.2, Windows 10 (10.0.17763.9376/1809/October2018Update/Redstone5)  
AMD EPYC 7763 2.44GHz, 1 CPU, 4 logical and 2 physical cores  
Memory: 15.99 GB Total, 7.21 GB Available  
.NET SDK 11.0.100-rc.3.26522.148

- Host: .NET 10.0.14 (10.0.14, 10.0.1426.52326), X64 RyuJIT x86-64-v3
- .NET 10 job: .NET 10.0.14 (10.0.14, 10.0.1426.52326), X64 RyuJIT x86-64-v3
- .NET 11 job: .NET 11.0.0 (11.0.0-rc.3.26522.148, 11.0.26.52348), X64 RyuJIT x86-64-v3

| Method                | Runtime   | Mean       | Ratio | Allocated | Alloc Ratio |
|---------------------- |---------- |-----------:|------:|----------:|------------:|
| IgnoreCaseAlternation | .NET 10.0 | 296.048 μs |  1.00 |         - |          NA |
| IgnoreCaseAlternation | .NET 11.0 |   4.759 μs |  0.02 |         - |          NA |
|                       |           |            |       |           |             |
| IgnoreCaseWholeWord   | .NET 10.0 | 301.640 μs |  1.00 |         - |          NA |
| IgnoreCaseWholeWord   | .NET 11.0 |   5.010 μs |  0.02 |         - |          NA |
|                       |           |            |       |           |             |
| CompiledAlternation   | .NET 10.0 | 453.066 μs |  1.00 |         - |          NA |
| CompiledAlternation   | .NET 11.0 | 366.507 μs |  0.81 |         - |          NA |
