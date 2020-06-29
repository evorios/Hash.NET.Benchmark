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
  1 ns       : 1 Nanosecond (0.000000001 sec)
  sse2       : Use SSE2 optimization
  avx2       : Use AVX2 optimization (non-portable)

```
Method                               | len  | seed  | Mean           | Error        | StdDev      | Throughput
-------------------------------------|------|-------|----------------|--------------|-------------|---------------
uranium62_xxHash                     | 2    | True  | 7.129 ns       | 0.0159 ns    | 0.0149 ns   | 267 MB/s
shibox_XXHash                        | 2    | True  | 7.418 ns       | 0.0211 ns    | 0.0198 ns   | 257 MB/s
EnokiSolutions_es_xxhash             | 2    | True  | 8.390 ns       | 0.0291 ns    | 0.0272 ns   | 227 MB/s
ssg_HashDepot                        | 2    | True  | 17 ns      | 0.0463 ns    | 0.0433 ns   | 107 MB/s
xoofx_smash                          | 2    | True  | 21 ns      | 0.0399 ns    | 0.0311 ns   | 88 MB/s
neosmart_hashing_net                 | 2    | True  | 31 ns      | 0.0857 ns    | 0.0801 ns   | 60 MB/s
Zhentar_xxHash3_NET                  | 2    | True  | 35 ns      | 0.1416 ns    | 0.1325 ns   | 53 MB/s
Zhentar_xxHash64_NET                 | 2    | False | 43 ns      | 0.1071 ns    | 0.1002 ns   | 44 MB/s
differentrain_YYProject_XXHash       | 2    | True  | 99 ns      | 0.1440 ns    | 0.1203 ns   | 19 MB/s
MiloszKrajewski_K4os_Hash_xxHash     | 2    | False | 113 ns     | 0.1905 ns    | 0.1782 ns   | 16 MB/s
ftlab_FT_xxHash                      | 2    | False | 114 ns     | 0.3376 ns    | 0.3158 ns   | 16 MB/s
ByteTerrace_Maths_Probability_XxHash | 2    | True  | 125 ns     | 0.2925 ns    | 0.2736 ns   | 15 MB/s
wilhelmliao_xxHash_NET               | 2    | True  | 158 ns     | 0.3776 ns    | 0.3532 ns   | 12 MB/s
ailen0ada_xxHash4net                 | 2    | False | 190 ns     | 0.4585 ns    | 0.4289 ns   | 10 MB/s
brandondahler_Data_HashFunction      | 2    | True  | 649 ns     | 1.8756 ns    | 1.7544 ns   | 2.9 MB/s
|                                    |      |       |                |              |             | 
uranium62_xxHash                     | 8    | True  | 5.884 ns       | 0.0128 ns    | 0.0120 ns   | 1296 MB/s
shibox_XXHash                        | 8    | True  | 6.156 ns       | 0.0179 ns    | 0.0167 ns   | 1239 MB/s
EnokiSolutions_es_xxhash             | 8    | True  | 11 ns      | 0.0209 ns    | 0.0196 ns   | 677 MB/s
ssg_HashDepot                        | 8    | True  | 17 ns      | 0.0352 ns    | 0.0329 ns   | 446 MB/s
xoofx_smash                          | 8    | True  | 17 ns      | 0.0360 ns    | 0.0319 ns   | 446 MB/s
neosmart_hashing_net                 | 8    | True  | 35 ns      | 0.0926 ns    | 0.0866 ns   | 214 MB/s
Zhentar_xxHash64_NET                 | 8    | False | 42 ns      | 0.0771 ns    | 0.0721 ns   | 178 MB/s
Zhentar_xxHash3_NET                  | 8    | True  | 47 ns      | 0.0949 ns    | 0.0888 ns   | 161 MB/s
differentrain_YYProject_XXHash       | 8    | True  | 103 ns     | 0.2542 ns    | 0.2254 ns   | 73 MB/s
MiloszKrajewski_K4os_Hash_xxHash     | 8    | False | 113 ns     | 0.2313 ns    | 0.2163 ns   | 67 MB/s
ftlab_FT_xxHash                      | 8    | False | 114 ns     | 0.2268 ns    | 0.2122 ns   | 66 MB/s
ByteTerrace_Maths_Probability_XxHash | 8    | True  | 126 ns     | 0.3009 ns    | 0.2814 ns   | 60 MB/s
wilhelmliao_xxHash_NET               | 8    | True  | 169 ns     | 0.3134 ns    | 0.2778 ns   | 45 MB/s
ailen0ada_xxHash4net                 | 8    | False | 207 ns     | 0.4341 ns    | 0.4061 ns   | 36 MB/s
brandondahler_Data_HashFunction      | 8    | True  | 667 ns     | 2.2322 ns    | 2.0880 ns   | 11 MB/s
|                                    |      |       |                |              |             | 
shibox_XXHash                        | 64   | True  | 17 ns      | 0.0372 ns    | 0.0329 ns   | 3511 MB/s
uranium62_xxHash                     | 64   | True  | 18 ns      | 0.0347 ns    | 0.0325 ns   | 3326 MB/s
ssg_HashDepot                        | 64   | True  | 34 ns      | 0.0529 ns    | 0.0469 ns   | 1758 MB/s
xoofx_smash                          | 64   | True  | 39 ns      | 0.0626 ns    | 0.0555 ns   | 1538 MB/s
EnokiSolutions_es_xxhash             | 64   | True  | 43 ns      | 0.1207 ns    | 0.1129 ns   | 1415 MB/s
Zhentar_xxHash64_NET                 | 64   | False | 53 ns      | 0.1498 ns    | 0.1401 ns   | 1140 MB/s
Zhentar_xxHash3_NET                  | 64   | True  | 67 ns      | 0.1977 ns    | 0.1849 ns   | 903 MB/s
MiloszKrajewski_K4os_Hash_xxHash     | 64   | False | 121 ns     | 0.3573 ns    | 0.3342 ns   | 504 MB/s
ftlab_FT_xxHash                      | 64   | False | 123 ns     | 0.3050 ns    | 0.2853 ns   | 496 MB/s
ByteTerrace_Maths_Probability_XxHash | 64   | True  | 124 ns     | 0.3166 ns    | 0.2962 ns   | 490 MB/s
neosmart_hashing_net                 | 64   | True  | 130 ns     | 0.2982 ns    | 0.2790 ns   | 467 MB/s
differentrain_YYProject_XXHash       | 64   | True  | 168 ns     | 0.3087 ns    | 0.2737 ns   | 363 MB/s
wilhelmliao_xxHash_NET               | 64   | True  | 292 ns     | 0.7579 ns    | 0.7089 ns   | 208 MB/s
ailen0ada_xxHash4net                 | 64   | False | 314 ns     | 0.9603 ns    | 0.8983 ns   | 193 MB/s
brandondahler_Data_HashFunction      | 64   | True  | 768 ns     | 1.9407 ns    | 1.8154 ns   | 79 MB/s
|                                    |      |       |                |              |             | 
shibox_XXHash                        | 512  | True  | 69 ns      | 0.1350 ns    | 0.1263 ns   | 6987 MB/s
uranium62_xxHash                     | 512  | True  | 79 ns      | 0.1228 ns    | 0.1149 ns   | 6132 MB/s
Zhentar_xxHash64_NET                 | 512  | False | 96 ns      | 0.1628 ns    | 0.1443 ns   | 5038 MB/s
ssg_HashDepot                        | 512  | True  | 161 ns     | 0.3887 ns    | 0.3636 ns   | 3015 MB/s
MiloszKrajewski_K4os_Hash_xxHash     | 512  | False | 164 ns     | 0.3250 ns    | 0.3040 ns   | 2965 MB/s
ftlab_FT_xxHash                      | 512  | False | 167 ns     | 0.2343 ns    | 0.2192 ns   | 2914 MB/s
ByteTerrace_Maths_Probability_XxHash | 512  | True  | 198 ns     | 0.2679 ns    | 0.2374 ns   | 2464 MB/s
xoofx_smash                          | 512  | True  | 242 ns     | 1.2157 ns    | 1.1371 ns   | 2011 MB/s
Zhentar_xxHash3_NET                  | 512  | True  | 254 ns     | 0.5221 ns    | 0.4884 ns   | 1915 MB/s
EnokiSolutions_es_xxhash             | 512  | True  | 263 ns     | 0.3250 ns    | 0.2881 ns   | 1854 MB/s
differentrain_YYProject_XXHash       | 512  | True  | 528 ns     | 1.1402 ns    | 1.0665 ns   | 923 MB/s
neosmart_hashing_net                 | 512  | True  | 793 ns     | 1.4524 ns    | 1.3585 ns   | 615 MB/s
ailen0ada_xxHash4net                 | 512  | False | 893 ns     | 2.1768 ns    | 2.0362 ns   | 546 MB/s
wilhelmliao_xxHash_NET               | 512  | True  | 1103 ns   | 2.9980 ns    | 2.8043 ns   | 442 MB/s
brandondahler_Data_HashFunction      | 512  | True  | 1116 ns   | 3.7075 ns    | 3.4680 ns   | 437 MB/s
|                                    |      |       |                |              |             | 
shibox_XXHash                        | 4K   | True  | 371 ns     | 0.6251 ns    | 0.5847 ns   | 10520 MB/s
uranium62_xxHash                     | 4K   | True  | 397 ns     | 0.5776 ns    | 0.5403 ns   | 9831 MB/s
Zhentar_xxHash64_NET                 | 4K   | False | 454 ns     | 0.8993 ns    | 0.8412 ns   | 8600 MB/s
MiloszKrajewski_K4os_Hash_xxHash     | 4K   | False | 458 ns     | 0.6154 ns    | 0.5456 ns   | 8515 MB/s
ftlab_FT_xxHash                      | 4K   | False | 462 ns     | 0.5130 ns    | 0.4799 ns   | 8451 MB/s
ByteTerrace_Maths_Probability_XxHash | 4K   | True  | 698 ns     | 1.4244 ns    | 1.3323 ns   | 5588 MB/s
ssg_HashDepot                        | 4K   | True  | 1191 ns   | 2.5446 ns    | 2.3802 ns   | 3278 MB/s
Zhentar_xxHash3_NET                  | 4K   | True  | 1299 ns   | 2.1581 ns    | 1.9131 ns   | 3006 MB/s
xoofx_smash                          | 4K   | True  | 1841 ns   | 6.5094 ns    | 6.0889 ns   | 2121 MB/s
EnokiSolutions_es_xxhash             | 4K   | True  | 1984 ns   | 5.7865 ns    | 5.4127 ns   | 1968 MB/s
differentrain_YYProject_XXHash       | 4K   | True  | 3375 ns   | 7.3130 ns    | 6.8406 ns   | 1157 MB/s
brandondahler_Data_HashFunction      | 4K   | True  | 3812 ns   | 8.1636 ns    | 7.2368 ns   | 1024 MB/s
ailen0ada_xxHash4net                 | 4K   | False | 5433 ns   | 14 ns   | 13 ns  | 718 MB/s
neosmart_hashing_net                 | 4K   | True  | 6017 ns   | 11 ns   | 11 ns  | 649 MB/s
wilhelmliao_xxHash_NET               | 4K   | True  | 7630 ns   | 13 ns   | 12 ns  | 511 MB/s
|                                    |      |       |                |              |             | 
shibox_XXHash                        | 32K  | True  | 2614 ns   | 8.6271 ns    | 7.6477 ns   | 11951 MB/s
uranium62_xxHash                     | 32K  | True  | 2675 ns   | 4.9537 ns    | 4.6337 ns   | 11678 MB/s
ftlab_FT_xxHash                      | 32K  | False | 2717 ns   | 6.1416 ns    | 5.7449 ns   | 11498 MB/s
MiloszKrajewski_K4os_Hash_xxHash     | 32K  | False | 2721 ns   | 5.2388 ns    | 4.9004 ns   | 11480 MB/s
Zhentar_xxHash64_NET                 | 32K  | False | 3278 ns   | 6.7266 ns    | 6.2920 ns   | 9530 MB/s
ByteTerrace_Maths_Probability_XxHash | 32K  | True  | 4610 ns   | 12 ns   | 12 ns  | 6777 MB/s
ssg_HashDepot                        | 32K  | True  | 9364 ns   | 27 ns   | 26 ns  | 3337 MB/s
Zhentar_xxHash3_NET                  | 32K  | True  | 9705 ns   | 24 ns   | 22 ns  | 3219 MB/s
xoofx_smash                          | 32K  | True  | 14612 ns  | 71 ns   | 66 ns  | 2138 MB/s
EnokiSolutions_es_xxhash             | 32K  | True  | 15741 ns  | 34 ns   | 32 ns  | 1985 MB/s
brandondahler_Data_HashFunction      | 32K  | True  | 25900 ns  | 42 ns   | 38 ns  | 1206 MB/s
differentrain_YYProject_XXHash       | 32K  | True  | 26124 ns  | 51 ns   | 47 ns  | 1196 MB/s
ailen0ada_xxHash4net                 | 32K  | False | 41740 ns  | 86 ns   | 80 ns  | 748 MB/s
neosmart_hashing_net                 | 32K  | True  | 47838 ns  | 89 ns   | 79 ns  | 653 MB/s
wilhelmliao_xxHash_NET               | 32K  | True  | 59411 ns  | 126 ns  | 118 ns | 526 MB/s
|                                    |      |       |                |              |             | 
shibox_XXHash                        | 256K | True  | 20589 ns      | 30 ns        | 28 ns       | 12142 MB/s
MiloszKrajewski_K4os_Hash_xxHash     | 256K | False | 20802 ns      | 49 ns        | 46 ns       | 12017 MB/s
ftlab_FT_xxHash                      | 256K | False | 20841 ns      | 35 ns        | 33 ns       | 11995 MB/s
uranium62_xxHash                     | 256K | True  | 21029 ns      | 34 ns        | 32 ns       | 11888 MB/s
Zhentar_xxHash64_NET                 | 256K | False | 25943 ns      | 62 ns        | 58 ns       | 9636 MB/s
ByteTerrace_Maths_Probability_XxHash | 256K | True  | 35898 ns      | 76 ns        | 71 ns       | 6964 MB/s
ssg_HashDepot                        | 256K | True  | 75144 ns      | 201 ns       | 188 ns      | 3326 MB/s
Zhentar_xxHash3_NET                  | 256K | True  | 76943 ns      | 200 ns       | 187 ns      | 3249 MB/s
xoofx_smash                          | 256K | True  | 116564 ns     | 451 ns       | 422 ns      | 2144 MB/s
EnokiSolutions_es_xxhash             | 256K | True  | 125494 ns     | 210 ns       | 175 ns      | 1992 MB/s
brandondahler_Data_HashFunction      | 256K | True  | 202574 ns     | 486 ns       | 454 ns      | 1234 MB/s
differentrain_YYProject_XXHash       | 256K | True  | 207212 ns     | 481 ns       | 450 ns      | 1206 MB/s
ailen0ada_xxHash4net                 | 256K | False | 330895 ns     | 595 ns       | 557 ns      | 755 MB/s
neosmart_hashing_net                 | 256K | True  | 381836 ns     | 996 ns       | 932 ns      | 654 MB/s
wilhelmliao_xxHash_NET               | 256K | True  | 474198 ns     | 1337 ns     | 1251 ns    | 527 MB/s
|                                    |      |       |                |              |             | 
shibox_XXHash                        | 2M   | True  | 164164 ns     | 187 ns       | 166 ns      | 12182 MB/s
MiloszKrajewski_K4os_Hash_xxHash     | 2M   | False | 164432 ns     | 292 ns       | 273 ns      | 12163 MB/s
ftlab_FT_xxHash                      | 2M   | False | 164601 ns     | 436 ns       | 408 ns      | 12150 MB/s
uranium62_xxHash                     | 2M   | True  | 167800 ns     | 398 ns       | 372 ns      | 11918 MB/s
Zhentar_xxHash64_NET                 | 2M   | False | 206788 ns     | 374 ns       | 332 ns      | 9671 MB/s
ByteTerrace_Maths_Probability_XxHash | 2M   | True  | 285967 ns     | 456 ns       | 427 ns      | 6993 MB/s
Zhentar_xxHash3_NET                  | 2M   | True  | 614038 ns     | 1428 ns     | 1336 ns    | 3257 MB/s
ssg_HashDepot                        | 2M   | True  | 614256 ns     | 1731 ns     | 1620 ns    | 3256 MB/s
xoofx_smash                          | 2M   | True  | 931416 ns     | 2780 ns     | 2601 ns    | 2147 MB/s
EnokiSolutions_es_xxhash             | 2M   | True  | 1004711 ns   | 1900 ns     | 1777 ns    | 1990 MB/s
brandondahler_Data_HashFunction      | 2M   | True  | 1626121 ns   | 2785 ns     | 2468 ns    | 1229 MB/s
differentrain_YYProject_XXHash       | 2M   | True  | 1645807 ns   | 3709 ns     | 3469 ns    | 1215 MB/s
ailen0ada_xxHash4net                 | 2M   | False | 2639917 ns   | 10194 ns    | 9535 ns    | 757 MB/s
neosmart_hashing_net                 | 2M   | True  | 3053154 ns   | 6051 ns     | 5660 ns    | 655 MB/s
wilhelmliao_xxHash_NET               | 2M   | True  | 3785951 ns   | 13188 ns    | 12336 ns   | 528 MB/s
|                                    |      |       |                |              |             | 
MiloszKrajewski_K4os_Hash_xxHash     | 16M  | False | 1458166 ns   | 4214 ns     | 3942 ns    | 10972 MB/s
shibox_XXHash                        | 16M  | True  | 1459821 ns   | 6232 ns     | 5524 ns    | 10960 MB/s
ftlab_FT_xxHash                      | 16M  | False | 1460366 ns   | 5406 ns     | 4793 ns    | 10956 MB/s
uranium62_xxHash                     | 16M  | True  | 1497455 ns   | 5874 ns     | 5494 ns    | 10684 MB/s
Zhentar_xxHash64_NET                 | 16M  | False | 1741702 ns   | 9260 ns     | 8662 ns    | 9186 MB/s
ByteTerrace_Maths_Probability_XxHash | 16M  | True  | 2337506 ns   | 7028 ns     | 6574 ns    | 6844 MB/s
ssg_HashDepot                        | 16M  | True  | 4990652 ns   | 23793 ns    | 21092 ns   | 3206 MB/s
Zhentar_xxHash3_NET                  | 16M  | True  | 5308748 ns   | 11986 ns    | 11211 ns   | 3013 MB/s
xoofx_smash                          | 16M  | True  | 7496698 ns   | 48713 ns    | 45566 ns   | 2134 MB/s
EnokiSolutions_es_xxhash             | 16M  | True  | 8117541 ns   | 28832 ns    | 26969 ns   | 1971 MB/s
differentrain_YYProject_XXHash       | 16M  | True  | 12784083 ns  | 44245 ns    | 41387 ns   | 1251 MB/s
brandondahler_Data_HashFunction      | 16M  | True  | 13640805 ns  | 20008 ns    | 18716 ns   | 1173 MB/s
ailen0ada_xxHash4net                 | 16M  | False | 21202963 ns  | 40450 ns    | 37837 ns   | 754 MB/s
neosmart_hashing_net                 | 16M  | True  | 24520240 ns  | 53961 ns    | 50475 ns   | 652 MB/s
wilhelmliao_xxHash_NET               | 16M  | True  | 30400399 ns  | 117494 ns   | 109903 ns  | 526 MB/s
|                                    |      |       |                |              |             | 
MiloszKrajewski_K4os_Hash_xxHash     | 128M | False | 11789926 ns  | 61121 ns    | 57173 ns   | 10856 MB/s
ftlab_FT_xxHash                      | 128M | False | 11868535 ns  | 110443 ns   | 103308 ns  | 10784 MB/s
shibox_XXHash                        | 128M | True  | 11901842 ns  | 56662 ns    | 53002 ns   | 10754 MB/s
uranium62_xxHash                     | 128M | True  | 12164262 ns  | 76874 ns    | 71908 ns   | 10522 MB/s
Zhentar_xxHash64_NET                 | 128M | False | 14148435 ns  | 123704 ns   | 115713 ns  | 9046 MB/s
ByteTerrace_Maths_Probability_XxHash | 128M | True  | 18477559 ns  | 48637 ns    | 40614 ns   | 6927 MB/s
ssg_HashDepot                        | 128M | True  | 40251597 ns  | 422215 ns   | 394940 ns  | 3180 MB/s
Zhentar_xxHash3_NET                  | 128M | True  | 41970034 ns  | 190996 ns   | 178658 ns  | 3049 MB/s
xoofx_smash                          | 128M | True  | 60073365 ns  | 382634 ns   | 357916 ns  | 2130 MB/s
EnokiSolutions_es_xxhash             | 128M | True  | 64858060 ns  | 152059 ns   | 142236 ns  | 1973 MB/s
differentrain_YYProject_XXHash       | 128M | True  | 103999066 ns | 291086 ns   | 258040 ns  | 1230 MB/s
brandondahler_Data_HashFunction      | 128M | True  | 110627959 ns | 240142 ns   | 187487 ns  | 1157 MB/s
ailen0ada_xxHash4net                 | 128M | False | 169209484 ns | 1063949 ns | 995219 ns  | 756 MB/s
neosmart_hashing_net                 | 128M | True  | 196203153 ns | 559805 ns   | 523642 ns  | 652 MB/s
wilhelmliao_xxHash_NET               | 128M | True  | 242312380 ns | 425779 ns   | 398274 ns  | 528 MB/s


``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 7 SP1 (6.1.7601.0)
Intel Core i5-4460 CPU 3.20GHz (Haswell), 1 CPU, 4 logical and 4 physical cores
Frequency=3117792 Hz, Resolution=320 ns, Timer=TSC
.NET Core SDK=3.1.301
  [Host]        : .NET Core 3.0.3 (CoreCLR 4.700.20.6603, CoreFX 4.700.20.6701), X64 RyuJIT
  .NET Core 3.0 : .NET Core 3.1.5 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.27001), X64 RyuJIT

Job=.NET Core 3.0  Runtime=.NET Core 3.0  

```
Method              | len  | sse2  | avx2  | seed | Mean        | Error     | StdDev    | Throughput
--------------------|------|-------|-------|------|-------------|-----------|-----------|--------------
Zhentar_xxHash3_NET | 2    | False | False | True | 9.572 ns    | 0.0267 ns | 0.0208 ns | 199 MB/s
Zhentar_xxHash3_NET | 2    | False | True  | True | 9.576 ns    | 0.0178 ns | 0.0166 ns | 199 MB/s
Zhentar_xxHash3_NET | 2    | True  | False | True | 9.573 ns    | 0.0248 ns | 0.0232 ns | 199 MB/s
Zhentar_xxHash3_NET | 2    | True  | True  | True | 9.567 ns    | 0.0201 ns | 0.0188 ns | 199 MB/s
|                   |      |       |       |      |             |           |           | 
Zhentar_xxHash3_NET | 8    | False | False | True | 9.707 ns    | 0.0212 ns | 0.0199 ns | 786 MB/s
Zhentar_xxHash3_NET | 8    | False | True  | True | 9.702 ns    | 0.0168 ns | 0.0157 ns | 786 MB/s
Zhentar_xxHash3_NET | 8    | True  | False | True | 9.686 ns    | 0.0139 ns | 0.0130 ns | 787 MB/s
Zhentar_xxHash3_NET | 8    | True  | True  | True | 9.692 ns    | 0.0185 ns | 0.0173 ns | 787 MB/s
|                   |      |       |       |      |             |           |           | 
Zhentar_xxHash3_NET | 64   | False | False | True | 21 ns   | 0.0587 ns | 0.0549 ns | 2794 MB/s
Zhentar_xxHash3_NET | 64   | False | True  | True | 21 ns   | 0.0365 ns | 0.0342 ns | 2795 MB/s
Zhentar_xxHash3_NET | 64   | True  | False | True | 21 ns   | 0.0441 ns | 0.0412 ns | 2794 MB/s
Zhentar_xxHash3_NET | 64   | True  | True  | True | 21 ns   | 0.0385 ns | 0.0360 ns | 2795 MB/s
|                   |      |       |       |      |             |           |           | 
Zhentar_xxHash3_NET | 512  | False | False | True | 136 ns  | 0.3702 ns | 0.3463 ns | 3587 MB/s
Zhentar_xxHash3_NET | 512  | False | True  | True | 64 ns   | 0.9330 ns | 0.8727 ns | 7563 MB/s
Zhentar_xxHash3_NET | 512  | True  | False | True | 71 ns   | 1.0632 ns | 0.9945 ns | 6816 MB/s
Zhentar_xxHash3_NET | 512  | True  | True  | True | 63 ns   | 0.1626 ns | 0.1521 ns | 7729 MB/s
|                   |      |       |       |      |             |           |           | 
Zhentar_xxHash3_NET | 4K   | False | False | True | 880 ns    | 1.90 ns   | 1.78 ns   | 4439 MB/s
Zhentar_xxHash3_NET | 4K   | False | True  | True | 155 ns    | 0.36 ns   | 0.34 ns   | 25050 MB/s
Zhentar_xxHash3_NET | 4K   | True  | False | True | 271 ns    | 0.72 ns   | 0.67 ns   | 14403 MB/s
Zhentar_xxHash3_NET | 4K   | True  | True  | True | 158 ns    | 0.22 ns   | 0.20 ns   | 24585 MB/s
|                   |      |       |       |      |             |           |           | 
Zhentar_xxHash3_NET | 32K  | False | False | True | 6775 ns  | 9.02 ns   | 8.44 ns   | 4611 MB/s
Zhentar_xxHash3_NET | 32K  | False | True  | True | 958 ns    | 7.49 ns   | 7.01 ns   | 32612 MB/s
Zhentar_xxHash3_NET | 32K  | True  | False | True | 1747 ns  | 7.88 ns   | 7.37 ns   | 17882 MB/s
Zhentar_xxHash3_NET | 32K  | True  | True  | True | 932 ns    | 4.70 ns   | 4.40 ns   | 33514 MB/s
|                   |      |       |       |      |             |           |           | 
Zhentar_xxHash3_NET | 256K | False | False | True | 53714 ns | 121 ns | 113 ns | 4654 MB/s
Zhentar_xxHash3_NET | 256K | False | True  | True | 6564 ns  | 15 ns  | 14 ns  | 38084 MB/s
Zhentar_xxHash3_NET | 256K | True  | False | True | 12083 ns | 28 ns  | 26 ns  | 20690 MB/s
Zhentar_xxHash3_NET | 256K | True  | True  | True | 6807 ns  | 16 ns  | 14 ns  | 36726 MB/s
|                   |      |       |       |      |             |           |           | 
Zhentar_xxHash3_NET | 2M   | False | False | True | 437027 ns  | 1440 ns  | 1347 ns  | 4576 MB/s
Zhentar_xxHash3_NET | 2M   | False | True  | True | 64662 ns   | 125 ns | 110 ns | 30929 MB/s
Zhentar_xxHash3_NET | 2M   | True  | False | True | 102212 ns  | 392 ns | 366 ns | 19567 MB/s
Zhentar_xxHash3_NET | 2M   | True  | True  | True | 64265 ns | 191 ns | 179 ns | 31120 MB/s
|                   |      |       |       |      |             |           |           | 
Zhentar_xxHash3_NET | 16M  | False | False | True | 4131192 ns  | 7627 ns    | 6761 ns    | 3873 MB/s
Zhentar_xxHash3_NET | 16M  | False | True  | True | 1098211 ns  | 3495 ns    | 3098 ns    | 14569 MB/s
Zhentar_xxHash3_NET | 16M  | True  | False | True | 1383320 ns  | 4954 ns    | 4634 ns    | 11566 MB/s
Zhentar_xxHash3_NET | 16M  | True  | True  | True | 1126231 ns  | 4242 ns    | 3968 ns    | 14206 MB/s
|                   |      |       |       |      |             |           |           | 
Zhentar_xxHash3_NET | 128M | False | False | True | 32092606 ns | 90993 ns   | 85115 ns   | 3988 MB/s
Zhentar_xxHash3_NET | 128M | False | True  | True | 9942258 ns  | 26607 ns   | 24889 ns   | 12874 MB/s
Zhentar_xxHash3_NET | 128M | True  | False | True | 11464749 ns | 26834 ns   | 25101 ns   | 11164 MB/s
Zhentar_xxHash3_NET | 128M | True  | True  | True | 9947491 ns  | 26628 ns   | 24908 ns   | 12867 MB/s


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



