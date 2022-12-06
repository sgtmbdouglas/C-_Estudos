using Xunit;
using FluentAssertions;

namespace variable.test;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Class1 instance = new();
        var response = instance.someString is string;
        response.Should().Be(true);
    }
}