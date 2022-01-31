using System.Reflection;

namespace Cloudlucky.GuardClauses;

public interface IGuardOptionsInitializer
{
    void Initialize(GuardOptionsInitializerConfiguration configuration);
}

public class GuardOptionsInitializerConfiguration
{
    public GuardExceptionInitializerType Exceptions { get; set; } = GuardExceptionInitializerType.Default;
}

public enum GuardExceptionInitializerType
{
    Default,
    SystemOnly,
    GuardOnly
}
