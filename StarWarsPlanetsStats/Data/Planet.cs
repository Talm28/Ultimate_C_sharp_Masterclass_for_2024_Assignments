
namespace StarWarsPlanetsStats.Data;

public record struct Planet
{
    public string Name { get; }
    public int Diameter { get; }
    public int? SurfaceWater { get; }
    public long? Population { get; }

    public Planet (string name, int diameter, int? surfaceWater, long? population)
    {
        if(name == null)
            throw new ArgumentNullException ("Name cannot be null.");
        Name = name;
        Diameter = diameter;
        SurfaceWater = surfaceWater;
        Population = population;
    } 
}