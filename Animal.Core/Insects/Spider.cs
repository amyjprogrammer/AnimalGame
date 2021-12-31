using Interfaces.Game;
using System;
using System.Collections.Generic;
using System.Text;
using Utils;

namespace Animal.Core.Insects
{
    public class Spider : Insect, IPoisonous
    {
        public Spider(int health, string name) : base(5, "Spider")
        {
        }

        public bool IsDeadly(int percent)
        {
            if (RandomUtils.Percentage(percent) != percent)
                return false;
            return true;
        }

    }
}
