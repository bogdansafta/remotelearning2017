using System;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductCollection Produse = new ProductCollection();
            Produse.Add(new Product("Covrigi", "Toortitzi", 5.99, 6, 1, 2));
            Produse.Add(new Product("Covrigi", "Croco", 3.99, 3, 1, 1));
            Produse.Add(new Product("Covrigi", "Toortitzi", 5.99, 6, 1, 2));
            Produse.Remove(new Product("Covrigi", "Croco",0,0,0,0));
            Node Temp = Produse.GetFirst();
            for (int i = 0; i < Produse.Count(); i++)
            {
                Console.WriteLine(Temp.Product.ToString());
                Temp = Temp.To;
            }
        }
    }
}
