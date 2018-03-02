using System;

namespace VendingMachine
{
    public class Stock
    {
        public string ProductName { get; }
        public int Quantity { get; set; }
        public DateTime Date { get; }

        public Stock(string productName, int quantity)
        {
            ProductName = productName;
            Quantity = quantity;
            Date = DateTime.Now;
        }

        public override string ToString()
        {
            return $"{ProductName}, {Quantity}, {Date}\n";
        }
    }
}