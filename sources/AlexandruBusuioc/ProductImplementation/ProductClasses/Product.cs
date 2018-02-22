using System;

namespace ProductImplementation
{
    public class Product : IEquatable<Product>
    {
        public string Name { get; private set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public ProductCategory Category { get; private set; }
        public Product(string name, decimal price, int quantity, ProductCategory category)
        {
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
            this.Category = category;
        }

        public override string ToString()
        {
            return $"Name = {Name}, Price = {Price:0.##}, Quantity = {Quantity}, Type Of Product = {Category}";
        }

        public bool Equals(Product other)
        {
            if (this.Name == other.Name &&
            this.Price == other.Price &&
            this.Quantity == other.Quantity &&
            this.Category == other.Category)
                return true;
            else
                return false;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            Product product = obj as Product;
            return Equals(product);
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode() * 17;
        }
    }
}