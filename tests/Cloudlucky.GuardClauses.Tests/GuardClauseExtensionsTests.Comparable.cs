namespace Cloudlucky.GuardClauses.Tests;

public class GuardClauseExtensions_ComparableTests
{
    [Fact]
    public void Test_out_of_range()
    {
        Guard.Against.OutOfRange(0, 0, 0);
        Guard.Against.OutOfRange(0, 0, 0, (x, y) => x.CompareTo(y));
        Guard.Against.OutOfRange(0, Range.FromInclusive(0).ToInclusive(0));
        Guard.Against.OutOfRange(0, 0, 1);
        Guard.Against.OutOfRange(0, 0, 1, (x, y) => x.CompareTo(y));
        Guard.Against.OutOfRange(0, Range.FromInclusive(0).ToInclusive(1));
        Guard.Against.OutOfRange(0, -1, 0);
        Guard.Against.OutOfRange(0, -1, 0, (x, y) => x.CompareTo(y));
        Guard.Against.OutOfRange(0, Range.FromInclusive(-1).ToInclusive(0));
        Guard.Against.OutOfRange(0, -1, 1);
        Guard.Against.OutOfRange(0, -1, 1, (x, y) => x.CompareTo(y));
        Guard.Against.OutOfRange(0, Range.FromInclusive(-1).ToInclusive(1));

        Guard.Against.OutOfRange(0, 0, 1, RangeLimit.FromInclusiveToExclusive);
        Assert.Throws<ArgumentOutOfRangeException>(() => Guard.Against.OutOfRange(1, 0, 1, RangeLimit.FromInclusiveToExclusive));
        Guard.Against.OutOfRange(1, 0, 1, RangeLimit.FromExclusiveToInclusive);
        Assert.Throws<ArgumentOutOfRangeException>(() => Guard.Against.OutOfRange(0, 0, 1, RangeLimit.FromExclusiveToInclusive));

        Assert.True(true);
    }

    [Fact]
    public void Test_in_range()
    {
        Guard.Against.InRange(0, 1, 2);
        Guard.Against.InRange(0, 1, 2, (x, y) => x.CompareTo(y));
        Guard.Against.InRange(0, Range.FromInclusive(1).ToInclusive(2));

        Assert.True(true);
    }

    [Fact]
    public void Test_less_than()
    {
        Guard.Against.LessThan(1, 0);

        Assert.True(true);
    }

    [Fact]
    public void Test_less_than_zero()
    {
        Guard.Against.LessThanZero(0);

        Assert.True(true);
    }

    [Fact]
    public void Test_not_less_than()
    {
        Guard.Against.NotLessThan(0, 1);

        Assert.True(true);
    }

    [Fact]
    public void Test_not_less_than_zero()
    {
        Guard.Against.NotLessThanZero(-1);

        Assert.True(true);
    }

    [Fact]
    public void Test_less_than_or_equal_to()
    {
        Guard.Against.LessThanOrEqualTo(1, 0);

        Assert.True(true);
    }

    [Fact]
    public void Test_less_than_or_equal_to_zero()
    {
        Guard.Against.LessThanOrEqualToZero(1);

        Assert.True(true);
    }

    [Fact]
    public void Test_Not_less_than_or_equal_to()
    {
        Guard.Against.NotLessThanOrEqualTo(0, 0);
        Guard.Against.NotLessThanOrEqualTo(-1, 0);

        Assert.True(true);
    }

    [Fact]
    public void Test_zero()
    {
        Guard.Against.Zero(1);
        Guard.Against.Zero(-1);

        Assert.True(true);
    }

    [Fact]
    public void Test_not_zero()
    {
        Guard.Against.NotZero(0);

        Assert.True(true);
    }

    [Fact]
    public void Test_not_less_than_or_equal_to_zero()
    {
        Guard.Against.NotLessThanOrEqualToZero(0);
        Guard.Against.NotLessThanOrEqualToZero(-1);

        Assert.True(true);
    }

    [Fact]
    public void Test_greater_than()
    {
        Guard.Against.GreaterThan(0, 1);

        Assert.True(true);
    }

    [Fact]
    public void Test_greater_than_zero()
    {
        Guard.Against.GreaterThanZero(-1);

        Assert.True(true);
    }

    [Fact]
    public void Test_not_greater_than()
    {
        Guard.Against.NotGreaterThan(2, 1);

        Assert.True(true);
    }

    [Fact]
    public void Test_not_greater_than_zero()
    {
        Guard.Against.NotGreaterThanZero(1);

        Assert.True(true);
    }

    [Fact]
    public void Test_greater_than_or_equal_to()
    {
        Guard.Against.GreaterThanOrEqualTo(-1, 0);

        Assert.True(true);
    }

    [Fact]
    public void Test_greater_than_or_equal_to_zero()
    {
        Guard.Against.GreaterThanOrEqualToZero(-1);

        Assert.True(true);
    }

    [Fact]
    public void Test_Not_greater_than_or_equal_to()
    {
        Guard.Against.NotGreaterThanOrEqualTo(1, 0);

        Assert.True(true);
    }

    [Fact]
    public void Test_not_greater_than_or_equal_to_zero()
    {
        Guard.Against.NotGreaterThanOrEqualToZero(1);

        Assert.True(true);
    }
}
