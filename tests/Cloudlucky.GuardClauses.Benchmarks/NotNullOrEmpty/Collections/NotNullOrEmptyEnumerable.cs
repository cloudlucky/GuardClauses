using Ardalis.GuardClauses;
using Cloudlucky.GuardClauses.Exceptions;
using Cloudlucky.GuardClauses.Fluent;
using Dawn;

namespace Cloudlucky.GuardClauses.Benchmarks.NotNullOrEmpty.Collections;

public class NotNullOrEmptyEnumerable
{
    private static readonly IEnumerable<int> Input = Enumerable.Range(0, 10);

    [Benchmark(Baseline = true)]
    public void Imperative()
    {
        if (Input is null)
        {
            throw new ArgumentNullException(nameof(Input));
        }

        if (!Input.Any())
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
