using Cloudlucky.GuardClauses.Exceptions;
using Cloudlucky.GuardClauses.Runtime.CompilerServices;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Cloudlucky.GuardClauses;

public static partial class GuardClauseExtensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause Null<T>(this IGuardClause guard, [NotNull] T? input, string? message = default, NullOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input is null
         ? throw options.GetNullException().Invoke(parameterName, message)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause Null<T>(this IGuardClause guard, [NotNull] T? input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstNullInterpolatedStringHandler<T> message, NullOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
#pragma warning disable CS8777 // The parameter input won't be null at this point.
        => message.IsNull
         ? throw options.GetNullException().Invoke(parameterName, message.ToString())
         : guard;
#pragma warning restore CS8777
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotNull<T>(this IGuardClause guard, T? input, string? message = default, NotNullOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input is not null
         ? throw options.GetNotNullException().Invoke(parameterName, message)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotNull<T>(this IGuardClause guard, T? input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstNotNullInterpolatedStringHandler<T> message, NotNullOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotNull
         ? throw options.GetNotNullException().Invoke(parameterName, message.ToString())
         : guard;
#endif
}

public class NullOptions : IGuardOptions
{
    public static NullOptions Default { get; set; } = default!;

    public GuardFunc NullException { get; set; } = default!;

    internal static void SetDefault(GuardOptionsInitializerConfiguration configuration)
    {
        Default = configuration.Exceptions switch
        {
            GuardExceptionInitializerType.GuardOnly => new()
            {
                NullException = (message, parameterName) => new NullException(message, parameterName)
            },
            _ => new()
            {
                NullException = (message, parameterName) => new ArgumentNullException(parameterName, GuardMessages.Null(message))
            }
        };
    }
}

public static class NullOptionsExtensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static GuardFunc GetNullException(this NullOptions? options)
        => options?.NullException ?? NullOptions.Default.NullException;
}

public class NotNullOptions : IGuardOptions
{
    public static NotNullOptions Default { get; set; } = default!;

    public GuardFunc NotNullException { get; set; } = default!;

    internal static void SetDefault(GuardOptionsInitializerConfiguration configuration)
    {
        Default = configuration.Exceptions switch
        {
            GuardExceptionInitializerType.SystemOnly => new()
            {
                NotNullException = (message, parameterName) => new ArgumentException(GuardMessages.NotNull(message), parameterName)
            },
            _ => new()
            {
                NotNullException = (message, parameterName) => new NotNullException(message, parameterName)
            }
        };
    }
}

public static class NotNullOptionsExtensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static GuardFunc GetNotNullException(this NotNullOptions? options)
        => options?.NotNullException ?? NotNullOptions.Default.NotNullException;
}
