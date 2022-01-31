using Cloudlucky.GuardClauses.Exceptions;
using Cloudlucky.GuardClauses.Extensions;
using Cloudlucky.GuardClauses.Runtime.CompilerServices;
using System.Runtime.CompilerServices;

namespace Cloudlucky.GuardClauses;

public static partial class GuardClauseExtensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause InRange<T>(this IGuardClause guard, T input, string? message = default, ValidEnumValueOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        where T : Enum
        => input.IsInRange()
         ? throw options.GetValidValueException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause InRange<T>(this IGuardClause guard, T input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstInRangeEnumInterpolatedStringHandler<T> message, ValidEnumValueOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        where T : Enum
        => message.IsInRange
         ? throw options.GetValidValueException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange<T>(this IGuardClause guard, T input, string? message = default, InvalidEnumValueOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        where T : Enum
        => input.IsOutOfRange()
         ? throw options.GetInvalidValueException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange<T>(this IGuardClause guard, T input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstOutOfRangeEnumInterpolatedStringHandler<T> message, InvalidEnumValueOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        where T : Enum
        => message.IsOutOfRange
         ? throw options.GetInvalidValueException().Invoke(message.ToString(), parameterName)
         : guard;
#endif
}

public class ValidEnumValueOptions : IGuardOptions
{
    public static ValidEnumValueOptions Default { get; set; } = default!;

    public GuardFunc ValidValueException { get; set; } = default!;

    internal static void SetDefault(GuardOptionsInitializerConfiguration configuration)
    {
        Default = configuration.Exceptions switch
        {
            GuardExceptionInitializerType.SystemOnly => new()
            {
                ValidValueException = (message, parameterName) => new ArgumentException(GuardMessages.InRange(message), parameterName)
            },
            _ => new()
            {
                ValidValueException = (message, parameterName) => new InRangeException(message, parameterName)
            }
        };
    }
}

public static class ValidEnumValueOptionsExtensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static GuardFunc GetValidValueException(this ValidEnumValueOptions? options)
        => options?.ValidValueException ?? ValidEnumValueOptions.Default.ValidValueException;
}

public class InvalidEnumValueOptions : IGuardOptions
{
    public static InvalidEnumValueOptions Default { get; set; } = default!;

    public GuardFunc InvalidValueException { get; set; } = default!;

    internal static void SetDefault(GuardOptionsInitializerConfiguration configuration)
    {
        Default = configuration.Exceptions switch
        {
            GuardExceptionInitializerType.GuardOnly => new()
            {
                InvalidValueException = (message, parameterName) => new OutOfRangeException(message, parameterName)
            },
            _ => new()
            {
                InvalidValueException = (message, parameterName) => new ArgumentOutOfRangeException(parameterName, GuardMessages.OutOfRange(message))
            }
        };
    }
}

public static class InvalidEnumValueOptionsExtensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static GuardFunc GetInvalidValueException(this InvalidEnumValueOptions? options)
        => options?.InvalidValueException ?? InvalidEnumValueOptions.Default.InvalidValueException;
}
