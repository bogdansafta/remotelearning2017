using System;

namespace VendingMachine
{
    public class ProductCategory
    {
        public string Name { get; set; }

        public override string ToString() => $"{Name} ";
    }
}