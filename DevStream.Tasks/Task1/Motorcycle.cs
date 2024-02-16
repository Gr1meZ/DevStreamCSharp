namespace DevStream.Tasks.Task1;

public class Motorcycle : Vehicle
{
    public StepType? Step { get;  set; }
    
    public Motorcycle() : base(350, "Blue", 1)
    {
        Step = StepType.Central;
    }
    
}

public enum StepType
{
    Central, Back
}