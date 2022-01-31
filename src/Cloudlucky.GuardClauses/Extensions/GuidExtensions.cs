using System.Runtime.CompilerServices;

namespace Cloudlucky.GuardClauses.Extensions;

public static class GuidExtensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsEmpty(this Guid input)
        => input == Guid.Empty;
}
