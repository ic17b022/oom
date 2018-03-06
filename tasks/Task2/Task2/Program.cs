using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human1 = new Human(182, "Hans", "Gruber", 85);
            Human human2 = new Human(160, "Hanna", "Gruber", 50);

            Console.WriteLine(human1.ToString());

            Console.WriteLine("human2 before change: {0}", human2.ToString());
            human2.updateSize(162);
            Console.WriteLine("human2 after change: {0}", human2.ToString());

        }
    }
}
