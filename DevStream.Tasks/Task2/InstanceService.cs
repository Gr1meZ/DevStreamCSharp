using System.Reflection;
using DevStream.Tasks.Task1;

namespace DevStream.Tasks.Task2;

public class InstanceService
{
    public static IEnumerable<Vehicle> GetInstances()
    {
        var types = Assembly.GetExecutingAssembly()
            .GetTypes()
            .Where(type => type.IsSubclassOf(typeof(Vehicle)));

        foreach (var type in types)
        {
            yield return (Vehicle)Activator.CreateInstance(type)!;
        }
    }
}