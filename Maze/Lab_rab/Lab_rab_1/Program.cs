using Library;
using System;

namespace Lab_rab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            MazeGame game = new MazeGame();
            Maze mazeWithBomb = game.Create(new MazeWithBombFactory());
            Console.WriteLine("Был создан лабиринт с бомбами.");

            Room room1WithBomb = mazeWithBomb.RoomNo(1);
            room1WithBomb.Enter();

            Console.WriteLine();

            Maze mazeWithTraps = game.Create(new MazeWithTrapsFactory());
            Console.WriteLine("Был создан лабиринт с ловушками.");

            Room room1WithTrap = mazeWithTraps.RoomNo(1);
            room1WithTrap.Enter();

            Console.ReadLine();

        }
    }
}
