using System;
using System.Linq;

namespace VendingMachine
{
    public class ContainableItemCollection : List<ContainableItem>
    {
        public bool RemoveBy(Position position)
        {
            //TODO CR @BS, it will be better to return false instead of throwing an exception
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