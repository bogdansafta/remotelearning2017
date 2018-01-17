using System;
using System.Collections.Generic;
namespace ProductImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            ContainableItemsCollection col = new ContainableItemsCollection();

            ProductCategory candyCategory = new ProductCategory("Candy");
            ProductCategory utilityCategory = new ProductCategory("Utility");

            Product candybar = new Product("Candybar", 10.3f, 6, candyCategory);
            Product bubblegum = new Product("Bubblegum", 5.221111111111f, 10, candyCategory);
            Product toothpick = new Product("Toothpick", 1f, 999, utilityCategory);

            ContainableItem first = new ContainableItem(new Position(0, 0, 1, 0), candybar);
            ContainableItem second = new ContainableItem(new Position(0, 1, 2, 1), bubblegum);
            ContainableItem third = new ContainableItem(new Position(0, 2, 1, 2), toothpick);

            col.Add(first);
            col.Add(second);
            col.Add(third);

            Dispenser dispenser = new Dispenser(col);
            PaymentTerminal terminal = new PaymentTerminal(dispenser, 100000, 1);

            Console.WriteLine("You will be paying by coins (other methods unimplemented)");
            Console.WriteLine("How many coins do you have in your wallet?");
            int numberOfCoins = Int32.Parse(Console.ReadLine());
            Console.WriteLine("How much does one coin value?");
            int coinValue = Int32.Parse(Console.ReadLine());

            Payment payment = new CoinPayment(numberOfCoins, coinValue);

            Console.WriteLine();
            Console.WriteLine("Select a product (insert ID):");
            for (int index = 0; index < col.Count; index++)
            {
                Console.WriteLine($"{col[index].position.id}:{col[index].product.Name}");
            }
            int choice = Int32.Parse(Console.ReadLine());
            terminal.Pay(choice, payment);
            Console.WriteLine();







        }
    }
}
