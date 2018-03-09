using System;

namespace VendingMachine
{
    public class Stock
    {
         private string productName;

        private int currentStock;

        private DateTime dateTime;

        public Stock(string productName, int currentStock, DateTime dateTime)
        {
            this.productName = productName;
            this.currentStock = currentStock;
            this.dateTime = dateTime;
        }

        public override string ToString()
        {
            return $"Name Product: {productName} , CurrentStock: {currentStock} , DateTime: {dateTime}";
        }
    }
}