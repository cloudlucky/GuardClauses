using Cloudlucky.GuardClauses.Exceptions;
using Cloudlucky.GuardClauses.Extensions;
using Cloudlucky.GuardClauses.Runtime.CompilerServices;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Cloudlucky.GuardClauses;

public static partial class GuardClauseExtensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause Default<T>(this IGuardClause guard, [NotNull] T? input, string? message = default, DefaultOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsDefault()
         ? throw options.GetDefaultException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause Default<T>(this IGuardClause guard, [NotNull] T? input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstDefaultInterpolatedStringHandler<T> message, DefaultOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
#pragma warning disable CS8777 // The parameter input won't be null at this point.
        => message.IsDefault
         ? throw options.GetDefaultException().Invoke(message.ToString(), parameterName)
         : guard;
#pragma warning restore CS8777
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause Default<T>(this IGuardClause guard, T? input, T? defaultValue, string? message = default, DefaultOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsDefault(defaultValue)
         ? throw options.GetDefaultException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause Default<T>(this IGuardClause guard, T? input, T? defaultValue, [InterpolatedStringHandlerArgument("input", "defaultValue")] ref GuardAgainstDefaultInterpolatedStringHandler<T> message, DefaultOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsDefault
         ? throw options.GetDefaultException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotDefault<T>(this IGuardClause guard, T? input, string? message = default, NotDefaultOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsDefault()
         ? throw options.GetNotDefaultException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotDefault<T>(this IGuardClause guard, T? input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstNotDefaultInterpolatedStringHandler<T> message, NotDefaultOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotDefault
         ? throw options.GetNotDefaultException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotDefault<T>(this IGuardClause guard, T? input, T? defaultValue, string? message = default, NotDefaultOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsDefault(defaultValue)
         ? throw options.GetNotDefaultException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotDefault<T>(this IGuardClause guard, T? input, T? defaultValue, [InterpolatedStringHandlerArgument("input", "defaultValue")] ref GuardAgainstNotDefaultInterpolatedStringHandler<T> message, NotDefaultOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotDefault
         ? throw options.GetNotDefaultException().Invoke(message.ToString(), parameterName)
         : guard;
#endif
}

public class DefaultOptions : IGuardOptions
{
    public static DefaultOptions Default { get; set; } = default!;

    public GuardFunc DefaultException { get; set; } = default!;

    internal static void SetDefault(GuardOptionsInitializerConfiguration configuration)
    {
        Default = configuration.Exceptions switch
        {
            GuardExceptionInitializerType.SystemOnly => new()
            {
                DefaultException = (message, parameterName) => new ArgumentException(GuardMessages.Default(message), parameterName)
            },
            _ => new()
            {
                DefaultException = (message, parameterName) => new DefaultException(message, parameterName)
            }
        };
    }
}

public static class DefaultOptionsExtensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static GuardFunc GetDefaultException(this DefaultOptions? options)
        => options?.DefaultException ?? DefaultOptions.Default.DefaultException;
}


public class NotDefaultOptions : IGuardOptions
{
    public static NotDefaultOptions Default { get; set; } = default!;

    public GuardFunc NotDefaultException { get; set; } = default!;

    internal static void SetDefault(GuardOptionsInitializerConfiguration configuration)
    {
        Default = configuration.Exceptions switch
        {
            GuardExceptionInitializerType.SystemOnly => new()
            {
                NotDefaultException = (message, parameterName) => new ArgumentException(GuardMessages.NotDefault(message), parameterName)
            },
            _ => new()
            {
                NotDefaultException = (message, parameterName) => new NotDefaultException(message, parameterName)
            }
        };
    }
}

public static class NotDefaultOptionsExtensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static GuardFunc GetNotDefaultException(this NotDefaultOptions? options)
        => options?.NotDefaultException ?? NotDefaultOptions.Default.NotDefaultException;
}

