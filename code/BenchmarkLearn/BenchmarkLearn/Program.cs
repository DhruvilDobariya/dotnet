using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace BenchmarkLearn
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<Program>();
            // benchmark method must non static and we must run program in release mode.
        }

        [Benchmark]
        public void Method1(int n1)
        {
            for (int i = 0; i < n1; i++) { };
        }

        [Benchmark]
        public void Method2(int n2)
        {
            for (int i = 0; i < n2; i++) { };
        }
    }
}