using System;

namespace Product___ProductCollection
{
    public class ContainableItemCollection : ProductCollection<ContainableItem>
    {
        public void RemoveByPos(Position pos)
        {
            ContainableItem item = new ContainableItem();
            if (item.position.Equals(pos))
            {
                Remove(item);
            }
        }
    }
}