using Library;

namespace Lab_rab_4
{
    internal class MazeWithBombFactory:MazeFactory
    {
        public override Wall CreateWall()
        {
            return new BombWall();
        }

        public override Room CreateRoom(int number)
        {
            if (number <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(number), number, "Число должно быть положительным.");
            }
            return new BombRoom(number);
        }
    }
}
