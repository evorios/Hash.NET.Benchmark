using BenchmarkDotNet.Running;

namespace Hash.NET.Benchmark
{
    class Program
    {
        static void Main(string[] args) => BenchmarkSwitcher.FromAssembly(typeof(AllowNonOptimized).Assembly).Run(args);
    }
}
