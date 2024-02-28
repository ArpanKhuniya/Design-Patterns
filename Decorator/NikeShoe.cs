using System;

namespace Decorator
{
    public class NikeShoe : ShoeDecorator
    {
        public NikeShoe(IShoe shoe) : base(shoe) { }
        public override string MakeShoe()
        {
            return "Nike Shoes.";
        }
    }
}