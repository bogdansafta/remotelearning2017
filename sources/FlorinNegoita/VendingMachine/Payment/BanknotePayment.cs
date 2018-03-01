using System;

namespace VendingMachine
{
    public class BanknotePayment : Payment
    {
        public override double Accumulate(double price)
        {
            double amount = 0;

            while (amount < price)
            {
                Console.WriteLine("Insert Banknotes:");
                double banknote = double.Parse(Console.ReadLine());

                if (banknote == 1 || banknote == 5 || banknote == 10 || banknote == 50 || banknote == 100)
                {
                    amount = amount + banknote;
                    Console.WriteLine($"Amount entered: {amount}, Product price: {price}");
                }
                else
                    Console.WriteLine("You didn't enter accepted banknotes. Try again!");
            }

            IsValid = true;
            return amount;
        }
        public override double Change(double price)
        {
            double inserted = Accumulate(price);
            double change = inserted - price;

            Console.WriteLine($"The rest: {change}");

            return change;
        }
    }
}