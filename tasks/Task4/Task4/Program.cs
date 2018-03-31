using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Human[] humans = new Human[]
            {
                new Human(178, "Hans", "Huber", 80),
                new Human(165, "Hanna", "Huber", 50)
            };

            JsonSerializerSettings settings = new JsonSerializerSettings();
            settings.TypeNameHandling = TypeNameHandling.All;

            using (System.IO.StreamWriter streamWriter = System.IO.File.AppendText("jsonFile.json"))
            {
                
                streamWriter.Write(JsonConvert.SerializeObject(humans, Formatting.Indented, settings));
                streamWriter.Flush();
                
            }

            string json = System.IO.File.ReadAllText("jsonFile.json");

            Human[] readHumans = JsonConvert.DeserializeObject<Human[]>(json);

            Console.WriteLine(json);
        }
    }
}
