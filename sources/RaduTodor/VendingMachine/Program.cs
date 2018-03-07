using System;
using System.IO;
using System.Linq;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            ContainableItemsCollection produse = new ContainableItemsCollection();
            produse.LocationOverlap += LocationOverlap;
            AddingProducts(produse);
            Dispenser dispenser = new Dispenser(produse);
            PaymentTerminal paymentTerminal = new PaymentTerminal(dispenser);
            VendingMachineConsole(produse, paymentTerminal);
        }

        private static void VendingMachineConsole(ContainableItemsCollection produse, PaymentTerminal paymentTerminal)
        {
            Boolean repeat = true;
            while (repeat)
            {
                try
                {
                    SaleOperation(produse, paymentTerminal);
                }
                catch (MyException myException)
                {
                    Console.WriteLine($"{myException.Problem}\nDo you want to try again?(anything/n)");
                    if (Console.ReadLine() == "n")
                    {
                        repeat = false;
                        Console.WriteLine("Have a nice day");
                    }
                }
            }
            Data.Instance.WritingCsv();
        }

        static void AddingProducts(ContainableItemsCollection produse)
        {
            produse.Add(new ContainableItem(new Product("Covrigi", "Toortitzi", 5, 6), new Position(0, 0, 1)));
            produse.Add(new ContainableItem(new Product("Covrigi", "Croco", 3, 3), new Position(0, 1, 2)));
            produse.Add(new ContainableItem(new Product("Covrigi", "Toortitzi", 5, 4), new Position(0, 0, 1)));
            produse.Remove(new ContainableItem(new Product("Covrigi", "Croco", 3, 3), new Position(0, 1, 2)));
            produse.Add(new ContainableItem(new Product("Covrigi", "Cornelius", 2, 5), new Position(0, 1, 2)));
            produse.Add(new ContainableItem(new Product("Covrigi", "Croco", 3, 1), new Position(0, 3, 1)));
            WrintingProductsInVolumes(produse);
        }

        static void WrintingProductsInVolumes(ContainableItemsCollection produse)
        {
            Node temp = produse.GetFirst();
            for (int i = 0; i < produse.Count(); i++)
            {
                int quantity = temp.ContainableItem.Product.GetSize();
                Data.Instance.AddToVolumes(temp.ContainableItem.Product, quantity);
                temp = temp.To;
            }
        }

        static void SaleOperation(ContainableItemsCollection produse, PaymentTerminal paymentTerminal)
        {
            int idProduct = -1;
            int option = -1;
            while (option != 0 && idProduct != 0)
            {
                Node temp = produse.GetFirst();
                for (int i = 0; i < produse.Count(); i++)
                {
                    Console.WriteLine(temp.ContainableItem.ToString());
                    temp = temp.To;
                }
                Console.WriteLine("ID Product:");
                int.TryParse(Console.ReadLine(), out idProduct);
                Console.WriteLine("Payment Option: (1-Coins;2-Banknote;3-Card)");
                int.TryParse(Console.ReadLine(), out option);
                paymentTerminal.Pay(idProduct, option);
            }
        }

        static void LocationOverlap(object sender, EventArgs e)
        {
            Console.WriteLine("The Location is Overlapping");
            Environment.Exit(0);
        }
    }
}
