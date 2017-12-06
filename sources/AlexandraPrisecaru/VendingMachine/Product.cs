using System;

namespace VendingMachine
{
    public class Product : IEquatable<Product>
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public Category Category { get; set; }
        public int Size { get; set; }

        public bool Equals(Product other)
        {
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
            if (!Size.Equals(other.Size))
            {
                return false;
            }
            return true;
        }

        public override string ToString(){
            return $"Name: {Name}\tPrice: {Price}\tCategory: {Category}";
        }
    }
}