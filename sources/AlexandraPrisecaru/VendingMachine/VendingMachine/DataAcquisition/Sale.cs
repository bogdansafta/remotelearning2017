using System;
using System.ComponentModel;

namespace VendingMachine
{
    public class Sale
    {
        public string ProductName { get; }
        public int Quantity { get; }
        public double Price { get; }
        public DateTime Date { get; }

        public Sale(Product product, int quantity=1)
        {
            ProductName = product.Name;
            Quantity = quantity;
            Price = product.Price;
            Date = DateTime.Now;
        }

        public override string ToString()
        {
            return $"{ProductName}, {Price}, {Quantity}, {Date}\n";
        }
    }
}