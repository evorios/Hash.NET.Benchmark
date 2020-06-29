using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Order;
using BenchmarkDotNet.Reports;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Validators;
using Perfolizer.Horology;
using System;
using System.Linq;
using System.Security.Cryptography;
#if !NETCOREAPP3_0
using Hasher01 = Extensions.Data.XXHash64CryptoServiceProvider;
using Hasher02 = Standart.Hash.xxHash.xxHash64;
using Hasher03 = OpenSource.Data.HashFunction.xxHash;
using Hasher04 = System.Security.Cryptography.xxHash64;
using Hasher05 = ByteTerrace.Maths.Probability.XxHash;
using Hasher06 = YYProject.XXHash.XXHash64;
using Hasher07 = ES.XxHash.XxHashEx;
using Hasher08 = FT.xxHash.XXH64;
using Hasher09 = K4os.Hash.xxHash.XXH64;
using Hasher10 = NeoSmart.Hashing.XXHash.Core.XXHash;
using Hasher11 = XXHash.XXHash64;
using Hasher12 = HashDepot.XXHash;
using Hasher13 = Smash.xxHash;
using Hasher14 = xxHash3.xxHash64;
#endif
using Hasher15 = xxHash3.xxHash3;

namespace Hash.NET.Benchmark
{
#if !NETCOREAPP3_0
    [Config(typeof(AllowNonOptimized))]
    [SimpleJob(RuntimeMoniker.Net472)]
    [GroupBenchmarksBy(BenchmarkLogicalGroupRule.ByParams)]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    public class HashNetBenchmark
    {
        private const long seed = 0;
        private byte[] data;
        [Params(2, 8, 64, 512, 4096, 32768, 262144, 2097152, 16777216, 134217728)]
        public int len;

        private Hasher01 hasher01;
        private Hasher03.IxxHash hasher03;
        private Hasher04 hasher04;
        private Hasher05 hasher05;
        private Hasher06 hasher06;
        private HashAlgorithm hasher08;
        private HashAlgorithm hasher09;
        private Hasher13.Hash64 hasher13;

        [GlobalSetup]
        public void Setup()
        {
            var rnd = new Random(len);
            data = new byte[len];
            rnd.NextBytes(data);

            hasher01 = new Hasher01(seed);
            hasher03 = Hasher03.xxHashFactory.Instance.Create(new Hasher03.xxHashConfig() { HashSizeInBits = 64, Seed = seed });
            hasher04 = Hasher04.Create();
            hasher05 = Hasher05.New(seed);
            hasher06 = new Hasher06((uint)seed);
            hasher08 = new Hasher08().AsHashAlgorithm();
            hasher09 = new Hasher09().AsHashAlgorithm();
            hasher13 = Hasher13.Create64(seed);
        }

        [Benchmark]
        [Arguments(true)]
        public byte[] wilhelmliao_xxHash_NET(bool seedAvl)
        {
            return hasher01.ComputeHash(data);
        }

        [Benchmark]
        [Arguments(true)]
        public ulong uranium62_xxHash(bool seedAvl)
        {
            return Hasher02.ComputeHash(data, data.Length, seed);
        }

        [Benchmark]
        [Arguments(true)]
        public byte[] brandondahler_Data_HashFunction(bool seedAvl)
        {
            return hasher03.ComputeHash(data).Hash;
        }

        [Benchmark]
        [Arguments(false)]
        public byte[] ailen0ada_xxHash4net(bool seedAvl)
        {
            return hasher04.ComputeHash(data);
        }

        [Benchmark]
        [Arguments(true)]
        public byte[] ByteTerrace_Maths_Probability_XxHash(bool seedAvl)
        {
            return hasher05.ComputeHash(data);
        }

        [Benchmark]
        [Arguments(true)]
        public byte[] differentrain_YYProject_XXHash(bool seedAvl)
        {
            return hasher06.ComputeHash(data);
        }

        [Benchmark]
        [Arguments(true)]
        public ulong EnokiSolutions_es_xxhash(bool seedAvl)
        {
            return Hasher07.XxHash(data, 0, data.Length, (ulong)seed);
        }

        [Benchmark]
        [Arguments(false)]
        public byte[] ftlab_FT_xxHash(bool seedAvl)
        {
            return hasher08.ComputeHash(data);
        }

        [Benchmark]
        [Arguments(false)]
        public byte[] MiloszKrajewski_K4os_Hash_xxHash(bool seedAvl)
        {
            return hasher09.ComputeHash(data);
        }

        [Benchmark]
        [Arguments(true)]
        public ulong neosmart_hashing_net(bool seedAvl)
        {
            return Hasher10.XXH64(data, (ulong)seed);
        }

        [Benchmark]
        [Arguments(true)]
        public ulong shibox_XXHash(bool seedAvl)
        {
            return Hasher11.Hash(data, seed);
        }

        [Benchmark]
        [Arguments(true)]
        public ulong ssg_HashDepot(bool seedAvl)
        {
            return Hasher12.Hash64(data, seed);
        }

        [Benchmark]
        [Arguments(true)]
        public ulong xoofx_smash(bool seedAvl)
        {
            hasher13.Write(data, 0, data.Length);
            return hasher13.Compute();
        }

        [Benchmark]
        [Arguments(false)]
        public ulong Zhentar_xxHash64_NET(bool seedAvl)
        {
            return Hasher14.Hash(data);
        }

        [Benchmark]
        [Arguments(true)]
        public ulong Zhentar_xxHash3_NET(bool seedAvl)
        {
            return Hasher15.Hash64(data, seed);
        }
    }
#endif

#if NETCOREAPP3_0
    [Config(typeof(AllowNonOptimized))]
    [SimpleJob(RuntimeMoniker.NetCoreApp30)]
    [GroupBenchmarksBy(BenchmarkLogicalGroupRule.ByParams)]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    public class HashNetBenchmark15
    {
        private const long seed = 0;
        private byte[] data;
        [Params(2, 8, 64, 512, 4096, 32768, 262144, 2097152, 16777216, 134217728)]
        public int len;

        [Params(false, true)]
        public bool UseSse2;
        [Params(false, true)]
        public bool UseAvx2;

        [GlobalSetup]
        public void Setup()
        {
            var rnd = new Random(len);
            data = new byte[len];
            rnd.NextBytes(data);
        }
        
        [Benchmark]
        [Arguments(true)]
        public ulong Zhentar_xxHash3_NET(bool seedAvl)
        {
            Hasher15.UseSse2 = UseSse2;
            Hasher15.UseAvx2 = UseAvx2;
            return Hasher15.Hash64(data, seed);
        }
    }
#endif

