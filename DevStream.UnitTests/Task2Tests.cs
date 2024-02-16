using System.Reflection;
using DevStream.Tasks.Task1;
using DevStream.Tasks.Task2;
using FluentAssertions;

namespace DevStream.UnitTests;

public class Task2Tests
{
    [Fact]
    public void Instances_MustNot_BeEmpty()
    {
        //Arrange 
        var typesCount = Assembly
            .GetAssembly(typeof(Vehicle))!
            .GetTypes()
            .Count(type => type.IsSubclassOf(typeof(Vehicle)));
        
        // Act
        var instances = InstanceService.GetInstances();

        //Assert
        instances.Should().NotBeEmpty();
        instances.Should().HaveCount(typesCount);
    }
}