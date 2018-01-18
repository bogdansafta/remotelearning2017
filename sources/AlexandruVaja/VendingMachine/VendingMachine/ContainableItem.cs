using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    public class ContainableItem : IEquatable<ContainableItem>
    {
        public Position Position { get; set; }
        public Product Product{ get; set; }

        public ContainableItem()
        {
            Position = new Position();
            Product = new Product();
        }

        public ContainableItem(Position position, Product product)
        {
            Position = position;
            Product = product;

        }

        public bool Equals(ContainableItem other)
        {
            if (!Position.Equals(other.Position) || !Product.Equals(other.Product))
                return false;
            return true;
        }
    }
}
