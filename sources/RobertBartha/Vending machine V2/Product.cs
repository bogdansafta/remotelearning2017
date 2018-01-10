using System;

namespace Vending_machine_V2
{
    public class Product : ContainableItem
    {
        public ProductCategory productType { get; set; }
        public int quantity { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public int cells { get; set; }
        public Product(Position position, ProductCategory productType, int quantity, string name, double price, int cells)
        {
            this.position = position;
            this.productType = productType;
            this.quantity = quantity;
            this.name = name;
            this.price = price;
            this.cells = cells;
        }
    }
}