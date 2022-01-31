#if NET6_0_OR_GREATER
using Cloudlucky.GuardClauses.Extensions;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Cloudlucky.GuardClauses.Runtime.CompilerServices;

[InterpolatedStringHandler]
public ref partial struct GuardAgainstOutOfRangeInterpolatedStringHandler
{
    private GuardInterpolatedStringHandler innerHandler;

    public GuardAgainstOutOfRangeInterpolatedStringHandler(int literalLength, int formattedCount, byte input, byte from, byte to, out bool shouldAppend)
    {
        if (input.IsOutOfRange(from, to))
        {
            this.IsOutOfRange = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstOutOfRangeInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, byte input, byte from, byte to, out bool shouldAppend)
    {
        if (input.IsOutOfRange(from, to))
        {
            this.IsOutOfRange = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstOutOfRangeInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, Span<char> initialBuffer, byte input, byte from, byte to, out bool shouldAppend)
    {
        if (input.IsOutOfRange(from, to))
        {
            this.IsOutOfRange = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider, initialBuffer);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstOutOfRangeInterpolatedStringHandler(int literalLength, int formattedCount, sbyte input, sbyte from, sbyte to, out bool shouldAppend)
    {
        if (input.IsOutOfRange(from, to))
        {
            this.IsOutOfRange = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstOutOfRangeInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, sbyte input, sbyte from, sbyte to, out bool shouldAppend)
    {
        if (input.IsOutOfRange(from, to))
        {
            this.IsOutOfRange = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstOutOfRangeInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, Span<char> initialBuffer, sbyte input, sbyte from, sbyte to, out bool shouldAppend)
    {
        if (input.IsOutOfRange(from, to))
        {
            this.IsOutOfRange = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider, initialBuffer);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstOutOfRangeInterpolatedStringHandler(int literalLength, int formattedCount, short input, short from, short to, out bool shouldAppend)
    {
        if (input.IsOutOfRange(from, to))
        {
            this.IsOutOfRange = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstOutOfRangeInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, short input, short from, short to, out bool shouldAppend)
    {
        if (input.IsOutOfRange(from, to))
        {
            this.IsOutOfRange = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstOutOfRangeInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, Span<char> initialBuffer, short input, short from, short to, out bool shouldAppend)
    {
        if (input.IsOutOfRange(from, to))
        {
            this.IsOutOfRange = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider, initialBuffer);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstOutOfRangeInterpolatedStringHandler(int literalLength, int formattedCount, ushort input, ushort from, ushort to, out bool shouldAppend)
    {
        if (input.IsOutOfRange(from, to))
        {
            this.IsOutOfRange = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstOutOfRangeInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, ushort input, ushort from, ushort to, out bool shouldAppend)
    {
        if (input.IsOutOfRange(from, to))
        {
            this.IsOutOfRange = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstOutOfRangeInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, Span<char> initialBuffer, ushort input, ushort from, ushort to, out bool shouldAppend)
    {
        if (input.IsOutOfRange(from, to))
        {
            this.IsOutOfRange = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider, initialBuffer);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstOutOfRangeInterpolatedStringHandler(int literalLength, int formattedCount, int input, int from, int to, out bool shouldAppend)
    {
        if (input.IsOutOfRange(from, to))
        {
            this.IsOutOfRange = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstOutOfRangeInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, int input, int from, int to, out bool shouldAppend)
    {
        if (input.IsOutOfRange(from, to))
        {
            this.IsOutOfRange = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstOutOfRangeInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, Span<char> initialBuffer, int input, int from, int to, out bool shouldAppend)
    {
        if (input.IsOutOfRange(from, to))
        {
            this.IsOutOfRange = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider, initialBuffer);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstOutOfRangeInterpolatedStringHandler(int literalLength, int formattedCount, uint input, uint from, uint to, out bool shouldAppend)
    {
        if (input.IsOutOfRange(from, to))
        {
            this.IsOutOfRange = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstOutOfRangeInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, uint input, uint from, uint to, out bool shouldAppend)
    {
        if (input.IsOutOfRange(from, to))
        {
            this.IsOutOfRange = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstOutOfRangeInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, Span<char> initialBuffer, uint input, uint from, uint to, out bool shouldAppend)
    {
        if (input.IsOutOfRange(from, to))
        {
            this.IsOutOfRange = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider, initialBuffer);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstOutOfRangeInterpolatedStringHandler(int literalLength, int formattedCount, nint input, nint from, nint to, out bool shouldAppend)
    {
        if (input.IsOutOfRange(from, to))
        {
            this.IsOutOfRange = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstOutOfRangeInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, nint input, nint from, nint to, out bool shouldAppend)
    {
        if (input.IsOutOfRange(from, to))
        {
            this.IsOutOfRange = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstOutOfRangeInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, Span<char> initialBuffer, nint input, nint from, nint to, out bool shouldAppend)
    {
        if (input.IsOutOfRange(from, to))
        {
            this.IsOutOfRange = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider, initialBuffer);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstOutOfRangeInterpolatedStringHandler(int literalLength, int formattedCount, nuint input, nuint from, nuint to, out bool shouldAppend)
    {
        if (input.IsOutOfRange(from, to))
        {
            this.IsOutOfRange = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstOutOfRangeInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, nuint input, nuint from, nuint to, out bool shouldAppend)
    {
        if (input.IsOutOfRange(from, to))
        {
            this.IsOutOfRange = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstOutOfRangeInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, Span<char> initialBuffer, nuint input, nuint from, nuint to, out bool shouldAppend)
    {
        if (input.IsOutOfRange(from, to))
        {
            this.IsOutOfRange = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider, initialBuffer);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstOutOfRangeInterpolatedStringHandler(int literalLength, int formattedCount, long input, long from, long to, out bool shouldAppend)
    {
        if (input.IsOutOfRange(from, to))
        {
            this.IsOutOfRange = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstOutOfRangeInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, long input, long from, long to, out bool shouldAppend)
    {
        if (input.IsOutOfRange(from, to))
        {
            this.IsOutOfRange = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstOutOfRangeInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, Span<char> initialBuffer, long input, long from, long to, out bool shouldAppend)
    {
        if (input.IsOutOfRange(from, to))
        {
            this.IsOutOfRange = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider, initialBuffer);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstOutOfRangeInterpolatedStringHandler(int literalLength, int formattedCount, ulong input, ulong from, ulong to, out bool shouldAppend)
    {
        if (input.IsOutOfRange(from, to))
        {
            this.IsOutOfRange = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstOutOfRangeInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, ulong input, ulong from, ulong to, out bool shouldAppend)
    {
        if (input.IsOutOfRange(from, to))
        {
            this.IsOutOfRange = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstOutOfRangeInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, Span<char> initialBuffer, ulong input, ulong from, ulong to, out bool shouldAppend)
    {
        if (input.IsOutOfRange(from, to))
        {
            this.IsOutOfRange = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider, initialBuffer);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstOutOfRangeInterpolatedStringHandler(int literalLength, int formattedCount, float input, float from, float to, out bool shouldAppend)
    {
        if (input.IsOutOfRange(from, to))
        {
            this.IsOutOfRange = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstOutOfRangeInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, float input, float from, float to, out bool shouldAppend)
    {
        if (input.IsOutOfRange(from, to))
        {
            this.IsOutOfRange = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstOutOfRangeInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, Span<char> initialBuffer, float input, float from, float to, out bool shouldAppend)
    {
        if (input.IsOutOfRange(from, to))
        {
            this.IsOutOfRange = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider, initialBuffer);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstOutOfRangeInterpolatedStringHandler(int literalLength, int formattedCount, double input, double from, double to, out bool shouldAppend)
    {
        if (input.IsOutOfRange(from, to))
        {
            this.IsOutOfRange = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstOutOfRangeInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, double input, double from, double to, out bool shouldAppend)
    {
        if (input.IsOutOfRange(from, to))
        {
            this.IsOutOfRange = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstOutOfRangeInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, Span<char> initialBuffer, double input, double from, double to, out bool shouldAppend)
    {
        if (input.IsOutOfRange(from, to))
        {
            this.IsOutOfRange = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider, initialBuffer);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstOutOfRangeInterpolatedStringHandler(int literalLength, int formattedCount, decimal input, decimal from, decimal to, out bool shouldAppend)
    {
        if (input.IsOutOfRange(from, to))
        {
            this.IsOutOfRange = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstOutOfRangeInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, decimal input, decimal from, decimal to, out bool shouldAppend)
    {
        if (input.IsOutOfRange(from, to))
        {
            this.IsOutOfRange = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstOutOfRangeInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, Span<char> initialBuffer, decimal input, decimal from, decimal to, out bool shouldAppend)
    {
        if (input.IsOutOfRange(from, to))
        {
            this.IsOutOfRange = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider, initialBuffer);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstOutOfRangeInterpolatedStringHandler(int literalLength, int formattedCount, DateTime input, DateTime from, DateTime to, out bool shouldAppend)
    {
        if (input.IsOutOfRange(from, to))
        {
            this.IsOutOfRange = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstOutOfRangeInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, DateTime input, DateTime from, DateTime to, out bool shouldAppend)
    {
        if (input.IsOutOfRange(from, to))
        {
            this.IsOutOfRange = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstOutOfRangeInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, Span<char> initialBuffer, DateTime input, DateTime from, DateTime to, out bool shouldAppend)
    {
        if (input.IsOutOfRange(from, to))
        {
            this.IsOutOfRange = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider, initialBuffer);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstOutOfRangeInterpolatedStringHandler(int literalLength, int formattedCount, DateOnly input, DateOnly from, DateOnly to, out bool shouldAppend)
    {
        if (input.IsOutOfRange(from, to))
        {
            this.IsOutOfRange = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstOutOfRangeInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, DateOnly input, DateOnly from, DateOnly to, out bool shouldAppend)
    {
        if (input.IsOutOfRange(from, to))
        {
            this.IsOutOfRange = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstOutOfRangeInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, Span<char> initialBuffer, DateOnly input, DateOnly from, DateOnly to, out bool shouldAppend)
    {
        if (input.IsOutOfRange(from, to))
        {
            this.IsOutOfRange = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider, initialBuffer);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstOutOfRangeInterpolatedStringHandler(int literalLength, int formattedCount, TimeOnly input, TimeOnly from, TimeOnly to, out bool shouldAppend)
    {
        if (input.IsOutOfRange(from, to))
        {
            this.IsOutOfRange = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstOutOfRangeInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, TimeOnly input, TimeOnly from, TimeOnly to, out bool shouldAppend)
    {
        if (input.IsOutOfRange(from, to))
        {
            this.IsOutOfRange = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstOutOfRangeInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, Span<char> initialBuffer, TimeOnly input, TimeOnly from, TimeOnly to, out bool shouldAppend)
    {
        if (input.IsOutOfRange(from, to))
        {
            this.IsOutOfRange = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider, initialBuffer);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstOutOfRangeInterpolatedStringHandler(int literalLength, int formattedCount, TimeSpan input, TimeSpan from, TimeSpan to, out bool shouldAppend)
    {
        if (input.IsOutOfRange(from, to))
        {
            this.IsOutOfRange = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstOutOfRangeInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, TimeSpan input, TimeSpan from, TimeSpan to, out bool shouldAppend)
    {
        if (input.IsOutOfRange(from, to))
        {
            this.IsOutOfRange = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstOutOfRangeInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, Span<char> initialBuffer, TimeSpan input, TimeSpan from, TimeSpan to, out bool shouldAppend)
    {
        if (input.IsOutOfRange(from, to))
        {
            this.IsOutOfRange = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider, initialBuffer);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public bool IsOutOfRange { get; } = false;
}

[InterpolatedStringHandler]
public ref partial struct GuardAgainstOutOfRangeComparableInterpolatedStringHandler<TInput>
    where TInput : IComparable<TInput>
{
    private GuardInterpolatedStringHandler innerHandler;

    public GuardAgainstOutOfRangeComparableInterpolatedStringHandler(int literalLength, int formattedCount, TInput input, TInput from, TInput to, out bool shouldAppend)
    {
        if (input.IsOutOfRange(from, to))
        {
            this.IsOutOfRange = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstOutOfRangeComparableInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, TInput input, TInput from, TInput to, out bool shouldAppend)
    {
        if (input.IsOutOfRange(from, to))
        {
            this.IsOutOfRange = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstOutOfRangeComparableInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, Span<char> initialBuffer, TInput input, TInput from, TInput to, out bool shouldAppend)
    {
        if (input.IsOutOfRange(from, to))
        {
            this.IsOutOfRange = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider, initialBuffer);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstOutOfRangeComparableInterpolatedStringHandler(int literalLength, int formattedCount, TInput input, in ComparableRange<TInput> range, out bool shouldAppend)
    {
        if (input.IsOutOfRange(range))
        {
            this.IsOutOfRange = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstOutOfRangeComparableInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, TInput input, in ComparableRange<TInput> range, out bool shouldAppend)
    {
        if (input.IsOutOfRange(range))
        {
            this.IsOutOfRange = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstOutOfRangeComparableInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, Span<char> initialBuffer, TInput input, in ComparableRange<TInput> range, out bool shouldAppend)
    {
        if (input.IsOutOfRange(range))
        {
            this.IsOutOfRange = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider, initialBuffer);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public bool IsOutOfRange { get; } = false;
}

[InterpolatedStringHandler]
public ref partial struct GuardAgainstOutOfRangeInterpolatedStringHandler<TInput>
{
    private GuardInterpolatedStringHandler innerHandler;

    public GuardAgainstOutOfRangeInterpolatedStringHandler(int literalLength, int formattedCount, TInput input, TInput from, TInput to, Comparison<TInput> comparison, out bool shouldAppend)
    {
        if (input.IsOutOfRange(from, to, comparison))
        {
            this.IsOutOfRange = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstOutOfRangeInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, TInput input, TInput from, TInput to, Comparison<TInput> comparison, out bool shouldAppend)
    {
        if (input.IsOutOfRange(from, to, comparison))
        {
            this.IsOutOfRange = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstOutOfRangeInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, Span<char> initialBuffer, TInput input, TInput from, TInput to, Comparison<TInput> comparison, out bool shouldAppend)
    {
        if (input.IsOutOfRange(from, to, comparison))
        {
            this.IsOutOfRange = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider, initialBuffer);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstOutOfRangeInterpolatedStringHandler(int literalLength, int formattedCount, TInput input, TInput from, TInput to, IComparer<TInput> comparer, out bool shouldAppend)
    {
        if (input.IsOutOfRange(from, to, comparer))
        {
            this.IsOutOfRange = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstOutOfRangeInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, TInput input, TInput from, TInput to, IComparer<TInput> comparer, out bool shouldAppend)
    {
        if (input.IsOutOfRange(from, to, comparer))
        {
            this.IsOutOfRange = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstOutOfRangeInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, Span<char> initialBuffer, TInput input, TInput from, TInput to, IComparer<TInput> comparer, out bool shouldAppend)
    {
        if (input.IsOutOfRange(from, to, comparer))
        {
            this.IsOutOfRange = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider, initialBuffer);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstOutOfRangeInterpolatedStringHandler(int literalLength, int formattedCount, TInput input, in ComparisonRange<TInput> range, out bool shouldAppend)
    {
        if (input.IsOutOfRange(range))
        {
            this.IsOutOfRange = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstOutOfRangeInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, TInput input, in ComparisonRange<TInput> range, out bool shouldAppend)
    {
        if (input.IsOutOfRange(range))
        {
            this.IsOutOfRange = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstOutOfRangeInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, Span<char> initialBuffer, TInput input, in ComparisonRange<TInput> range, out bool shouldAppend)
    {
        if (input.IsOutOfRange(range))
        {
            this.IsOutOfRange = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider, initialBuffer);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstOutOfRangeInterpolatedStringHandler(int literalLength, int formattedCount, TInput input, in ComparerRange<TInput> range, out bool shouldAppend)
    {
        if (input.IsOutOfRange(range))
        {
            this.IsOutOfRange = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstOutOfRangeInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, TInput input, in ComparerRange<TInput> range, out bool shouldAppend)
    {
        if (input.IsOutOfRange(range))
        {
            this.IsOutOfRange = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstOutOfRangeInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, Span<char> initialBuffer, TInput input, in ComparerRange<TInput> range, out bool shouldAppend)
    {
        if (input.IsOutOfRange(range))
        {
            this.IsOutOfRange = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider, initialBuffer);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public bool IsOutOfRange { get; } = false;
}
#endif
