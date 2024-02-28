using System;

namespace Decorator
{
    public abstract class ShoeDecorator : IShoe
    {
        private IShoe shoe;

        public ShoeDecorator(IShoe shoe)
        {
            this.shoe = shoe;
        }

        public virtual string MakeShoe()
        {
            return shoe.MakeShoe();
        }
    }
}
