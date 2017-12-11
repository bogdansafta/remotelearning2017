using System;

namespace Product___ProductCollection
{
    public class Product : ContainableItem
    {
        public string ProductType { get; set; }
        public int Cantitate { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Cells { get; set; }
        public Product(Position position, string ProductType, int Cantitate, string Name, double Price, int Cells)
        {
            this.position = position;
            this.ProductType = ProductType;
            this.Cantitate = Cantitate;
            this.Name = Name;
            this.Price = Price;
            this.Cells = Cells;
        }
    }
}