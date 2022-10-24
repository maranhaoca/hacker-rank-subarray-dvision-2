using Xunit;
using Src;
using System.Collections.Generic;

namespace Tests;

public class ResultTest
{
    [Fact]
    public void Test1()
    {
        var s = new List<int>(){2, 2, 1, 3, 2};
        var d = 4;
        var m = 2;

        var expected = 2;

        var actual = Result.birthday(s, d, m);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test2()
    {
        var s = new List<int>(){4};
        var d = 4;
        var m = 1;

        var expected = 1;

        var actual = Result.birthday(s, d, m);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test3()
    {
        var s = new List<int>(){2, 5, 1, 3, 4, 4, 3, 5, 1, 1, 2, 1, 4, 1, 3, 3, 4, 2, 1};
        var d = 18;
        var m = 7;

        var expected = 3;

        var actual = Result.birthday(s, d, m);

        Assert.Equal(expected, actual);
    }
}