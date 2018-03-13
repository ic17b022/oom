using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreature[] creatures = new ICreature[]
            {
                new Human(178, "Hans", "Huber", 80),
                new Lizard(15, 0.2M),
            };
   
            foreach(ICreature x in creatures){
                Console.WriteLine(x.ToString());
            }
        }
    }
}
