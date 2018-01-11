using System;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            ContainableItemsCollection Produse = new ContainableItemsCollection();
            Produse.LocationOverlap += p_LocationOverlap;
            Produse.Add(new ContainableItem(new Product("Covrigi", "Toortitzi", 5, 6), new Position(0, 0, 1)));
            Produse.Add(new ContainableItem(new Product("Covrigi", "Croco", 3, 3), new Position(0, 1, 2)));
            Produse.Add(new ContainableItem(new Product("Covrigi", "Toortitzi", 5, 4), new Position(0, 0, 1)));
            Produse.Remove(new ContainableItem(new Product("Covrigi", "Croco", 3, 3), new Position(0, 1, 2)));
            Produse.Add(new ContainableItem(new Product("Covrigi", "Cornelius", 2, 5), new Position(0, 1, 2)));
            Produse.Add(new ContainableItem(new Product("Covrigi", "Croco", 3, 0), new Position(0, 3, 1)));
            Node Temp = Produse.GetFirst();
            for (int i = 0; i < Produse.Count(); i++)
            {
                Console.WriteLine(Temp.containableItem.ToString());
                Temp = Temp.To;
            }
            Dispenser dispenser = new Dispenser(Produse);
            PaymentTerminal paymentTerminal = new PaymentTerminal(dispenser);
            paymentTerminal.Pay(1, 2);
            paymentTerminal.Pay(2, 1);
            paymentTerminal.Pay(1, 3);
            //paymentTerminal.Pay(3,1);
            Temp = Produse.GetFirst();
            for (int i = 0; i < Produse.Count(); i++)
            {
                Console.WriteLine(Temp.containableItem.ToString());
                Temp = Temp.To;
            }
            Console.ReadLine();

        }
        static void p_LocationOverlap(object sender, EventArgs e)
        {
            Console.WriteLine("The Location is Overlapping");
            Environment.Exit(0);
        }
    }
}
