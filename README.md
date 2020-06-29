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
uranium62_xxHash                     | 2    | True  | 7.129 ns       | 0.0159 ns    | 0.0149 ns   | 267,5 MB/s
shibox_XXHash                        | 2    | True  | 7.418 ns       | 0.0211 ns    | 0.0198 ns   | 257,1 MB/s
EnokiSolutions_es_xxhash             | 2    | True  | 8.390 ns       | 0.0291 ns    | 0.0272 ns   | 227,3 MB/s
ssg_HashDepot                        | 2    | True  | 17.774 ns      | 0.0463 ns    | 0.0433 ns   | 107,3 MB/s
xoofx_smash                          | 2    | True  | 21.559 ns      | 0.0399 ns    | 0.0311 ns   | 88,5 MB/s
neosmart_hashing_net                 | 2    | True  | 31.372 ns      | 0.0857 ns    | 0.0801 ns   | 60,8 MB/s
Zhentar_xxHash3_NET                  | 2    | True  | 35.695 ns      | 0.1416 ns    | 0.1325 ns   | 53,4 MB/s
Zhentar_xxHash64_NET                 | 2    | False | 43.361 ns      | 0.1071 ns    | 0.1002 ns   | 44,0 MB/s
differentrain_YYProject_XXHash       | 2    | True  | 99.138 ns      | 0.1440 ns    | 0.1203 ns   | 19,2 MB/s
MiloszKrajewski_K4os_Hash_xxHash     | 2    | False | 113.696 ns     | 0.1905 ns    | 0.1782 ns   | 16,8 MB/s
ftlab_FT_xxHash                      | 2    | False | 114.084 ns     | 0.3376 ns    | 0.3158 ns   | 16,7 MB/s
ByteTerrace_Maths_Probability_XxHash | 2    | True  | 125.345 ns     | 0.2925 ns    | 0.2736 ns   | 15,2 MB/s
wilhelmliao_xxHash_NET               | 2    | True  | 158.721 ns     | 0.3776 ns    | 0.3532 ns   | 12,0 MB/s
ailen0ada_xxHash4net                 | 2    | False | 190.365 ns     | 0.4585 ns    | 0.4289 ns   | 10,0 MB/s
brandondahler_Data_HashFunction      | 2    | True  | 649.557 ns     | 1.8756 ns    | 1.7544 ns   | 2,9 MB/s
|                                    |      |       |                |              |             | 
uranium62_xxHash                     | 8    | True  | 5.884 ns       | 0.0128 ns    | 0.0120 ns   | 1 296,7 MB/s
shibox_XXHash                        | 8    | True  | 6.156 ns       | 0.0179 ns    | 0.0167 ns   | 1 239,4 MB/s
EnokiSolutions_es_xxhash             | 8    | True  | 11.259 ns      | 0.0209 ns    | 0.0196 ns   | 677,6 MB/s
ssg_HashDepot                        | 8    | True  | 17.086 ns      | 0.0352 ns    | 0.0329 ns   | 446,5 MB/s
xoofx_smash                          | 8    | True  | 17.098 ns      | 0.0360 ns    | 0.0319 ns   | 446,2 MB/s
neosmart_hashing_net                 | 8    | True  | 35.529 ns      | 0.0926 ns    | 0.0866 ns   | 214,7 MB/s
Zhentar_xxHash64_NET                 | 8    | False | 42.665 ns      | 0.0771 ns    | 0.0721 ns   | 178,8 MB/s
Zhentar_xxHash3_NET                  | 8    | True  | 47.310 ns      | 0.0949 ns    | 0.0888 ns   | 161,3 MB/s
differentrain_YYProject_XXHash       | 8    | True  | 103.408 ns     | 0.2542 ns    | 0.2254 ns   | 73,8 MB/s
MiloszKrajewski_K4os_Hash_xxHash     | 8    | False | 113.157 ns     | 0.2313 ns    | 0.2163 ns   | 67,4 MB/s
ftlab_FT_xxHash                      | 8    | False | 114.292 ns     | 0.2268 ns    | 0.2122 ns   | 66,8 MB/s
ByteTerrace_Maths_Probability_XxHash | 8    | True  | 126.535 ns     | 0.3009 ns    | 0.2814 ns   | 60,3 MB/s
wilhelmliao_xxHash_NET               | 8    | True  | 169.512 ns     | 0.3134 ns    | 0.2778 ns   | 45,0 MB/s
ailen0ada_xxHash4net                 | 8    | False | 207.979 ns     | 0.4341 ns    | 0.4061 ns   | 36,7 MB/s
brandondahler_Data_HashFunction      | 8    | True  | 667.982 ns     | 2.2322 ns    | 2.0880 ns   | 11,4 MB/s
|                                    |      |       |                |              |             | 
shibox_XXHash                        | 64   | True  | 17.384 ns      | 0.0372 ns    | 0.0329 ns   | 3 511,0 MB/s
uranium62_xxHash                     | 64   | True  | 18.351 ns      | 0.0347 ns    | 0.0325 ns   | 3 326,0 MB/s
ssg_HashDepot                        | 64   | True  | 34.704 ns      | 0.0529 ns    | 0.0469 ns   | 1 758,7 MB/s
xoofx_smash                          | 64   | True  | 39.670 ns      | 0.0626 ns    | 0.0555 ns   | 1 538,6 MB/s
EnokiSolutions_es_xxhash             | 64   | True  | 43.107 ns      | 0.1207 ns    | 0.1129 ns   | 1 415,9 MB/s
Zhentar_xxHash64_NET                 | 64   | False | 53.524 ns      | 0.1498 ns    | 0.1401 ns   | 1 140,3 MB/s
Zhentar_xxHash3_NET                  | 64   | True  | 67.554 ns      | 0.1977 ns    | 0.1849 ns   | 903,5 MB/s
MiloszKrajewski_K4os_Hash_xxHash     | 64   | False | 121.027 ns     | 0.3573 ns    | 0.3342 ns   | 504,3 MB/s
ftlab_FT_xxHash                      | 64   | False | 123.054 ns     | 0.3050 ns    | 0.2853 ns   | 496,0 MB/s
ByteTerrace_Maths_Probability_XxHash | 64   | True  | 124.378 ns     | 0.3166 ns    | 0.2962 ns   | 490,7 MB/s
neosmart_hashing_net                 | 64   | True  | 130.705 ns     | 0.2982 ns    | 0.2790 ns   | 467,0 MB/s
differentrain_YYProject_XXHash       | 64   | True  | 168.113 ns     | 0.3087 ns    | 0.2737 ns   | 363,1 MB/s
wilhelmliao_xxHash_NET               | 64   | True  | 292.193 ns     | 0.7579 ns    | 0.7089 ns   | 208,9 MB/s
ailen0ada_xxHash4net                 | 64   | False | 314.912 ns     | 0.9603 ns    | 0.8983 ns   | 193,8 MB/s
brandondahler_Data_HashFunction      | 64   | True  | 768.803 ns     | 1.9407 ns    | 1.8154 ns   | 79,4 MB/s
|                                    |      |       |                |              |             | 
shibox_XXHash                        | 512  | True  | 69.875 ns      | 0.1350 ns    | 0.1263 ns   | 6 987,9 MB/s
uranium62_xxHash                     | 512  | True  | 79.621 ns      | 0.1228 ns    | 0.1149 ns   | 6 132,5 MB/s
Zhentar_xxHash64_NET                 | 512  | False | 96.907 ns      | 0.1628 ns    | 0.1443 ns   | 5 038,7 MB/s
ssg_HashDepot                        | 512  | True  | 161.904 ns     | 0.3887 ns    | 0.3636 ns   | 3 015,9 MB/s
MiloszKrajewski_K4os_Hash_xxHash     | 512  | False | 164.635 ns     | 0.3250 ns    | 0.3040 ns   | 2 965,8 MB/s
ftlab_FT_xxHash                      | 512  | False | 167.558 ns     | 0.2343 ns    | 0.2192 ns   | 2 914,1 MB/s
ByteTerrace_Maths_Probability_XxHash | 512  | True  | 198.159 ns     | 0.2679 ns    | 0.2374 ns   | 2 464,1 MB/s
xoofx_smash                          | 512  | True  | 242.800 ns     | 1.2157 ns    | 1.1371 ns   | 2 011,0 MB/s
Zhentar_xxHash3_NET                  | 512  | True  | 254.905 ns     | 0.5221 ns    | 0.4884 ns   | 1 915,5 MB/s
EnokiSolutions_es_xxhash             | 512  | True  | 263.315 ns     | 0.3250 ns    | 0.2881 ns   | 1 854,4 MB/s
differentrain_YYProject_XXHash       | 512  | True  | 528.728 ns     | 1.1402 ns    | 1.0665 ns   | 923,5 MB/s
neosmart_hashing_net                 | 512  | True  | 793.465 ns     | 1.4524 ns    | 1.3585 ns   | 615,4 MB/s
ailen0ada_xxHash4net                 | 512  | False | 893.620 ns     | 2.1768 ns    | 2.0362 ns   | 546,4 MB/s
wilhelmliao_xxHash_NET               | 512  | True  | 1,103.984 ns   | 2.9980 ns    | 2.8043 ns   | 442,3 MB/s
brandondahler_Data_HashFunction      | 512  | True  | 1,116.209 ns   | 3.7075 ns    | 3.4680 ns   | 437,4 MB/s
|                                    |      |       |                |              |             | 
shibox_XXHash                        | 4K   | True  | 371.320 ns     | 0.6251 ns    | 0.5847 ns   | 10 520 MB/s
uranium62_xxHash                     | 4K   | True  | 397.313 ns     | 0.5776 ns    | 0.5403 ns   | 9 831 MB/s
Zhentar_xxHash64_NET                 | 4K   | False | 454.203 ns     | 0.8993 ns    | 0.8412 ns   | 8 600 MB/s
MiloszKrajewski_K4os_Hash_xxHash     | 4K   | False | 458.708 ns     | 0.6154 ns    | 0.5456 ns   | 8 515 MB/s
ftlab_FT_xxHash                      | 4K   | False | 462.193 ns     | 0.5130 ns    | 0.4799 ns   | 8 451 MB/s
ByteTerrace_Maths_Probability_XxHash | 4K   | True  | 698.977 ns     | 1.4244 ns    | 1.3323 ns   | 5 588 MB/s
ssg_HashDepot                        | 4K   | True  | 1,191.365 ns   | 2.5446 ns    | 2.3802 ns   | 3 278 MB/s
Zhentar_xxHash3_NET                  | 4K   | True  | 1,299.369 ns   | 2.1581 ns    | 1.9131 ns   | 3 006 MB/s
xoofx_smash                          | 4K   | True  | 1,841.156 ns   | 6.5094 ns    | 6.0889 ns   | 2 121 MB/s
EnokiSolutions_es_xxhash             | 4K   | True  | 1,984.453 ns   | 5.7865 ns    | 5.4127 ns   | 1 968 MB/s
differentrain_YYProject_XXHash       | 4K   | True  | 3,375.841 ns   | 7.3130 ns    | 6.8406 ns   | 1 157 MB/s
brandondahler_Data_HashFunction      | 4K   | True  | 3,812.990 ns   | 8.1636 ns    | 7.2368 ns   | 1 024 MB/s
ailen0ada_xxHash4net                 | 4K   | False | 5,433.343 ns   | 14.3898 ns   | 13.4602 ns  | 718 MB/s
neosmart_hashing_net                 | 4K   | True  | 6,017.759 ns   | 11.9936 ns   | 11.2188 ns  | 649 MB/s
wilhelmliao_xxHash_NET               | 4K   | True  | 7,630.527 ns   | 13.0758 ns   | 12.2311 ns  | 511 MB/s
|                                    |      |       |                |              |             | 
shibox_XXHash                        | 32K  | True  | 2,614.835 ns   | 8.6271 ns    | 7.6477 ns   | 11 951 MB/s
uranium62_xxHash                     | 32K  | True  | 2,675.792 ns   | 4.9537 ns    | 4.6337 ns   | 11 678 MB/s
ftlab_FT_xxHash                      | 32K  | False | 2,717.751 ns   | 6.1416 ns    | 5.7449 ns   | 11 498 MB/s
MiloszKrajewski_K4os_Hash_xxHash     | 32K  | False | 2,721.979 ns   | 5.2388 ns    | 4.9004 ns   | 11 480 MB/s
Zhentar_xxHash64_NET                 | 32K  | False | 3,278.856 ns   | 6.7266 ns    | 6.2920 ns   | 9 530 MB/s
ByteTerrace_Maths_Probability_XxHash | 32K  | True  | 4,610.614 ns   | 12.9760 ns   | 12.1377 ns  | 6 777 MB/s
ssg_HashDepot                        | 32K  | True  | 9,364.704 ns   | 27.9987 ns   | 26.1900 ns  | 3 337 MB/s
Zhentar_xxHash3_NET                  | 32K  | True  | 9,705.338 ns   | 24.5718 ns   | 22.9845 ns  | 3 219 MB/s
xoofx_smash                          | 32K  | True  | 14,612.367 ns  | 71.4706 ns   | 66.8536 ns  | 2 138 MB/s
EnokiSolutions_es_xxhash             | 32K  | True  | 15,741.682 ns  | 34.8367 ns   | 32.5862 ns  | 1 985 MB/s
brandondahler_Data_HashFunction      | 32K  | True  | 25,900.254 ns  | 42.9708 ns   | 38.0925 ns  | 1 206 MB/s
differentrain_YYProject_XXHash       | 32K  | True  | 26,124.257 ns  | 51.2200 ns   | 47.9112 ns  | 1 196 MB/s
ailen0ada_xxHash4net                 | 32K  | False | 41,740.732 ns  | 86.2044 ns   | 80.6357 ns  | 748 MB/s
neosmart_hashing_net                 | 32K  | True  | 47,838.087 ns  | 89.6037 ns   | 79.4314 ns  | 653 MB/s
wilhelmliao_xxHash_NET               | 32K  | True  | 59,411.309 ns  | 126.3414 ns  | 118.1798 ns | 526 MB/s
|                                    |      |       |                |              |             | 
shibox_XXHash                        | 256K | True  | 20,589 ns      | 30 ns        | 28 ns       | 12 142 MB/s
MiloszKrajewski_K4os_Hash_xxHash     | 256K | False | 20,802 ns      | 49 ns        | 46 ns       | 12 017 MB/s
ftlab_FT_xxHash                      | 256K | False | 20,841 ns      | 35 ns        | 33 ns       | 11 995 MB/s
uranium62_xxHash                     | 256K | True  | 21,029 ns      | 34 ns        | 32 ns       | 11 888 MB/s
Zhentar_xxHash64_NET                 | 256K | False | 25,943 ns      | 62 ns        | 58 ns       | 9 636 MB/s
ByteTerrace_Maths_Probability_XxHash | 256K | True  | 35,898 ns      | 76 ns        | 71 ns       | 6 964 MB/s
ssg_HashDepot                        | 256K | True  | 75,144 ns      | 201 ns       | 188 ns      | 3 326 MB/s
Zhentar_xxHash3_NET                  | 256K | True  | 76,943 ns      | 200 ns       | 187 ns      | 3 249 MB/s
xoofx_smash                          | 256K | True  | 116,564 ns     | 451 ns       | 422 ns      | 2 144 MB/s
EnokiSolutions_es_xxhash             | 256K | True  | 125,494 ns     | 210 ns       | 175 ns      | 1 992 MB/s
brandondahler_Data_HashFunction      | 256K | True  | 202,574 ns     | 486 ns       | 454 ns      | 1 234 MB/s
differentrain_YYProject_XXHash       | 256K | True  | 207,212 ns     | 481 ns       | 450 ns      | 1 206 MB/s
ailen0ada_xxHash4net                 | 256K | False | 330,895 ns     | 595 ns       | 557 ns      | 755 MB/s
neosmart_hashing_net                 | 256K | True  | 381,836 ns     | 996 ns       | 932 ns      | 654 MB/s
wilhelmliao_xxHash_NET               | 256K | True  | 474,198 ns     | 1,337 ns     | 1,251 ns    | 527 MB/s
|                                    |      |       |                |              |             | 
shibox_XXHash                        | 2M   | True  | 164,164 ns     | 187 ns       | 166 ns      | 12 182 MB/s
MiloszKrajewski_K4os_Hash_xxHash     | 2M   | False | 164,432 ns     | 292 ns       | 273 ns      | 12 163 MB/s
ftlab_FT_xxHash                      | 2M   | False | 164,601 ns     | 436 ns       | 408 ns      | 12 150 MB/s
uranium62_xxHash                     | 2M   | True  | 167,800 ns     | 398 ns       | 372 ns      | 11 918 MB/s
Zhentar_xxHash64_NET                 | 2M   | False | 206,788 ns     | 374 ns       | 332 ns      | 9 671 MB/s
ByteTerrace_Maths_Probability_XxHash | 2M   | True  | 285,967 ns     | 456 ns       | 427 ns      | 6 993 MB/s
Zhentar_xxHash3_NET                  | 2M   | True  | 614,038 ns     | 1,428 ns     | 1,336 ns    | 3 257 MB/s
ssg_HashDepot                        | 2M   | True  | 614,256 ns     | 1,731 ns     | 1,620 ns    | 3 256 MB/s
xoofx_smash                          | 2M   | True  | 931,416 ns     | 2,780 ns     | 2,601 ns    | 2 147 MB/s
EnokiSolutions_es_xxhash             | 2M   | True  | 1,004,711 ns   | 1,900 ns     | 1,777 ns    | 1 990 MB/s
brandondahler_Data_HashFunction      | 2M   | True  | 1,626,121 ns   | 2,785 ns     | 2,468 ns    | 1 229 MB/s
differentrain_YYProject_XXHash       | 2M   | True  | 1,645,807 ns   | 3,709 ns     | 3,469 ns    | 1 215 MB/s
ailen0ada_xxHash4net                 | 2M   | False | 2,639,917 ns   | 10,194 ns    | 9,535 ns    | 757 MB/s
neosmart_hashing_net                 | 2M   | True  | 3,053,154 ns   | 6,051 ns     | 5,660 ns    | 655 MB/s
wilhelmliao_xxHash_NET               | 2M   | True  | 3,785,951 ns   | 13,188 ns    | 12,336 ns   | 528 MB/s
|                                    |      |       |                |              |             | 
MiloszKrajewski_K4os_Hash_xxHash     | 16M  | False | 1,458,166 ns   | 4,214 ns     | 3,942 ns    | 10 972 MB/s
shibox_XXHash                        | 16M  | True  | 1,459,821 ns   | 6,232 ns     | 5,524 ns    | 10 960 MB/s
ftlab_FT_xxHash                      | 16M  | False | 1,460,366 ns   | 5,406 ns     | 4,793 ns    | 10 956 MB/s
uranium62_xxHash                     | 16M  | True  | 1,497,455 ns   | 5,874 ns     | 5,494 ns    | 10 684 MB/s
Zhentar_xxHash64_NET                 | 16M  | False | 1,741,702 ns   | 9,260 ns     | 8,662 ns    | 9 186 MB/s
ByteTerrace_Maths_Probability_XxHash | 16M  | True  | 2,337,506 ns   | 7,028 ns     | 6,574 ns    | 6 844 MB/s
ssg_HashDepot                        | 16M  | True  | 4,990,652 ns   | 23,793 ns    | 21,092 ns   | 3 206 MB/s
Zhentar_xxHash3_NET                  | 16M  | True  | 5,308,748 ns   | 11,986 ns    | 11,211 ns   | 3 013 MB/s
xoofx_smash                          | 16M  | True  | 7,496,698 ns   | 48,713 ns    | 45,566 ns   | 2 134 MB/s
EnokiSolutions_es_xxhash             | 16M  | True  | 8,117,541 ns   | 28,832 ns    | 26,969 ns   | 1 971 MB/s
differentrain_YYProject_XXHash       | 16M  | True  | 12,784,083 ns  | 44,245 ns    | 41,387 ns   | 1 251 MB/s
brandondahler_Data_HashFunction      | 16M  | True  | 13,640,805 ns  | 20,008 ns    | 18,716 ns   | 1 173 MB/s
ailen0ada_xxHash4net                 | 16M  | False | 21,202,963 ns  | 40,450 ns    | 37,837 ns   | 754 MB/s
neosmart_hashing_net                 | 16M  | True  | 24,520,240 ns  | 53,961 ns    | 50,475 ns   | 652 MB/s
wilhelmliao_xxHash_NET               | 16M  | True  | 30,400,399 ns  | 117,494 ns   | 109,903 ns  | 526 MB/s
|                                    |      |       |                |              |             | 
MiloszKrajewski_K4os_Hash_xxHash     | 128M | False | 11,789,926 ns  | 61,121 ns    | 57,173 ns   | 10 856 MB/s
ftlab_FT_xxHash                      | 128M | False | 11,868,535 ns  | 110,443 ns   | 103,308 ns  | 10 784 MB/s
shibox_XXHash                        | 128M | True  | 11,901,842 ns  | 56,662 ns    | 53,002 ns   | 10 754 MB/s
uranium62_xxHash                     | 128M | True  | 12,164,262 ns  | 76,874 ns    | 71,908 ns   | 10 522 MB/s
Zhentar_xxHash64_NET                 | 128M | False | 14,148,435 ns  | 123,704 ns   | 115,713 ns  | 9 046 MB/s
ByteTerrace_Maths_Probability_XxHash | 128M | True  | 18,477,559 ns  | 48,637 ns    | 40,614 ns   | 6 927 MB/s
ssg_HashDepot                        | 128M | True  | 40,251,597 ns  | 422,215 ns   | 394,940 ns  | 3 180 MB/s
Zhentar_xxHash3_NET                  | 128M | True  | 41,970,034 ns  | 190,996 ns   | 178,658 ns  | 3 049 MB/s
xoofx_smash                          | 128M | True  | 60,073,365 ns  | 382,634 ns   | 357,916 ns  | 2 130 MB/s
EnokiSolutions_es_xxhash             | 128M | True  | 64,858,060 ns  | 152,059 ns   | 142,236 ns  | 1 973 MB/s
differentrain_YYProject_XXHash       | 128M | True  | 103,999,066 ns | 291,086 ns   | 258,040 ns  | 1 230 MB/s
brandondahler_Data_HashFunction      | 128M | True  | 110,627,959 ns | 240,142 ns   | 187,487 ns  | 1 157 MB/s
ailen0ada_xxHash4net                 | 128M | False | 169,209,484 ns | 1,063,949 ns | 995,219 ns  | 756 MB/s
neosmart_hashing_net                 | 128M | True  | 196,203,153 ns | 559,805 ns   | 523,642 ns  | 652 MB/s
wilhelmliao_xxHash_NET               | 128M | True  | 242,312,380 ns | 425,779 ns   | 398,274 ns  | 528 MB/s


