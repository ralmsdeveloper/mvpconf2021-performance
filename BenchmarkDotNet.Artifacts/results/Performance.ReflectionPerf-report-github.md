``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19042.1348 (20H2/October2020Update)
Intel Core i9-10900K CPU 3.70GHz, 1 CPU, 20 logical and 10 physical cores
.NET SDK=6.0.100
  [Host]     : .NET 6.0.0 (6.0.21.52210), X64 RyuJIT
  DefaultJob : .NET 6.0.0 (6.0.21.52210), X64 RyuJIT


```
|                      Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
|---------------------------- |----------:|----------:|----------:|-------:|----------:|
|               AcessoPublico |  6.402 ns | 0.1909 ns | 0.4230 ns | 0.0031 |      32 B |
|            ReflectionNormal | 75.102 ns | 0.9169 ns | 0.8577 ns | 0.0030 |      32 B |
|         ReflectionOtimizado | 47.340 ns | 0.6824 ns | 0.6050 ns | 0.0030 |      32 B |
| ReflectionOtimizadoDelegate |  7.662 ns | 0.2124 ns | 0.3989 ns | 0.0031 |      32 B |
