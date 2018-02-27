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
    }
}