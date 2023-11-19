using Library;

namespace Lab_rab_2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("программа работает");
            MazeGame maze = new MazeGame();
            MazeBuilder builder = new MazeWithBombBuilder();
            maze.CreateMaze(builder);
        }
    }
}
