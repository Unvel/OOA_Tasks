using System;

namespace Library
{
    public class Room : IMapSite
    {
        public int Number { get; set; }
        protected IMapSite[] Sides = new IMapSite[4];
        public Room(int number)
        {
            if (number <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(number), number, "Номер комнаты не соответствует условию");
            }
            Number = number;
        }

        public Room()
        {
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
            Console.WriteLine("Вошли в комнату");
        }

        public void Initialize(int roomNumber)
        {
            Number = roomNumber;
        }

        public virtual IMapSite Clone()
        {
            Room clonedRoom = (Room)this.MemberwiseClone();
            clonedRoom.Sides = new IMapSite[Sides.Length];

            for (int i = 0; i < Sides.Length; i++)
            {
                if (Sides[i] != null)
                {
                    clonedRoom.Sides[i] = Sides[i].Clone();
                }
            }

            return clonedRoom;
        }
    }
}