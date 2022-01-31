namespace Cloudlucky.GuardClauses.Tests;

public class GuardClauseExtensions_NotFoundTests
{
    [Theory]
    [InlineData(1)]
    [InlineData("Test")]
    public void Test_found_values<T>(T param)
    {
        Guard.Against.NotFound(param);

        Assert.True(true);
    }

    [Fact]
    public void Test_not_found_reference_type()
    {
        string? param = default;

        Assert.Throws<NotFoundException>(() => Guard.Against.NotFound(param));
    }

    [Fact]
    public void Test_not_found_value_type()
    {
        int? param = default;

        Assert.Throws<NotFoundException>(() => Guard.Against.NotFound(param));
        Assert.Throws<NotFoundException>(() => Guard.Against.NotFound(default(int)));
    }
}
