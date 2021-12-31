using System;
using System.Collections.Generic;
using System.Text;

namespace Utils
{
    public static class RandomUtils
    {
        static Random random = new Random();

        public static int Percentage(int percent)
        {
            return random.Next(1, percent + 1);
        }
    }
}
