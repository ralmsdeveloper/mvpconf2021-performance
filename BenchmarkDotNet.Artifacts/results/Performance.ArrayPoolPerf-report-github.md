``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19042.1348 (20H2/October2020Update)
Intel Core i9-10900K CPU 3.70GHz, 1 CPU, 20 logical and 10 physical cores
.NET SDK=6.0.100
  [Host]     : .NET 6.0.0 (6.0.21.52210), X64 RyuJIT
  DefaultJob : .NET 6.0.0 (6.0.21.52210), X64 RyuJIT


```
|          Method |     Mean |    Error |   StdDev |    Gen 0 |    Gen 1 |    Gen 2 | Allocated |
|---------------- |---------:|---------:|---------:|---------:|---------:|---------:|----------:|
|      ArrayNomal | 526.4 μs | 10.47 μs | 28.12 μs | 333.0078 | 332.0313 | 332.0313 |  2,056 KB |
| ArrayUsandoPool | 265.3 μs |  2.88 μs |  2.69 μs |   0.4883 |        - |        - |      8 KB |
