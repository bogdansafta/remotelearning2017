using System;
using System.Collections.Generic;

namespace New_Folder
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Product p = new Product("Snacks","Lays",5,10,3,new Position(1,1,1));
            Product p1 = new Product("Snacks","Lays",5,10,3,new Position(1,2,1));
            Product p2 = new Product("Snacks","Lays",5,10,3,new Position(1,1,2));
            ContainableItemsCollection.AddItem(p);
            ContainableItemsCollection.AddItem(p1);
            ContainableItemsCollection.AddItem(p2);
            ContainableItemsCollection.ShowList();
            ContainableItem item = new ContainableItem();
            Console.WriteLine("GetItem");
            item=ContainableItemsCollection.GetItem(0);
            Console.WriteLine(item);
            Console.WriteLine("Count is "+ContainableItemsCollection.Count());
            Console.WriteLine("Remove");
            ContainableItemsCollection.RemoveItem(p2);
            ContainableItemsCollection.ShowList();


        }
    }
}
