using System;

namespace Vending_machine_V2
{
    public class Stock
    {
        int quantity { get; set; }
        DateTime dateTime;
        string productName { get; set; }
        string productCategory { get; set; }

        public Stock(int quantity,DateTime dateTime,string productName, string productCategory)
        {
            this.quantity=quantity;
            this.dateTime=dateTime;
            this.productName=productName;
            this.productCategory=productCategory;
        }
    }
}