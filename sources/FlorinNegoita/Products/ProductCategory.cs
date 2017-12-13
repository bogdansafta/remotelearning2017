using System;

namespace Products
{
    public class ProductCategory
    {
        public string Name { get; set; }

        public override string ToString()
        {
            return $" Name: {Name} ";
        }
    }
}