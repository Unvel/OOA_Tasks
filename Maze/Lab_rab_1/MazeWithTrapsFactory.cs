using Library;

namespace Lab_rab_3
{
    public class MazeWithTrapsFactory : MazeFactory
    {
        public override Room CreateRoom(int Number)
        {
            if(Number <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(Number), Number, "Число должно быть положительным.");
            }
            return new TrapRoom(Number);
        }

        public override Door CreateDoor(Room room1, Room room2)
        {
            ArgumentNullException.ThrowIfNull(room1); 
            ArgumentNullException.ThrowIfNull(room2);
            return new TrapDoor(room1, room2);
        }
    }
}
