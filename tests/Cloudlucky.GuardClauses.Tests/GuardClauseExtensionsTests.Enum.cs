namespace Cloudlucky.GuardClauses.Tests;

public class GuardClauseExtensions_EnumTests
{
    [Fact]
    public void Test_valid_values()
    {
        Guard.Against.OutOfRange(SByteEnum.Item1);
        Guard.Against.OutOfRange(SByteEnum.Item1, $"{SByteEnum.Item1}");
        Guard.Against.OutOfRange(ByteEnum.Item1);
        Guard.Against.OutOfRange(ByteEnum.Item1, $"{ByteEnum.Item1}");
        Guard.Against.OutOfRange(Int16Enum.Item1);
        Guard.Against.OutOfRange(Int16Enum.Item1, $"{Int16Enum.Item1}");
        Guard.Against.OutOfRange(UInt16Enum.Item1);
        Guard.Against.OutOfRange(UInt16Enum.Item1, $"{UInt16Enum.Item1}");
        Guard.Against.OutOfRange(Int32Enum.Item1);
        Guard.Against.OutOfRange(Int32Enum.Item1, $"{Int32Enum.Item1}");
        Guard.Against.OutOfRange(UInt32Enum.Item1);
        Guard.Against.OutOfRange(UInt32Enum.Item1, $"{UInt32Enum.Item1}");
        Guard.Against.OutOfRange(Int64Enum.Item1);
        Guard.Against.OutOfRange(Int64Enum.Item1, $"{Int64Enum.Item1}");
        Guard.Against.OutOfRange(UInt64Enum.Item1);
        Guard.Against.OutOfRange(UInt64Enum.Item1, $"{UInt64Enum.Item1}");
        Guard.Against.OutOfRange(FlagEnum.Small1);
        Guard.Against.OutOfRange(FlagEnum.Small1, $"{FlagEnum.Small1}");
        Guard.Against.OutOfRange(FlagEnum.Small1 | FlagEnum.Small2, $"{FlagEnum.Small1 | FlagEnum.Small2}");
        Guard.Against.OutOfRange(FlagEnum.Big1 | FlagEnum.Big2, $"{FlagEnum.Big1 | FlagEnum.Big2}");
        Guard.Against.OutOfRange(FlagEnum.Small1 | FlagEnum.Big1, $"{FlagEnum.Small1 | FlagEnum.Big1}");

        Assert.True(true);
    }

    [Fact]
    public void Test_invalid_values()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => Guard.Against.OutOfRange((SByteEnum)8));
        Assert.Throws<ArgumentOutOfRangeException>(() => Guard.Against.OutOfRange((SByteEnum)8, $"{(SByteEnum)8}"));
        Assert.Throws<ArgumentOutOfRangeException>(() => Guard.Against.OutOfRange((ByteEnum)8));
        Assert.Throws<ArgumentOutOfRangeException>(() => Guard.Against.OutOfRange((ByteEnum)8, $"{(ByteEnum)8}"));
        Assert.Throws<ArgumentOutOfRangeException>(() => Guard.Against.OutOfRange((Int16Enum)8));
        Assert.Throws<ArgumentOutOfRangeException>(() => Guard.Against.OutOfRange((Int16Enum)8, $"{(Int16Enum)8}"));
        Assert.Throws<ArgumentOutOfRangeException>(() => Guard.Against.OutOfRange((UInt16Enum)8));
        Assert.Throws<ArgumentOutOfRangeException>(() => Guard.Against.OutOfRange((UInt16Enum)8, $"{(UInt16Enum)8}"));
        Assert.Throws<ArgumentOutOfRangeException>(() => Guard.Against.OutOfRange((Int32Enum)8));
        Assert.Throws<ArgumentOutOfRangeException>(() => Guard.Against.OutOfRange((Int32Enum)8, $"{(Int32Enum)8}"));
        Assert.Throws<ArgumentOutOfRangeException>(() => Guard.Against.OutOfRange((UInt32Enum)8));
        Assert.Throws<ArgumentOutOfRangeException>(() => Guard.Against.OutOfRange((UInt32Enum)8, $"{(UInt32Enum)8}"));
        Assert.Throws<ArgumentOutOfRangeException>(() => Guard.Against.OutOfRange((Int64Enum)8));
        Assert.Throws<ArgumentOutOfRangeException>(() => Guard.Against.OutOfRange((Int64Enum)8, $"{(Int64Enum)8}"));
        Assert.Throws<ArgumentOutOfRangeException>(() => Guard.Against.OutOfRange((UInt64Enum)8));
        Assert.Throws<ArgumentOutOfRangeException>(() => Guard.Against.OutOfRange((UInt64Enum)8, $"{(UInt64Enum)8}"));
        Assert.Throws<ArgumentOutOfRangeException>(() => Guard.Against.OutOfRange((FlagEnum)(-1)));
        Assert.Throws<ArgumentOutOfRangeException>(() => Guard.Against.OutOfRange((FlagEnum)(-1), $"{(FlagEnum)(-1)}"));
    }

    private enum SByteEnum : sbyte
    {
        Item1 = -1,
        Item2,
        Item3
    }

    private enum ByteEnum : byte
    {
        Item1,
        Item2,
        Item3
    }

    private enum Int16Enum : short
    {
        Item1 = -1,
        Item2,
        Item3
    }

    private enum UInt16Enum : ushort
    {
        Item1,
        Item2,
        Item3
    }

    private enum Int32Enum : int
    {
        Item1 = -1,
        Item2,
        Item3
    }

    private enum UInt32Enum : uint
    {
        Item1,
        Item2,
        Item3
    }

    private enum Int64Enum : long
    {
        Item1 = -1,
        Item2,
        Item3
    }

    private enum UInt64Enum : ulong
    {
        Item1,
        Item2,
        Item3
    }

    [Flags]
    private enum FlagEnum
    {
        Zero = 0,

        Small1 = 1 << 0,
        Small2 = 1 << 1,
        Small3 = 1 << 2,
        AllSmallValues = Small1 | Small2 | Small3,

        Big1 = 1 << 10,
        Big2 = 1 << 11,
        Big3 = 1 << 12,
        AllBigValues = Big1 | Big2 | Big3
    }
}
