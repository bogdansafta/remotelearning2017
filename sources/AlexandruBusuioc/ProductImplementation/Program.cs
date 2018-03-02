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

            Product candybar = new Product("Candybar", 10, 5, candyCategory);
            Product bubblegum = new Product("Bubblegum", 5, 10, candyCategory);
            Product toothpick = new Product("Toothpick", 1.1m, 900, utilityCategory);

            ContainableItem first = new ContainableItem(new Position(0, 0, 1, 0), candybar);
            ContainableItem second = new ContainableItem(new Position(0, 1, 2, 1), bubblegum);
            ContainableItem third = new ContainableItem(new Position(0, 2, 1, 2), toothpick);

            col.Add(first);
            col.Add(second);
            col.Add(third);       

            Dispenser dispenser = new Dispenser(col);
            PaymentTerminal terminal = new PaymentTerminal(dispenser);

            Console.WriteLine();

            Console.WriteLine("Select a product (insert ID):");
            for (int index = 0; index < col.Count; index++)
            {
                Console.WriteLine($"{col[index].position.id}:{col[index].product.Name}");
            }

            int choice = Int32.Parse(Console.ReadLine());
            decimal amountToPay = col.FindByID(choice).product.Price;

            Console.WriteLine();

            System.Console.WriteLine("1.Pay with Credit Card");
            System.Console.WriteLine("2.Pay with Coins");
            System.Console.WriteLine("Select the desired payment method");

            int paymentChoice = Int32.Parse(Console.ReadLine());

            switch (paymentChoice)
            {
                case 1:
                    System.Console.WriteLine("Insert your credit card pin:");
                    int pin = Int32.Parse(Console.ReadLine());

                    CreditCard card = new CreditCard(pin);
                    Payment payment = new CreditCardPayment(amountToPay, card);

                    System.Console.WriteLine("Confirm your credit card pin:");
                    (decimal, bool) result = terminal.Pay(choice, payment);
                    decimal change = result.Item1;
                    if (result.Item2)
                    {
                        System.Console.WriteLine("Payment succeeded!");
                    }
                    else
                    {
                        System.Console.WriteLine("Payment failed!");
                    }
                    System.Console.WriteLine($"Your change is :{change}");
                    break;

                case 2:
                    System.Console.WriteLine("How many coins do you have in your wallet:");
                    int nrOfCoins = Int32.Parse(Console.ReadLine());
                    System.Console.WriteLine("How much does one coin value:");
                    int coinValue = Int32.Parse(Console.ReadLine());
                    payment = new CoinPayment(amountToPay, nrOfCoins, coinValue);
                    result = terminal.Pay(choice, payment);
                    change = result.Item1;
                    if (result.Item2)
                    {
                        System.Console.WriteLine("Payment succeeded!");
                    }
                    else
                    {
                        System.Console.WriteLine("Payment failed!");
                    }
                    System.Console.WriteLine($"Your change is :{change}");
                    break;

                default:
                    System.Console.WriteLine("Please press 1 or 2");
                    break;

            }
            DataAcquisition.Instance.ExportToCSV();
            Console.ReadKey();
        }
    }
}
