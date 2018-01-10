using System;

namespace VendingMachine
{
    public class Product
    {
        public string Name { get; set; }

        public int Quantity { get; set; }

        public double Price { get; set; }

        public ProductCategory Category { get; set; }

        public Product() { }
        public Product(Position position, string name, int quantity, double price, ProductCategory category) 
        {
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
            this.Category = category;
        }
         
        public override string ToString()
        {
            return $"Name: {this.Name} / Price: {this.Price} / Quantity: {this.Quantity} / Category: {this.Category}  ";
        }
    }
}