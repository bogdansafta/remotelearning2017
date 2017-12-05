using System;
using System.Collections.Generic;
namespace ProductImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductCollection col = new ProductCollection();

            Product first = new Product("Candybar", 10.3f, 6, 2,"Candy");
            Product second = new Product("Bubblegum", 5.221111111111f, 10, 1,"Candy");
            Product third = new Product("Toothpick", 1f, 999, 1,"Utility");

            col.Add(first);
            col.Add(second);
            col.Add(third);

            for(int i=0;i<col.Count;i++)
            {
                System.Console.WriteLine(col[i]);
            }

            System.Console.WriteLine("Removing second element...");
            col.Remove(second);
            
            for(int i=0;i<col.Count;i++)
            {
                System.Console.WriteLine(col[i]);
            }
        }
    }
}
