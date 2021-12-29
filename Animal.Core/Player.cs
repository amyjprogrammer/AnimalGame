using System;
using System.Collections.Generic;
using System.Text;

namespace Animal.Core
{
    public class Player : Animal
    {
        public Player(int x, int y, int health) : base(health)
        {
            X = x;
            Y = y;
        }

        public int X { get; set; }
        public int Y { get; set; }
    }
}
