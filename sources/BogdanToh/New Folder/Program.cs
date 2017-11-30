using System;
using System.Collections.Generic;

namespace New_Folder
{
    class Program
    {
        static void Main(string[] args)
        {

            LinkedList<Product> l = new LinkedList<Product>();
            Product p = new Product();



            l.Add(p);
            //l.Remove(p);


            foreach (Product prod in l)
            {
                Console.WriteLine(prod);
            }


        }
    }
}
