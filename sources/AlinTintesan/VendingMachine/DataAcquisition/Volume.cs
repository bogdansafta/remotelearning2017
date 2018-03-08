using System;

namespace VendingMachine
{
    public class Volume
    {
        public string ProductName { get; }

        public int TotalQuantity { get; }

        public DateTime date { get; }

        public Volume(Product product, int totalQuantity)
        {
            this.ProductName = product.Name;
            this.TotalQuantity = totalQuantity;
            this.date = DateTime.Now;
        }

        public override string ToString()
        {
            return $"{this.ProductName},{this.TotalQuantity},{this.date}";
        }
    }
}