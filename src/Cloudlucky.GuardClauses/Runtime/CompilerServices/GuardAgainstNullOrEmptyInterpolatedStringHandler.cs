#if NET6_0_OR_GREATER
using Cloudlucky.GuardClauses.Extensions;
using System.Collections;
using System.Runtime.CompilerServices;

namespace Cloudlucky.GuardClauses.Runtime.CompilerServices;

[InterpolatedStringHandler]
public ref partial struct GuardAgainstNullOrEmptyInterpolatedStringHandler
{
    private GuardInterpolatedStringHandler innerHandler;

    public GuardAgainstNullOrEmptyInterpolatedStringHandler(int literalLength, int formattedCount, string? input, out bool shouldAppend)
    {
        if (input.IsNullOrEmpty())
        {
            this.IsNull = input is null;
            this.IsEmpty = !this.IsNull;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNullOrEmptyInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, string? input, out bool shouldAppend)
    {
        if (input.IsNullOrEmpty())
        {
            this.IsNull = input is null;
            this.IsEmpty = !this.IsNull;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNullOrEmptyInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, Span<char> initialBuffer, string? input, out bool shouldAppend)
    {
        if (input.IsNullOrEmpty())
        {
            this.IsNull = input is null;
            this.IsEmpty = !this.IsNull;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider, initialBuffer);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNullOrEmptyInterpolatedStringHandler(int literalLength, int formattedCount, Guid? input, out bool shouldAppend)
    {
        this.IsNull = input.IsNull();
        this.IsEmpty = !this.IsNull && input!.Value.IsEmpty();

        if (this.IsNull || this.IsEmpty)
        {
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNullOrEmptyInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, Guid? input, out bool shouldAppend)
    {
        this.IsNull = input.IsNull();
        this.IsEmpty = !this.IsNull && input!.Value.IsEmpty();

        if (this.IsNull || this.IsEmpty)
        {
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNullOrEmptyInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, Span<char> initialBuffer, Guid? input, out bool shouldAppend)
    {
        this.IsNull = input.IsNull();
        this.IsEmpty = !this.IsNull && input!.Value.IsEmpty();

        if (this.IsNull || this.IsEmpty)
        {
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider, initialBuffer);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNullOrEmptyInterpolatedStringHandler(int literalLength, int formattedCount, IEnumerable? input, out bool shouldAppend)
    {
        this.IsNull = input.IsNull();
        this.IsEmpty = !this.IsNull && input!.IsEmpty();

        if (this.IsNull || this.IsEmpty)
        {
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNullOrEmptyInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, IEnumerable? input, out bool shouldAppend)
    {
        this.IsNull = input.IsNull();
        this.IsEmpty = !this.IsNull && input!.IsEmpty();

        if (this.IsNull || this.IsEmpty)
        {
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNullOrEmptyInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, Span<char> initialBuffer, IEnumerable? input, out bool shouldAppend)
    {
        this.IsNull = input.IsNull();
        this.IsEmpty = !this.IsNull && input!.IsEmpty();

        if (this.IsNull || this.IsEmpty)
        {
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider, initialBuffer);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public bool IsNull { get; } = false;

    public bool IsEmpty { get; } = false;
}

[InterpolatedStringHandler]
public ref partial struct GuardAgainstNullOrEmptyInterpolatedStringHandler<TInput>
{
    private GuardInterpolatedStringHandler innerHandler;

    public GuardAgainstNullOrEmptyInterpolatedStringHandler(int literalLength, int formattedCount, IEnumerable<TInput>? input, out bool shouldAppend)
    {
        this.IsNull = input.IsNull();
        this.IsEmpty = !this.IsNull && input!.IsEmpty();

        if (this.IsNull || this.IsEmpty)
        {
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNullOrEmptyInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, IEnumerable<TInput>? input, out bool shouldAppend)
    {
        this.IsNull = input.IsNull();
        this.IsEmpty = !this.IsNull && input!.IsEmpty();

        if (this.IsNull || this.IsEmpty)
        {
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNullOrEmptyInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, Span<char> initialBuffer, IEnumerable<TInput>? input, out bool shouldAppend)
    {
        this.IsNull = input.IsNull();
        this.IsEmpty = !this.IsNull && input!.IsEmpty();

        if (this.IsNull || this.IsEmpty)
        {
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider, initialBuffer);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNullOrEmptyInterpolatedStringHandler(int literalLength, int formattedCount, ICollection<TInput>? input, out bool shouldAppend)
    {
        this.IsNull = input.IsNull();
        this.IsEmpty = !this.IsNull && input!.IsEmpty();

        if (this.IsNull || this.IsEmpty)
        {
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNullOrEmptyInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, ICollection<TInput>? input, out bool shouldAppend)
    {
        this.IsNull = input.IsNull();
        this.IsEmpty = !this.IsNull && input!.IsEmpty();

        if (this.IsNull || this.IsEmpty)
        {
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNullOrEmptyInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, Span<char> initialBuffer, ICollection<TInput>? input, out bool shouldAppend)
    {
        this.IsNull = input.IsNull();
        this.IsEmpty = !this.IsNull && input!.IsEmpty();

        if (this.IsNull || this.IsEmpty)
        {
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider, initialBuffer);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNullOrEmptyInterpolatedStringHandler(int literalLength, int formattedCount, TInput[]? input, out bool shouldAppend)
    {
        this.IsNull = input.IsNull();
        this.IsEmpty = !this.IsNull && input!.IsEmpty();

        if (this.IsNull || this.IsEmpty)
        {
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNullOrEmptyInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, TInput[]? input, out bool shouldAppend)
    {
        this.IsNull = input.IsNull();
        this.IsEmpty = !this.IsNull && input!.IsEmpty();

        if (this.IsNull || this.IsEmpty)
        {
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNullOrEmptyInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, Span<char> initialBuffer, TInput[]? input, out bool shouldAppend)
    {
        this.IsNull = input.IsNull();
        this.IsEmpty = !this.IsNull && input!.IsEmpty();

        if (this.IsNull || this.IsEmpty)
        {
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider, initialBuffer);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public bool IsNull { get; } = false;

    public bool IsEmpty { get; } = false;
}
#endif
