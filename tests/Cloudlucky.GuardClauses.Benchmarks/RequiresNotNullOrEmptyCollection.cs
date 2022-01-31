using Ardalis.GuardClauses;
using Cloudlucky.GuardClauses.Exceptions;
using Cloudlucky.GuardClauses.Fluent;
using Dawn;
using System.Collections;

namespace Cloudlucky.GuardClauses.Benchmarks;

public class RequiresNotNullOrEmptyCollection
{
    private static readonly IEnumerable<int> Elements = new List<int> { 1 };

    private static readonly IEnumerable ElementsNonGeneric = new List<int> { 1 };

    private static readonly IEnumerable<int> S = Enumerable.Range(0, 10);

    [Benchmark(Baseline = true)]
    public void Imperative()
    {
        if (Elements is null)
        {
            throw new ArgumentNullException(nameof(Elements));
        }

        if (!Elements.Any())
        {
            throw new EmptyException(nameof(Elements));
        }
    }

    [Benchmark]
    public void CurrentEnumerableGeneric()
    {
        Guard.Against.NullOrEmpty(Elements);
    }

    [Benchmark]
    public void CurrentEnumerableNonGeneric()
    {
        Guard.Against.NullOrEmpty(ElementsNonGeneric);
    }

    [Benchmark]
    public void CurrentFluent()
    {
        ElementsNonGeneric.MustNotBeNullOrEmpty();
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
        global::Ardalis.GuardClauses.Guard.Against.NullOrEmpty(Elements, nameof(Elements));
    }

    [Benchmark]
    public void DawnGuard()
    {
        Dawn.Guard.Argument(Elements).NotNull().NotEmpty();
    }

    [Benchmark]
    public void LiteGuardClauses()
    {
        Light.GuardClauses.Check.MustNotBeNullOrEmpty(Elements);
    }
}
