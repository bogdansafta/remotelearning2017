using System;
namespace VendingMachine
{
    public class PaymentTerminal
    {
        public string ErrorMessage = "The amount of money is lower than the product price";
        public Dispenser Dispenser { get; set; }

        public PaymentTerminal()
        {
            Dispenser = new Dispenser();
        }

        public void Pay(int id, Payment payment)
        {
            string line = Console.ReadLine();
            double newAmount;
            double amount = payment.MoneyPaid;
            Product product = Dispenser.ContainableItemCollection.getItemById(id).Product;
            double rest;
            do
            {
                rest = payment.change(amount, product.Price);
                if (rest < 0)
                {
                    Console.WriteLine(ErrorMessage);
                    Console.WriteLine($"Enter more {rest}");
                    newAmount = int.Parse(line);

                }
            } while (rest >= 0);

            if (rest > 0)
            {
                Console.WriteLine("banii trebuie sa se intoarca la cumparator");
            }

            Dispenser.dispense(id);

        }



    }
}