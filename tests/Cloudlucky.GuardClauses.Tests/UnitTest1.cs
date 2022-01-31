using Cloudlucky.GuardClauses.Runtime.CompilerServices;
using System.Runtime.CompilerServices;

namespace Cloudlucky.GuardClauses.Tests;

[CollectionDefinition("NoParallelization", DisableParallelization = true)]
public class NoParallelizationCollection { }

[Collection("NoParallelization")]
public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        //string? s = default;
        //Assert.Throws<ArgumentNullException>(() => Guard.Against.Null(s));

        //Assert.Throws<Exception>(() => Guard.When(() => true).Throw(() => new Exception()));

        //var i = (int?)null;
        //Assert.Throws<ArgumentNullException>(() => Guard.Against.Null(i));

        //Guard.Against.ArgumentNull(s, "message");
        //Guard.Against.ArgumentNull(s, "message", "patate");
    }

    [Fact]
    public void Test2()
    {
        Guard.Initialize(new() {  Exceptions = GuardExceptionInitializerType.SystemOnly });

        string? s = default;
        Assert.Throws<ArgumentNullException>(() => Guard.Against.Null(s));

        var s2 = string.Empty;
        Assert.Throws<ArgumentException>(() => Guard.Against.NullOrEmpty(s2));

        Assert.Throws<Exception>(() => Guard.Against.ToBe(() => true == false).OtherwiseThrow(() => new Exception()));

        var i = (int?)null;
        Assert.Throws<ArgumentNullException>(() => Guard.Against.Null(i));

        //Guard.Against.ArgumentNull(s, "message");
        //Guard.Against.ArgumentNull(s, "message", "patate");

        Guard.Initialize(new() { Exceptions = GuardExceptionInitializerType.Default });
    }
}
