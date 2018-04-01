using System;

namespace Task4
{
    class Human : ICreature
    {
        public int Size { get; private set; }
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
