using System;

namespace Decorator
{
    public class PumaShoe : ShoeDecorator
    {
        public PumaShoe(IShoe shoe) : base(shoe)
        {
        }

        //public PumaShoe(IShoe shoe) : base(shoe) { }
        public override string MakeShoe()
        {
            return "Puma Shoes.";
        }
    }
}