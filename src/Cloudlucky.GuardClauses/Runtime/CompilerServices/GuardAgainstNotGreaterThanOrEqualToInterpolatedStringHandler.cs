#if NET6_0_OR_GREATER
using Cloudlucky.GuardClauses.Extensions;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Cloudlucky.GuardClauses.Runtime.CompilerServices;

[InterpolatedStringHandler]
public ref partial struct GuardAgainstNotGreaterThanOrEqualToInterpolatedStringHandler
{
    private GuardInterpolatedStringHandler innerHandler;

    public GuardAgainstNotGreaterThanOrEqualToInterpolatedStringHandler(int literalLength, int formattedCount, byte input, byte other, out bool shouldAppend)
    {
        if (!input.IsGreaterThanOrEqualTo(other))
        {
            this.IsNotGreaterThanOrEqualTo = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanOrEqualToInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, byte input, byte other, out bool shouldAppend)
    {
        if (!input.IsGreaterThanOrEqualTo(other))
        {
            this.IsNotGreaterThanOrEqualTo = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanOrEqualToInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, Span<char> initialBuffer, byte input, byte other, out bool shouldAppend)
    {
        if (!input.IsGreaterThanOrEqualTo(other))
        {
            this.IsNotGreaterThanOrEqualTo = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider, initialBuffer);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanOrEqualToInterpolatedStringHandler(int literalLength, int formattedCount, sbyte input, sbyte other, out bool shouldAppend)
    {
        if (!input.IsGreaterThanOrEqualTo(other))
        {
            this.IsNotGreaterThanOrEqualTo = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanOrEqualToInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, sbyte input, sbyte other, out bool shouldAppend)
    {
        if (!input.IsGreaterThanOrEqualTo(other))
        {
            this.IsNotGreaterThanOrEqualTo = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanOrEqualToInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, Span<char> initialBuffer, sbyte input, sbyte other, out bool shouldAppend)
    {
        if (!input.IsGreaterThanOrEqualTo(other))
        {
            this.IsNotGreaterThanOrEqualTo = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider, initialBuffer);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanOrEqualToInterpolatedStringHandler(int literalLength, int formattedCount, short input, short other, out bool shouldAppend)
    {
        if (!input.IsGreaterThanOrEqualTo(other))
        {
            this.IsNotGreaterThanOrEqualTo = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanOrEqualToInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, short input, short other, out bool shouldAppend)
    {
        if (!input.IsGreaterThanOrEqualTo(other))
        {
            this.IsNotGreaterThanOrEqualTo = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanOrEqualToInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, Span<char> initialBuffer, short input, short other, out bool shouldAppend)
    {
        if (!input.IsGreaterThanOrEqualTo(other))
        {
            this.IsNotGreaterThanOrEqualTo = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider, initialBuffer);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanOrEqualToInterpolatedStringHandler(int literalLength, int formattedCount, ushort input, ushort other, out bool shouldAppend)
    {
        if (!input.IsGreaterThanOrEqualTo(other))
        {
            this.IsNotGreaterThanOrEqualTo = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanOrEqualToInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, ushort input, ushort other, out bool shouldAppend)
    {
        if (!input.IsGreaterThanOrEqualTo(other))
        {
            this.IsNotGreaterThanOrEqualTo = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanOrEqualToInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, Span<char> initialBuffer, ushort input, ushort other, out bool shouldAppend)
    {
        if (!input.IsGreaterThanOrEqualTo(other))
        {
            this.IsNotGreaterThanOrEqualTo = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider, initialBuffer);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanOrEqualToInterpolatedStringHandler(int literalLength, int formattedCount, int input, int other, out bool shouldAppend)
    {
        if (!input.IsGreaterThanOrEqualTo(other))
        {
            this.IsNotGreaterThanOrEqualTo = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanOrEqualToInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, int input, int other, out bool shouldAppend)
    {
        if (!input.IsGreaterThanOrEqualTo(other))
        {
            this.IsNotGreaterThanOrEqualTo = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanOrEqualToInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, Span<char> initialBuffer, int input, int other, out bool shouldAppend)
    {
        if (!input.IsGreaterThanOrEqualTo(other))
        {
            this.IsNotGreaterThanOrEqualTo = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider, initialBuffer);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanOrEqualToInterpolatedStringHandler(int literalLength, int formattedCount, uint input, uint other, out bool shouldAppend)
    {
        if (!input.IsGreaterThanOrEqualTo(other))
        {
            this.IsNotGreaterThanOrEqualTo = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanOrEqualToInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, uint input, uint other, out bool shouldAppend)
    {
        if (!input.IsGreaterThanOrEqualTo(other))
        {
            this.IsNotGreaterThanOrEqualTo = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanOrEqualToInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, Span<char> initialBuffer, uint input, uint other, out bool shouldAppend)
    {
        if (!input.IsGreaterThanOrEqualTo(other))
        {
            this.IsNotGreaterThanOrEqualTo = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider, initialBuffer);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanOrEqualToInterpolatedStringHandler(int literalLength, int formattedCount, nint input, nint other, out bool shouldAppend)
    {
        if (!input.IsGreaterThanOrEqualTo(other))
        {
            this.IsNotGreaterThanOrEqualTo = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanOrEqualToInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, nint input, nint other, out bool shouldAppend)
    {
        if (!input.IsGreaterThanOrEqualTo(other))
        {
            this.IsNotGreaterThanOrEqualTo = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanOrEqualToInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, Span<char> initialBuffer, nint input, nint other, out bool shouldAppend)
    {
        if (!input.IsGreaterThanOrEqualTo(other))
        {
            this.IsNotGreaterThanOrEqualTo = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider, initialBuffer);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanOrEqualToInterpolatedStringHandler(int literalLength, int formattedCount, nuint input, nuint other, out bool shouldAppend)
    {
        if (!input.IsGreaterThanOrEqualTo(other))
        {
            this.IsNotGreaterThanOrEqualTo = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanOrEqualToInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, nuint input, nuint other, out bool shouldAppend)
    {
        if (!input.IsGreaterThanOrEqualTo(other))
        {
            this.IsNotGreaterThanOrEqualTo = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanOrEqualToInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, Span<char> initialBuffer, nuint input, nuint other, out bool shouldAppend)
    {
        if (!input.IsGreaterThanOrEqualTo(other))
        {
            this.IsNotGreaterThanOrEqualTo = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider, initialBuffer);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanOrEqualToInterpolatedStringHandler(int literalLength, int formattedCount, long input, long other, out bool shouldAppend)
    {
        if (!input.IsGreaterThanOrEqualTo(other))
        {
            this.IsNotGreaterThanOrEqualTo = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanOrEqualToInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, long input, long other, out bool shouldAppend)
    {
        if (!input.IsGreaterThanOrEqualTo(other))
        {
            this.IsNotGreaterThanOrEqualTo = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanOrEqualToInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, Span<char> initialBuffer, long input, long other, out bool shouldAppend)
    {
        if (!input.IsGreaterThanOrEqualTo(other))
        {
            this.IsNotGreaterThanOrEqualTo = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider, initialBuffer);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanOrEqualToInterpolatedStringHandler(int literalLength, int formattedCount, ulong input, ulong other, out bool shouldAppend)
    {
        if (!input.IsGreaterThanOrEqualTo(other))
        {
            this.IsNotGreaterThanOrEqualTo = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanOrEqualToInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, ulong input, ulong other, out bool shouldAppend)
    {
        if (!input.IsGreaterThanOrEqualTo(other))
        {
            this.IsNotGreaterThanOrEqualTo = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanOrEqualToInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, Span<char> initialBuffer, ulong input, ulong other, out bool shouldAppend)
    {
        if (!input.IsGreaterThanOrEqualTo(other))
        {
            this.IsNotGreaterThanOrEqualTo = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider, initialBuffer);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanOrEqualToInterpolatedStringHandler(int literalLength, int formattedCount, float input, float other, out bool shouldAppend)
    {
        if (!input.IsGreaterThanOrEqualTo(other))
        {
            this.IsNotGreaterThanOrEqualTo = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanOrEqualToInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, float input, float other, out bool shouldAppend)
    {
        if (!input.IsGreaterThanOrEqualTo(other))
        {
            this.IsNotGreaterThanOrEqualTo = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanOrEqualToInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, Span<char> initialBuffer, float input, float other, out bool shouldAppend)
    {
        if (!input.IsGreaterThanOrEqualTo(other))
        {
            this.IsNotGreaterThanOrEqualTo = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider, initialBuffer);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanOrEqualToInterpolatedStringHandler(int literalLength, int formattedCount, double input, double other, out bool shouldAppend)
    {
        if (!input.IsGreaterThanOrEqualTo(other))
        {
            this.IsNotGreaterThanOrEqualTo = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanOrEqualToInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, double input, double other, out bool shouldAppend)
    {
        if (!input.IsGreaterThanOrEqualTo(other))
        {
            this.IsNotGreaterThanOrEqualTo = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanOrEqualToInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, Span<char> initialBuffer, double input, double other, out bool shouldAppend)
    {
        if (!input.IsGreaterThanOrEqualTo(other))
        {
            this.IsNotGreaterThanOrEqualTo = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider, initialBuffer);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanOrEqualToInterpolatedStringHandler(int literalLength, int formattedCount, decimal input, decimal other, out bool shouldAppend)
    {
        if (!input.IsGreaterThanOrEqualTo(other))
        {
            this.IsNotGreaterThanOrEqualTo = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanOrEqualToInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, decimal input, decimal other, out bool shouldAppend)
    {
        if (!input.IsGreaterThanOrEqualTo(other))
        {
            this.IsNotGreaterThanOrEqualTo = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanOrEqualToInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, Span<char> initialBuffer, decimal input, decimal other, out bool shouldAppend)
    {
        if (!input.IsGreaterThanOrEqualTo(other))
        {
            this.IsNotGreaterThanOrEqualTo = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider, initialBuffer);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanOrEqualToInterpolatedStringHandler(int literalLength, int formattedCount, DateTime input, DateTime other, out bool shouldAppend)
    {
        if (!input.IsGreaterThanOrEqualTo(other))
        {
            this.IsNotGreaterThanOrEqualTo = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanOrEqualToInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, DateTime input, DateTime other, out bool shouldAppend)
    {
        if (!input.IsGreaterThanOrEqualTo(other))
        {
            this.IsNotGreaterThanOrEqualTo = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanOrEqualToInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, Span<char> initialBuffer, DateTime input, DateTime other, out bool shouldAppend)
    {
        if (!input.IsGreaterThanOrEqualTo(other))
        {
            this.IsNotGreaterThanOrEqualTo = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider, initialBuffer);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanOrEqualToInterpolatedStringHandler(int literalLength, int formattedCount, DateOnly input, DateOnly other, out bool shouldAppend)
    {
        if (!input.IsGreaterThanOrEqualTo(other))
        {
            this.IsNotGreaterThanOrEqualTo = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanOrEqualToInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, DateOnly input, DateOnly other, out bool shouldAppend)
    {
        if (!input.IsGreaterThanOrEqualTo(other))
        {
            this.IsNotGreaterThanOrEqualTo = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanOrEqualToInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, Span<char> initialBuffer, DateOnly input, DateOnly other, out bool shouldAppend)
    {
        if (!input.IsGreaterThanOrEqualTo(other))
        {
            this.IsNotGreaterThanOrEqualTo = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider, initialBuffer);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanOrEqualToInterpolatedStringHandler(int literalLength, int formattedCount, TimeOnly input, TimeOnly other, out bool shouldAppend)
    {
        if (!input.IsGreaterThanOrEqualTo(other))
        {
            this.IsNotGreaterThanOrEqualTo = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanOrEqualToInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, TimeOnly input, TimeOnly other, out bool shouldAppend)
    {
        if (!input.IsGreaterThanOrEqualTo(other))
        {
            this.IsNotGreaterThanOrEqualTo = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanOrEqualToInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, Span<char> initialBuffer, TimeOnly input, TimeOnly other, out bool shouldAppend)
    {
        if (!input.IsGreaterThanOrEqualTo(other))
        {
            this.IsNotGreaterThanOrEqualTo = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider, initialBuffer);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanOrEqualToInterpolatedStringHandler(int literalLength, int formattedCount, TimeSpan input, TimeSpan other, out bool shouldAppend)
    {
        if (!input.IsGreaterThanOrEqualTo(other))
        {
            this.IsNotGreaterThanOrEqualTo = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanOrEqualToInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, TimeSpan input, TimeSpan other, out bool shouldAppend)
    {
        if (!input.IsGreaterThanOrEqualTo(other))
        {
            this.IsNotGreaterThanOrEqualTo = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanOrEqualToInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, Span<char> initialBuffer, TimeSpan input, TimeSpan other, out bool shouldAppend)
    {
        if (!input.IsGreaterThanOrEqualTo(other))
        {
            this.IsNotGreaterThanOrEqualTo = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider, initialBuffer);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public bool IsNotGreaterThanOrEqualTo { get; } = false;
}

[InterpolatedStringHandler]
public ref partial struct GuardAgainstNotGreaterThanOrEqualToComparableInterpolatedStringHandler<TInput>
    where TInput : IComparable<TInput>
{
    private GuardInterpolatedStringHandler innerHandler;

    public GuardAgainstNotGreaterThanOrEqualToComparableInterpolatedStringHandler(int literalLength, int formattedCount, TInput input, TInput other, out bool shouldAppend)
    {
        if (!input.IsGreaterThanOrEqualTo(other))
        {
            this.IsNotGreaterThanOrEqualTo = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanOrEqualToComparableInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, TInput input, TInput other, out bool shouldAppend)
    {
        if (!input.IsGreaterThanOrEqualTo(other))
        {
            this.IsNotGreaterThanOrEqualTo = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanOrEqualToComparableInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, Span<char> initialBuffer, TInput input, TInput other, out bool shouldAppend)
    {
        if (!input.IsGreaterThanOrEqualTo(other))
        {
            this.IsNotGreaterThanOrEqualTo = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider, initialBuffer);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public bool IsNotGreaterThanOrEqualTo { get; } = false;
}

[InterpolatedStringHandler]
public ref partial struct GuardAgainstNotGreaterThanOrEqualToInterpolatedStringHandler<TInput>
{
    private GuardInterpolatedStringHandler innerHandler;

    public GuardAgainstNotGreaterThanOrEqualToInterpolatedStringHandler(int literalLength, int formattedCount, TInput input, TInput other, Comparison<TInput> comparison, out bool shouldAppend)
    {
        if (!input.IsGreaterThanOrEqualTo(other, comparison))
        {
            this.IsNotGreaterThanOrEqualTo = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanOrEqualToInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, TInput input, TInput other, Comparison<TInput> comparison, out bool shouldAppend)
    {
        if (!input.IsGreaterThanOrEqualTo(other, comparison))
        {
            this.IsNotGreaterThanOrEqualTo = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanOrEqualToInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, Span<char> initialBuffer, TInput input, TInput other, Comparison<TInput> comparison, out bool shouldAppend)
    {
        if (!input.IsGreaterThanOrEqualTo(other, comparison))
        {
            this.IsNotGreaterThanOrEqualTo = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider, initialBuffer);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanOrEqualToInterpolatedStringHandler(int literalLength, int formattedCount, TInput input, TInput other, IComparer<TInput> comparer, out bool shouldAppend)
    {
        if (!input.IsGreaterThanOrEqualTo(other, comparer))
        {
            this.IsNotGreaterThanOrEqualTo = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanOrEqualToInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, TInput input, TInput other, IComparer<TInput> comparer, out bool shouldAppend)
    {
        if (!input.IsGreaterThanOrEqualTo(other, comparer))
        {
            this.IsNotGreaterThanOrEqualTo = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotGreaterThanOrEqualToInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, Span<char> initialBuffer, TInput input, TInput other, IComparer<TInput> comparer, out bool shouldAppend)
    {
        if (!input.IsGreaterThanOrEqualTo(other, comparer))
        {
            this.IsNotGreaterThanOrEqualTo = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider, initialBuffer);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public bool IsNotGreaterThanOrEqualTo { get; } = false;
}
#endif
