using System.Reflection;

namespace Cloudlucky.GuardClauses;

public interface IGuardInitializer
{
#if NETSTANDARD2_0_OR_GREATER
    void Init(GuardOptionsInitializerConfiguration configuration);
#endif

    void Init(GuardOptionsInitializerConfiguration configuration, IEnumerable<Assembly> assemblies);

    void Init(GuardOptionsInitializerConfiguration configuration, params Assembly[] assemblies);
}

internal class GuardInitializer : IGuardInitializer
{
    private static readonly Type IGuardOptionsInitializerType = typeof(IGuardOptionsInitializer);
#if LESS_THAN_NETSTANDARD2_0
    private static readonly TypeInfo IGuardOptionsInitializerTypeInfo = IGuardOptionsInitializerType.GetTypeInfo();
#endif

#if NETSTANDARD2_0_OR_GREATER
    public void Init(GuardOptionsInitializerConfiguration configuration)
    {
        var types = TypeLoader.FromAppDomain();

        Init(configuration, types);
    }
#endif

    public void Init(GuardOptionsInitializerConfiguration configuration, IEnumerable<Assembly> assemblies)
    {
        var types = TypeLoader.FromAssemblies(assemblies);

        Init(configuration, types);
    }

    public void Init(GuardOptionsInitializerConfiguration configuration, params Assembly[] assemblies)
        => this.Init(configuration, (IEnumerable<Assembly>)assemblies);

    private static void Init(GuardOptionsInitializerConfiguration configuration, IEnumerable<Type> types)
    {
        foreach (var type in types)
        {
            if (CanCreateInstance(type))
            {
                var guardOptionsInitializer = (IGuardOptionsInitializer)Activator.CreateInstance(type)!; // TODO Check if we need a custom catch (and Throw custom exception) to make it more clear and if we need to catch the null

                guardOptionsInitializer.Initialize(configuration);
            }
        }
    }

    private static bool CanCreateInstance(Type type)
#if LESS_THAN_NETSTANDARD2_0
    {
        var typeInfo = type.GetTypeInfo();
        return typeInfo.IsClass && !typeInfo.IsAbstract && IGuardOptionsInitializerTypeInfo.IsAssignableFrom(typeInfo);
    }
#else
        => type.IsClass && !type.IsAbstract && IGuardOptionsInitializerType.IsAssignableFrom(type);
#endif
}
