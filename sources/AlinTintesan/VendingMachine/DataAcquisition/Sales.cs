using System;

namespace VendingMachine
{
    public class Sales
    {
        public string ProductName { get; }

        public int Quantity { get; }

        public double Price { get; }

        public DateTime date { get; }

        public Sales(Product product)
        {
            this.ProductName = product.Name;
            this.Quantity = 1;
            this.Price = product.Price;
            this.date = DateTime.Now;
        }

        public override string ToString()
        {
            return $"{this.ProductName},{this.Quantity},{this.Price},{this.date}";
        }

    }
}