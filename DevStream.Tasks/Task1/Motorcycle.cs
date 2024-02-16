namespace DevStream.Tasks.Task1;

public partial class Motorcycle : Vehicle
{
    public StepType? Step { get;  private set; }
    
    public Motorcycle() : base(350, "Blue", 1)
    {
        Step = StepType.Central;
    }
    
}

public enum StepType
{
    Central, Back
}

