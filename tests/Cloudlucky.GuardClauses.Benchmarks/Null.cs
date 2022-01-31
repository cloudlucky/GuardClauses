using Ardalis.GuardClauses;
using Dawn;
using Light.GuardClauses;

namespace Cloudlucky.GuardClauses.Benchmarks;

public class Null
{
    [Benchmark(Baseline = true)]
    [Arguments("hello")]
    [Arguments(null)]
    public void Imperative(string value)
    {
        try
        {
            if (value is null)
            {
                throw new ArgumentNullException(nameof(value));
            }
        }
        catch
        {
        }
    }

    [Benchmark]
    [Arguments("hello")]
    [Arguments(null)]
    public void Current(string value)
    {
        try
        {
            Guard.Against.Null(value);
        }
        catch
        {
        }
    }

    [Benchmark]
    [Arguments("hello")]
    [Arguments(null)]
    public void CurrentDelegate(string value)
    {
        try
        {
            Guard.Against.ToBe(() => value is not null).OtherwiseThrow(() => new ArgumentNullException(nameof(value)));
        }
        catch
        {
        }
    }

    [Benchmark]
    [Arguments("hello")]
    [Arguments(null)]
    public void ArdalisGuardClauses(string value)
    {
        try
        {
            global::Ardalis.GuardClauses.Guard.Against.Null(value, nameof(value));
        }
        catch
        {
        }
    }

    [Benchmark]
    [Arguments("hello")]
    [Arguments(null)]
    public void DawnGuard(string value)
    {
        try
        {
            Dawn.Guard.Argument(value).NotNull();
        }
        catch
        {
        }
    }

    [Benchmark]
    [Arguments("hello")]
    [Arguments(null)]
    public void LiteGuardClauses(string value)
    {
        try
        {
            value.MustNotBeNull();
        }
        catch
        {
        }
    }
}
