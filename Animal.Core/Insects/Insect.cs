using Interfaces.Game;
using System;
using System.Collections.Generic;
using System.Text;
using Utils;

namespace Animal.Core.Insects
{
    public abstract class Insect : Animal, IElusive
    {
        protected Insect(int health, string name) : base(health)
        {
            Name = name;
        }

        public string Name { get; set; }

        public bool Dodging(int percent)
        {
            if (RandomUtils.Percentage(percent) == percent)
                return false;
            return true;
        }
    }
}
