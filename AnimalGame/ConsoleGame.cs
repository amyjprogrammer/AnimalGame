using Animal.Core;
using Animal.Core.Insects;
using Animal.Core.Mammals;
using System;
using System.Collections.Generic;
using System.Text;
using Utils;

namespace AnimalGame
{
    class ConsoleGame
    {
        Player player;
        Arena[,] arena;

        public void Play()
        {
            CreatePlayer();
            CreateGameWorld();
        }

        private void CreatePlayer()
        {
            player = new Player(1, 1, 30);
        }

        private void CreateGameWorld()
        {
            arena = new Arena[10, 10];

            int percentage = RandomUtils.Percentage(4);
            if (percentage == 1)
                arena[5, 5].Insect = new Bee();
            else if (percentage == 2)
                arena[5, 5].Insect = new Spider();
            else if (percentage == 3)
                arena[5, 5].Mammal = new Koala();
            else
                arena[5, 5].Mammal = new Elephant();
        }


    }
}
