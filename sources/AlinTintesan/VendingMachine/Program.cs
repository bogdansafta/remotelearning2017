using System;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            /*List<int> list=new List<int>();
            list.Add(5);
            list.Add(6);
            list.Add(7);
            list.Add(8);
            list.Add(9);
            list.Remove(9);
            for(int i=0;i<list.Count();i++)
                Console.WriteLine(list.GetItem(i));
            Console.WriteLine(list.Count());
            */
            Product p1=new Product("beverage","pepsi",5.5,1,1);
            Product p2=new Product("snack","cheerios",7.2,1,2);
            Product p3=new Product("snack","snickers",2.5,1,1);
            ProductCollection productCollection=new ProductCollection();
            productCollection.products.Add(p1);
            productCollection.products.Add(p2);
            productCollection.products.Add(p3);
            productCollection.products.Remove(p2);
            for(int i=0;i<productCollection.products.Count();i++)
                Console.WriteLine(productCollection.products.GetItem(i));

        }
    }
}
