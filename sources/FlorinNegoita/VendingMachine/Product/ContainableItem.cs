using System;

namespace VendingMachine
{
    public class ContainableItem
    {
        public Position Position { get; set; }

        public Product Product { get; set; }

        public override string ToString() => $" Position: {Position} , Product: {Product}";
    }
}