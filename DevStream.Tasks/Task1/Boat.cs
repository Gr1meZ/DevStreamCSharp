namespace DevStream.Tasks.Task1;

public class Boat : Vehicle
{
    public MaterialType? Material { get;  set; }
    
    public Boat() : base(100, "White", 2)
    {
        Material = MaterialType.Gum;
    }
}

public enum MaterialType
{
   Gum, Metal
}