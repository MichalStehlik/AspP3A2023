using ASP05GameStructure.Models;

namespace ASP05GameStructure.Services
{
    public class LocationService
    {
        public LocationService()
        {
            Locations = new Dictionary<int, Location> {
                { 0, new Location { Name="Vchod", Description = "<p>Jsi u vchodu do podzemí.</p>", ImagePath="entrance.jpg"} },
                { 1, new Location { Name="Chodba", Description = "<p>Vešel jsi dovnitř, je tu tma.</p>"} },
                { 2, new Location { Name="Levá místnost",Description = "<p>Místnost je velmi zašlá.</p>"}},
                { 3, new Location { Name="Pravá místnost", Description = "<p>V místnosti je netopýr.</p>"} }
            };
            Connections = new List<Connection>
            {
                new Connection { From = 0, To = 1, Description = "Jdi dovnitř." },
                new Connection { From = 1, To = 0, Description = "Jdi ven." },
                new Connection { From = 1, To = 2, Description = "Jdi doprava." },
                new Connection { From = 2, To = 1, Description = "Jdi zpět." },
                new Connection { From = 1, To = 3, Description = "Jdi doleva." },
                new Connection { From = 3, To = 1, Description = "Jdi zpět." }
            };  
        }

        public Dictionary<int, Location> Locations { get; private set; }
        public List<Connection> Connections { get; private set; }
        public Location? GetLocation(int id)
        {
            return Locations.GetValueOrDefault(id);
        }
        public List<Connection> GetConnections(int id)
        {
            return Connections.Where(c => c.From == id).ToList();
        }
    }
}
