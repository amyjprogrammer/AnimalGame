using System;
using System.Collections.Generic;
using System.Text;

namespace Animal.Core.Insects
{
    public class Bee : Insect
    {
        public Bee(int health, string name) : base(10, "Bee")
        {
        }

        public override AttackResult Attact(Animal opponent, int damage = 10)
        {
            return base.Attact(opponent, damage);
        }
    }
}
