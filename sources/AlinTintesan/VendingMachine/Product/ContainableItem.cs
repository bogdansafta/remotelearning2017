using System;

namespace VendingMachine
{
    public class ContainableItem : IComparable<ContainableItem>
    {
        public Position Position { get; set; }
        public Product Product { get; set; }

        public ContainableItem(Position position, Product product)
        {
            this.Position = position;
            this.Product = product;
        }

        public int CompareTo(ContainableItem other) => this.CompareTo(other);

        public override string ToString() => $"Position: {this.Position} \n";
    }
}