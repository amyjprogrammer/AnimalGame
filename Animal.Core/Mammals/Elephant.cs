using Interfaces.Game;
using System;
using System.Collections.Generic;
using System.Text;

namespace Animal.Core.Mammals
{
    public class Elephant : Mammal, IReach
    {
        public Elephant(int health, string name) : base(50, "Elephant")
        {
        }

        public bool InRange { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
