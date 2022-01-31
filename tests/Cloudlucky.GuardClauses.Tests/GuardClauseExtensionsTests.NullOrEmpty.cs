using System.Collections;

namespace Cloudlucky.GuardClauses.Tests;

public class GuardClauseExtensions_NotNullOrEmptyTests
{
    [Fact]
    public void Test_not_null_or_empty_string()
    {
        var param = "Test";

        Guard.Against.NullOrEmpty(param);

        Assert.True(true);
    }

    [Fact]
    public void Test_null_string()
    {
        string? param = default;

        Assert.Throws<ArgumentNullException>(() => Guard.Against.NullOrEmpty(param));
    }

    [Fact]
    public void Test_empty_string()
    {
        var param = string.Empty;

        Assert.Throws<EmptyException>(() => Guard.Against.NullOrEmpty(param));
    }

    [Fact]
    public void Test_not_null_or_empty_guid()
    {
        var param = Guid.NewGuid();

        Guard.Against.NullOrEmpty(param);

        Assert.True(true);
    }

    [Fact]
    public void Test_null_guid()
    {
        Guid? param = default;

        Assert.Throws<ArgumentNullException>(() => Guard.Against.NullOrEmpty(param));
    }

    [Fact]
    public void Test_empty_guid()
    {
        var param = Guid.Empty;

        Assert.Throws<EmptyException>(() => Guard.Against.NullOrEmpty(param));
    }

    [Fact]
    public void Test_not_null_or_empty_collection()
    {
        var param = new List<int> { 1 };

        Guard.Against.NullOrEmpty(param);
        Guard.Against.NullOrEmpty((IEnumerable<int>)param);
        Guard.Against.NullOrEmpty((IEnumerable?)param);

        var param2 = new[] { 1 };

        Guard.Against.NullOrEmpty(param2);

        Assert.True(true);
    }

    [Fact]
    public void Test_null_collection()
    {
        List<int>? nullCollection = default;

        Assert.Throws<ArgumentNullException>(() => Guard.Against.NullOrEmpty(nullCollection));
        Assert.Throws<ArgumentNullException>(() => Guard.Against.NullOrEmpty((IEnumerable<int>?)nullCollection));
        Assert.Throws<ArgumentNullException>(() => Guard.Against.NullOrEmpty((IEnumerable?)nullCollection));

        int[]? nullArray = default;

        Assert.Throws<ArgumentNullException>(() => Guard.Against.NullOrEmpty(nullArray));

        string? nullString = default;

        Assert.Throws<ArgumentNullException>(() => Guard.Against.NullOrEmpty(nullString));
    }

    [Fact]
    public void Test_empty_collection()
    {
        var emptyCollection = new List<int>();

        Assert.Throws<EmptyException>(() => Guard.Against.NullOrEmpty(emptyCollection));
        Assert.Throws<EmptyException>(() => Guard.Against.NullOrEmpty((IEnumerable<int>?)emptyCollection));
        Assert.Throws<EmptyException>(() => Guard.Against.NullOrEmpty((IEnumerable?)emptyCollection));

        var emptyArray = Array.Empty<int>();

        Assert.Throws<EmptyException>(() => Guard.Against.NullOrEmpty(emptyArray));

        var emptyString = string.Empty;

        Assert.Throws<EmptyException>(() => Guard.Against.NullOrEmpty(emptyArray));
    }
}
