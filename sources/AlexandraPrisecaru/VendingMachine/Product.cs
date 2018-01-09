using System;
using System.Linq;
using System.Reflection;

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
<<<<<<< HEAD
            if (other == null)
=======
            //TODO CR @BS, have a look to what I wrote in Position.cs
            if (!Name.Equals(other.Name))
>>>>>>> b1af3edc8098738e111d289541ff659a5c8293a2
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
            return $"Name: {Name}\tPrice: {Price}\tCategory: {Category} \tPosition: {Position.ToString()}";
        }
    }
}