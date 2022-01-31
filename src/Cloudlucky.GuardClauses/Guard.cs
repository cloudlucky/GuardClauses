using System.Reflection;
using System.Runtime.CompilerServices;

namespace Cloudlucky.GuardClauses;

public interface IGuardClause
{
}

public class Guard : IGuardClause
{
    private static readonly Guard Instance = new();
    private Guard()
    {
    }

    static Guard()
    {
        Initialize(default);
    }

    public static IGuardClause Against { [MethodImpl(MethodImplOptions.AggressiveInlining)] get; } = Instance;

    // TODO it's slow
    public static GuardCondition When(GuardCondition condition) => condition;

    public static void Initialize(GuardOptionsInitializerConfiguration? configuration)
    {
        configuration ??= new();

        new OptionsInitializer().Initialize(configuration);
    }

#if NETSTANDARD2_0_OR_GREATER
    public static void Initialize(GuardOptionsInitializerConfiguration? configuration, IGuardInitializer? guardInitializer = default)
    {
        configuration ??= new();
        guardInitializer ??= new GuardInitializer();

        guardInitializer.Init(configuration);
    }
#endif

    public static void Initialize(GuardOptionsInitializerConfiguration? configuration, params Assembly[] assemblies)
    {
        configuration ??= new();
        var guardInitializer = new GuardInitializer();

        guardInitializer.Init(configuration, assemblies);
    }
}
