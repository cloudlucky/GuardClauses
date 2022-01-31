using System.Reflection;

namespace Cloudlucky.GuardClauses;

internal static class TypeLoader
{
#if LESS_THAN_NETSTANDARD2_0
    private static readonly Assembly CurrentAssembly = typeof(TypeLoader).GetTypeInfo().Assembly;
#else

    private static readonly Assembly CurrentAssembly = typeof(TypeLoader).Assembly;
#endif

#if NETSTANDARD2_0_OR_GREATER
    public static IEnumerable<Type> FromAppDomain()
        => GetTypesFromAssembly(CurrentAssembly).Concat(GetTypesFromAppDomain());
#endif 

    public static IEnumerable<Type> FromAssemblies(params Assembly[] assemblies)
        => GetTypesFromAssembly(CurrentAssembly).Concat(GetTypesFromAssemblies(assemblies));

    public static IEnumerable<Type> FromAssemblies(IEnumerable<Assembly> assemblies)
        => GetTypesFromAssembly(CurrentAssembly).Concat(GetTypesFromAssemblies(assemblies));

    public static IEnumerable<Type> FromAssembly(Assembly assembly)
        => GetTypesFromAssembly(CurrentAssembly).Concat(GetTypesFromAssembly(assembly));

#if NETSTANDARD2_0_OR_GREATER
    private static IEnumerable<Type> GetTypesFromAppDomain()
        => AppDomain.CurrentDomain
                    .GetAssemblies()
                    .Where(x => !x.IsDynamic && x != CurrentAssembly)
                    .SelectMany(GetTypesFromAssembly);
#endif

    private static IEnumerable<Type> GetTypesFromAssemblies(params Assembly[] assemblies)
        => assemblies.SelectMany(GetTypesFromAssembly);

    private static IEnumerable<Type> GetTypesFromAssemblies(IEnumerable<Assembly> assemblies)
        => assemblies.SelectMany(GetTypesFromAssembly);

    private static IEnumerable<Type> GetTypesFromAssembly(Assembly assembly)
    {
        try
        {
#if LESS_THAN_NETSTANDARD2_0
            return assembly.DefinedTypes.Select(x => x.GetType());
#else

            return assembly.GetTypes();
#endif
        }
        catch (ReflectionTypeLoadException e)
        {
            return e.Types
                .Where(x => x is not null)
                .Select(x => x!);
        }
    }
}
