using System;
using System.Collections.Generic;
using System.Linq;

namespace VendingMachine
{
    class ContainableItemsCollection
    {
       
        private static LinkedList<ContainableItem> listOfItems = new LinkedList<ContainableItem>();
        public static void ShowList()
        {
            foreach (ContainableItem item in listOfItems)
            {
                Console.WriteLine(item);
            }
        }


        public static void AddItem(ContainableItem item)
        {
           listOfItems.Add(item);
        }


        public static void RemoveItem(ContainableItem item)
        {
           listOfItems.Remove(item);
        }

        
        public static ContainableItem GetItem(int index)
        {
            ContainableItem item= new ContainableItem();
            item =listOfItems.GetItem(index);
            return item;
        }
        

        public static int Count()
        {
            return listOfItems.Count;
        }

        
        public static void RemoveByPosition(Position position)
        {   
           
            ContainableItem itemToDelete = listOfItems.FirstOrDefault(deletedItem=>deletedItem.Position.Equals(position));
            if(itemToDelete!=null)
            {
            RemoveItem(itemToDelete);
            }
            else
            {
                throw new System.Exception("Item could not be found");
            }
        }


        public static LinkedList<ContainableItem> GetList()
        {
            return listOfItems;
        }
    }
}