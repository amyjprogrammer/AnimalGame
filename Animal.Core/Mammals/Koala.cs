using Interfaces.Game;
using System;
using System.Collections.Generic;
using System.Text;
using Utils;

namespace Animal.Core.Mammals
{
    class Koala : Mammal, IAdorable
    {
        public Koala(int health, string name) : base(30, "Koala")
        {
        }

        public void Stunning()
        {
            var stunned = RandomUtils.Percentage(3);
            Console.WriteLine($"Opponent stunned for {stunned}");
        }
    }
}
