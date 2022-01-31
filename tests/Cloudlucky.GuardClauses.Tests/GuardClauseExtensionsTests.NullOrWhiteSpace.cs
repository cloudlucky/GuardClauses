namespace Cloudlucky.GuardClauses.Tests;

public class GuardClauseExtensions_NullOrWhiteSpaceTests
{
    [Fact]
    public void Test_null_or_white_space()
    {
        Guard.Against.NotNullOrWhiteSpace("  ");
        Guard.Against.NotNullOrWhiteSpace(string.Empty);
        Guard.Against.NotNullOrWhiteSpace(null);

        Assert.True(true);
    }

    [Fact]
    public void Test_not_null_or_white_space()
    {
        var param = "test";

        Guard.Against.NullOrWhiteSpace(param);

        Assert.True(true);
    }

    [Fact]
    public void Test_null()
    {
        string? param = default;

        Assert.Throws<ArgumentNullException>(() => Guard.Against.NullOrWhiteSpace(param));
    }

    [Fact]
    public void Test_empty()
    {
        var param = string.Empty;

        Assert.Throws<EmptyException>(() => Guard.Against.NullOrWhiteSpace(param));
    }

    [Fact]
    public void Test_white_space()
    {
        var param = "     ";

        Assert.Throws<EmptyException>(() => Guard.Against.NullOrWhiteSpace(param));
    }
}
