using System;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductCollection Produse = new ProductCollection();
            Produse.LocationOverlap += p_LocationOverlap;
            Produse.Add(new Product("Covrigi", "Toortitzi", 5.99, 6), 0, 0, 1);
            Produse.Add(new Product("Covrigi", "Croco", 3.99, 3), 0, 1, 2);
            Produse.Add(new Product("Covrigi", "Toortitzi", 5.99, 6), 0, 0, 1);
            Produse.Remove(new Product("Covrigi", "Croco", 0, 0));
     //       Produse.Add(new Product("Covrigi", "Cornelius", 2.49, 5), 0, 0, 1);
            Node Temp = Produse.GetFirst();
            for (int i = 0; i < Produse.Count(); i++)
            {
                Console.WriteLine(Temp.containableItem.ToString());
                Temp = Temp.To;
            }
        }
        static void p_LocationOverlap(object sender, EventArgs e)
        {
            Console.WriteLine("The Location is Overlapping");
            Environment.Exit(0);
        }
    }
}
