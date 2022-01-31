using Ardalis.GuardClauses;
using Cloudlucky.GuardClauses.Exceptions;
using Cloudlucky.GuardClauses.Fluent;
using Dawn;
using Light.GuardClauses;
using System.Collections;

namespace Cloudlucky.GuardClauses.Benchmarks.Comparable.Ranges;

public class NativeRangeBenchmark
{
    private const int MinValue = -10;
    private const int MaxValue = 10;
    private static readonly int Input = Random.Shared.Next(MinValue, MaxValue);

    [Benchmark(Baseline = true)]
    public void Imperative()
    {
        if (Input < MinValue || Input > MaxValue)
        {
            throw new ArgumentException(nameof(Input));
        }
    }

    [Benchmark]
    public void Current()
    {
        Guard.Against.OutOfRange(Input, MinValue, MaxValue);
    }

    [Benchmark]
    public void CurrentFluent()
    {
        Input.MustNotBeOutOfRange(MinValue, MaxValue);
    }

    //[Benchmark]
    //public void CurrentDelegate()
    //{
    //    try
    //    {
    //        Guard.Against.ToBe(() => Elements is not null && Elements.Any()).OtherwiseThrow(() => new ArgumentNullException(nameof(Elements)));
    //    }
    //    catch
    //    {
    //    }
    //}

    [Benchmark]
    public void ArdalisGuardClauses()
    {
        global::Ardalis.GuardClauses.Guard.Against.OutOfRange(Input, nameof(Input), MinValue, MaxValue);
    }

    [Benchmark]
    public void DawnGuard()
    {
        Dawn.Guard.Argument(Input).InRange(MinValue, MaxValue);
    }

    //[Benchmark]
    //public void LiteGuardClauses()
    //{
    //    // doesn't exist
    //}
}
