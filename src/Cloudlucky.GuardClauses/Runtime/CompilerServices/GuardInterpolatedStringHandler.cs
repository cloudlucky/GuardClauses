#if NET6_0_OR_GREATER
using System.Runtime.CompilerServices;

namespace Cloudlucky.GuardClauses.Runtime.CompilerServices;

[InterpolatedStringHandler]
public ref partial struct GuardInterpolatedStringHandler
{
#pragma warning disable IDE0044 // Must not be readonly otherwise it doesn't work
    private DefaultInterpolatedStringHandler innerHandler;
#pragma warning restore IDE0044

    /// <summary>Creates a handler used to translate an interpolated string into a <see cref="string"/>.</summary>
    /// <param name="literalLength">The number of constant characters outside of interpolation expressions in the interpolated string.</param>
    /// <param name="formattedCount">The number of interpolation expressions in the interpolated string.</param>
    /// <remarks>This is intended to be called only by compiler-generated code. Arguments are not validated as they'd otherwise be for members intended to be used directly.</remarks>
    public GuardInterpolatedStringHandler(int literalLength, int formattedCount)
    {
        this.innerHandler = new DefaultInterpolatedStringHandler(literalLength, formattedCount);
    }

    /// <summary>Creates a handler used to translate an interpolated string into a <see cref="string"/>.</summary>
    /// <param name="literalLength">The number of constant characters outside of interpolation expressions in the interpolated string.</param>
    /// <param name="formattedCount">The number of interpolation expressions in the interpolated string.</param>
    /// <param name="provider">An object that supplies culture-specific formatting information.</param>
    /// <remarks>This is intended to be called only by compiler-generated code. Arguments are not validated as they'd otherwise be for members intended to be used directly.</remarks>
    public GuardInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider)
    {
        this.innerHandler = new DefaultInterpolatedStringHandler(literalLength, formattedCount, provider);
    }

    /// <summary>Creates a handler used to translate an interpolated string into a <see cref="string"/>.</summary>
    /// <param name="literalLength">The number of constant characters outside of interpolation expressions in the interpolated string.</param>
    /// <param name="formattedCount">The number of interpolation expressions in the interpolated string.</param>
    /// <param name="provider">An object that supplies culture-specific formatting information.</param>
    /// <param name="initialBuffer">A buffer temporarily transferred to the handler for use as part of its formatting.  Contents may be overwritten.</param>
    /// <remarks>This is intended to be called only by compiler-generated code. Arguments are not validated as they'd otherwise be for members intended to be used directly.</remarks>
    public GuardInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider? provider, Span<char> initialBuffer)
    {
        this.innerHandler = new DefaultInterpolatedStringHandler(literalLength, formattedCount, provider, initialBuffer);
    }
}
#endif
