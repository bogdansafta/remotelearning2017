using System;

namespace ProductImplementation
{
    public class Product : IEquatable<Product>
    {
        public string name { get; private set; }
        public double price { get; set; }
        public int quantity { get; set; }
        public int size { get; private set; }
        public string type { get; private set; }
        public Product(string name, double price, int quantity, int size, string type)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
            this.size = size;
            this.type = type;
        }
        public override string ToString()
        {
            return $"Name = {name}, Price = {price:0.##}, Quantity = {quantity}, Nr Of Cells Occupied = {size}, Type Of Product = {type}";
        }
        public bool Equals(Product other)
        {
            if (this.name == other.name &&
            this.price == other.price &&
            this.quantity == other.quantity &&
            this.size == other.size &&
            this.type == other.type)
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
            return this.name.GetHashCode();
        }
    }
}