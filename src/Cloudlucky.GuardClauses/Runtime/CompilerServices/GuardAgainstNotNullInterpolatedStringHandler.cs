#if NET6_0_OR_GREATER
using System.Runtime.CompilerServices;

namespace Cloudlucky.GuardClauses.Runtime.CompilerServices;

[InterpolatedStringHandler]
public ref partial struct GuardAgainstNotNullInterpolatedStringHandler<TInput>
{
    private GuardInterpolatedStringHandler innerHandler;

    public GuardAgainstNotNullInterpolatedStringHandler(int literalLength, int formattedCount, TInput? input, out bool shouldAppend)
    {
        if (input is not null)
        {
            this.IsNotNull = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotNullInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, TInput? input, out bool shouldAppend)
    {
        if (input is not null)
        {
            this.IsNotNull = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNotNullInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, Span<char> initialBuffer, TInput? input, out bool shouldAppend)
    {
        if (input is not null)
        {
            this.IsNotNull = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider, initialBuffer);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public bool IsNotNull { get; } = false;
}
#endif
