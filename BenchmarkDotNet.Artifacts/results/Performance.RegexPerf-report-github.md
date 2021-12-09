``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19042.1348 (20H2/October2020Update)
Intel Core i9-10900K CPU 3.70GHz, 1 CPU, 20 logical and 10 physical cores
.NET SDK=6.0.100
  [Host]     : .NET 6.0.0 (6.0.21.52210), X64 RyuJIT
  DefaultJob : .NET 6.0.0 (6.0.21.52210), X64 RyuJIT


```
|                     Method |           Mean |         Error |        StdDev |  Gen 0 | Allocated |
|--------------------------- |---------------:|--------------:|--------------:|-------:|----------:|
|          RegexInterpretado |      83.587 ns |     1.6110 ns |     1.5070 ns |      - |         - |
|             RegexCompilado |      33.976 ns |     0.3746 ns |     0.3320 ns |      - |         - |
| RegexInterpretadoTransient |   1,265.519 ns |    24.9477 ns |    48.0658 ns | 0.2556 |   2,680 B |
|    RegexCompiladoTransient | 612,572.422 ns | 4,165.6063 ns | 3,896.5107 ns |      - |   7,664 B |
|          MetodoCustomizado |       7.224 ns |     0.0352 ns |     0.0329 ns |      - |         - |
