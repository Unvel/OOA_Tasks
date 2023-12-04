using System;

namespace Library
{
    public class Door : IMapSite
    {
        protected Room _room1 { get; set; }
        protected Room _room2 { get; set; }
        public bool isOpen { get; set; }

        public Door(Room room1, Room room2)
        {
            if (room1 == null)
            {
                throw new ArgumentNullException(nameof(room1));
            }
            if (room2 == null)
            {
                throw new ArgumentNullException(nameof(room2));
            }

            this._room1 = room1;
            this._room2 = room2;
            isOpen = true;
        }

        public Door()
        { }
        public void Initialize(Room r1, Room r2)
        {
            _room1 = r1;
            _room2 = r2;
        }
        public void Enter()
        {
            if (isOpen)
            {
                Console.WriteLine("Мы вошли в дверь");
            }
            else
            {
                Console.WriteLine("Дверь закрыта");
            }
        }
        public Room OtherSideFrom(Room room)
        {
            if (room.Number == _room1.Number)
            {
                return _room2;
            }
            else if (room.Number == _room2.Number)
            {
                return _room1;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }
        public virtual IMapSite Clone()
        {
            Door clonedDoor = new Door
            {
                _room1 = (Room)this._room1.Clone(),
                _room2 = (Room)this._room2.Clone(),
                isOpen = this.isOpen
            };

            return clonedDoor;
        }
    }
}