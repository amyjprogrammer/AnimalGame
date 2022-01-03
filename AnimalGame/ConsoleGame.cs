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
        Insect opponent;
        Mammal mammal;

        public void Play()
        {
            CreatePlayer();
            CreateGameWorld();
            CreateOpponent();

            do
            {
                Console.Clear();
                DisplayGameWorld();
                Console.ReadKey();
            } while (player.IsAlive);
        }

        private void CreatePlayer()
        {
            player = new Player(1, 1, 30);
        }

        private void CreateOpponent()
        {
            int percentage = RandomUtils.Percentage(4);
            if (percentage == 1)
                opponent = new Bee();
            else if (percentage == 2)
                opponent = new Spider();
            else if (percentage == 3)
                mammal = new Koala();
            else
                mammal = new Elephant();
        }

        private void CreateGameWorld()
        {
            arena = new Arena[10, 10];
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
                    else if (x == 0 || y == 0 /*|| x == 9*/ || y == 9)
                        Console.Write("-");
                    else if (x == 5 && y == 5)
                    {
                        if (opponent.Name != null)
                            Console.WriteLine("I");
                        else
                            Console.WriteLine("M");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
