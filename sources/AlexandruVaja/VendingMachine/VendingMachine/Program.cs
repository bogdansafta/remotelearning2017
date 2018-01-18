using System;

namespace VendingMachine
{
    public class Program
    {
        static void Main(string[] args)
        {
            ProductList<Product> produs = new ProductList<Product>();
            produs.Add(new Product("Croco", "Mac", 6.7, 4));
            Console.WriteLine(produs.GetItem(0).ToString());
        }
    }
}
