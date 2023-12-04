using System;
using System.Linq;

namespace Library
{
    public class TrapRoom : Room
    {

        private static Random _rnd = new Random();
        public TrapRoom(int number) : base(number)
        { }
        public override void Enter()
        {
            base.Enter();
            if (_rnd.Next(2) == 0)
            {
                Console.WriteLine("Сработала ловушка, дверь закрыта");
                Sides.OfType<TrapDoor>().ToList().ForEach(door => door.isOpen = false);
            }
        }
        public TrapRoom()
        {
        }
        public virtual TrapRoom Clone()
        {

            TrapRoom clonedRoom = (TrapRoom)base.Clone();
            TrapRoom roomWithTrapClone = new TrapRoom(Number);

            return roomWithTrapClone;
        }
    }
}