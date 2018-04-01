using Newtonsoft.Json;
using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreature[] creatures = new ICreature[]
            {
                new Human(178, "Hans", "Huber", 80),
                new Human(165, "Hanna", "Huber", 50),
                new Lizard(10, 0.1M),
                new Lizard(15, 0.2M)
            };

            JsonSerializerSettings settings = new JsonSerializerSettings();
            settings.TypeNameHandling = TypeNameHandling.Auto;
            settings.Formatting = Formatting.Indented;

            using (System.IO.StreamWriter streamWriter = new System.IO.StreamWriter(System.IO.File.Open("jsonFile.json", System.IO.FileMode.Create)))
            {
                
                streamWriter.Write(JsonConvert.SerializeObject(creatures, settings));
                streamWriter.Flush();
                
            }

            string json = System.IO.File.ReadAllText("jsonFile.json");

            ICreature[] readCreatures = JsonConvert.DeserializeObject<ICreature[]>(json, settings);

            Console.WriteLine(json);
        }
    }
}
