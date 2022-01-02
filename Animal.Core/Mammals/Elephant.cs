using Interfaces.Game;
using System;
using System.Collections.Generic;
using System.Text;

namespace Animal.Core.Mammals
{
    public class Elephant : Mammal, IReach
    {
        public Elephant() : base(50, "Elephant")
        {
        }

        
        public bool InRange 
        { 
            get => throw new NotImplementedException(); set => throw new NotImplementedException(); 
        }

        public override AttackResult Attact(Animal opponent, int damage = 20)
        {
            return base.Attact(opponent, damage);
        }
    }
}
