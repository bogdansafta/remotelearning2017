using System;
using System.Linq;

namespace VendingMachine
{
    public class ContainableItemCollection : List<ContainableItem>
    {
        public void RemoveBy(Position position)
        {
            ContainableItem containableItem = this.FirstOrDefault(item => item.Position.Equals(position));
            if (containableItem == null)
            {
                throw new NullReferenceException();
            }

            this.Remove(containableItem);
        }
    }
}