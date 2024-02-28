namespace Decorator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IShoe shoe = new PlainShoe();
            Console.WriteLine(shoe.MakeShoe());

            shoe = new NikeShoe(shoe);
            Console.WriteLine(shoe.MakeShoe());

            shoe = new PumaShoe(shoe);
            Console.WriteLine(shoe.MakeShoe());
        }

    }
}