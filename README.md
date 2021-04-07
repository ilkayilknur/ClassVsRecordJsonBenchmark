``` ini

BenchmarkDotNet=v0.12.1, OS=macOS 11.2.3 (20D91) [Darwin 20.3.0]
Intel Core i9-8950HK CPU 2.90GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.201
  [Host]     : .NET Core 5.0.4 (CoreCLR 5.0.421.11614, CoreFX 5.0.421.11614), X64 RyuJIT
  DefaultJob : .NET Core 5.0.4 (CoreCLR 5.0.421.11614, CoreFX 5.0.421.11614), X64 RyuJIT


```
|            Method |     Mean |    Error |   StdDev |
|------------------ |---------:|---------:|---------:|
|   SerializeRecord | 398.9 ns |  8.02 ns | 19.82 ns |
|    SerializeClass | 398.5 ns |  8.66 ns | 25.27 ns |
| DeserializeRecord | 635.0 ns | 11.06 ns | 23.58 ns |
|  DeserializeClass | 507.1 ns | 10.18 ns | 28.55 ns |
