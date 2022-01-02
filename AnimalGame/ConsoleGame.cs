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

            do
            {
                Console.Clear();
                DisplayGameWorld();

            } while (player.IsAlive);
        }

        private void CreatePlayer()
        {
            player = new Player(1, 1, 30);
        }

        private void CreateGameWorld()
        {
            arena = new Arena[10, 10];
            int x = 5;
            int y = 5;
            arena[x, y] = new Arena();

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

        private void DisplayGameWorld()
        {
            for (int y = 0; y < arena.GetLength(1); y++)
            {
                for (int x = 0; x < arena.GetLength(0); x++)
                {
                    Arena room = arena[x, y];
                    if (player.X == x && player.Y == y)
                        Console.Write("P");
                    else if (x == 0 || y == 0 || x == 10 || y ==10)
                        Console.Write("-");
                    /*else if (room.Insect != null)
                        Console.Write("I");
                    //else if (room.Insect.Name == "Spider")
                    //    Console.Write("S");
                    else if (room.Mammal != null)
                        Console.Write("M");
                    //else if (room.Insect.Name == "Elephant")
                    //    Console.Write("E");
                    else
                        Console.Write(" ");*/
                }
                Console.WriteLine();
            }
        }
    }
}