    public class AllowNonOptimized : ManualConfig
    {
        public AllowNonOptimized()
        {
            AddValidator(JitOptimizationsValidator.DontFailOnError); // ALLOW NON-OPTIMIZED DLLS
            AddLogger(DefaultConfig.Instance.GetLoggers().ToArray()); // manual config has no loggers by default
            AddExporter(DefaultConfig.Instance.GetExporters().ToArray()); // manual config has no exporters by default
            AddColumnProvider(DefaultConfig.Instance.GetColumnProviders().ToArray()); // manual config has no columns by default
            AddColumn(new ThroughputColumn());
        }
    }

    public class ThroughputColumn : IColumn
    {
        public string Id => nameof(ThroughputColumn);
        public string ColumnName => "Throughput";

        public ThroughputColumn() { }

        public bool IsDefault(Summary summary, BenchmarkCase benchmarkCase) => false;

        public string GetValue(Summary summary, BenchmarkCase benchmarkCase)
        {
            var bytes = (int)benchmarkCase.Parameters.Items[0].Value;
            var iterTime = summary[benchmarkCase].ResultStatistics.Mean;
            var iterPerSec = TimeUnit.Second.NanosecondAmount / iterTime;
            var bytesPerSec = iterPerSec * bytes;
            var MBps = bytesPerSec / (1 << 20);
            return $"{MBps:N1} MB/s";
        }

        public bool IsAvailable(Summary summary) => summary.BenchmarksCases.FirstOrDefault()?.Parameters.Items.Any() ?? false;
        public bool AlwaysShow => true;
        public ColumnCategory Category => ColumnCategory.Metric;
        public int PriorityInCategory => 0;
        public bool IsNumeric => true;
        public UnitType UnitType => UnitType.Dimensionless;
        public string Legend => $"Throughput in MB/s";
        public string GetValue(Summary summary, BenchmarkCase benchmarkCase, SummaryStyle style) => GetValue(summary, benchmarkCase);
        public override string ToString() => ColumnName;
    }
}
