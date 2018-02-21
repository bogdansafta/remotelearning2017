using System;

namespace VendingMachine
{
    public class CoinPayment : Payment
    {
        public override Boolean Change(double price)
        {
            IsValid = false;
            while (Accumulate < price)
            {
                Console.WriteLine("Insert Coins");
                double inserted;
                double.TryParse(Console.ReadLine(), out inserted);
                if (inserted == 50 || inserted == 10 || inserted == 5 || inserted == 1)
                    Accumulate = Accumulate + inserted / 100.0;
                else
                    throw new MyException("Money not accepted");
            }
            Console.WriteLine(ChangeGiven(Accumulate - price));
            IsValid = true;
            Accumulate = 0;
            return IsValid;
        }

        private String ChangeGiven(double change)
        {
            String written = "";
            while (change >= 0.50)
            {
                written += ", 50";
                change -= 0.50;
            }
            while (change >= 0.10)
            {
                written += ", 10";
                change -= 0.10;
            }
            while (change >= 0.5)
            {
                written += ", 5";
                change -= 0.5;
            }
            while (change >= 0.1)
            {
                written += ", 1";
                change -= 0.1;
            }
            written += " bani";
            return written;
        }
    }
}