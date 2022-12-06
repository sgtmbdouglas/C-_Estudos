using Xunit;
using FluentAssertions;

namespace variable.Test;

public class UnitTest1
{
    [Fact]
    public void TestVariableConversion()
    {
        Class1 instance = new();

        instance.strEntry.Should().Be("42");
        var strTypeCheck = instance.strEntry is string;
        strTypeCheck.Should().Be(true);

        instance.DoConversion();

        instance.intResponse.Should().Be(42);
        var intTypeCheck = instance.intResponse is int;
        intTypeCheck.Should().Be(true);
    }
}