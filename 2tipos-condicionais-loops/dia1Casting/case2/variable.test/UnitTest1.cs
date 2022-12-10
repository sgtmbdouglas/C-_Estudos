using Xunit;
using FluentAssertions;

namespace variable.Test;

public class UnitTest1
{
    [Fact]
    public void TestVariableConversion()
    {
        Class1 instance = new();

        instance.intEntry.Should().Be(42);
        var intTypeCheck = instance.intEntry is int;
        intTypeCheck.Should().Be(true);

        instance.Transform();

        instance.doubleResponse.Should().Be(42.0);
        var floatTypeCheck = instance.doubleResponse is double;
        floatTypeCheck.Should().Be(true);
    }
}