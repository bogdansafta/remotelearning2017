using System;

namespace Vending_machine_V2
{
    public class Sale
    {
        private Product product;
        private DateTime dateTime;

        public Sale(Product product, DateTime dateTime)
        {
            this.product = product;
            this.dateTime = dateTime;
        }
        public override String ToString()
        {
            return (product.ToString() + " " + dateTime);
        }
    }
}