using System;

namespace VendingMachine
{
    public class Product :IEquatable<Product>
    {
        
        public Product() { }

        public Product(ProductCategory category, string name, double price, int quantity, int cells)
        {
            this.TypeOfProduct = category;
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
            this.NrOfCells = cells;
            
        }
        public ProductCategory TypeOfProduct { get; set; }
        public string Name { get; set; } = "Product";
        public double Price { get; set; } = 5;

        public int Quantity { get; set; } = 0;

        public int NrOfCells { get; set; } = 0;

        public override string ToString()
        {
            return $@" 
                       Type: {this.TypeOfProduct.ToString()}
                       Name: {this.Name} 
                       Price: {this.Price}
                       Quantity: {this.Quantity}
                       Cells: {this.NrOfCells}";
        }

      

        public bool Equals(Product product)
        {
           if (this == null || this.Name != product.Name || this.NrOfCells != this.NrOfCells
            || this.Price != product.Price || this.Quantity != product.Quantity|| this.TypeOfProduct!=product.TypeOfProduct)
            { return false; }
            
            return true;
        }
    }
}