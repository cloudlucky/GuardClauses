namespace Cloudlucky.GuardClauses.Reflection;

/// <summary>
/// This class caches <see cref="Type" /> instances to avoid use of the typeof operator.
/// </summary>
internal static class TypeCache
{
    /// <summary>
    /// Gets the <see cref="FlagsAttribute" /> type.
    /// </summary>
    public static readonly Type FlagsAttributeType = typeof(FlagsAttribute);
}