namespace Cloudlucky.GuardClauses;

internal static class GuardMessages
{
    public static string Default(string? message = default)
        => message ?? "Value must not be default (null or default).";

    public static string NotDefault(string? message = default)
        => message ?? "Value must be default (null or default).";

    public static string Empty(string? message = default)
        => message ?? "Value must not be empty.";

    public static string NotEmpty(string? message = default)
        => message ?? "Value must be empty.";

    public static string Null(string? message = default)
        => message ?? "Value must not be null.";

    public static string NotNull(string? message = default)
        => message ?? "Value must be null.";

    public static string OutOfRange(string? message = default)
        => message ?? "Value must be in range.";

    public static string InRange(string? message = default)
        => message ?? "Value must be out of range.";

    public static string Found(string? message = default)
        => message ?? "Value must not be null or default";

    public static string NotFound(string? message = default)
        => message ?? "Value must be null or default";

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
