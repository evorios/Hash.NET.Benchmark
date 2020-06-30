# Hash.NET.Benchmark

Benchmark for .NET implementations of fast non-cryptographic hash algorithm [xxHash](https://github.com/Cyan4973/xxHash) created by @Cyan4973

``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 7 SP1 (6.1.7601.0)
Intel Core i5-4460 CPU 3.20GHz (Haswell), 1 CPU, 4 logical and 4 physical cores
Frequency=3117792 Hz, Resolution=320.7398 ns, Timer=TSC
  [Host]     : .NET Framework 4.8 (4.8.3928.0), X64 RyuJIT
  .NET 4.7.2 : .NET Framework 4.8 (4.8.3928.0), X64 RyuJIT

Runtime=.NET 4.7.2  

// * Legends *
  len        : Size of data block in bytes
  seed       : Custom seed supported
  Mean       : Arithmetic mean of all measurements
  Error      : Half of 99.9% confidence interval
  StdDev     : Standard deviation of all measurements
  Throughput : Throughput in MB/s
  1 ns       : 1 Nanosecond  (0.000000001 sec)
  1 μs       : 1 Microsecond (0.000001 sec)
  sse2       : Use SSE2 optimization
  avx2       : Use AVX2 optimization (non-portable)

```
Method                               | len  | seed  | Mean      | Error    | StdDev   | Throughput
-------------------------------------|------|-------|-----------|----------|----------|---------------
uranium62_xxHash                     | 2    | True  | 7.129 ns  | 0.015 ns | 0.014 ns | 267 MB/s
shibox_XXHash                        | 2    | True  | 7.418 ns  | 0.021 ns | 0.019 ns | 257 MB/s
EnokiSolutions_es_xxhash             | 2    | True  | 8.390 ns  | 0.029 ns | 0.027 ns | 227 MB/s
ssg_HashDepot                        | 2    | True  | 17 ns     | 0.046 ns | 0.043 ns | 107 MB/s
xoofx_smash                          | 2    | True  | 21 ns     | 0.039 ns | 0.031 ns | 88 MB/s
neosmart_hashing_net                 | 2    | True  | 31 ns     | 0.085 ns | 0.080 ns | 60 MB/s
Zhentar_xxHash3_NET                  | 2    | True  | 35 ns     | 0.141 ns | 0.132 ns | 53 MB/s
Zhentar_xxHash64_NET                 | 2    | False | 43 ns     | 0.107 ns | 0.100 ns | 44 MB/s
differentrain_YYProject_XXHash       | 2    | True  | 99 ns     | 0.144 ns | 0.120 ns | 19 MB/s
MiloszKrajewski_K4os_Hash_xxHash     | 2    | False | 113 ns    | 0.190 ns | 0.178 ns | 16 MB/s
ftlab_FT_xxHash                      | 2    | False | 114 ns    | 0.337 ns | 0.315 ns | 16 MB/s
ByteTerrace_Maths_Probability_XxHash | 2    | True  | 125 ns    | 0.292 ns | 0.273 ns | 15 MB/s
wilhelmliao_xxHash_NET               | 2    | True  | 158 ns    | 0.377 ns | 0.353 ns | 12 MB/s
ailen0ada_xxHash4net                 | 2    | False | 190 ns    | 0.458 ns | 0.428 ns | 10 MB/s
brandondahler_Data_HashFunction      | 2    | True  | 649 ns    | 1.875 ns | 1.754 ns | 2.9 MB/s
|                                    |      |       |           |          |          | 
uranium62_xxHash                     | 8    | True  | 5.884 ns  | 0.012 ns | 0.012 ns | 1296 MB/s
shibox_XXHash                        | 8    | True  | 6.156 ns  | 0.017 ns | 0.016 ns | 1239 MB/s
EnokiSolutions_es_xxhash             | 8    | True  | 11 ns     | 0.020 ns | 0.019 ns | 677 MB/s
ssg_HashDepot                        | 8    | True  | 17 ns     | 0.035 ns | 0.032 ns | 446 MB/s
xoofx_smash                          | 8    | True  | 17 ns     | 0.036 ns | 0.031 ns | 446 MB/s
neosmart_hashing_net                 | 8    | True  | 35 ns     | 0.092 ns | 0.086 ns | 214 MB/s
Zhentar_xxHash64_NET                 | 8    | False | 42 ns     | 0.077 ns | 0.072 ns | 178 MB/s
Zhentar_xxHash3_NET                  | 8    | True  | 47 ns     | 0.094 ns | 0.088 ns | 161 MB/s
differentrain_YYProject_XXHash       | 8    | True  | 103 ns    | 0.254 ns | 0.225 ns | 73 MB/s
MiloszKrajewski_K4os_Hash_xxHash     | 8    | False | 113 ns    | 0.231 ns | 0.216 ns | 67 MB/s
ftlab_FT_xxHash                      | 8    | False | 114 ns    | 0.226 ns | 0.212 ns | 66 MB/s
ByteTerrace_Maths_Probability_XxHash | 8    | True  | 126 ns    | 0.300 ns | 0.281 ns | 60 MB/s
wilhelmliao_xxHash_NET               | 8    | True  | 169 ns    | 0.313 ns | 0.277 ns | 45 MB/s
ailen0ada_xxHash4net                 | 8    | False | 207 ns    | 0.434 ns | 0.406 ns | 36 MB/s
brandondahler_Data_HashFunction      | 8    | True  | 667 ns    | 2.232 ns | 2.088 ns | 11 MB/s
|                                    |      |       |           |          |          | 
shibox_XXHash                        | 64   | True  | 17 ns     | 0.037 ns | 0.032 ns | 3511 MB/s
uranium62_xxHash                     | 64   | True  | 18 ns     | 0.034 ns | 0.032 ns | 3326 MB/s
ssg_HashDepot                        | 64   | True  | 34 ns     | 0.052 ns | 0.046 ns | 1758 MB/s
xoofx_smash                          | 64   | True  | 39 ns     | 0.062 ns | 0.055 ns | 1538 MB/s
EnokiSolutions_es_xxhash             | 64   | True  | 43 ns     | 0.120 ns | 0.112 ns | 1415 MB/s
Zhentar_xxHash64_NET                 | 64   | False | 53 ns     | 0.149 ns | 0.140 ns | 1140 MB/s
Zhentar_xxHash3_NET                  | 64   | True  | 67 ns     | 0.197 ns | 0.184 ns | 903 MB/s
MiloszKrajewski_K4os_Hash_xxHash     | 64   | False | 121 ns    | 0.357 ns | 0.334 ns | 504 MB/s
ftlab_FT_xxHash                      | 64   | False | 123 ns    | 0.305 ns | 0.285 ns | 496 MB/s
ByteTerrace_Maths_Probability_XxHash | 64   | True  | 124 ns    | 0.316 ns | 0.296 ns | 490 MB/s
neosmart_hashing_net                 | 64   | True  | 130 ns    | 0.298 ns | 0.279 ns | 467 MB/s
differentrain_YYProject_XXHash       | 64   | True  | 168 ns    | 0.308 ns | 0.273 ns | 363 MB/s
wilhelmliao_xxHash_NET               | 64   | True  | 292 ns    | 0.757 ns | 0.708 ns | 208 MB/s
ailen0ada_xxHash4net                 | 64   | False | 314 ns    | 0.960 ns | 0.898 ns | 193 MB/s
brandondahler_Data_HashFunction      | 64   | True  | 768 ns    | 1.940 ns | 1.815 ns | 79 MB/s
|                                    |      |       |           |          |          | 
shibox_XXHash                        | 512  | True  | 69 ns     | 0.135 ns | 0.126 ns | 6987 MB/s
uranium62_xxHash                     | 512  | True  | 79 ns     | 0.122 ns | 0.114 ns | 6132 MB/s
Zhentar_xxHash64_NET                 | 512  | False | 96 ns     | 0.162 ns | 0.144 ns | 5038 MB/s
ssg_HashDepot                        | 512  | True  | 161 ns    | 0.388 ns | 0.363 ns | 3015 MB/s
MiloszKrajewski_K4os_Hash_xxHash     | 512  | False | 164 ns    | 0.325 ns | 0.304 ns | 2965 MB/s
ftlab_FT_xxHash                      | 512  | False | 167 ns    | 0.234 ns | 0.219 ns | 2914 MB/s
ByteTerrace_Maths_Probability_XxHash | 512  | True  | 198 ns    | 0.267 ns | 0.237 ns | 2464 MB/s
xoofx_smash                          | 512  | True  | 242 ns    | 1.215 ns | 1.137 ns | 2011 MB/s
Zhentar_xxHash3_NET                  | 512  | True  | 254 ns    | 0.522 ns | 0.488 ns | 1915 MB/s
EnokiSolutions_es_xxhash             | 512  | True  | 263 ns    | 0.325 ns | 0.288 ns | 1854 MB/s
differentrain_YYProject_XXHash       | 512  | True  | 528 ns    | 1.140 ns | 1.066 ns | 923 MB/s
neosmart_hashing_net                 | 512  | True  | 793 ns    | 1.452 ns | 1.358 ns | 615 MB/s
ailen0ada_xxHash4net                 | 512  | False | 893 ns    | 2.176 ns | 2.036 ns | 546 MB/s
wilhelmliao_xxHash_NET               | 512  | True  | 1103 ns   | 2.998 ns | 2.804 ns | 442 MB/s
brandondahler_Data_HashFunction      | 512  | True  | 1116 ns   | 3.707 ns | 3.468 ns | 437 MB/s
|                                    |      |       |           |          |          | 
shibox_XXHash                        | 4K   | True  | 371 ns    | 0.625 ns | 0.584 ns | 10520 MB/s
uranium62_xxHash                     | 4K   | True  | 397 ns    | 0.577 ns | 0.540 ns | 9831 MB/s
Zhentar_xxHash64_NET                 | 4K   | False | 454 ns    | 0.899 ns | 0.841 ns | 8600 MB/s
MiloszKrajewski_K4os_Hash_xxHash     | 4K   | False | 458 ns    | 0.615 ns | 0.545 ns | 8515 MB/s
ftlab_FT_xxHash                      | 4K   | False | 462 ns    | 0.513 ns | 0.479 ns | 8451 MB/s
ByteTerrace_Maths_Probability_XxHash | 4K   | True  | 698 ns    | 1.424 ns | 1.332 ns | 5588 MB/s
ssg_HashDepot                        | 4K   | True  | 1191 ns   | 2.544 ns | 2.380 ns | 3278 MB/s
Zhentar_xxHash3_NET                  | 4K   | True  | 1299 ns   | 2.158 ns | 1.913 ns | 3006 MB/s
xoofx_smash                          | 4K   | True  | 1841 ns   | 6.509 ns | 6.088 ns | 2121 MB/s
EnokiSolutions_es_xxhash             | 4K   | True  | 1984 ns   | 5.786 ns | 5.412 ns | 1968 MB/s
differentrain_YYProject_XXHash       | 4K   | True  | 3375 ns   | 7.313 ns | 6.840 ns | 1157 MB/s
brandondahler_Data_HashFunction      | 4K   | True  | 3812 ns   | 8.163 ns | 7.236 ns | 1024 MB/s
ailen0ada_xxHash4net                 | 4K   | False | 5433 ns   | 14 ns    | 13 ns    | 718 MB/s
neosmart_hashing_net                 | 4K   | True  | 6017 ns   | 11 ns    | 11 ns    | 649 MB/s
wilhelmliao_xxHash_NET               | 4K   | True  | 7630 ns   | 13 ns    | 12 ns    | 511 MB/s
|                                    |      |       |           |          |          | 
shibox_XXHash                        | 32K  | True  | 2614 ns   | 8.627 ns | 7.647 ns | 11951 MB/s
uranium62_xxHash                     | 32K  | True  | 2675 ns   | 4.953 ns | 4.633 ns | 11678 MB/s
ftlab_FT_xxHash                      | 32K  | False | 2717 ns   | 6.141 ns | 5.744 ns | 11498 MB/s
MiloszKrajewski_K4os_Hash_xxHash     | 32K  | False | 2721 ns   | 5.238 ns | 4.900 ns | 11480 MB/s
Zhentar_xxHash64_NET                 | 32K  | False | 3278 ns   | 6.726 ns | 6.292 ns | 9530 MB/s
ByteTerrace_Maths_Probability_XxHash | 32K  | True  | 4610 ns   | 12 ns    | 12 ns    | 6777 MB/s
ssg_HashDepot                        | 32K  | True  | 9364 ns   | 27 ns    | 26 ns    | 3337 MB/s
Zhentar_xxHash3_NET                  | 32K  | True  | 9705 ns   | 24 ns    | 22 ns    | 3219 MB/s
xoofx_smash                          | 32K  | True  | 14612 ns  | 71 ns    | 66 ns    | 2138 MB/s
EnokiSolutions_es_xxhash             | 32K  | True  | 15741 ns  | 34 ns    | 32 ns    | 1985 MB/s
brandondahler_Data_HashFunction      | 32K  | True  | 25900 ns  | 42 ns    | 38 ns    | 1206 MB/s
differentrain_YYProject_XXHash       | 32K  | True  | 26124 ns  | 51 ns    | 47 ns    | 1196 MB/s
ailen0ada_xxHash4net                 | 32K  | False | 41740 ns  | 86 ns    | 80 ns    | 748 MB/s
neosmart_hashing_net                 | 32K  | True  | 47838 ns  | 89 ns    | 79 ns    | 653 MB/s
wilhelmliao_xxHash_NET               | 32K  | True  | 59411 ns  | 126 ns   | 118 ns   | 526 MB/s
|                                    |      |       |           |          |          | 
shibox_XXHash                        | 256K | True  | 20589 ns  | 30 ns    | 28 ns    | 12142 MB/s
MiloszKrajewski_K4os_Hash_xxHash     | 256K | False | 20802 ns  | 49 ns    | 46 ns    | 12017 MB/s
ftlab_FT_xxHash                      | 256K | False | 20841 ns  | 35 ns    | 33 ns    | 11995 MB/s
uranium62_xxHash                     | 256K | True  | 21029 ns  | 34 ns    | 32 ns    | 11888 MB/s
Zhentar_xxHash64_NET                 | 256K | False | 25943 ns  | 62 ns    | 58 ns    | 9636 MB/s
ByteTerrace_Maths_Probability_XxHash | 256K | True  | 35898 ns  | 76 ns    | 71 ns    | 6964 MB/s
ssg_HashDepot                        | 256K | True  | 75144 ns  | 201 ns   | 188 ns   | 3326 MB/s
Zhentar_xxHash3_NET                  | 256K | True  | 76943 ns  | 200 ns   | 187 ns   | 3249 MB/s
xoofx_smash                          | 256K | True  | 116 μs    | 451 ns   | 422 ns   | 2144 MB/s
EnokiSolutions_es_xxhash             | 256K | True  | 125 μs    | 210 ns   | 175 ns   | 1992 MB/s
brandondahler_Data_HashFunction      | 256K | True  | 202 μs    | 486 ns   | 454 ns   | 1234 MB/s
differentrain_YYProject_XXHash       | 256K | True  | 207 μs    | 481 ns   | 450 ns   | 1206 MB/s
ailen0ada_xxHash4net                 | 256K | False | 330 μs    | 595 ns   | 557 ns   | 755 MB/s
neosmart_hashing_net                 | 256K | True  | 381 μs    | 996 ns   | 932 ns   | 654 MB/s
wilhelmliao_xxHash_NET               | 256K | True  | 474 μs    | 1337 ns  | 1251 ns  | 527 MB/s
|                                    |      |       |           |          |          | 
shibox_XXHash                        | 2M   | True  | 164 μs    | 187 ns   | 166 ns   | 12182 MB/s
MiloszKrajewski_K4os_Hash_xxHash     | 2M   | False | 164 μs    | 292 ns   | 273 ns   | 12163 MB/s
ftlab_FT_xxHash                      | 2M   | False | 164 μs    | 436 ns   | 408 ns   | 12150 MB/s
uranium62_xxHash                     | 2M   | True  | 167 μs    | 398 ns   | 372 ns   | 11918 MB/s
Zhentar_xxHash64_NET                 | 2M   | False | 206 μs    | 374 ns   | 332 ns   | 9671 MB/s
ByteTerrace_Maths_Probability_XxHash | 2M   | True  | 285 μs    | 456 ns   | 427 ns   | 6993 MB/s
Zhentar_xxHash3_NET                  | 2M   | True  | 614 μs    | 1428 ns  | 1336 ns  | 3257 MB/s
ssg_HashDepot                        | 2M   | True  | 614 μs    | 1731 ns  | 1620 ns  | 3256 MB/s
xoofx_smash                          | 2M   | True  | 931 μs    | 2780 ns  | 2601 ns  | 2147 MB/s
EnokiSolutions_es_xxhash             | 2M   | True  | 1004 μs   | 1900 ns  | 1777 ns  | 1990 MB/s
brandondahler_Data_HashFunction      | 2M   | True  | 1626 μs   | 2785 ns  | 2468 ns  | 1229 MB/s
differentrain_YYProject_XXHash       | 2M   | True  | 1645 μs   | 3709 ns  | 3469 ns  | 1215 MB/s
ailen0ada_xxHash4net                 | 2M   | False | 2639 μs   | 10194 ns | 9535 ns  | 757 MB/s
neosmart_hashing_net                 | 2M   | True  | 3053 μs   | 6051 ns  | 5660 ns  | 655 MB/s
wilhelmliao_xxHash_NET               | 2M   | True  | 3785 μs   | 13188 ns | 12336 ns | 528 MB/s
|                                    |      |       |           |          |          | 
MiloszKrajewski_K4os_Hash_xxHash     | 16M  | False | 1458 μs   | 4214 ns  | 3942 ns  | 10972 MB/s
shibox_XXHash                        | 16M  | True  | 1459 μs   | 6232 ns  | 5524 ns  | 10960 MB/s
ftlab_FT_xxHash                      | 16M  | False | 1460 μs   | 5406 ns  | 4793 ns  | 10956 MB/s
uranium62_xxHash                     | 16M  | True  | 1497 μs   | 5874 ns  | 5494 ns  | 10684 MB/s
Zhentar_xxHash64_NET                 | 16M  | False | 1741 μs   | 9260 ns  | 8662 ns  | 9186 MB/s
ByteTerrace_Maths_Probability_XxHash | 16M  | True  | 2337 μs   | 7028 ns  | 6574 ns  | 6844 MB/s
ssg_HashDepot                        | 16M  | True  | 4990 μs   | 23793 ns | 21092 ns | 3206 MB/s
Zhentar_xxHash3_NET                  | 16M  | True  | 5308 μs   | 11986 ns | 11211 ns | 3013 MB/s
xoofx_smash                          | 16M  | True  | 7496 μs   | 48713 ns | 45566 ns | 2134 MB/s
EnokiSolutions_es_xxhash             | 16M  | True  | 8117 μs   | 28832 ns | 26969 ns | 1971 MB/s
differentrain_YYProject_XXHash       | 16M  | True  | 12784 μs  | 44245 ns | 41387 ns | 1251 MB/s
brandondahler_Data_HashFunction      | 16M  | True  | 13640 μs  | 20008 ns | 18716 ns | 1173 MB/s
ailen0ada_xxHash4net                 | 16M  | False | 21202 μs  | 40450 ns | 37837 ns | 754 MB/s
neosmart_hashing_net                 | 16M  | True  | 24520 μs  | 53961 ns | 50475 ns | 652 MB/s
wilhelmliao_xxHash_NET               | 16M  | True  | 30400 μs  | 117 μs   | 109 μs   | 526 MB/s
|                                    |      |       |           |          |          | 
MiloszKrajewski_K4os_Hash_xxHash     | 128M | False | 11789 μs  | 61121 ns | 57173 ns | 10856 MB/s
ftlab_FT_xxHash                      | 128M | False | 11868 μs  | 110 μs   | 103 μs   | 10784 MB/s
shibox_XXHash                        | 128M | True  | 11901 μs  | 56662 ns | 53002 ns | 10754 MB/s
uranium62_xxHash                     | 128M | True  | 12164 μs  | 76874 ns | 71908 ns | 10522 MB/s
Zhentar_xxHash64_NET                 | 128M | False | 14148 μs  | 123 μs   | 115 μs   | 9046 MB/s
ByteTerrace_Maths_Probability_XxHash | 128M | True  | 18477 μs  | 48637 ns | 40614 ns | 6927 MB/s
ssg_HashDepot                        | 128M | True  | 40251 μs  | 422 μs   | 394 μs   | 3180 MB/s
Zhentar_xxHash3_NET                  | 128M | True  | 41970 μs  | 190 μs   | 178 μs   | 3049 MB/s
xoofx_smash                          | 128M | True  | 60073 μs  | 382 μs   | 357 μs   | 2130 MB/s
EnokiSolutions_es_xxhash             | 128M | True  | 64858 μs  | 152 μs   | 142 μs   | 1973 MB/s
differentrain_YYProject_XXHash       | 128M | True  | 103999 μs | 291 μs   | 258 μs   | 1230 MB/s
brandondahler_Data_HashFunction      | 128M | True  | 110627 μs | 240 μs   | 187 μs   | 1157 MB/s
ailen0ada_xxHash4net                 | 128M | False | 169209 μs | 1063 μs  | 995 μs   | 756 MB/s
neosmart_hashing_net                 | 128M | True  | 196203 μs | 559 μs   | 523 μs   | 652 MB/s
wilhelmliao_xxHash_NET               | 128M | True  | 242312 μs | 425 μs   | 398 μs   | 528 MB/s


``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 7 SP1 (6.1.7601.0)
Intel Core i5-4460 CPU 3.20GHz (Haswell), 1 CPU, 4 logical and 4 physical cores
Frequency=3117792 Hz, Resolution=320 ns, Timer=TSC
.NET Core SDK=3.1.301
  [Host]        : .NET Core 3.0.3 (CoreCLR 4.700.20.6603, CoreFX 4.700.20.6701), X64 RyuJIT
  .NET Core 3.0 : .NET Core 3.1.5 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.27001), X64 RyuJIT

Job=.NET Core 3.0  Runtime=.NET Core 3.0  

```
Method              | len  | sse2  | avx2  | seed | Mean     | Error    | StdDev   | Throughput
--------------------|------|-------|-------|------|----------|----------|----------|--------------
Zhentar_xxHash3_NET | 2    | False | False | True | 9.572 ns | 0.026 ns | 0.020 ns | 199 MB/s
Zhentar_xxHash3_NET | 2    | False | True  | True | 9.576 ns | 0.017 ns | 0.016 ns | 199 MB/s
Zhentar_xxHash3_NET | 2    | True  | False | True | 9.573 ns | 0.024 ns | 0.023 ns | 199 MB/s
Zhentar_xxHash3_NET | 2    | True  | True  | True | 9.567 ns | 0.020 ns | 0.018 ns | 199 MB/s
|                   |      |       |       |      |          |          |          | 
Zhentar_xxHash3_NET | 8    | False | False | True | 9.707 ns | 0.021 ns | 0.019 ns | 786 MB/s
Zhentar_xxHash3_NET | 8    | False | True  | True | 9.702 ns | 0.016 ns | 0.015 ns | 786 MB/s
Zhentar_xxHash3_NET | 8    | True  | False | True | 9.686 ns | 0.013 ns | 0.013 ns | 787 MB/s
Zhentar_xxHash3_NET | 8    | True  | True  | True | 9.692 ns | 0.018 ns | 0.017 ns | 787 MB/s
|                   |      |       |       |      |          |          |          | 
Zhentar_xxHash3_NET | 64   | False | False | True | 21 ns    | 0.058 ns | 0.054 ns | 2794 MB/s
Zhentar_xxHash3_NET | 64   | False | True  | True | 21 ns    | 0.036 ns | 0.034 ns | 2795 MB/s
Zhentar_xxHash3_NET | 64   | True  | False | True | 21 ns    | 0.044 ns | 0.041 ns | 2794 MB/s
Zhentar_xxHash3_NET | 64   | True  | True  | True | 21 ns    | 0.038 ns | 0.036 ns | 2795 MB/s
|                   |      |       |       |      |          |          |          | 
Zhentar_xxHash3_NET | 512  | False | False | True | 136 ns   | 0.370 ns | 0.346 ns | 3587 MB/s
Zhentar_xxHash3_NET | 512  | False | True  | True | 64 ns    | 0.933 ns | 0.872 ns | 7563 MB/s
Zhentar_xxHash3_NET | 512  | True  | False | True | 71 ns    | 1.063 ns | 0.994 ns | 6816 MB/s
Zhentar_xxHash3_NET | 512  | True  | True  | True | 63 ns    | 0.162 ns | 0.152 ns | 7729 MB/s
|                   |      |       |       |      |          |          |          | 
Zhentar_xxHash3_NET | 4K   | False | False | True | 880 ns   | 1.903 ns | 1.780 ns | 4439 MB/s
Zhentar_xxHash3_NET | 4K   | False | True  | True | 155 ns   | 0.366 ns | 0.342 ns | 25050 MB/s
Zhentar_xxHash3_NET | 4K   | True  | False | True | 271 ns   | 0.723 ns | 0.676 ns | 14403 MB/s
Zhentar_xxHash3_NET | 4K   | True  | True  | True | 158 ns   | 0.225 ns | 0.200 ns | 24585 MB/s
|                   |      |       |       |      |          |          |          | 
Zhentar_xxHash3_NET | 32K  | False | False | True | 6775 ns  | 9.023 ns | 8.440 ns | 4611 MB/s
Zhentar_xxHash3_NET | 32K  | False | True  | True | 958 ns   | 7.499 ns | 7.015 ns | 32612 MB/s
Zhentar_xxHash3_NET | 32K  | True  | False | True | 1747 ns  | 7.889 ns | 7.379 ns | 17882 MB/s
Zhentar_xxHash3_NET | 32K  | True  | True  | True | 932 ns   | 4.706 ns | 4.402 ns | 33514 MB/s
|                   |      |       |       |      |          |          |          | 
Zhentar_xxHash3_NET | 256K | False | False | True | 53714 ns | 121 ns   | 113 ns   | 4654 MB/s
Zhentar_xxHash3_NET | 256K | False | True  | True | 6564 ns  | 15 ns    | 14 ns    | 38084 MB/s
Zhentar_xxHash3_NET | 256K | True  | False | True | 12083 ns | 28 ns    | 26 ns    | 20690 MB/s
Zhentar_xxHash3_NET | 256K | True  | True  | True | 6807 ns  | 16 ns    | 14 ns    | 36726 MB/s
|                   |      |       |       |      |          |          |          | 
Zhentar_xxHash3_NET | 2M   | False | False | True | 437 μs   | 1440 ns  | 1347 ns  | 4576 MB/s
Zhentar_xxHash3_NET | 2M   | False | True  | True | 64662 ns | 125 ns   | 110 ns   | 30929 MB/s
Zhentar_xxHash3_NET | 2M   | True  | False | True | 102 μs   | 392 ns   | 366 ns   | 19567 MB/s
Zhentar_xxHash3_NET | 2M   | True  | True  | True | 64265 ns | 191 ns   | 179 ns   | 31120 MB/s
|                   |      |       |       |      |          |          |          | 
Zhentar_xxHash3_NET | 16M  | False | False | True | 4131 μs  | 7627 ns  | 6761 ns  | 3873 MB/s
Zhentar_xxHash3_NET | 16M  | False | True  | True | 1098 μs  | 3495 ns  | 3098 ns  | 14569 MB/s
Zhentar_xxHash3_NET | 16M  | True  | False | True | 1383 μs  | 4954 ns  | 4634 ns  | 11566 MB/s
Zhentar_xxHash3_NET | 16M  | True  | True  | True | 1126 μs  | 4242 ns  | 3968 ns  | 14206 MB/s
|                   |      |       |       |      |          |          |          | 
Zhentar_xxHash3_NET | 128M | False | False | True | 32092 μs | 90993 ns | 85115 ns | 3988 MB/s
Zhentar_xxHash3_NET | 128M | False | True  | True | 9942 μs  | 26607 ns | 24889 ns | 12874 MB/s
Zhentar_xxHash3_NET | 128M | True  | False | True | 11464 μs | 26834 ns | 25101 ns | 11164 MB/s
Zhentar_xxHash3_NET | 128M | True  | True  | True | 9947 μs  | 26628 ns | 24908 ns | 12867 MB/s


### List of xxHash implementations (alphabetical-sorted):
- [ailen0ada_xxHash4net](https://github.com/ailen0ada/xxHash4net)
- [brandondahler_Data_HashFunction](https://github.com/brandondahler/Data.HashFunction)
- [ByteTerrace_Maths_Probability_XxHash](https://dev.azure.com/byteterrace/CSharp/_git/ByteTerrace.Maths.Probability.XxHash)
- [differentrain_YYProject_XXHash](https://github.com/differentrain/YYProject.XXHash)
- [EnokiSolutions_es_xxhash](https://github.com/EnokiSolutions/es-xxhash)
- [ftlab_FT_xxHash](https://github.com/ftlab/FT.xxHash)
- [MiloszKrajewski_K4os_Hash_xxHash](https://github.com/MiloszKrajewski/K4os.Hash.xxHash)
- [neosmart_hashing_net](https://github.com/neosmart/hashing.net)
- [shibox_XXHash](https://github.com/shibox/XXHash)
- [ssg_HashDepot](https://github.com/ssg/HashDepot)
- [uranium62_xxHash](https://github.com/uranium62/xxHash)
- [wilhelmliao_xxHash_NET](https://github.com/wilhelmliao/xxHash.NET)
- [xoofx_smash](https://github.com/xoofx/smash)
- [Zhentar_xxHash3(64)_NET](https://github.com/Zhentar/xxHash3.NET)



