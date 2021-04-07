using System;
using BenchmarkDotNet.Running;

namespace ClassVsRecordJsonBenchmark
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<JsonBenchmark>();
        }
    }
}
