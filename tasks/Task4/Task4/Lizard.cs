using System;

namespace Task4
{
    class Lizard : ICreature
    {
        private int Size;
        public decimal Weight { get; set; }

        public Lizard(int size, decimal weight)
        {
            Size = size;
            Weight = weight;
        }

        public void updateSize(int size)
        {
            if (size >= Size)
                Size = size;
            else
                throw new ArgumentOutOfRangeException("Lizards don't shrink in this abstraction! Your size " + size.ToString() + " is smaller than current size " + Size.ToString());
        }
        public int getSize()
        {
            return Size;
        }

        public bool isWarmblooded()
        {
            return false;
        }

        override public string ToString()
        {
            return String.Format("{0}, {1}, {2}", Size.ToString(), Weight.ToString(), isWarmblooded().ToString());
        }
    }
}
