using Interfaces.Game;
using System;
using System.Collections.Generic;
using System.Text;


namespace Animal.Core
{
    public abstract class Animal : IEdible
    {
        protected Animal(int health)
        {
            Health = health;
        }

        public virtual int Health { get; set; }
        public bool IsAlive { get { return Health > 0; } }

        public virtual AttackResult Attact(Animal opponent, int damage) 
        {
            opponent.Health -= damage;
            return new AttackResult(this, opponent, damage);
        }

        public virtual void Eat(IEdible edible)
        {
            this.Health = +edible.Health;
        }
    }
}
