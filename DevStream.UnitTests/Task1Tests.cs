using DevStream.Tasks.Task1;
using DevStream.Tasks.Task2;
using FluentAssertions;

namespace DevStream.UnitTests;

public class Task1Tests
{
    [Fact]
    public void BoatProperties_MustNot_BeDefault()
    {
        //Arrange & Act
        var boat = new Boat();
        
        //Assert
        boat.Material.Should().NotBe(null);
        boat.MaxSpeed.Should().NotBe(default);
        boat.Color.Should().NotBe(default);
        boat.SeatsCount.Should().NotBe(default);
    }
    
    [Fact]
    public void CarProperties_MustNot_BeDefault()
    {
        //Arrange & Act
        var boat = new Car();
        
        //Assert
        boat.Type.Should().NotBe(null);
        boat.MaxSpeed.Should().NotBe(default);
        boat.DoorsCount.Should().NotBe(default);
        boat.Color.Should().NotBe(default);
        boat.SeatsCount.Should().NotBe(default);
    }
    
    [Fact]
    public void MotorcycleProperties_MustNot_BeDefault()
    {
        //Arrange & Act
        var boat = new Motorcycle();
        
        //Assert
        boat.Step.Should().NotBe(null);
        boat.MaxSpeed.Should().NotBe(default);
        boat.Color.Should().NotBe(default);
        boat.SeatsCount.Should().NotBe(default);
    }
    
    [Fact]
    public void HelicopterProperties_MustNot_BeDefault()
    {
        //Arrange & Act
        var boat = new Helicopter();
        
        //Assert
        boat.MaxHeight.Should().NotBe(default);
        boat.MaxSpeed.Should().NotBe(default);
        boat.Color.Should().NotBe(default);
        boat.SeatsCount.Should().NotBe(default);
    }
}