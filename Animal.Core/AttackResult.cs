using System;
using System.Collections.Generic;
using System.Text;

namespace Animal.Core
{
    public class AttackResult
    {
        public AttackResult(Animal attacker, Animal opponent, int damage)
        {
            Attacker = attacker;
            Opponent = opponent;
            Damage = damage;
        }

        public Animal Attacker { get; set; }
        public Animal Opponent { get; set; }
        public int Damage { get; set; }
    }
}
