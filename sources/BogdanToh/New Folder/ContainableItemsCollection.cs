using System;
using System.Collections.Generic;

namespace New_Folder
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
        public static void AddItem(ContainableItem product)
        {
           listOfItems.Add(product);
        }
        public static void RemoveItem(ContainableItem product)
        {
           listOfItems.Remove(product);
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
        
    }
}