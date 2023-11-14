namespace Lab_adapter
{
    public class WildDuck:Duck
    {
        public override void Quack()
        {
            Console.WriteLine("дикая утка крякает");
        }

        public override void Fly()
        {
            Console.WriteLine("дикая утка летает");
        }
    }
}
