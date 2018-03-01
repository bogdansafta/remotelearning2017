using System;
namespace ProductImplementation
{
    public class ContainableItem
    {
        public Position position;
        public Product product;

        public ContainableItem(Position position, Product product)
        {
            this.position = position;
            this.product = product;
        }

        public override string ToString()
        {
            return product + " at position:" + position;
        } 
    }
}