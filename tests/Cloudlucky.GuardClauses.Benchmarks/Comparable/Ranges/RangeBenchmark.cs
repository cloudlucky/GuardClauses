using Ardalis.GuardClauses;
using Cloudlucky.GuardClauses.Exceptions;
using Cloudlucky.GuardClauses.Fluent;
using Dawn;
using Light.GuardClauses;
using System.Collections;

namespace Cloudlucky.GuardClauses.Benchmarks.Comparable.Ranges;

public class RangeBenchmark
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
        Guard.Against.OutOfRange(Input, Range.FromInclusive(MinValue).ToInclusive(MaxValue));
    }

    [Benchmark]
    public void CurrentFluent()
    {
        Input.MustNotBeOutOfRange(Range.FromInclusive(MinValue).ToInclusive(MaxValue));
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

    //[Benchmark]
    //public void ArdalisGuardClauses()
    //{
    //    // Doesn't exist
    //}

    //[Benchmark]
    //public void DawnGuard()
    //{
    //    // Doesn't exist
    //}

    [Benchmark]
    public void LiteGuardClauses()
    {
        Input.MustBeIn(Light.GuardClauses.Range.FromInclusive(MinValue).ToInclusive(MaxValue));
    }
}
