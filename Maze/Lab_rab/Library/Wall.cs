using System;

namespace Library
{
    public class Wall : IMapSite
    {
        public virtual void Enter()
        {
            Console.WriteLine("Вы врезались в стену");
        }
        public virtual Wall Clone()
        {
            Wall clonedWall = new Wall();

            return clonedWall;
        }
    }
}