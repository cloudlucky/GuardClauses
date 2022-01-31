#if NET6_0_OR_GREATER
using Cloudlucky.GuardClauses.Extensions;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Cloudlucky.GuardClauses.Runtime.CompilerServices;

[InterpolatedStringHandler]
public ref partial struct GuardAgainstInRangeEnumInterpolatedStringHandler<TInput>
    where TInput : Enum
{
    private GuardInterpolatedStringHandler innerHandler;

    public GuardAgainstInRangeEnumInterpolatedStringHandler(int literalLength, int formattedCount, TInput input, out bool shouldAppend)
    {
        if (input.IsInRange())
        {
            this.IsInRange = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstInRangeEnumInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, TInput input, out bool shouldAppend)
    {
        if (input.IsInRange())
        {
            this.IsInRange = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstInRangeEnumInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, Span<char> initialBuffer, TInput input, out bool shouldAppend)
    {
        if (input.IsInRange())
        {
            this.IsInRange = true;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider, initialBuffer);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public bool IsInRange { get; } = false;
}
#endif
