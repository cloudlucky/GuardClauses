#if NET6_0_OR_GREATER
using Cloudlucky.GuardClauses.Extensions;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Cloudlucky.GuardClauses.Runtime.CompilerServices;

[InterpolatedStringHandler]
public ref partial struct GuardAgainstNotGreaterThanZeroInterpolatedStringHandler
{
    private GuardInterpolatedStringHandler innerHandler;

    public GuardAgainstNotGreaterThanZeroInterpolatedStringHandler(int literalLength, int formattedCount, byte input, out bool shouldAppend)
    {
        if (!input.IsGreaterThanZero())
        {
            this.IsNotGreaterThanZero = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanZeroInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, byte input, out bool shouldAppend)
    {
        if (!input.IsGreaterThanZero())
        {
            this.IsNotGreaterThanZero = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanZeroInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, Span<char> initialBuffer, byte input, out bool shouldAppend)
    {
        if (!input.IsGreaterThanZero())
        {
            this.IsNotGreaterThanZero = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider, initialBuffer);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanZeroInterpolatedStringHandler(int literalLength, int formattedCount, sbyte input, out bool shouldAppend)
    {
        if (!input.IsGreaterThanZero())
        {
            this.IsNotGreaterThanZero = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanZeroInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, sbyte input, out bool shouldAppend)
    {
        if (!input.IsGreaterThanZero())
        {
            this.IsNotGreaterThanZero = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanZeroInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, Span<char> initialBuffer, sbyte input, out bool shouldAppend)
    {
        if (!input.IsGreaterThanZero())
        {
            this.IsNotGreaterThanZero = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider, initialBuffer);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanZeroInterpolatedStringHandler(int literalLength, int formattedCount, short input, out bool shouldAppend)
    {
        if (!input.IsGreaterThanZero())
        {
            this.IsNotGreaterThanZero = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanZeroInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, short input, out bool shouldAppend)
    {
        if (!input.IsGreaterThanZero())
        {
            this.IsNotGreaterThanZero = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanZeroInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, Span<char> initialBuffer, short input, out bool shouldAppend)
    {
        if (!input.IsGreaterThanZero())
        {
            this.IsNotGreaterThanZero = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider, initialBuffer);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanZeroInterpolatedStringHandler(int literalLength, int formattedCount, ushort input, out bool shouldAppend)
    {
        if (!input.IsGreaterThanZero())
        {
            this.IsNotGreaterThanZero = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanZeroInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, ushort input, out bool shouldAppend)
    {
        if (!input.IsGreaterThanZero())
        {
            this.IsNotGreaterThanZero = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanZeroInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, Span<char> initialBuffer, ushort input, out bool shouldAppend)
    {
        if (!input.IsGreaterThanZero())
        {
            this.IsNotGreaterThanZero = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider, initialBuffer);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanZeroInterpolatedStringHandler(int literalLength, int formattedCount, int input, out bool shouldAppend)
    {
        if (!input.IsGreaterThanZero())
        {
            this.IsNotGreaterThanZero = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanZeroInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, int input, out bool shouldAppend)
    {
        if (!input.IsGreaterThanZero())
        {
            this.IsNotGreaterThanZero = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanZeroInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, Span<char> initialBuffer, int input, out bool shouldAppend)
    {
        if (!input.IsGreaterThanZero())
        {
            this.IsNotGreaterThanZero = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider, initialBuffer);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanZeroInterpolatedStringHandler(int literalLength, int formattedCount, uint input, out bool shouldAppend)
    {
        if (!input.IsGreaterThanZero())
        {
            this.IsNotGreaterThanZero = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanZeroInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, uint input, out bool shouldAppend)
    {
        if (!input.IsGreaterThanZero())
        {
            this.IsNotGreaterThanZero = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanZeroInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, Span<char> initialBuffer, uint input, out bool shouldAppend)
    {
        if (!input.IsGreaterThanZero())
        {
            this.IsNotGreaterThanZero = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider, initialBuffer);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanZeroInterpolatedStringHandler(int literalLength, int formattedCount, nint input, out bool shouldAppend)
    {
        if (!input.IsGreaterThanZero())
        {
            this.IsNotGreaterThanZero = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanZeroInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, nint input, out bool shouldAppend)
    {
        if (!input.IsGreaterThanZero())
        {
            this.IsNotGreaterThanZero = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanZeroInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, Span<char> initialBuffer, nint input, out bool shouldAppend)
    {
        if (!input.IsGreaterThanZero())
        {
            this.IsNotGreaterThanZero = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider, initialBuffer);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanZeroInterpolatedStringHandler(int literalLength, int formattedCount, nuint input, out bool shouldAppend)
    {
        if (!input.IsGreaterThanZero())
        {
            this.IsNotGreaterThanZero = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanZeroInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, nuint input, out bool shouldAppend)
    {
        if (!input.IsGreaterThanZero())
        {
            this.IsNotGreaterThanZero = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanZeroInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, Span<char> initialBuffer, nuint input, out bool shouldAppend)
    {
        if (!input.IsGreaterThanZero())
        {
            this.IsNotGreaterThanZero = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider, initialBuffer);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanZeroInterpolatedStringHandler(int literalLength, int formattedCount, long input, out bool shouldAppend)
    {
        if (!input.IsGreaterThanZero())
        {
            this.IsNotGreaterThanZero = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanZeroInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, long input, out bool shouldAppend)
    {
        if (!input.IsGreaterThanZero())
        {
            this.IsNotGreaterThanZero = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanZeroInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, Span<char> initialBuffer, long input, out bool shouldAppend)
    {
        if (!input.IsGreaterThanZero())
        {
            this.IsNotGreaterThanZero = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider, initialBuffer);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanZeroInterpolatedStringHandler(int literalLength, int formattedCount, ulong input, out bool shouldAppend)
    {
        if (!input.IsGreaterThanZero())
        {
            this.IsNotGreaterThanZero = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanZeroInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, ulong input, out bool shouldAppend)
    {
        if (!input.IsGreaterThanZero())
        {
            this.IsNotGreaterThanZero = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanZeroInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, Span<char> initialBuffer, ulong input, out bool shouldAppend)
    {
        if (!input.IsGreaterThanZero())
        {
            this.IsNotGreaterThanZero = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider, initialBuffer);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanZeroInterpolatedStringHandler(int literalLength, int formattedCount, float input, out bool shouldAppend)
    {
        if (!input.IsGreaterThanZero())
        {
            this.IsNotGreaterThanZero = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanZeroInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, float input, out bool shouldAppend)
    {
        if (!input.IsGreaterThanZero())
        {
            this.IsNotGreaterThanZero = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanZeroInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, Span<char> initialBuffer, float input, out bool shouldAppend)
    {
        if (!input.IsGreaterThanZero())
        {
            this.IsNotGreaterThanZero = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider, initialBuffer);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanZeroInterpolatedStringHandler(int literalLength, int formattedCount, double input, out bool shouldAppend)
    {
        if (!input.IsGreaterThanZero())
        {
            this.IsNotGreaterThanZero = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanZeroInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, double input, out bool shouldAppend)
    {
        if (!input.IsGreaterThanZero())
        {
            this.IsNotGreaterThanZero = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanZeroInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, Span<char> initialBuffer, double input, out bool shouldAppend)
    {
        if (!input.IsGreaterThanZero())
        {
            this.IsNotGreaterThanZero = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider, initialBuffer);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanZeroInterpolatedStringHandler(int literalLength, int formattedCount, decimal input, out bool shouldAppend)
    {
        if (!input.IsGreaterThanZero())
        {
            this.IsNotGreaterThanZero = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanZeroInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, decimal input, out bool shouldAppend)
    {
        if (!input.IsGreaterThanZero())
        {
            this.IsNotGreaterThanZero = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanZeroInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, Span<char> initialBuffer, decimal input, out bool shouldAppend)
    {
        if (!input.IsGreaterThanZero())
        {
            this.IsNotGreaterThanZero = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider, initialBuffer);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanZeroInterpolatedStringHandler(int literalLength, int formattedCount, DateTime input, out bool shouldAppend)
    {
        if (!input.IsGreaterThanZero())
        {
            this.IsNotGreaterThanZero = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanZeroInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, DateTime input, out bool shouldAppend)
    {
        if (!input.IsGreaterThanZero())
        {
            this.IsNotGreaterThanZero = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanZeroInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, Span<char> initialBuffer, DateTime input, out bool shouldAppend)
    {
        if (!input.IsGreaterThanZero())
        {
            this.IsNotGreaterThanZero = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider, initialBuffer);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanZeroInterpolatedStringHandler(int literalLength, int formattedCount, DateOnly input, out bool shouldAppend)
    {
        if (!input.IsGreaterThanZero())
        {
            this.IsNotGreaterThanZero = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanZeroInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, DateOnly input, out bool shouldAppend)
    {
        if (!input.IsGreaterThanZero())
        {
            this.IsNotGreaterThanZero = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanZeroInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, Span<char> initialBuffer, DateOnly input, out bool shouldAppend)
    {
        if (!input.IsGreaterThanZero())
        {
            this.IsNotGreaterThanZero = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider, initialBuffer);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanZeroInterpolatedStringHandler(int literalLength, int formattedCount, TimeOnly input, out bool shouldAppend)
    {
        if (!input.IsGreaterThanZero())
        {
            this.IsNotGreaterThanZero = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanZeroInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, TimeOnly input, out bool shouldAppend)
    {
        if (!input.IsGreaterThanZero())
        {
            this.IsNotGreaterThanZero = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanZeroInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, Span<char> initialBuffer, TimeOnly input, out bool shouldAppend)
    {
        if (!input.IsGreaterThanZero())
        {
            this.IsNotGreaterThanZero = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider, initialBuffer);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanZeroInterpolatedStringHandler(int literalLength, int formattedCount, TimeSpan input, out bool shouldAppend)
    {
        if (!input.IsGreaterThanZero())
        {
            this.IsNotGreaterThanZero = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanZeroInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, TimeSpan input, out bool shouldAppend)
    {
        if (!input.IsGreaterThanZero())
        {
            this.IsNotGreaterThanZero = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanZeroInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, Span<char> initialBuffer, TimeSpan input, out bool shouldAppend)
    {
        if (!input.IsGreaterThanZero())
        {
            this.IsNotGreaterThanZero = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider, initialBuffer);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public bool IsNotGreaterThanZero { get; } = false;
}

[InterpolatedStringHandler]
public ref partial struct GuardAgainstNotGreaterThanZeroComparableInterpolatedStringHandler<TInput>
    where TInput : IComparable<TInput?>
{
    private GuardInterpolatedStringHandler innerHandler;

    public GuardAgainstNotGreaterThanZeroComparableInterpolatedStringHandler(int literalLength, int formattedCount, TInput input, out bool shouldAppend)
    {
        if (!input.IsGreaterThanZero())
        {
            this.IsNotGreaterThanZero = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanZeroComparableInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, TInput input, out bool shouldAppend)
    {
        if (!input.IsGreaterThanZero())
        {
            this.IsNotGreaterThanZero = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanZeroComparableInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, Span<char> initialBuffer, TInput input, out bool shouldAppend)
    {
        if (!input.IsGreaterThanZero())
        {
            this.IsNotGreaterThanZero = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider, initialBuffer);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public bool IsNotGreaterThanZero { get; } = false;
}

[InterpolatedStringHandler]
public ref partial struct GuardAgainstNotGreaterThanZeroInterpolatedStringHandler<TInput>
{
    private GuardInterpolatedStringHandler innerHandler;

    public GuardAgainstNotGreaterThanZeroInterpolatedStringHandler(int literalLength, int formattedCount, TInput input, Comparison<TInput?> comparison, out bool shouldAppend)
    {
        if (!input.IsGreaterThanZero(comparison))
        {
            this.IsNotGreaterThanZero = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanZeroInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, TInput input, Comparison<TInput?> comparison, out bool shouldAppend)
    {
        if (!input.IsGreaterThanZero(comparison))
        {
            this.IsNotGreaterThanZero = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanZeroInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, Span<char> initialBuffer, TInput input, Comparison<TInput?> comparison, out bool shouldAppend)
    {
        if (!input.IsGreaterThanZero(comparison))
        {
            this.IsNotGreaterThanZero = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider, initialBuffer);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanZeroInterpolatedStringHandler(int literalLength, int formattedCount, TInput input, IComparer<TInput?> comparer, out bool shouldAppend)
    {
        if (!input.IsGreaterThanZero(comparer))
        {
            this.IsNotGreaterThanZero = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanZeroInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, TInput input, IComparer<TInput?> comparer, out bool shouldAppend)
    {
        if (!input.IsGreaterThanZero(comparer))
        {
            this.IsNotGreaterThanZero = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanZeroInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, Span<char> initialBuffer, TInput input, IComparer<TInput?> comparer, out bool shouldAppend)
    {
        if (!input.IsGreaterThanZero(comparer))
        {
            this.IsNotGreaterThanZero = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider, initialBuffer);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public bool IsNotGreaterThanZero { get; } = false;
}
#endif
