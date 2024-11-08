namespace StarWarsPlanetsStats.Data
{
    public static class PlanetDataManipulator
    {

        // Find min planet in root object by property
        public static Tuple<string, string> GetMinInProperty(IEnumerable<Planet> planets, string property, Func<Planet,long?> getProperty)
        {
            Planet minPlanet = planets
                                .MinBy(getProperty);
            return new Tuple<string, string> (minPlanet.Name, getProperty(minPlanet).ToString());
        }
        // Find max planet in root object by property
        public static Tuple<string, string> GetMaxInProperty(IEnumerable<Planet> planets, string property, Func<Planet,long?> getProperty)
        {
            Planet maxPlanet = planets
                                .MaxBy(getProperty);
            return new Tuple<string, string> (maxPlanet.Name, getProperty(maxPlanet).ToString());
        } 
    }
}