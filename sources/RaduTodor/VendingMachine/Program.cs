using System;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            ContainableItemsCollection Produse = new ContainableItemsCollection();
            Produse.LocationOverlap += LocationOverlap;
            Produse.Add(new ContainableItem(new Product("Covrigi", "Toortitzi", 5, 6), new Position(0, 0, 1)));
            Produse.Add(new ContainableItem(new Product("Covrigi", "Croco", 3, 3), new Position(0, 1, 2)));
            Produse.Add(new ContainableItem(new Product("Covrigi", "Toortitzi", 5, 4), new Position(0, 0, 1)));
            Produse.Remove(new ContainableItem(new Product("Covrigi", "Croco", 3, 3), new Position(0, 1, 2)));
            Produse.Add(new ContainableItem(new Product("Covrigi", "Cornelius", 2, 5), new Position(0, 1, 2)));
            Produse.Add(new ContainableItem(new Product("Covrigi", "Croco", 3, 1), new Position(0, 3, 1)));
            Node Temp = Produse.GetFirst();
            for (int i = 0; i < Produse.Count(); i++)
            {
                Console.WriteLine(Temp.containableItem.ToString());
                Temp = Temp.To;
            }
            Dispenser dispenser = new Dispenser(Produse);
            PaymentTerminal paymentTerminal = new PaymentTerminal(dispenser);
            int IDProduct = -1;
            int Option = -1;
            while (Option != 0 && IDProduct != 0)
            {
                Console.WriteLine("ID Product:");
                int.TryParse(Console.ReadLine(), out IDProduct);
                if (IDProduct==0)
                    break;
                Console.WriteLine("Payment Option: (1-Coins;2-Banknote;3-Card)");
                int.TryParse(Console.ReadLine(), out Option);
                if (Option==0)
                    break;
                paymentTerminal.Pay(IDProduct, Option);
            }
            Data z=Data.Instance;
            Console.WriteLine(z.ToString());
            Console.ReadLine();
        }
        static void LocationOverlap(object sender, EventArgs e)
        {
            Console.WriteLine("The Location is Overlapping");
            Environment.Exit(0);
        }
    }
}
