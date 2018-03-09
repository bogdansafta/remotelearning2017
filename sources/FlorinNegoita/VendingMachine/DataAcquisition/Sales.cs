using System;

namespace VendingMachine
{
    public class Sales
    {
        private string productName;

        private int quantity;

        private double price;
        private DateTime dateTime;

        public Sales(Product product, DateTime dateTime)
        {
            this.productName = product.Name;
            this.quantity = product.Quantity;
            this.price = product.Price;
            this.dateTime = dateTime;
        }
        public override string ToString()
        {
            return $"Name Product: {productName} , Price: {price} , Quantity: {quantity} , DateTime: {dateTime}";
        }
    }
}