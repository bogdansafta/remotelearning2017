using System;

namespace VendingMachine
{
    public class Sales
    {
        Product product;

        DateTime dateTime;

        public Sales(Product product, DateTime dateTime)
        {
            this.product = product;
            this.dateTime = dateTime;
        }
        public override string ToString()
        {
            return $"Product: {product.ToString()} , DateTime: {dateTime}";
        }
    }
}