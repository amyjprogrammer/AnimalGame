using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Game
{
    public interface IPoisonous
    {
        bool IsDeadly(int percent);
    }
}
