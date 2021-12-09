``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19042.1348 (20H2/October2020Update)
Intel Core i9-10900K CPU 3.70GHz, 1 CPU, 20 logical and 10 physical cores
.NET SDK=6.0.100
  [Host]     : .NET 6.0.0 (6.0.21.52210), X64 RyuJIT
  DefaultJob : .NET 6.0.0 (6.0.21.52210), X64 RyuJIT


```
|       Method |        Mean |     Error |    StdDev |      Median |  Gen 0 |  Gen 1 | Allocated |
|------------- |------------:|----------:|----------:|------------:|-------:|-------:|----------:|
| SemDestrutor |   0.0040 ns | 0.0071 ns | 0.0067 ns |   0.0000 ns |      - |      - |         - |
| ComDestrutor | 143.6635 ns | 2.8659 ns | 7.2946 ns | 143.4008 ns | 0.0038 | 0.0019 |      40 B |
