namespace Cloudlucky.GuardClauses.Tests;

public class GuardClauseExtensions_NotNullTests
{
    [Theory]
    [InlineData(1)]
    [InlineData("Test")]
    public void Test_not_null_values<T>(T param)
    {
        Guard.Against.Null(param);
        Guard.Against.Null(System.Guid.NewGuid());

        Assert.True(true);
    }

    [Fact]
    public void Test_null_reference_type()
    {
        string? param = default;

        Assert.Throws<ArgumentNullException>(() => Guard.Against.Null(param));
    }

    [Fact]
    public void Test_null_value_type()
    {
        int? param = default;

        Assert.Throws<ArgumentNullException>(() => Guard.Against.Null(param));
    }
}
