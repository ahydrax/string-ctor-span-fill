string-ctor-span-fill


### benchmark 0
// * Summary *

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19043.1165 (21H1/May2021Update)
AMD Ryzen 7 3800X, 1 CPU, 16 logical and 8 physical cores
.NET SDK=6.0.100-preview.7.21379.14
[Host]     : .NET 6.0.0 (6.0.21.37719), X64 RyuJIT
Job-OXHUQO : .NET 7.0.0 (42.42.42.42424), X64 RyuJIT
Job-SYEFKS : .NET 7.0.0 (42.42.42.42424), X64 RyuJIT


|          Method |        Job |                                                                             Toolchain | Count |      Mean |     Error |    StdDev | Ratio | RatioSD |
|---------------- |----------- |-------------------------------------------------------------------------------------- |------ |----------:|----------:|----------:|------:|--------:|
| CreateNewString | Job-OXHUQO | \runtime-main\ |     1 |  5.236 ns | 0.1200 ns | 0.1002 ns |  1.13 |    0.04 |
| CreateNewString | Job-SYEFKS |      \runtime\ |     1 |  4.651 ns | 0.1471 ns | 0.1376 ns |  1.00 |    0.00 |
|                 |            |                                                                                       |       |           |           |           |       |         |
| CreateNewString | Job-OXHUQO | \runtime-main\ |     2 |  5.575 ns | 0.1718 ns | 0.1607 ns |  1.11 |    0.05 |
| CreateNewString | Job-SYEFKS |      \runtime\ |     2 |  4.978 ns | 0.1586 ns | 0.1763 ns |  1.00 |    0.00 |
|                 |            |                                                                                       |       |           |           |           |       |         |
| CreateNewString | Job-OXHUQO | \runtime-main\ |     4 |  5.122 ns | 0.1503 ns | 0.1405 ns |  1.03 |    0.03 |
| CreateNewString | Job-SYEFKS |      \runtime\ |     4 |  4.961 ns | 0.1168 ns | 0.1092 ns |  1.00 |    0.00 |
|                 |            |                                                                                       |       |           |           |           |       |         |
| CreateNewString | Job-OXHUQO | \runtime-main\ |     5 |  5.300 ns | 0.0775 ns | 0.0647 ns |  1.05 |    0.02 |
| CreateNewString | Job-SYEFKS |      \runtime\ |     5 |  5.022 ns | 0.0706 ns | 0.0626 ns |  1.00 |    0.00 |
|                 |            |                                                                                       |       |           |           |           |       |         |
| CreateNewString | Job-OXHUQO | \runtime-main\ |     8 |  5.574 ns | 0.1701 ns | 0.1671 ns |  1.06 |    0.04 |
| CreateNewString | Job-SYEFKS |      \runtime\ |     8 |  5.276 ns | 0.1571 ns | 0.1543 ns |  1.00 |    0.00 |
|                 |            |                                                                                       |       |           |           |           |       |         |
| CreateNewString | Job-OXHUQO | \runtime-main\ |    10 |  6.344 ns | 0.1578 ns | 0.1476 ns |  1.19 |    0.05 |
| CreateNewString | Job-SYEFKS |      \runtime\ |    10 |  5.377 ns | 0.1681 ns | 0.1868 ns |  1.00 |    0.00 |
|                 |            |                                                                                       |       |           |           |           |       |         |
| CreateNewString | Job-OXHUQO | \runtime-main\ |    11 |  6.672 ns | 0.1685 ns | 0.1576 ns |  1.22 |    0.04 |
| CreateNewString | Job-SYEFKS |      \runtime\ |    11 |  5.470 ns | 0.0865 ns | 0.0809 ns |  1.00 |    0.00 |
|                 |            |                                                                                       |       |           |           |           |       |         |
| CreateNewString | Job-OXHUQO | \runtime-main\ |    12 |  6.020 ns | 0.1457 ns | 0.1363 ns |  1.00 |    0.04 |
| CreateNewString | Job-SYEFKS |      \runtime\ |    12 |  5.987 ns | 0.1759 ns | 0.2025 ns |  1.00 |    0.00 |
|                 |            |                                                                                       |       |           |           |           |       |         |
| CreateNewString | Job-OXHUQO | \runtime-main\ |    16 |  6.294 ns | 0.1891 ns | 0.1768 ns |  1.02 |    0.05 |
| CreateNewString | Job-SYEFKS |      \runtime\ |    16 |  6.193 ns | 0.1839 ns | 0.1720 ns |  1.00 |    0.00 |
|                 |            |                                                                                       |       |           |           |           |       |         |
| CreateNewString | Job-OXHUQO | \runtime-main\ |    17 |  6.685 ns | 0.0948 ns | 0.0792 ns |  1.06 |    0.03 |
| CreateNewString | Job-SYEFKS |      \runtime\ |    17 |  6.298 ns | 0.1373 ns | 0.1217 ns |  1.00 |    0.00 |
|                 |            |                                                                                       |       |           |           |           |       |         |
| CreateNewString | Job-OXHUQO | \runtime-main\ |    32 |  9.142 ns | 0.1548 ns | 0.1448 ns |  1.14 |    0.02 |
| CreateNewString | Job-SYEFKS |      \runtime\ |    32 |  8.037 ns | 0.1582 ns | 0.1480 ns |  1.00 |    0.00 |
|                 |            |                                                                                       |       |           |           |           |       |         |
| CreateNewString | Job-OXHUQO | \runtime-main\ |   100 | 19.397 ns | 0.1128 ns | 0.1055 ns |  1.51 |    0.01 |
| CreateNewString | Job-SYEFKS |      \runtime\ |   100 | 12.842 ns | 0.0922 ns | 0.0770 ns |  1.00 |    0.00 |
|                 |            |                                                                                       |       |           |           |           |       |         |
| CreateNewString | Job-OXHUQO | \runtime-main\ |   103 | 20.812 ns | 0.2721 ns | 0.2545 ns |  1.62 |    0.03 |
| CreateNewString | Job-SYEFKS |      \runtime\ |   103 | 12.863 ns | 0.1743 ns | 0.1630 ns |  1.00 |    0.00 |
|                 |            |                                                                                       |       |           |           |           |       |         |
| CreateNewString | Job-OXHUQO | \runtime-main\ |   128 | 23.914 ns | 0.1793 ns | 0.1678 ns |  1.68 |    0.02 |
| CreateNewString | Job-SYEFKS |      \runtime\ |   128 | 14.260 ns | 0.1631 ns | 0.1526 ns |  1.00 |    0.00 |


### benchmark 1
BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19043.1165 (21H1/May2021Update)
AMD Ryzen 7 3800X, 1 CPU, 16 logical and 8 physical cores
.NET SDK=6.0.100-preview.7.21379.14
[Host]     : .NET 6.0.0 (6.0.21.37719), X64 RyuJIT
Job-XJQQXY : .NET 7.0.0 (42.42.42.42424), X64 RyuJIT
Job-DWITDZ : .NET 7.0.0 (42.42.42.42424), X64 RyuJIT


|                                Method |        Job |                                                                             Toolchain |     Mean |   Error |  StdDev | Ratio | RatioSD |
|-------------------------------------- |----------- |-------------------------------------------------------------------------------------- |---------:|--------:|--------:|------:|--------:|
| CreateNewString_AssumedWithoutHotPath | Job-XJQQXY | \runtime-main\ | 192.1 ns | 3.10 ns | 2.90 ns |  1.22 |    0.03 |
| CreateNewString_AssumedWithoutHotPath | Job-DWITDZ |      \runtime\ | 157.8 ns | 3.17 ns | 3.12 ns |  1.00 |    0.00 |