using System;

namespace VendingMachine
{
    public class Sale
    {
        public string productName;
        private string productCategory;
        private double price;
        private int quantity=0;
        private DateTime dateTime;

        public Sale()
        {
        }

        public Sale(Product product, DateTime dateTime)
        {
            this.productName=product.GetName();
            this.productCategory=product.GetCategory();
            this.price=product.Price;
            this.quantity++;
            this.dateTime=dateTime;
        }

        public string ProductCategory { get => productCategory; set => productCategory = value; }

        public int Quantity { get => quantity; set => quantity = value; }

        public override String ToString()
        {
            return $@"""{productName}"",""{productCategory}"",""{price}"",""{quantity}"",""{dateTime}""
";
        }
    }
}