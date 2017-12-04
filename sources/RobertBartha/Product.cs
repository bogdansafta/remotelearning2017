using System;

namespace Product___ProductCollection
{
    public class Product
    {
        public string ProductType;
        public int Cantitate;
        public string Name;
        public double Price;
        public int Cells;
        public Product(string ProductType, int Cantitate, string Name, double Price, int Cells)
        {
            this.ProductType = ProductType;
            this.Cantitate = Cantitate;
            this.Name = Name;
            this.Price = Price;
            this.Cells = Cells;
        }
    }
}