using Cloudlucky.GuardClauses.Exceptions;
using Cloudlucky.GuardClauses.Extensions;
using Cloudlucky.GuardClauses.Runtime.CompilerServices;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Cloudlucky.GuardClauses;

public static partial class GuardClauseExtensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause Found<T>(this IGuardClause guard, T? input, string? message = default, FoundOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsDefault()
         ? throw options.GetFoundException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause Found<T>(this IGuardClause guard, T? input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstNotDefaultInterpolatedStringHandler<T> message, FoundOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotDefault
         ? throw options.GetFoundException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotFound<T>(this IGuardClause guard, [NotNull] T? input, string? message = default, NotFoundOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsDefault()
         ? throw options.GetNotFoundException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotFound<T>(this IGuardClause guard, [NotNull] T? input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstDefaultInterpolatedStringHandler<T> message, NotFoundOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
#pragma warning disable CS8777 // The parameter input won't be null
        => message.IsDefault
         ? throw options.GetNotFoundException().Invoke(message.ToString(), parameterName)
         : guard;
#pragma warning restore CS8777
#endif
}

public class FoundOptions : IGuardOptions
{
    public static FoundOptions Default { get; set; } = default!;

    public GuardFunc FoundException { get; set; } = default!;

    internal static void SetDefault(GuardOptionsInitializerConfiguration configuration)
    {
        Default = configuration.Exceptions switch
        {
            GuardExceptionInitializerType.SystemOnly => new()
            {
                FoundException = (message, parameterName) => new ArgumentException(GuardMessages.Found(message), parameterName)
            },
            _ => new()
            {
                FoundException = (message, parameterName) => new FoundException(message, parameterName)
            }
        };
    }
}

public static class FoundOptionsExtensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static GuardFunc GetFoundException(this FoundOptions? options)
        => options?.FoundException ?? FoundOptions.Default.FoundException;
}

public class NotFoundOptions : IGuardOptions
{
    public static NotFoundOptions Default { get; set; } = default!;

    public GuardFunc NotFoundException { get; set; } = default!;

    internal static void SetDefault(GuardOptionsInitializerConfiguration configuration)
    {
        Default = configuration.Exceptions switch
        {
            GuardExceptionInitializerType.SystemOnly => new()
            {
                NotFoundException = (message, parameterName) => new ArgumentNullException(GuardMessages.NotFound(message), parameterName)
            },
            _ => new()
            {
                NotFoundException = (message, parameterName) => new NotFoundException(message, parameterName)
            }
        };
    }
}

public static class NotFoundOptionsExtensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static GuardFunc GetNotFoundException(this NotFoundOptions? options)
        => options?.NotFoundException ?? NotFoundOptions.Default.NotFoundException;
}
