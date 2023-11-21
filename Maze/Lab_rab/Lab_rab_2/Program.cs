using System;

namespace Lab_rab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("программа работает");
            MazeGame maze = new MazeGame();
            MazeBuilder builder = new MazeWithBombBuilder();
            maze.CreateMaze(builder);
            Console.ReadLine();
        }
    }
}
