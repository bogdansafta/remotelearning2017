using System;
using System.Collections.Generic;

namespace New_Folder
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Product p = new Product("Snacks","Lays",5,10,3);

            ProductCollection.AddItem(p);
            ProductCollection.ShowList();
            Product emptyProd = new Product();
            Console.WriteLine("GetItem");
            emptyProd=ProductCollection.GetItem(0);
            Console.WriteLine(emptyProd);
            Console.WriteLine("Count is "+ProductCollection.Count());
            Console.WriteLine("Remove");
            ProductCollection.RemoveItem(p);
            ProductCollection.ShowList();


        }
    }
}
