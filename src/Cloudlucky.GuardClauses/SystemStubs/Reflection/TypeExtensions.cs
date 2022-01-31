#if LESS_THAN_NETSTANDARD2_0
namespace System.Reflection;

internal static class TypeExtensions
{
    public static FieldInfo[] GetFields(this Type type)
        => type.GetRuntimeFields().ToArray();

    public static Attribute GetCustomAttribute(this Type type, Type attributeType)
        => type.GetTypeInfo().GetCustomAttribute(attributeType);
}
#endif