``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 7 SP1 (6.1.7601.0)
Intel Core i5-4460 CPU 3.20GHz (Haswell), 1 CPU, 4 logical and 4 physical cores
Frequency=3117792 Hz, Resolution=320.7398 ns, Timer=TSC
.NET Core SDK=3.1.301
  [Host]        : .NET Core 3.0.3 (CoreCLR 4.700.20.6603, CoreFX 4.700.20.6701), X64 RyuJIT
  .NET Core 3.0 : .NET Core 3.1.5 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.27001), X64 RyuJIT

Job=.NET Core 3.0  Runtime=.NET Core 3.0  

```
Method              | len  | sse2  | avx2  | seed | Mean        | Error     | StdDev    | Throughput
--------------------|------|-------|-------|------|-------------|-----------|-----------|--------------
Zhentar_xxHash3_NET | 2    | False | False | True | 9.572 ns    | 0.0267 ns | 0.0208 ns | 199,3 MB/s
Zhentar_xxHash3_NET | 2    | False | True  | True | 9.576 ns    | 0.0178 ns | 0.0166 ns | 199,2 MB/s
Zhentar_xxHash3_NET | 2    | True  | False | True | 9.573 ns    | 0.0248 ns | 0.0232 ns | 199,2 MB/s
Zhentar_xxHash3_NET | 2    | True  | True  | True | 9.567 ns    | 0.0201 ns | 0.0188 ns | 199,4 MB/s
|                   |      |       |       |      |             |           |           | 
Zhentar_xxHash3_NET | 8    | False | False | True | 9.707 ns    | 0.0212 ns | 0.0199 ns | 786,0 MB/s
Zhentar_xxHash3_NET | 8    | False | True  | True | 9.702 ns    | 0.0168 ns | 0.0157 ns | 786,4 MB/s
Zhentar_xxHash3_NET | 8    | True  | False | True | 9.686 ns    | 0.0139 ns | 0.0130 ns | 787,7 MB/s
Zhentar_xxHash3_NET | 8    | True  | True  | True | 9.692 ns    | 0.0185 ns | 0.0173 ns | 787,2 MB/s
|                   |      |       |       |      |             |           |           | 
Zhentar_xxHash3_NET | 64   | False | False | True | 21.838 ns   | 0.0587 ns | 0.0549 ns | 2 794,9 MB/s
Zhentar_xxHash3_NET | 64   | False | True  | True | 21.837 ns   | 0.0365 ns | 0.0342 ns | 2 795,1 MB/s
Zhentar_xxHash3_NET | 64   | True  | False | True | 21.838 ns   | 0.0441 ns | 0.0412 ns | 2 794,9 MB/s
Zhentar_xxHash3_NET | 64   | True  | True  | True | 21.836 ns   | 0.0385 ns | 0.0360 ns | 2 795,2 MB/s
|                   |      |       |       |      |             |           |           | 
Zhentar_xxHash3_NET | 512  | False | False | True | 136.121 ns  | 0.3702 ns | 0.3463 ns | 3 587,1 MB/s
Zhentar_xxHash3_NET | 512  | False | True  | True | 64.562 ns   | 0.9330 ns | 0.8727 ns | 7 563,0 MB/s
Zhentar_xxHash3_NET | 512  | True  | False | True | 71.631 ns   | 1.0632 ns | 0.9945 ns | 6 816,6 MB/s
Zhentar_xxHash3_NET | 512  | True  | True  | True | 63.171 ns   | 0.1626 ns | 0.1521 ns | 7 729,6 MB/s
|                   |      |       |       |      |             |           |           | 
Zhentar_xxHash3_NET | 4K   | False | False | True | 880.0 ns    | 1.90 ns   | 1.78 ns   | 4 439 MB/s
Zhentar_xxHash3_NET | 4K   | False | True  | True | 155.9 ns    | 0.36 ns   | 0.34 ns   | 25 050 MB/s
Zhentar_xxHash3_NET | 4K   | True  | False | True | 271.2 ns    | 0.72 ns   | 0.67 ns   | 14 403 MB/s
Zhentar_xxHash3_NET | 4K   | True  | True  | True | 158.8 ns    | 0.22 ns   | 0.20 ns   | 24 585 MB/s
|                   |      |       |       |      |             |           |           | 
Zhentar_xxHash3_NET | 32K  | False | False | True | 6,775.9 ns  | 9.02 ns   | 8.44 ns   | 4 611 MB/s
Zhentar_xxHash3_NET | 32K  | False | True  | True | 958.2 ns    | 7.49 ns   | 7.01 ns   | 32 612 MB/s
Zhentar_xxHash3_NET | 32K  | True  | False | True | 1,747.5 ns  | 7.88 ns   | 7.37 ns   | 17 882 MB/s
Zhentar_xxHash3_NET | 32K  | True  | True  | True | 932.4 ns    | 4.70 ns   | 4.40 ns   | 33 514 MB/s
|                   |      |       |       |      |             |           |           | 
Zhentar_xxHash3_NET | 256K | False | False | True | 53,714.0 ns | 121.62 ns | 113.77 ns | 4 654 MB/s
Zhentar_xxHash3_NET | 256K | False | True  | True | 6,564.2 ns  | 15.38 ns  | 14.39 ns  | 38 084 MB/s
Zhentar_xxHash3_NET | 256K | True  | False | True | 12,083.0 ns | 28.37 ns  | 26.54 ns  | 20 690 MB/s
Zhentar_xxHash3_NET | 256K | True  | True  | True | 6,807.0 ns  | 16.57 ns  | 14.69 ns  | 36 726 MB/s
|                   |      |       |       |      |             |           |           | 
Zhentar_xxHash3_NET | 2M   | False | False | True | 437,0 ns    | 1,4 ns    | 1,3 ns    | 4 576 MB/s
Zhentar_xxHash3_NET | 2M   | False | True  | True | 64,662.8 ns | 125.20 ns | 110.98 ns | 30 929 MB/s
Zhentar_xxHash3_NET | 2M   | True  | False | True | 102,2 ns    | 392.17 ns | 366.84 ns | 19 567 MB/s
Zhentar_xxHash3_NET | 2M   | True  | True  | True | 64,265.4 ns | 191.58 ns | 179.21 ns | 31 120 MB/s
|                   |      |       |       |      |             |           |           | 
Zhentar_xxHash3_NET | 16M  | False | False | True | 4,131,1 ns  | 7,6 ns    | 6,7 ns    | 3 873 MB/s
Zhentar_xxHash3_NET | 16M  | False | True  | True | 1,098,2 ns  | 3,4 ns    | 3,0 ns    | 14 569 MB/s
Zhentar_xxHash3_NET | 16M  | True  | False | True | 1,383,3 ns  | 4,9 ns    | 4,6 ns    | 11 566 MB/s
Zhentar_xxHash3_NET | 16M  | True  | True  | True | 1,126,2 ns  | 4,2 ns    | 3,9 ns    | 14 206 MB/s
|                   |      |       |       |      |             |           |           | 
Zhentar_xxHash3_NET | 128M | False | False | True | 32,092,6 ns | 90,9 ns   | 85,1 ns   | 3 988 MB/s
Zhentar_xxHash3_NET | 128M | False | True  | True | 9,942,2 ns  | 26,6 ns   | 24,8 ns   | 12 874 MB/s
Zhentar_xxHash3_NET | 128M | True  | False | True | 11,464,7 ns | 26,8 ns   | 25,1 ns   | 11 164 MB/s
Zhentar_xxHash3_NET | 128M | True  | True  | True | 9,947,4 ns  | 26,6 ns   | 24,9 ns   | 12 867 MB/s


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



