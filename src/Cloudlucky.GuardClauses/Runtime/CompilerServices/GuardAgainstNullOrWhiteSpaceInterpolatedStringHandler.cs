#if NET6_0_OR_GREATER
using Cloudlucky.GuardClauses.Extensions;
using System.Runtime.CompilerServices;

namespace Cloudlucky.GuardClauses.Runtime.CompilerServices;

[InterpolatedStringHandler]
public ref partial struct GuardAgainstNullOrWhiteSpaceInterpolatedStringHandler
{
    private GuardInterpolatedStringHandler innerHandler;

    public GuardAgainstNullOrWhiteSpaceInterpolatedStringHandler(int literalLength, int formattedCount, string? input, out bool shouldAppend)
    {
        if (!input.IsNullOrWhiteSpace())
        {
            this.IsNull = input.IsNull();
            this.IsWhiteSpace = !this.IsNull;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNullOrWhiteSpaceInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, string? input, out bool shouldAppend)
    {
        if (input.IsNullOrWhiteSpace())
        {
            this.IsNull = input.IsNull();
            this.IsWhiteSpace = !this.IsNull;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public GuardAgainstNullOrWhiteSpaceInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, Span<char> initialBuffer, string? input, out bool shouldAppend)
    {
        if (input.IsNullOrWhiteSpace())
        {
            this.IsNull = input.IsNull();
            this.IsWhiteSpace = !this.IsNull;
            this.innerHandler = new GuardInterpolatedStringHandler(literalLength, formattedCount, provider, initialBuffer);
            shouldAppend = true;
            return;
        }

        this.innerHandler = default;
        shouldAppend = false;
    }

    public bool IsNull { get; } = false;

    public bool IsWhiteSpace { get; } = false;
}
#endif
