using System;
using System.IO;
using Newtonsoft.Json;

namespace CodeCourseWeek5
{
    class Program
    {
        // dotnet add package Newtonsoft.Json
        // dotnet restore

        const string ShipFile = "Ship.json";

        static void Main(string[] args)
        {
            Ship ship = null;

            if (File.Exists(ShipFile))
            {
                var fileText = File.ReadAllText(ShipFile);
                ship = JsonConvert.DeserializeObject<Ship>(fileText);
            }
            else
            {
                ship = new Ship(1);
            }

            var random = new Random();

            var container = new Container(random.Next());
            container.lastUpdated = DateTime.UtcNow;

            ship.AddContainer(container);

            Console.WriteLine($"The ship #{ship.id} has {ship.containers.Count} container(s).");

            var text = JsonConvert.SerializeObject(ship, Formatting.Indented);

            File.WriteAllText(ShipFile, text);
        }
    }
}
