#if NET6_0_OR_GREATER
using Cloudlucky.GuardClauses.Extensions;
using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Cloudlucky.GuardClauses.Runtime.CompilerServices;

[InterpolatedStringHandler]
public ref partial struct GuardAgainstNotNullOrEmptyInterpolatedStringHandler
{
    private GuardInterpolatedStringHandler innerHandler;

    public GuardAgainstNotNullOrEmptyInterpolatedStringHandler(int literalLength, int formattedCount, string? input, out bool shouldAppend)
    {
        if (!input.IsNullOrEmpty())
        {
            this.IsNotNullOrEmpty = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotNullOrEmptyInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, string? input, out bool shouldAppend)
    {
        if (!input.IsNullOrEmpty())
        {
            this.IsNotNullOrEmpty = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotNullOrEmptyInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, Span<char> initialBuffer, string? input, out bool shouldAppend)
    {
        if (!input.IsNullOrEmpty())
        {
            this.IsNotNullOrEmpty = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider, initialBuffer);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotNullOrEmptyInterpolatedStringHandler(int literalLength, int formattedCount, Guid? input, out bool shouldAppend)
    {
        if (input is not null && !input.Value.IsEmpty())
        {
            this.IsNotNullOrEmpty = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotNullOrEmptyInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, Guid? input, out bool shouldAppend)
    {
        if (input is not null && !input.Value.IsEmpty())
        {
            this.IsNotNullOrEmpty = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotNullOrEmptyInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, Span<char> initialBuffer, Guid? input, out bool shouldAppend)
    {
        if (input is not null && !input.Value.IsEmpty())
        {
            this.IsNotNullOrEmpty = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider, initialBuffer);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotNullOrEmptyInterpolatedStringHandler(int literalLength, int formattedCount, IEnumerable? input, out bool shouldAppend)
    {
        if (!input.IsNullOrEmpty())
        {
            this.IsNotNullOrEmpty = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotNullOrEmptyInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, IEnumerable? input, out bool shouldAppend)
    {
        if (!input.IsNullOrEmpty())
        {
            this.IsNotNullOrEmpty = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotNullOrEmptyInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, Span<char> initialBuffer, IEnumerable? input, out bool shouldAppend)
    {
        if (!input.IsNullOrEmpty())
        {
            this.IsNotNullOrEmpty = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider, initialBuffer);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public bool IsNotNullOrEmpty { get; } = false;
}

[InterpolatedStringHandler]
public ref partial struct GuardAgainstNotNullOrEmptyInterpolatedStringHandler<TInput>
{
    private GuardInterpolatedStringHandler innerHandler;

    public GuardAgainstNotNullOrEmptyInterpolatedStringHandler(int literalLength, int formattedCount, IEnumerable<TInput>? input, out bool shouldAppend)
    {
        if (!input.IsNullOrEmpty())
        {
            this.IsNotNullOrEmpty = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotNullOrEmptyInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, IEnumerable<TInput>? input, out bool shouldAppend)
    {
        if (!input.IsNullOrEmpty())
        {
            this.IsNotNullOrEmpty = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotNullOrEmptyInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, Span<char> initialBuffer, IEnumerable<TInput>? input, out bool shouldAppend)
    {
        if (!input.IsNullOrEmpty())
        {
            this.IsNotNullOrEmpty = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider, initialBuffer);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotNullOrEmptyInterpolatedStringHandler(int literalLength, int formattedCount, ICollection<TInput>? input, out bool shouldAppend)
    {
        if (!input.IsNullOrEmpty())
        {
            this.IsNotNullOrEmpty = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotNullOrEmptyInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, ICollection<TInput>? input, out bool shouldAppend)
    {
        if (!input.IsNullOrEmpty())
        {
            this.IsNotNullOrEmpty = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotNullOrEmptyInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, Span<char> initialBuffer, ICollection<TInput>? input, out bool shouldAppend)
    {
        if (!input.IsNullOrEmpty())
        {
            this.IsNotNullOrEmpty = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider, initialBuffer);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotNullOrEmptyInterpolatedStringHandler(int literalLength, int formattedCount, TInput[]? input, out bool shouldAppend)
    {
        if (!input.IsNullOrEmpty())
        {
            this.IsNotNullOrEmpty = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotNullOrEmptyInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, TInput[]? input, out bool shouldAppend)
    {
        if (!input.IsNullOrEmpty())
        {
            this.IsNotNullOrEmpty = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotNullOrEmptyInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, Span<char> initialBuffer, TInput[]? input, out bool shouldAppend)
    {
        if (!input.IsNullOrEmpty())
        {
            this.IsNotNullOrEmpty = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider, initialBuffer);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public bool IsNotNullOrEmpty { get; } = false;
}
#endif
