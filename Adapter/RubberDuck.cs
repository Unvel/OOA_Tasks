namespace Lab_adapter
{
    public class RubberDuck:Duck
    {

        public override void Quack()
        {
            Console.WriteLine("уточка крякает");
        }

        public override void Fly()
        {
            Console.WriteLine("уточка не летает");
        }
    }
}
