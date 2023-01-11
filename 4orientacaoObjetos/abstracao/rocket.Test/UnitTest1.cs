using Xunit;
using FluentAssertions;

namespace rocket.Test;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var trybeRocket = new Rocket();
        trybeRocket.Should().NotBeNull();
        trybeRocket.Should().BeOfType<Rocket>();
    }
}

public class UnitTest2
{
    [Fact]
    public void Test2()
    {
        var trybeRocket = new Rocket("Trybe I", "Brasil", 100000);
        trybeRocket.Name.Should().Be("Trybe I");
        trybeRocket.Country.Should().Be("Brasil");
        trybeRocket.Speed.Should().Be(100000);
    }
}