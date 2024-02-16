namespace DevStream.Tasks.Task1;

public abstract class Vehicle
{
    public int MaxSpeed { get; set; }
    public string Color { get;  set;}
    public int SeatsCount { get;  set; }
    public Vehicle(int maxSpeed, string color, int seatsCount)
    {
        MaxSpeed = maxSpeed;
        Color = color;
        SeatsCount = seatsCount;
    }
    
    //Only for unit tests
    public Vehicle(){}
}