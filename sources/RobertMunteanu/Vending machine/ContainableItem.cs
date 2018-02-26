using System;

namespace VendingMachine
{
   public class ContainableItem
    {
        public ContainableItem() {}
        public ContainableItem(Position position)
        {
            this.Position = position;
        }
        public ContainableItem(Product product, Position position) 
        {
            this.Product = product;
            this.Position = position;
        }
        public Position Position { get; set; }
        public Product Product { get; set; }
    }
}