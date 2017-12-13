using System;

namespace ProductImplementation
{
    public class Product : ContainableItem, IEquatable<Product>
    {
        public string name { get; private set; }
        public double price { get; set; }
        public int quantity { get; set; }
        public ProductCategory category { get; private set; }
        public Product(Position position, string name, double price, int quantity, ProductCategory category)
        {
            base.position = position;
            this.name = name;
            this.price = price;
            this.quantity = quantity;
            this.category = category;
        }

        public override string ToString()
        {
            return $"Name = {name}, Price = {price:0.##}, Quantity = {quantity}, Type Of Product = {category}, Position = {position}";
        }

        public bool Equals(Product other)
        {
            if (this.name == other.name &&
            this.price == other.price &&
            this.quantity == other.quantity &&
            this.category == other.category)
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
            return this.name.GetHashCode() * 17;
        }

        public Position GetPosition()
        {
            return base.position;
        }
    }
}