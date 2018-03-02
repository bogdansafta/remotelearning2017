using System;

namespace VendingMachine
{
    public class Volume
    {
        public string ProductName { get; }
        public int TotalQuantity { get; set; }
        public DateTime Date { get; }

        public Volume(string productName, int quantity)
        {
            ProductName = productName;
            TotalQuantity += quantity;
            Date = DateTime.Now;
        }

        public override string ToString()
        {
            return $"{ProductName}, {TotalQuantity}, {Date}\n";
        }
    }
}