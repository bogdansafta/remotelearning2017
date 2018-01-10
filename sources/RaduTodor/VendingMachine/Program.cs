using System;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            ContainableItemsCollection Produse = new ContainableItemsCollection();
            Produse.LocationOverlap += p_LocationOverlap;
            Produse.Add(new ContainableItem(new Product("Covrigi", "Toortitzi", 5, 6),new Position(0,0,1)));
            Produse.Add(new ContainableItem(new Product("Covrigi", "Croco", 3, 3),new Position(0,1,2)));
            Produse.Add(new ContainableItem(new Product("Covrigi", "Toortitzi", 5, 4),new Position(0,0,1)));
            Produse.Remove(new ContainableItem(new Product("Covrigi", "Croco", 3, 3),new Position(0,1,2)));
            Produse.Add(new ContainableItem(new Product("Covrigi", "Cornelius", 2, 5),new Position(0,1,2)));
            Produse.Add(new ContainableItem(new Product("Covrigi", "Croco", 3, 0),new Position(0,3,1)));
            Node Temp = Produse.GetFirst();
            for (int i = 0; i < Produse.Count(); i++)
            {
                Console.WriteLine(Temp.containableItem.ToString());
                Temp = Temp.To;
            }
            Dispenser dispenser=new Dispenser(Produse);
            dispenser.LocationNotAvailable+=p_LocationNotAvailabe;
            dispenser.NotInStock+=p_NotInStock;
            Console.WriteLine(dispenser.Dispense(1).ToString());
            Console.WriteLine(dispenser.Dispense(1).ToString());
            Console.WriteLine(dispenser.Dispense(3).ToString());

        }
        static void p_LocationOverlap(object sender, EventArgs e)
        {
            Console.WriteLine("The Location is Overlapping");
            Environment.Exit(0);
        }
         static void p_LocationNotAvailabe(object sender, EventArgs e)
        {
            Console.WriteLine("This location is inexistent");
            Environment.Exit(0);
        }
         static void p_NotInStock(object sender, EventArgs e)
        {
            Console.WriteLine("This product is currently not in stock");
            Environment.Exit(0);
        }
    }
}
