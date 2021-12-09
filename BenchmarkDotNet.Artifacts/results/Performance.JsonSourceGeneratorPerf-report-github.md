``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19042.1348 (20H2/October2020Update)
Intel Core i9-10900K CPU 3.70GHz, 1 CPU, 20 logical and 10 physical cores
.NET SDK=6.0.100
  [Host]     : .NET 6.0.0 (6.0.21.52210), X64 RyuJIT
  DefaultJob : .NET 6.0.0 (6.0.21.52210), X64 RyuJIT


```
|                         Method |     Mean |     Error |    StdDev |  Gen 0 | Allocated |
|------------------------------- |---------:|----------:|----------:|-------:|----------:|
|    SerializeDeserializerNormal | 1.178 μs | 0.0061 μs | 0.0054 μs | 0.0553 |     592 B |
| SerializeDeserializerOtimizado | 1.096 μs | 0.0075 μs | 0.0070 μs | 0.0553 |     592 B |
