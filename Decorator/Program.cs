using System;

public class Program
{
    public static void Main(string[] args)
    {
		IShoe shoe = new PlainShoe();
		shoe.MakeShoe();

		shoe = new NikeShoe();
		shoe.MakeShoe();

		shoe = new PumaShoe();
		shoe.MakeShoe();
	}
	
}
