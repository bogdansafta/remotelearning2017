using System;

namespace VendingMachine
{
    public class ProductCategory
    {
        public string Name { get; set; }

        public ProductCategory(string name)
        {
            this.Name = name;
        }

        public override string ToString() => $"ProductCategory: {this.Name} ";
    }
}