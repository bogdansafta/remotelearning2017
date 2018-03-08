using System;

namespace VendingMachine
{
    public class ActualStock
    {
        public string ProductName { get; }

        public int CurrentStock { get; set; }

        public DateTime date { get; }

        public ActualStock(Product product)
        {
            this.ProductName = product.Name;
            this.CurrentStock = product.Quantity;
            this.date = DateTime.Now;
        }

        public override string ToString()
        {
            return $"{this.ProductName},{this.CurrentStock},{this.date}";
        }

    }
}