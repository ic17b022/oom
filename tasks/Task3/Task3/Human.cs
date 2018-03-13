using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Human : ICreature
    {
        private int Size;
        public string FirstName { get; }
        public string LastName { get; set; }
        public int Weight { get; set; }

        public Human(int size, string firstName, string lastName, int weight)
        {
            Size = size;
            FirstName = firstName;
            LastName = lastName;
            Weight = weight;
        }

        public void updateSize(int size)
        {
            if (size >= Size)
                Size = size;
            else
                throw new ArgumentOutOfRangeException("Humans don't shrink in this abstraction! Your size " + size.ToString() + " is smaller than current size " + Size.ToString());
        }

        override public string ToString()
        {
            return String.Format("{0}, {1}, {2}, {3}, {4}", Size.ToString(), FirstName, LastName, Weight.ToString(), isWarmblooded());
        }

        public bool isWarmblooded()
        {
            return true;
        }
    }
}
