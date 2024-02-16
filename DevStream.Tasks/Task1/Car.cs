namespace DevStream.Tasks.Task1;

public class Car : Vehicle
{
    public int DoorsCount { get;  set; }
    public CarType? Type { get;  set; }
    
    public Car() : base(300, "Black", 4)
    {
        DoorsCount = 4;
        Type = CarType.Sedan;
    }
    
    
}

public enum CarType {
    Sedan,
    Universal,
    Hatchback
}
