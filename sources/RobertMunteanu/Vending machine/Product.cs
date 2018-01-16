using System;

namespace VendingMachine
{
    public class Product
    {
        public string Name { get; private set; }
        public double Price { get; set; }
        public Category Category{ get; private set; }
        public int Quantity { get; set; }

        public Product(string Name, double Price, Category Category, int Quantity)
        {
            this.Name = Name;
            this.Price = Price; 
            this.Category = Category;
            this.Quantity = Quantity;
        }
    }
}