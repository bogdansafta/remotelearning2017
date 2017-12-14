using System;

namespace VendingMachine
{
    public class Product : ContainableItem, IEquatable<Product>
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public Category Category { get; set; }
        public int Quantity { get; set; } = 1;

        public bool Equals(Product other)
        {
            //TODO CR @BS, have a look to what I wrote in Position.cs
            if (!Name.Equals(other.Name))
            {
                return false;
            }
            if (Price != other.Price)
            {
                return false;
            }
            if (!Category.Equals(other.Category))
            {
                return false;
            }
            if (Quantity != other.Quantity)
            {
                return false;
            }
            return true;
        }

        public override string ToString()
        {
            return $"Name: {Name}\tPrice: {Price}\tCategory: {Category} \tPosition: {Position.ToString()}";
        }
    }
}