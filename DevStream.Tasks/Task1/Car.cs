namespace DevStream.Tasks.Task1;

public partial class Car : Vehicle
{
    public int DoorsCount { get; private set; }
    public CarType? Type { get;  private set; }
    
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

