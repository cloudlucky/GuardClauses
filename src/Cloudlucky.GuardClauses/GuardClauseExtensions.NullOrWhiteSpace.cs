using Cloudlucky.GuardClauses.Exceptions;
using Cloudlucky.GuardClauses.Extensions;
using Cloudlucky.GuardClauses.Runtime.CompilerServices;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Cloudlucky.GuardClauses;

public static partial class GuardClauseExtensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NullOrWhiteSpace(this IGuardClause guard, [NotNull] string? input, string? message = default, NullOrWhiteSpaceOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
    {
        if (input.IsNullOrWhiteSpace())
        {
            if (input is null)
            {
                throw options.GetNullException().Invoke(message, parameterName);
            }

            throw options.GetWhiteSpaceException().Invoke(message, parameterName);
        }

        return guard;
    }

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NullOrWhiteSpace(this IGuardClause guard, [NotNull] string? input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstNullOrWhiteSpaceInterpolatedStringHandler message, NullOrWhiteSpaceOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
#pragma warning disable CS8777 // The parameter input won't be null at this point.
        => message.IsNull
         ? throw options.GetNullException().Invoke(message.ToString(), parameterName)
         : message.IsWhiteSpace
            ? throw options.GetWhiteSpaceException().Invoke(message.ToString(), parameterName)
            : guard;
#pragma warning restore CS8777
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotNullOrWhiteSpace(this IGuardClause guard, string? input, string? message = default, NotNullOrWhiteSpaceOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsNullOrWhiteSpace()
         ? throw options.GetNotNullOrWhiteSpaceException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotNullOrWhiteSpace(this IGuardClause guard, string? input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstNotNullOrWhiteSpaceInterpolatedStringHandler message, NotNullOrWhiteSpaceOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !message.IsNullOrWhiteSpace
         ? throw options.GetNotNullOrWhiteSpaceException().Invoke(message.ToString(), parameterName)
         : guard;
#endif
}

public class NullOrWhiteSpaceOptions : IGuardOptions
{
    public static NullOrWhiteSpaceOptions Default { get; set; } = default!;

    public NullOptions? NullOptions { get; set; }

    public GuardFunc WhiteSpaceException { get; set; } = default!;

    internal static void SetDefault(GuardOptionsInitializerConfiguration configuration)
    {
        Default = configuration.Exceptions switch
        {
            GuardExceptionInitializerType.SystemOnly => new()
            {
                WhiteSpaceException = (message, parameterName) => new ArgumentException(message, parameterName)
            },
            _ => new()
            {
                WhiteSpaceException = (message, parameterName) => new EmptyException(message, parameterName)
            },
        };
    }
}

public static class NullOrWhiteSpaceOptionsExtensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static GuardFunc GetNullException(this NullOrWhiteSpaceOptions? options)
        => options?.NullOptions?.NullException ?? NullOrWhiteSpaceOptions.Default.NullOptions.GetNullException();

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static GuardFunc GetWhiteSpaceException(this NullOrWhiteSpaceOptions? options)
        => options?.WhiteSpaceException ?? NullOrWhiteSpaceOptions.Default.WhiteSpaceException;
}

public class NotNullOrWhiteSpaceOptions : IGuardOptions
{
    public static NotNullOrWhiteSpaceOptions Default { get; set; } = default!;

    public GuardFunc NotNullOrWhiteSpaceException { get; set; } = default!;

    internal static void SetDefault(GuardOptionsInitializerConfiguration configuration)
    {
        Default = configuration.Exceptions switch
        {
            GuardExceptionInitializerType.SystemOnly => new()
            {
                NotNullOrWhiteSpaceException = (message, parameterName) => new ArgumentException(GuardMessages.NotNullOrEmpty(message), parameterName)
            },
            _ => new()
            {
                NotNullOrWhiteSpaceException = (message, parameterName) => new NotNullOrEmptyException(message, parameterName)
            },
        };
    }
}

public static class NotNullOrWhiteSpaceOptionsExtensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static GuardFunc GetNotNullOrWhiteSpaceException(this NotNullOrWhiteSpaceOptions? options)
        => options?.NotNullOrWhiteSpaceException ?? NotNullOrWhiteSpaceOptions.Default.NotNullOrWhiteSpaceException;
}
