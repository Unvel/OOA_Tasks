using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                sides.OfType<TrapDoor>().ToList().ForEach(door => door.IsOpen = false);
            }
        }
        public TrapRoom()
        {
        }
        public override Room Clone()
        {
            return (TrapRoom)this.MemberwiseClone();
        }
    }
}