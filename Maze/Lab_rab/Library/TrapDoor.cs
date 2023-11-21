using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Library
{
    public class TrapDoor : Door
    {

        internal bool IsOpen { get; set; }
        public TrapDoor(Room room1, Room room2) : base(room1, room2)
        { }

        public TrapDoor()
        {
        }

        public override void Enter()
        {
            if (IsOpen)
            {
                base.Enter();
            }
            else
            {
                Console.WriteLine("Дверь закрылась, прохода нет");
            }
        }

        public override Door Clone()
        {
            return (TrapDoor)this.MemberwiseClone();
        }
    }
}