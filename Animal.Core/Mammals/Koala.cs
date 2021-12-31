using Interfaces.Game;
using System;
using System.Collections.Generic;
using System.Text;
using Utils;

namespace Animal.Core.Mammals
{
    public class Koala : Mammal, IAdorable
    {
        public Koala(int health, string name) : base(30, "Koala")
        {
        }

        public void Stunning()
        {
            var stunned = RandomUtils.Percentage(3);
            Console.WriteLine($"Opponent stunned for {stunned}");
        }

        public override AttackResult Attact(Animal opponent, int damage = 5)
        {
            return base.Attact(opponent, damage);
        }

    }
}
