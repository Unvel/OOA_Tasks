namespace Library
{
    public class TrapDoor : Door
    {
        public TrapDoor(Room room1, Room room2) : base(room1, room2) { }

        public  void Enter()
        {
            if (isOpen)
            {
                Console.WriteLine("Вы вошли в дверь");
            }
        }
    }
}
