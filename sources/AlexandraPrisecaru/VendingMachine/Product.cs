using System;
using System.Linq;
using System.Reflection;

namespace VendingMachine
{
    public class Product : IEquatable<Product>
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public Category Category { get; set; }
        public int Quantity { get; set; } = 1;

        public bool Equals(Product other)
        {
            if (other == null)
            {
                return false;
            }

            foreach (PropertyInfo property in this.GetType().GetProperties())
            {
                if (!property.GetValue(this).Equals(property.GetValue(other)))
                {
                    return false;
                }
            }

            return true;
        }

        public override string ToString()
        {
            return $"Name: {Name}\tPrice: {Price}\tCategory: {Category.Name}";
        }
    }
}