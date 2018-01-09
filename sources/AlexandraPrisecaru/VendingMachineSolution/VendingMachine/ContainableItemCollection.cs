using System;
using System.Linq;

namespace VendingMachine
{
    public class ContainableItemCollection : List<ContainableItem>
    {
        public bool RemoveBy(Position position)
        {
            ContainableItem containableItem = this.FirstOrDefault(item => item.Position.Equals(position));
            if (containableItem == null)
            {
                return false;
            }

            this.Remove(containableItem);
            return true;
        }
    }
}