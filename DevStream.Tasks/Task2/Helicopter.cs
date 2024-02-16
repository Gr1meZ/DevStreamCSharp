using DevStream.Tasks.Task1;

namespace DevStream.Tasks.Task2;

public partial class Helicopter : Vehicle
{
    public int MaxHeight { get;  set; }
    
    public Helicopter() : base(400, "Black", 6)
    {
        MaxHeight = 1000;
    }
}

