﻿using System;
using BenchmarkDotNet.Running;

namespace Benchmarking.ObjectBoxing;

internal static class Program
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0060:Remove unused parameter", Justification = "Keep unused paramater in benchamrking and testing")]
    private static void Main(string[] args)
    {
        BenchmarkRunner.Run(typeof(Program).Assembly);
    }
}
