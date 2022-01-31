using Cloudlucky.GuardClauses.Exceptions;
using Cloudlucky.GuardClauses.Extensions;
using Cloudlucky.GuardClauses.Runtime.CompilerServices;
using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Cloudlucky.GuardClauses;

public static partial class GuardClauseExtensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NullOrEmpty(this IGuardClause guard, [NotNull] string? input, string? message = default, NullOrEmptyOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
    {
        if (input.IsNullOrEmpty())
        {
            if (input is null)
            {
                throw options.GetNullException().Invoke(message, parameterName);
            }

            throw options.GetEmptyException().Invoke(message, parameterName);
        }

        return guard;
    }

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NullOrEmpty(this IGuardClause guard, [NotNull] string? input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstNullOrEmptyInterpolatedStringHandler message, NullOrEmptyOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
#pragma warning disable CS8777 // Parameter input won't be null
        => message.IsNull
         ? throw options.GetNullException().Invoke(message.ToString(), parameterName)
         : message.IsEmpty
            ? throw options.GetEmptyException().Invoke(message.ToString(), parameterName)
            : guard;
#pragma warning restore CS8777
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NullOrEmpty(this IGuardClause guard, [NotNull] Guid? input, string? message = default, NullOrEmptyOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input is null
         ? throw options.GetNullException().Invoke(message, parameterName)
         : input.Value.IsEmpty()
            ? throw options.GetEmptyException().Invoke(message, parameterName)
            : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NullOrEmpty(this IGuardClause guard, [NotNull] Guid? input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstNullOrEmptyInterpolatedStringHandler message, NullOrEmptyOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
#pragma warning disable CS8777 // Parameter input won't be null
        => message.IsNull
         ? throw options.GetNullException().Invoke(message.ToString(), parameterName)
         : message.IsEmpty
            ? throw options.GetEmptyException().Invoke(message.ToString(), parameterName)
            : guard;
#pragma warning restore CS8777
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NullOrEmpty(this IGuardClause guard, [NotNull] IEnumerable? input, string? message = default, NullOrEmptyOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input is null
         ? throw options.GetNullException().Invoke(message, parameterName)
         : input.IsEmpty()
            ? throw options.GetEmptyException().Invoke(message, parameterName)
            : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NullOrEmpty(this IGuardClause guard, [NotNull] IEnumerable? input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstNullOrEmptyInterpolatedStringHandler message, NullOrEmptyOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
#pragma warning disable CS8777 // Parameter input won't be null
        => message.IsNull
         ? throw options.GetNullException().Invoke(message.ToString(), parameterName)
         : message.IsEmpty
            ? throw options.GetEmptyException().Invoke(message.ToString(), parameterName)
            : guard;
#pragma warning restore CS8777
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NullOrEmpty<T>(this IGuardClause guard, [NotNull] IEnumerable<T>? input, string? message = default, NullOrEmptyOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input is null
         ? throw options.GetNullException().Invoke(message, parameterName)
         : input.IsEmpty()
            ? throw options.GetEmptyException().Invoke(message, parameterName)
            : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NullOrEmpty<T>(this IGuardClause guard, [NotNull] IEnumerable<T>? input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstNullOrEmptyInterpolatedStringHandler<T> message, NullOrEmptyOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
#pragma warning disable CS8777 // Parameter input won't be null
        => message.IsNull
         ? throw options.GetNullException().Invoke(message.ToString(), parameterName)
         : message.IsEmpty
            ? throw options.GetEmptyException().Invoke(message.ToString(), parameterName)
            : guard;
#pragma warning restore CS8777
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NullOrEmpty<T>(this IGuardClause guard, [NotNull] ICollection<T>? input, string? message = default, NullOrEmptyOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input is null
         ? throw options.GetNullException().Invoke(message, parameterName)
         : input.IsEmpty()
            ? throw options.GetEmptyException().Invoke(message, parameterName)
            : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NullOrEmpty<T>(this IGuardClause guard, [NotNull] ICollection<T>? input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstNullOrEmptyInterpolatedStringHandler<T> message, NullOrEmptyOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
#pragma warning disable CS8777 // Parameter input won't be null
        => message.IsNull
         ? throw options.GetNullException().Invoke(message.ToString(), parameterName)
         : message.IsEmpty
            ? throw options.GetEmptyException().Invoke(message.ToString(), parameterName)
            : guard;
#pragma warning restore CS8777
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NullOrEmpty<T>(this IGuardClause guard, [NotNull] T[]? input, string? message = default, NullOrEmptyOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input is null
         ? throw options.GetNullException().Invoke(message, parameterName)
         : input.IsEmpty()
            ? throw options.GetEmptyException().Invoke(message, parameterName)
            : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NullOrEmpty<T>(this IGuardClause guard, [NotNull] T[]? input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstNullOrEmptyInterpolatedStringHandler<T> message, NullOrEmptyOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
#pragma warning disable CS8777 // Parameter input won't be null
        => message.IsNull
         ? throw options.GetNullException().Invoke(message.ToString(), parameterName)
         : message.IsEmpty
            ? throw options.GetEmptyException().Invoke(message.ToString(), parameterName)
            : guard;
#pragma warning restore CS8777
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotNullOrEmpty(this IGuardClause guard, string? input, string? message = default, NotNullOrEmptyOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsNullOrEmpty()
         ? throw options.GetNotNullOrEmptyException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotNullOrEmpty(this IGuardClause guard, string? input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstNotNullOrEmptyInterpolatedStringHandler message, NotNullOrEmptyOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotNullOrEmpty
         ? throw options.GetNotNullOrEmptyException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotNullOrEmpty(this IGuardClause guard, Guid? input, string? message = default, NotNullOrEmptyOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input is not null && !input.Value.IsEmpty()
         ? throw options.GetNotNullOrEmptyException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotNullOrEmpty(this IGuardClause guard, Guid? input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstNotNullOrEmptyInterpolatedStringHandler message, NotNullOrEmptyOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotNullOrEmpty
         ? throw options.GetNotNullOrEmptyException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotNullOrEmpty(this IGuardClause guard, IEnumerable? input, string? message = default, NotNullOrEmptyOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsNullOrEmpty()
         ? throw options.GetNotNullOrEmptyException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotNullOrEmpty(this IGuardClause guard, IEnumerable? input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstNotNullOrEmptyInterpolatedStringHandler message, NotNullOrEmptyOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotNullOrEmpty
         ? throw options.GetNotNullOrEmptyException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotNullOrEmpty<T>(this IGuardClause guard, IEnumerable<T>? input, string? message = default, NotNullOrEmptyOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsNullOrEmpty()
         ? throw options.GetNotNullOrEmptyException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotNullOrEmpty<T>(this IGuardClause guard, IEnumerable<T>? input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstNotNullOrEmptyInterpolatedStringHandler<T> message, NotNullOrEmptyOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotNullOrEmpty
         ? throw options.GetNotNullOrEmptyException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotNullOrEmpty<T>(this IGuardClause guard, ICollection<T>? input, string? message = default, NotNullOrEmptyOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsNullOrEmpty()
         ? throw options.GetNotNullOrEmptyException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotNullOrEmpty<T>(this IGuardClause guard, ICollection<T>? input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstNotNullOrEmptyInterpolatedStringHandler<T> message, NotNullOrEmptyOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotNullOrEmpty
         ? throw options.GetNotNullOrEmptyException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotNullOrEmpty<T>(this IGuardClause guard, T[]? input, string? message = default, NotNullOrEmptyOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsNullOrEmpty()
         ? throw options.GetNotNullOrEmptyException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotNullOrEmpty<T>(this IGuardClause guard, T[]? input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstNotNullOrEmptyInterpolatedStringHandler<T> message, NotNullOrEmptyOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotNullOrEmpty
         ? throw options.GetNotNullOrEmptyException().Invoke(message.ToString(), parameterName)
         : guard;
#endif
}

public class NullOrEmptyOptions : IGuardOptions
{
    public static NullOrEmptyOptions Default { get; set; } = default!;

    public NullOptions? NullOptions { get; set; }

    public EmptyOptions? EmptyOptions { get; set; }

    internal static void SetDefault(GuardOptionsInitializerConfiguration configuration)
    {
        Default = new();
    }
}

public static class NullOrEmptyOptionsExtensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static GuardFunc GetNullException(this NullOrEmptyOptions? options)
        => options?.NullOptions?.NullException ?? NullOrEmptyOptions.Default.NullOptions.GetNullException();

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static GuardFunc GetEmptyException(this NullOrEmptyOptions? options)
        => options?.EmptyOptions?.EmptyException ?? NullOrEmptyOptions.Default.EmptyOptions.GetEmptyException();
}

public class NotNullOrEmptyOptions : IGuardOptions
{
    public static NotNullOrEmptyOptions Default { get; set; } = default!;

    public GuardFunc NotNullOrEmptyException { get; set; } = default!;

    internal static void SetDefault(GuardOptionsInitializerConfiguration configuration)
    {
        Default = configuration.Exceptions switch
        {
            GuardExceptionInitializerType.SystemOnly => new()
            {
                NotNullOrEmptyException = (message, parameterName) => new ArgumentException(GuardMessages.NotNullOrEmpty(message), parameterName)
            },
            _ => new()
            {
                NotNullOrEmptyException = (message, parameterName) => new NotNullOrEmptyException(message, parameterName)
            },
        };
    }
}

public static class NotNullOrEmptyOptionsExtensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static GuardFunc GetNotNullOrEmptyException(this NotNullOrEmptyOptions? options)
        => options?.NotNullOrEmptyException ?? NotNullOrEmptyOptions.Default.NotNullOrEmptyException;
}
