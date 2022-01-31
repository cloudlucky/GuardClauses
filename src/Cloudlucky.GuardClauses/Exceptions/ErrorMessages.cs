namespace Cloudlucky.GuardClauses.Exceptions;

internal static class ErrorMessages
{
    public static string GetGenericErrorMessage(string? message = default)
        => message ?? "A guard exception occurred.";
    public static string GetGenericErrorMessage(string? message, string? parameterName)
    {
        message ??= GetGenericErrorMessage(message);

        return parameterName is null
            ? message
            : string.Format("{0} (parameter: {1})", message, parameterName);
    }

    public static string Null(string? message = default)
        => message ?? "Value cannot be null";

    public static string NotNull(string? message = default)
        => message ?? "Value cannot be not null";

    public static string Default(string? message = default)
        => message ?? "Value cannot be default";

    public static string NotDefault(string? message = default)
        => message ?? "Value cannot be not default";

    public static string Empty(string? message = default)
        => message ?? "Value cannot be empty";

    public static string NotEmpty(string? message = default)
        => message ?? "Value cannot be not empty";

    public static string Found(string? message = default)
        => message ?? "Value was found (default or null)";

    public static string NotFound(string? message = default)
        => message ?? "Value was not found (it cannot be default or null)";

    public static string OutOfRange(string? message = default)
        => message ?? "Value cannot be out of range";

    public static string InRange(string? message = default)
        => message ?? "Value cannot be in range";

    public static string NotNullOrEmpty(string? message = default)
        => message ?? "Value must be null or empty";

    public static string GreaterThan(string? message = default)
        => message ?? "Value must not be greater than.";

    public static string NotGreaterThan(string? message = default)
        => message ?? "Value must be greater than.";

    public static string GreaterThanOrEqualTo(string? message = default)
        => message ?? "Value must not be greater than or equal to.";

    public static string NotGreaterThanOrEqualTo(string? message = default)
        => message ?? "Value must be greater than or equal to.";

    public static string LessThan(string? message = default)
        => message ?? "Value must not be less than.";

    public static string NotLessThan(string? message = default)
        => message ?? "Value must be less than.";

    public static string LessThanOrEqualTo(string? message = default)
        => message ?? "Value must not be less than or equal to.";

    public static string NotLessThanOrEqualTo(string? message = default)
        => message ?? "Value must be less than or equal to.";

    public static string Zero(string? message = default)
        => message ?? "Value must not be zero.";

    public static string NotZero(string? message = default)
        => message ?? "Value must be zero.";
}
