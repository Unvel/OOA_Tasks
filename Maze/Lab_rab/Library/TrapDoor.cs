using System;

namespace Library
{
    public class TrapDoor : Door
    {
        public TrapDoor(Room room1, Room room2) : base(room1, room2) { }
        public TrapDoor() { }
        public void Enter()
        {
            if (isOpen)
            {
                Console.WriteLine("Мы вошли в дверь");
            }
        }
        public override IMapSite Clone()
        {
            TrapDoor clonedDoor = (TrapDoor)base.Clone();

            clonedDoor._room1 = (Room)this._room1.Clone();
            clonedDoor._room2 = (Room)this._room2.Clone();

            return clonedDoor;
        }
    }
}