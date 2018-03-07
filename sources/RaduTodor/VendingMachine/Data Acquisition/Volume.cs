using System;

namespace VendingMachine
{
    public class Volume
    {
        private string productName;
        private string productCategory;
        private int quantity;
        private DateTime dateTime;

        public Volume()
        {
        }

        public Volume(String productName,String productCategory,int quantity,DateTime dateTime)
        {
            this.productName=productName;
            this.productCategory=productCategory;
            this.quantity=quantity;
            this.dateTime=dateTime;
        }

        public string ProductName { get => productName; set => productName = value; }

        public string ProductCategory { get => productCategory; set => productCategory = value; }

        public int Quantity { get => quantity; set => quantity = value; }

        public override String ToString()
        {
            return $@"""{productName}"",""{productCategory}"",""{quantity}"",""{dateTime}""
";
        }
    }
}