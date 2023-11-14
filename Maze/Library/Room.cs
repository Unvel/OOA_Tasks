namespace Library
{
    public class Room : IMapSite
    {
        protected IMapSite[] Sides { get; private init; }
        public int roomNumber { get; private init; }

        public Room(int roomNo)
        {
            if(roomNo<=0)
            {
                throw new ArgumentOutOfRangeException(nameof(roomNo), roomNo,"Ожидается положительное число");  
            }
            roomNumber = roomNo;
            Sides = new IMapSite[4];
        }

        public IMapSite GetSide(Direction direction)
        {
            return Sides[(int)direction];
        }

        public void SetSide(Direction direction, IMapSite side)
        {
            Sides[(int)direction] = side;
        }

        public virtual void Enter()
        {
            Console.WriteLine($"Вы вошли в комнату номер {roomNumber}");
        }
    }
}
