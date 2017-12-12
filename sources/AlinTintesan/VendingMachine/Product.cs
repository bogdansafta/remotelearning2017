using System;

namespace VendingMachine
{
    public class Product : ContainableItem//, IEquatable<Product>
    {
        public string Name { get; set; }

        public int Quantity { get; set; }

        public double Price { get; set; }

        public ProductCategory Category { get; set; }

        public Product(Position position, string name, int quantity, double price, ProductCategory category) : base(position)
        {
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
            this.Category = category;
        }


        /* public bool Equals(Product other)
        {
            if (this.Name != other.Name)
                return false;
            if (this.Quantity != other.Quantity)
                return false;
            if (this.Price != other.Price)
                return false;
            if (!this.Position.Equals(other.Position))
                return false;
            return true;
        } */


        /*public override bool Equals(object obj)
        {
            if(obj==null)
                return false;
            Product product=obj as Product;
            if(product==null)
                return false;
            else
                return this.Equals(product);
        } */            
        
        
        public override string ToString()
        {
            return $"Name: {this.Name} / Price: {this.Price} / Quantity: {this.Quantity} / Category: {this.Category} / Position: {base.Position} ";
        }
    }
}