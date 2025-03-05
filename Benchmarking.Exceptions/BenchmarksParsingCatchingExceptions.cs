﻿using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace Benchmarking.Exceptions
{
    [MemoryDiagnoser, Orderer(SummaryOrderPolicy.FastestToSlowest)]
    public class BenchmarksParsingCatchingExceptions
    {
        [Benchmark]
        public string CaptureExceptionWithTryParse() => ParsingCatchingExceptions.TryParseIntegerConversion();

        [Benchmark]
        public string CaptureExceptionWithTryCatch() => ParsingCatchingExceptions.TryCatchIntegerConversion();
    }
}
