using System;

namespace VendingMachine
{
    public class Volume
    {
        private string productName;

        private int totalQuantity;

        private DateTime dateTime;

        public Volume(string productName, int totalQuantity, DateTime dateTime)
        {
            this.productName = productName;
            this.totalQuantity = totalQuantity;
            this.dateTime = dateTime;
        }

        public override string ToString()
        {
            return $"Name Product: {productName} , Total Quantity: {totalQuantity} , DateTime: {dateTime}";
        }
    }

}