using System.Text.Json;
using DevStream.Tasks.Task1;
using DevStream.Tasks.Task2;

namespace DevStream.Tasks.Task3;

public class Program
{
    public static Vehicle[] Instances;
   
    static Program()
    {
        Instances = InstanceService.GetInstances()
            .OrderBy(x => x.GetType().Name)
            .ToArray();
    }
    
    static async Task Main(string[] args)
    {
        PrintVehicles();
        PrintSearchedTypes();
        await WriteToDisk();
    }

    public static IEnumerable<Type> SearchTypeByPart(string part) 
        =>  Instances
            .Where(x => x.GetType().Name.ToLower().Contains(part.ToLower()))
            .Select( x => x.GetType());

    public static async Task WriteToDisk()
    {
        var json = JsonSerializer.Serialize(Instances);
        var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "result.json");
        await File.WriteAllTextAsync(path, json);
    }

    public static void PrintVehicles()
    {
        Console.WriteLine("Names of vehicles");
        foreach (var instance in Instances)
        {
            Console.WriteLine(instance.GetType().Name);
        }
    }
    
    public static void PrintSearchedTypes()
    {
        var input = "bo";
        var types = SearchTypeByPart(input);
        
        Console.WriteLine("\nRealization example of types search by part");
        foreach (var type in types)
        {
            Console.WriteLine(type.Name);
        }
    }
}