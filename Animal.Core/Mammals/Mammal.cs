using System;
using System.Collections.Generic;
using System.Text;

namespace Animal.Core.Mammals
{
    public abstract class Mammal : Animal
    {
        public Mammal(int health, string name) : base(health)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}
