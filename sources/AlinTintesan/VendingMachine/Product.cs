using System;

namespace VendingMachine
{
    public class Product
    {
        private string type {get; set;}
        private string name {get; set;}
        private double price {get; set;}
        private int quantity {get; set;}
        private int size {get; set;}

        public Product(string type, string name, double price, int quantity, int size)
        {
            this.type=type;
            this.name=name;
            this.price=price;
            this.quantity=quantity;
            this.size=size;
        }

        public override string ToString()
        {
            return "Type: "+this.type+" / Name: "+this.name+" / Price: "+this.price+" / Quantity: "+this.quantity+
            " / Size: "+this.size;
        }
    }
}