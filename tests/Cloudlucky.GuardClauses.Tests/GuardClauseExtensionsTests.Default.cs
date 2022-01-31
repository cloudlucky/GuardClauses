namespace Cloudlucky.GuardClauses.Tests;

public class GuardClauseExtensions_NotDefaultTests
{
    [Fact]
    public void Test_not_default_values()
    {
        Guard.Against.Default("Test");
        Guard.Against.Default("Test", message: $"Test {1}");
        Guard.Against.Default(1);
        Guard.Against.Default(1, $"Test {1}");

        Assert.True(true);
    }

    [Fact]
    public void Test_default_reference_type()
    {
        string? param = default;
        var param2 = "patate";
        var param2Default = "patate";
        Assert.Throws<DefaultException>(() => Guard.Against.Default(param));
        Assert.Throws<DefaultException>(() => Guard.Against.Default(param2, defaultValue: param2Default));
        Assert.Throws<DefaultException>(() => Guard.Against.Default(param, message: $"The param {param} is default"));
        Assert.Throws<DefaultException>(() => Guard.Against.Default(param2, param2Default, $"The param {param2} is default with {param2Default}"));
    }

    [Fact]
    public void Test_default_nullable_value_type()
    {
        int? param = default;

        Assert.Throws<DefaultException>(() => Guard.Against.Default(param));
    }

    [Fact]
    public void Test_default_value_type()
    {
        int param = default;

        Assert.Throws<DefaultException>(() => Guard.Against.Default(param));
    }
}
