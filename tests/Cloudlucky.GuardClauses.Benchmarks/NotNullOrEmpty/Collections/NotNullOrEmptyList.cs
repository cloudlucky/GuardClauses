using Ardalis.GuardClauses;
using Cloudlucky.GuardClauses.Exceptions;
using Cloudlucky.GuardClauses.Fluent;
using Dawn;

namespace Cloudlucky.GuardClauses.Benchmarks.NotNullOrEmpty.Collections;

public class NotNullOrEmptyList
{
    private static readonly List<int> Input = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

    [Benchmark(Baseline = true)]
    public void Imperative()
    {
        if (Input is null)
        {
            throw new ArgumentNullException(nameof(Input));
        }

        if (Input.Count == 0)
        {
            throw new EmptyException(nameof(Input));
        }
    }

    [Benchmark]
    public void Current()
    {
        Guard.Against.NullOrEmpty(Input);
    }

    [Benchmark]
    public void Current2()
    {
        Guard.Against.Null(Input).Empty(Input);
    }

    [Benchmark]
    public void CurrentFluent()
    {
        Input.MustNotBeNullOrEmpty();
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
        Ardalis.GuardClauses.Guard.Against.NullOrEmpty(Input, nameof(Input));
    }

    [Benchmark]
    public void DawnGuard()
    {
        Dawn.Guard.Argument(Input).NotNull().NotEmpty();
    }

    [Benchmark]
    public void LiteGuardClauses()
    {
        Light.GuardClauses.Check.MustNotBeNullOrEmpty(Input);
    }
}
