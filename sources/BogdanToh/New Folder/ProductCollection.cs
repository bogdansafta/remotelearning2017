using System;
using System.Collections.Generic;

namespace New_Folder
{
    class ProductCollection
    {
        private static LinkedList<Product> listofProducts = new LinkedList<Product>();
        public static void ShowList()
        {
            foreach (Product prod in listofProducts)
            {
                Console.WriteLine(prod);
            }
        }
        public static void AddItem(Product product)
        {
            listofProducts.Add(product);
        }
        public static void RemoveItem(Product product)
        {
            listofProducts.Remove(product);
        }
        public static Product GetItem(int index)
        {
            Product product= new Product();
            product =listofProducts.GetItem(index);
            return product;
        }
        public static int Count()
        {
            return listofProducts.Count;
        }
    }
}