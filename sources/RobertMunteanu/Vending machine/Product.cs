using System;

namespace VendingMachine
{
    public class Product : ContainableItem
    {
        public string Name { get; private set; }
        public double Price { get; set; }
        public Category category = new Category("Any");
        public int Quantity { get; set; }

        public Product(string Name, double Price, Category category, int Quantity, Position position)
        {
            this.Name = Name;
            this.Price = Price; 
            this.category = category;
            this.Quantity = Quantity;
            base.position = position;
        }
    }
}