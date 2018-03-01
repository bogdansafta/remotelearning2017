using System;

namespace VendingMachine
{
    public class CoinPayment : Payment
    {
     public override double Accumulate(double price)
        {
            double amount = 0;

            while (amount < price)
            {
                Console.WriteLine("Insert Banknotes:");
                double banknote = double.Parse(Console.ReadLine());

                if (banknote == 0.50 || banknote == 0.10 || banknote == 0.05 || banknote == 0.01)
                {
                    amount = amount + banknote;
                    Console.WriteLine($"Amount entered: {amount}, Product price: {price}");
                }
                else
                    Console.WriteLine("You didn't enter accepted coins. Try again!");
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