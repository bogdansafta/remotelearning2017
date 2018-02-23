using System;

namespace VendingMachine
{
    public class Product 
    {
        public ProductCategory Category { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public int Quantity { get; set; }

        public override string ToString()
        {
            return $" Category: {Category} , Name: {Name} , Price: {Price} , Quantity: {Quantity} ";
        }
    }
}