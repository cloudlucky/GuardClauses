using Cloudlucky.GuardClauses.Exceptions;

namespace Cloudlucky.GuardClauses;

public static partial class GuardClauseExtensions
{
    // TODO not sure to keep as it's slow
    public static GuardCondition ToBe(this IGuardClause guard, GuardCondition condition) => condition;
}

internal class OptionsInitializer : IGuardOptionsInitializer
{
    public void Initialize(GuardOptionsInitializerConfiguration configuration)
    {
        GreaterThanOptions.SetDefault(configuration);
        NotGreaterThanOptions.SetDefault(configuration);

        GreaterThanOrEqualToOptions.SetDefault(configuration);
        NotGreaterThanOrEqualToOptions.SetDefault(configuration);

        InRangeOptions.SetDefault(configuration);
        OutOfRangeOptions.SetDefault(configuration);

        LessThanOptions.SetDefault(configuration);
        NotLessThanOptions.SetDefault(configuration);

        LessThanOrEqualToOptions.SetDefault(configuration);
        NotLessThanOrEqualToOptions.SetDefault(configuration);

        ZeroOptions.SetDefault(configuration);
        NotZeroOptions.SetDefault(configuration);

        DefaultOptions.SetDefault(configuration);
        NotDefaultOptions.SetDefault(configuration);

        EmptyOptions.SetDefault(configuration);
        NotEmptyOptions.SetDefault(configuration);
        
        ValidEnumValueOptions.SetDefault(configuration);
        InvalidEnumValueOptions.SetDefault(configuration);

        FoundOptions.SetDefault(configuration);
        NotFoundOptions.SetDefault(configuration);
        
        NullOptions.SetDefault(configuration);
        NotNullOptions.SetDefault(configuration);
        
        NullOrEmptyOptions.SetDefault(configuration);
        NotNullOrEmptyOptions.SetDefault(configuration);
        
        NullOrWhiteSpaceOptions.SetDefault(configuration);
        NotNullOrWhiteSpaceOptions.SetDefault(configuration);
    }
}
