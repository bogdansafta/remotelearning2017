using System;

namespace Products
{
    public class Product : ContainableItem
    {
        public ProductCategory Category { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public int Quantity { get; set; }

        public int Size { get; set; }

        public override string ToString()
        {
            return $" Category: {Category} , Name: {Name} , Price: {Price} , Quantity: {Quantity} , Size: {Size} , Position: {Position}";
        }
    }
}