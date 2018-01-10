using System;

namespace Vending_machine_V2
{
    public class ContainableItemCollection : List<ContainableItem>
    {
        private static List<ContainableItem> listOfItems = new List<ContainableItem>();
        public static void AddItem(ContainableItem item)
        {
            listOfItems.Add(item);
        }


        public static void RemoveItem(ContainableItem item)
        {
            listOfItems.Remove(item);
        }

        public void RemoveByPos(Position pos)
        {
            ContainableItem item = new ContainableItem();
            if (item.position.Equals(pos))
            {
                Remove(item);
            }
        }
        public static List<ContainableItem> GetList()
        {
            return listOfItems;
        }
    }
}