using Xunit;
using FluentAssertions;

namespace car.Test;

public class CarTest
{
    [Fact]
    public void ShouldBeAbleToConvertTopSpeed()
    {
        var car = new Car();
        car.TopSpeed = 100;

        car.TopSpeed.Should().Be(100);
        car.TopSpeedMph.Should().BeApproximately(62.13, 0.1);
    }

    // [Fact]
    // public void HasKphToMphStaticMethod()
    // {
    //     var car = new Car();
    //     car.KphToMph(100).Should().BeApproximately(62.13, 0.1);
    // }
}