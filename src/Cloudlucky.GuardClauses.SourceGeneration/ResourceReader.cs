using Microsoft.CodeAnalysis;
using System;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Cloudlucky.GuardClauses.SourceGeneration;

internal class ResourceReader
{
    public static string? GetResource<TAssembly>(string endWith)
        => GetResource(endWith, typeof(TAssembly));

    public static string? GetResource(string endWith, Type? assemblyType = default)
    {
        var assembly = GetAssembly(assemblyType);

        var resources = assembly.GetManifestResourceNames().Where(r => r.EndsWith(endWith));

        if (!resources.Any())
        {
            throw new InvalidOperationException($"There is no resources that ends with '{endWith}'");
        }

        if (resources.Count() > 1)
        {
            throw new InvalidOperationException($"There is more then one resource that ends with '{endWith}'");
        }

        var resourceName = resources.First();

        return ReadEmbededResource(assembly, resourceName);
    }

    private static Assembly GetAssembly(Type? assemblyType)
        => assemblyType is null
         ? Assembly.GetExecutingAssembly()
         : Assembly.GetAssembly(assemblyType);

    private static string? ReadEmbededResource(Assembly assembly, string name)
    {
        using var resourceStream = assembly.GetManifestResourceStream(name);
        if (resourceStream is null)
        {
            return null;
        }

        using var streamReader = new StreamReader(resourceStream);
        return streamReader.ReadToEnd();
    }
}
