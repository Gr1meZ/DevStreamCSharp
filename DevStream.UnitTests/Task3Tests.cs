using System.Text;
using System.Text.Json;
using DevStream.Tasks.Task1;
using FluentAssertions;
using Program = DevStream.Tasks.Task3.Program;

namespace DevStream.UnitTests;

public class Task3Tests
{
    [Theory]
    [InlineData("moto", new[]{"Motorcycle"})]
    [InlineData("bo", new[]{"Boat"})]
    [InlineData("copter", new[]{"Helicopter"})]
    [InlineData("a", new[]{"Car", "Boat"})]
    public void SearchTypeByPart_Must_ReturnTypes(string part, string[] expectedResults)
    {
        //Act
        var searchedTypes = Program.SearchTypeByPart(part).Select(x => x.Name);
        //Assert
        searchedTypes.Should().NotBeEmpty();
        searchedTypes.Should().BeEquivalentTo(expectedResults);
    }

    [Fact]
    public async Task WriteToDisk_Must_BeCompleted()
    {
        //Act
        await Program.WriteToDisk();
        
        //Assert
        var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "result.json");
        var result = await File.ReadAllTextAsync(path, Encoding.UTF8);
        var vehicles = JsonSerializer.Deserialize<VehicleDto[]>(result);

        vehicles.Should().NotBeEmpty();
        vehicles.Should().BeEquivalentTo(Program.Instances);
    }

}