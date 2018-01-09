using System;
using System.Reflection;

namespace VendingMachine
{
    public class ContainableItem : IEquatable<ContainableItem>
    {
        public Position Position { get; set; } = new Position(-1, -1, -1);
        public Product Product { get; set; }

        public bool Equals(ContainableItem other)
        {
<<<<<<< HEAD
            if (other == null)
=======
            //TODO CR @BS, have a look of what I wrote in Position.cs
            if (!Position.Equals(other.Position))
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
    }
}